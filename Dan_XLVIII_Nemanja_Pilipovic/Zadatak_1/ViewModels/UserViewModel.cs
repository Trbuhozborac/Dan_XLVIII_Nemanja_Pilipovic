using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Zadatak_1.Commands;
using Zadatak_1.Models;
using Zadatak_1.Views;

namespace Zadatak_1.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        #region Objects

        UserView main;

        #endregion

        #region Constructors 

        public UserViewModel(UserView mainOpen)
        {
            main = mainOpen;
            AllFood = GetAllFood();
        }

        #endregion

        #region Properties

        private Food food;

        public Food Food
        {
            get { return food; }
            set
            {
                food = value;
                OnPropertyChanged("Food");
            }
        }


        private List<Food> allFood;

        public List<Food> AllFood
        {
            get { return allFood; }
            set
            {
                allFood = value;
                OnPropertyChanged("AllFood");
            }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        #endregion

        #region Commands

        private ICommand addItem;
        public ICommand AddItem
        {
            get
            {
                if (addItem == null)
                {
                    addItem = new RelayCommand(param => AddNewItem(), param => CanAddNewItem());
                }
                return addItem;
            }
        }

        private ICommand save;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand(param => SaveExecute(), param => CanSaveExecute());
                }
                return save;
            }
        }

        private ICommand close;
        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return close;
            }
        }


        #endregion

        #region Functions

        /// <summary>
        /// Gets all Food for Menu
        /// </summary>
        /// <returns></returns>
        private List<Food> GetAllFood()
        {
            List<Food> food = new List<Food>();
            Food fish = new Food("Fish", 100);
            Food chips = new Food("Chips", 200);
            Food cevap = new Food("Cevap", 250);
            Food pljeskavica = new Food("Pljeskavica", 250);
            food.Add(fish);
            food.Add(chips);
            food.Add(cevap);
            food.Add(pljeskavica);
            return food;
        }

        /// <summary>
        /// Adds the Price of selected food 
        /// </summary>
        private void AddNewItem()
        {
            Price += Food.Price;
        }

        /// <summary>
        /// Checks if Food can be added
        /// </summary>
        /// <returns></returns>
        private bool CanAddNewItem()
        {
            return true;
        }

        /// <summary>
        /// Saves the Order in database
        /// </summary>
        private void SaveExecute()
        {
            try
            {
                tblOrder order = new tblOrder();
                order.Price = Price;
                order.State = "Waiting";
                using (PizzaRestourantEntities db = new PizzaRestourantEntities())
                {
                    if(db.tblOrders.Any(x => x.State == "Waiting"))
                    {
                        MessageBox.Show($"You already orderd.  Order Status: {order.State}");
                    }
                    else
                    {
                        DateTime dateTime = DateTime.Now;
                        order.CreatedDate = dateTime.Date;
                        order.CreatedTime = dateTime.TimeOfDay;
                        db.tblOrders.Add(order);
                        db.SaveChanges();

                        MessageBox.Show($"Ordered Successfully! Order Status: {order.State}");
                        main.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Checks if Saving of the Order can be Executed
        /// </summary>
        /// <returns></returns>
        private bool CanSaveExecute()
        {
            if (Price <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Close Main window
        /// </summary>
        private void CloseExecute()
        {
            main.Close();
        }

        /// <summary>
        /// Checks if Main window can be clsoed
        /// </summary>
        /// <returns></returns>
        private bool CanCloseExecute()
        {
            return true;
        }

        #endregion

    }
}
