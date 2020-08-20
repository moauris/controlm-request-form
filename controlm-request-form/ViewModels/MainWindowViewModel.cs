using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using controlm_request_form.Models;
using System.Diagnostics;

namespace controlm_request_form.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Constructors
        public MainWindowViewModel()
        {
#if DEBUG
            Debug.Print("MainWindowViewModel() Initialized");
#endif

        }


        #endregion
        #region Properties
        private RequestBuilder PageRequestBuilder
        => new RequestBuilder();

        private string ticketNumber;

        public string TicketNumber
        {
            get { return ticketNumber; }
            set
            {
                ticketNumber = value;
                OnPropertyChanged("TicketNumber", value);
            }
        }

        private DateTime dateRequested = DateTime.Today;

        public DateTime DateRequested
        {
            get { return dateRequested; }
            set
            {
                dateRequested = value;
                OnPropertyChanged("DateRequested", value);
            }
        }

        private string applicantPIC;

        public string ApplicantPIC
        {
            get { return applicantPIC; }
            set
            {
                applicantPIC = value;
                OnPropertyChanged("ApplicantPIC", value);
            }
        }

        private string approverPIC;

        public string ApproverPIC
        {
            get { return approverPIC; }
            set
            {
                approverPIC = value;
                OnPropertyChanged("ApproverPIC", value);
            }
        }

        private string comment;

        public string SpecialComment
        {
            get { return comment; }
            set
            {
                comment = value;
                OnPropertyChanged("SpecialComment", value);
            }
        }


        #endregion
        #region Methods

        #endregion
        #region Events

       
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string PropertyName, object newValue)
        {
            PropertyChanged?.Invoke(this
                , new PropertyChangedEventArgs(PropertyName));
            //Populate Builder here:
            PageRequestBuilder.Populate(PropertyName, newValue);
        }
        #endregion


    }
}
