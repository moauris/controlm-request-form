using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using controlm_request_form.ControlMObjectBuilders;
using controlm_request_form.ControlMObject;
using System.Globalization;

namespace controlm_request_form.Models
{
    
    public class Request : ControlMBaseObject
    {
        #region Constructors

        #endregion
        #region Properties
        private string ticketNumber;

        public string TicketNumber
        {
            get { return ticketNumber; }
            set { ticketNumber = value; }
        }

        private DateTime dateRequested;

        public DateTime DateRequested
        {
            get { return dateRequested; }
            set { dateRequested = value; }
        }

        private PersonInCharge applicantPIC;

        public PersonInCharge ApplicantPIC
        {
            get { return applicantPIC; }
            set { applicantPIC = value; }
        }

        private PersonInCharge approverPIC;

        public PersonInCharge ApproverPIC
        {
            get { return approverPIC; }
            set { approverPIC = value; }
        }

        private string comment;

        public string SpecialComment
        {
            get { return comment; }
            set { comment = value; }
        }

        private ObservableCollection<MAgentRequest> requests;

        public ObservableCollection<MAgentRequest> Requests
        {
            get { return requests; }
            set { requests = value; }
        }

        #endregion
        #region Methods

        #endregion
        #region Events

        #endregion

    }

    public struct PersonInCharge
    {
        #region Constructors

        #endregion
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMailAddress { get; set; }
        #endregion
        #region Methods
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        #endregion
        #region Events

        #endregion


    }

    class RequestBuilder : BuilderBase
    {
        #region Constructors

        #endregion
        #region Properties

        #endregion
        #region Methods

        #endregion
        #region Events

        #endregion
        public override void Populate<RequestProperties>(RequestProperties Property, object Value)
        {
            throw new NotImplementedException();
        }

        public override ControlMBaseObject TryBuild()
        {
            throw new NotImplementedException();
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }

    public enum RequestProperties
    {
        TicketNumber,
        DateRequested,
        ApplicantPIC,
        ApproverPIC,
        SpecialComment,
        Requests,
    }
}
