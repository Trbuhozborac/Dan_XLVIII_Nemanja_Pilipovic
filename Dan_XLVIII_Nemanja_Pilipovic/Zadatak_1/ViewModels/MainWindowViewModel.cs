using System;
using System.Windows.Input;
using Zadatak_1.Commands;
using Zadatak_1.Views;

namespace Zadatak_1.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Objects

        MainWindow main;

        #endregion

        #region Constructors

        public MainWindowViewModel(MainWindow mainOpen)
        {
            main = mainOpen;
        }

        #endregion

        #region Commands

        private ICommand showUserView;
        public ICommand ShowUserView
        {
            get
            {
                if (showUserView == null)
                {
                    showUserView = new RelayCommand(param => ShowUserViewExecute(), param => CanShowUserView());
                }
                return showUserView;
            }
        }

        private ICommand showEmployeeView;
        public ICommand ShowEmployeeView
        {
            get
            {
                if (showEmployeeView == null)
                {
                    showEmployeeView = new RelayCommand(param => ShowEmployeeViewExecute(), param => CanShowEmployeeView());
                }
                return showEmployeeView;
            }
        }

        #endregion

        #region Functions

        /// <summary>
        /// Shows User View
        /// </summary>
        private void ShowUserViewExecute()
        {
            UserView view = new UserView();
            view.ShowDialog();
        }

        private bool CanShowUserView()
        {
            return true;
        }

        /// <summary>
        /// Shows Employee View
        /// </summary>
        private void ShowEmployeeViewExecute()
        {
            EmployeeView view = new EmployeeView();
            view.ShowDialog();
        }

        private bool CanShowEmployeeView()
        {
            return true;
        }

        #endregion
    }
}
