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
       // private readonly ICustomersService _CustomersService;

        //public CustomerViewModel(ICustomersService _CustomersService)
        //{
        //    this._CustomersService = _CustomersService;

        //    //_Customer = new CustomerModel("Witek");                     
        //    Load();

        //}

        public CustomerViewModel()
            //: this(new MocCustomersServices()) // gdy kożystamy z Moc używamy metod Moc
                                               //: this(new DbProductService()) // gdy kożystamy z bazy danych kożystamy z metod klasy DbProductService
        {
            Load();
        }


        private void Load()
        {
            //Customers = new ObservableCollection<CustomerModel>(_CustomersService.Get());  //implementacja klasy informującej listę o konieczności zmiany
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

        private bool CanAddText()
        {
            return true;
        }

        private void AddText()
        {
            this.TextValue = "zmiana";
        }

        //private ICollection<CustomerModel> _Customers;

        //public ICollection<CustomerModel> Customers
        //{
        //    get { return _Customers; }
        //    set
        //    {
        //        _Customers = value;
        //        OnPropertyChanged();
        //    }
        //}

        //private CustomerModel _Customer;

        //public CustomerModel Customer
        //{
        //    get { return _Customer; }
        //    set
        //    {
        //        _Customer = value;
        //        OnPropertyChanged();
        //    }
        //}
    }
 }
