using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace AMONIC_Airlines_3
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        class InactiveTimer
        {
            private DispatcherTimer _timer = new DispatcherTimer();
            public DispatcherTimer timer { get { return _timer; } }

            private bool _lostKeyboard = true;
            public bool lostKeyboard { get { return _lostKeyboard; } set { _lostKeyboard = value; } }

            private bool _lostMouse = true;
            public bool lostMouse { get { return _lostMouse; } set { _lostMouse = value; } }

            private bool _newPage = false;
            public bool newPage { get { return _newPage; } set { _newPage = value; } }

            public void InitialTimer()
            {
                _timer.Interval = new TimeSpan(0, 1, 0);
            }
        }

        InactiveTimer inactiveTimer = new InactiveTimer();
        SqlConnect sqlCon = new SqlConnect();
        public LoginPage()
        {
            InitializeComponent();
            
        }
      

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            inactiveTimer.InitialTimer();
            inactiveTimer.timer.Tick += Timer_Tick;
            inactiveTimer.timer.Start();
            sqlCon.OpenConnect();
        }

        private void bt_login_Click(object sender, RoutedEventArgs e)
        {
            inactiveTimer.timer.Stop();

            inactiveTimer.newPage = true;

            if (!String.IsNullOrWhiteSpace(tb_email.Text) && !String.IsNullOrWhiteSpace(pb_password.Password))
            {
                string userInfo = sqlCon.CheckLogin(tb_email.Text, pb_password.Password);

                if(userInfo != null)
                {
                    string role = userInfo.Substring(0, userInfo.IndexOf(';'));
                    bool active = userInfo.Substring(userInfo.IndexOf(';') + 1, userInfo.Length - 1 - userInfo.IndexOf(';')) == "True" ? true : false;

                    if(active)
                    {
                        if (role == "User")
                        {
                            inactiveTimer.timer.Stop();
                            FrameNavigate.NavigateTo(new UserPage(tb_email.Text));
                        }
                        else if (role == "Administrator")
                        {
                            inactiveTimer.timer.Stop();
                            FrameNavigate.NavigateTo(new AdminPage());
                        }
                        else
                        {
                            MessageBox.Show("Неизвестная роль.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                        MessageBox.Show("Данное действие недоступно. Администратор заблокировал вам доступ.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                    MessageBox.Show("Неправильный логин или пароль.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
            else
                MessageBox.Show("Заполните пустые поля.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            sqlCon.CloseConnect();
        }

        private void bt_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Вы были неактивны в течении одной минуты. Вы все еще с нами?", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            Application.Current.Shutdown();
        }

        private void Page_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            inactiveTimer.lostKeyboard = true;

            if(inactiveTimer.lostMouse && inactiveTimer.lostKeyboard && !inactiveTimer.newPage)
                inactiveTimer.timer.Start();
        }

        private void Page_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            inactiveTimer.lostKeyboard = false;
            inactiveTimer.timer.Stop();
        }

        private void Page_MouseLeave(object sender, MouseEventArgs e)
        {
            inactiveTimer.lostMouse = true;

            if (inactiveTimer.lostMouse && inactiveTimer.lostKeyboard && !inactiveTimer.newPage)
                inactiveTimer.timer.Start();
        }

        private void Page_MouseEnter(object sender, MouseEventArgs e)
        {
            inactiveTimer.lostMouse = false;
            inactiveTimer.timer.Stop();
        }
    }
}
