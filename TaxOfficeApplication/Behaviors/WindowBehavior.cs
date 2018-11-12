namespace TaxOfficeApplication.Behaviors
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows;
    using System.Windows.Interop;

    public sealed class WindowBehavior
    {
        private static readonly Type OwnerType = typeof(WindowBehavior);

        private const int GWL_STYLE = -16;
        private const int WS_SYSMENU = 0x80000;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public static void SetClose(DependencyObject target, bool value)
        {
            target.SetValue(CloseProperty, value);
        }

        public static readonly DependencyProperty CloseProperty =
            DependencyProperty.RegisterAttached(
                "Close",
                typeof(bool),
                OwnerType,
                new UIPropertyMetadata(false, (sender, e) =>
                {
                    if (!(e.NewValue is bool) || !(bool)e.NewValue)
                    {
                        return;
                    }

                    var window = sender as Window ?? Window.GetWindow(sender);
                    if (window != null)
                    {
                        window.Close();
                    }
                }));

        public static readonly DependencyProperty HideCloseProperty =
            DependencyProperty.RegisterAttached(
                "HideClose",
                typeof(bool),
                OwnerType,
                new FrameworkPropertyMetadata(false, HideCloseChangedCallback));

        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static bool GetHideClose(Window window)
        {
            return (bool)window.GetValue(HideCloseProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static void SetHideClose(Window window, bool value)
        {
            window.SetValue(HideCloseProperty, value);
        }

        private static void HideCloseChangedCallback(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var window = sender as Window;
            if (window == null)
            {
                return;
            }

            var hideClose = (bool)e.NewValue;
            if (hideClose && !GetIsHiddenClose(window))
            {
                if (!window.IsLoaded)
                {
                    window.Loaded += HideWhenLoadedDelegate;
                }
                else
                {
                    HideClose(window);
                }

                SetIsHiddenClose(window, true);
            }
            else if (!hideClose && GetIsHiddenClose(window))
            {
                if (!window.IsLoaded)
                {
                    window.Loaded -= ShowWhenLoadedDelegate;
                }
                else
                {
                    ShowClose(window);
                }

                SetIsHiddenClose(window, false);
            }
        }

        /// <summary>
        /// The hide when loaded delegate.
        /// </summary>
        private static readonly RoutedEventHandler HideWhenLoadedDelegate = (sender, e) =>
        {
            var window = sender as Window;

            if (window == null)
            {
                return;
            }

            HideClose(window);
            window.Loaded -= HideWhenLoadedDelegate;
        };

        /// <summary>
        /// The show when loaded delegate.
        /// </summary>
        private static readonly RoutedEventHandler ShowWhenLoadedDelegate = (sender, e) =>
        {
            var window = sender as Window;

            if (window == null)
            {
                return;
            }

            ShowClose(window);
            window.Loaded -= ShowWhenLoadedDelegate;
        };

        private static void HideClose(Window window)
        {
            var handle = new WindowInteropHelper(window).Handle;
            SetWindowLong(handle, GWL_STYLE, GetWindowLong(handle, GWL_STYLE) & ~WS_SYSMENU);
        }

        private static void ShowClose(Window window)
        {
            var handle = new WindowInteropHelper(window).Handle;
            SetWindowLong(handle, GWL_STYLE, GetWindowLong(handle, GWL_STYLE) | WS_SYSMENU);
        }

        private static readonly DependencyPropertyKey IsHiddenCloseKey =
            DependencyProperty.RegisterAttachedReadOnly(
                "IsHiddenClose",
                typeof(bool),
                OwnerType,
                new FrameworkPropertyMetadata(false));

        public static readonly DependencyProperty IsHiddenCloseProperty =
            IsHiddenCloseKey.DependencyProperty;

        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static bool GetIsHiddenClose(Window window)
        {
            return (bool)window.GetValue(IsHiddenCloseProperty);
        }

        private static void SetIsHiddenClose(Window window, bool value)
        {
            window.SetValue(IsHiddenCloseKey, value);
        }
    }
}