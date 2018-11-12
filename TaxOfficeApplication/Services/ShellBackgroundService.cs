using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Threading;
using Dapper;
using Prism.Events;
using TableDependency.SqlClient;
using TaxOfficeApplication.Events;
using TaxOfficeApplication.Interfaces;
using TaxOfficeApplication.Models;

namespace TaxOfficeApplication.Services
{
    public class ShellBackgroundService : IBackgroundService
    {
        private readonly IEventAggregator eventAggregator;
        private readonly DispatcherTimer dispatcherTimer = new DispatcherTimer(DispatcherPriority.Send);


        private string ConnectionString
        {
            get { return Properties.Settings.Default.ConnectionString; }
        }

        public ShellBackgroundService(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;

            this.eventAggregator = eventAggregator;

            this.dispatcherTimer.Interval = TimeSpan.FromMilliseconds(125);
            this.dispatcherTimer.Tick += (sender, e) =>
            {
                var currentProcess = Process.GetCurrentProcess();
                var memoryUsed = currentProcess.PrivateMemorySize64;
                this.eventAggregator.GetEvent<MemoryStatusEvent>().Publish(memoryUsed / 1024 / 1024);
            };
            this.dispatcherTimer.Start();

            //Pobranie listy kontrahentów.
            this.eventAggregator.GetEvent<GetContractorsEvent>().Subscribe(() =>
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    //                   DynamicParameters parameters = new DynamicParameters();
                    //                    parameters.Add("@Id", 0);
                    //                    parameters.Add("@Nip", "");
                    var list = connection.Query<Contractor>("GetAllContrctor", null, commandType: CommandType.StoredProcedure).ToList();
                    eventAggregator.GetEvent<ContractorsListEvent>().Publish(list);
                }

            }, ThreadOption.BackgroundThread, true);


        }

    }
}