using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Refferal_of_patients
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool logincheck = false;

        public MainWindow()
        {
            InitializeComponent();
            LoginForm.Visibility = Visibility.Collapsed;
            LoadPatientsDb();
        }

        public void LoadPatientsDb()
        {
            using (var entity = new BigBoarsEntities())
            {
                PatientGrid.ItemsSource = entity.TherapMeasures.ToList();
            }

            PatientGrid.Loaded += (sender, e) =>
            {
                if (PatientGrid.Columns.Count > 0)
                {
                    if (PatientGrid.Columns.Count > 1)
                    {
                        PatientGrid.Columns[0].Header = "Код процедуры";
                        PatientGrid.Columns[1].Header = "Номер пациента";
                        PatientGrid.Columns[2].Header = "Дата мероприятия";
                        PatientGrid.Columns[3].Header = "Ответственный врач";
                        PatientGrid.Columns[4].Header = "Тип мероприятия";
                        PatientGrid.Columns[5].Header = "Название мероприятия";
                        PatientGrid.Columns[6].Header = "Результаты";
                        PatientGrid.Columns[7].Header = "Рекомендация";
                        PatientGrid.Columns[8].Visibility = Visibility.Collapsed;
                    }
                }
            };
        }

        private void ProfileBg_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (logincheck != true)
            {
                LoginForm.Visibility = Visibility.Visible;
                ClearAllTextboxes();
            }
            else { }
        }

        private void LoginForm_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LoginForm.Visibility = Visibility.Collapsed;
        }

        private void ProfileSumbit_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBx.Password;

            using (var entity = new BigBoarsEntities()) 
            {
                var autorization = entity.Acounts.FirstOrDefault(u => u.Логин == login && u.Пароль == password);
                if (autorization != null)
                {
                    LoginForm.Visibility = Visibility.Collapsed;
                    ProfileImg.Source = new BitmapImage(new Uri("/Resources/LogginedProfile.png", UriKind.Relative)) { CreateOptions = BitmapCreateOptions.IgnoreImageCache };
                    PatientItem.Visibility = Visibility.Visible;
                    logincheck = true;
                }
                else { MessageBox.Show("Ошибка", "Неправильный логин и/или пароль"); }
            }
        }

        public void ClearAllTextboxes()
        {
            LoginBox.Clear();
            PasswordBx.Clear();
        }

        private void MedCardBtn_Click(object sender, RoutedEventArgs e)
        {
            if(PatientGrid.SelectedCells.Count > 0) 
            {
                var selectedPatient = PatientGrid.SelectedCells[0].Item as Patient;
                if (selectedPatient != null) 
                {
                    //Выводим значения в формы
                }
            }
        }
    }
}
