using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;
using TEST02_WPFMVVM.Commands;
using TEST02_WPFMVVM.interfaces;
using TEST02_WPFMVVM.model;
using TEST02_WPFMVVM.services;

namespace TEST02_WPFMVVM.viewmodel
{
    public class CustomerViewModel : BaseViewModel
    {
        private readonly ICustomersService _CustomersService;

        public CustomerViewModel(ICustomersService _CustomersService)
        {
            this._CustomersService = _CustomersService;

            //_Customer = new CustomerModel("Witek");                     
            Load();

        }

        public CustomerViewModel()
            : this(new MocCustomersServices()) // gdy kożystamy z Moc używamy metod Moc
                                               //: this(new DbProductService()) // gdy kożystamy z bazy danych kożystamy z metod klasy DbProductService
        {
           
        }


        private void Load()
        {
            Customers = new ObservableCollection<CustomerModel>(_CustomersService.Get());  //implementacja klasy informującej listę o konieczności zmiany
            this.TextValue = "abc";
            
        }

        private string _TextValue;

        public string TextValue
        {
            get
            {                
                return _TextValue;
            }
            set
            {
                _TextValue = value;
                OnPropertyChanged();
            }
        }


        public ICommand AddTextCommand
        {
            get
            {
                return new RelayCommand(c => AddText(), c => CanAddText());
            }
        }

        //public ICommand AddTextCommand => new RelayCommand(c => AddText(), c => CanAddText);

        // public ICommand StartCommand => new RelayCommand(() => Start(), () => CanStart);



        private bool CanAddText()
        {
            return true;
        }

        private void AddText()
        {
            //this.TextValue = "zmiana";
            this.TextValue = this.SelectedCustomer.Name;
        }

        private ICollection<CustomerModel> _Customers;

        public ICollection<CustomerModel> Customers
        {
            get { return _Customers; }
            set
            {
                _Customers = value;
                OnPropertyChanged();
            }
        }

        private CustomerModel _Customer;

        public CustomerModel Customer
        {
            get { return _Customer; }
            set
            {
                _Customer = value;
                OnPropertyChanged();
            }
        }

        private CustomerModel _SelectedCustomer;

        public CustomerModel SelectedCustomer
        {
            get { return _SelectedCustomer; }
            set
            {
                _SelectedCustomer = value;                
                OnPropertyChanged();
            }
        }
       

        private bool _IsSelectedCustomer;

        public bool IsSelectedCustomer
        {
            get { return _IsSelectedCustomer; }
            set
            {
                _IsSelectedCustomer = value;                                
                OnPropertyChanged();                
            }
        }

        private bool _ButtonEnabled;

        public bool ButtonEnabled
        {
            get
            {
                //if(this.IsSelectedCustomer == false)
                //{
                //    _ButtonEnabled = false;
                //}
                //else
                //{
                //    _ButtonEnabled = true;
                //}
                
                return _ButtonEnabled;
            }
            set
            {                
                 _ButtonEnabled = value;
                OnPropertyChanged();
            }
        }


        // private bool IsSelectedCustomer => SelectedCustomer != null;

        private ICommand _SelectCommand;
        public ICommand SelectCommand
        {
            get
            {
                if (_SelectCommand == null)
                {
                    _SelectCommand = new RelayCommand(p => Select());
                }

                return _SelectCommand;
            }
        }


        private void Select()
        {
            this.ButtonEnabled = true;
        }







    }
 }
