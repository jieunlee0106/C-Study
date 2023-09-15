using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Models
{
    public class User : INotifyPropertyChanged
    {
        private int userId;
        private string firstName;
        private string lastName;
        private string city;
        private string state;
        private string country;
        public int UserId 
        {
            get { return userId; } 
            set 
            {
                userId = value;
                OnPropertyChanged("UserId");
            } 
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                OnPropertyChanged("City");
                // OnPropertyChanged(city); => 바뀌는 변수를 넣어야 하는 것 아닌가...?

            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged("State");
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }
        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;  
    private void OnPropertyChanged(string propertyName)  
    {  
        if (PropertyChanged != null)  
        {  
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));  
        }  
    }  
    #endregion  
    }
}
