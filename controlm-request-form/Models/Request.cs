using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using controlm_request_form.ControlMObjectBuilders;
using controlm_request_form.BaseObjects;
using System.Globalization;

namespace controlm_request_form.Models
{
    
    public class Request : ControlMObjectBase
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

        private string applicantPIC;

        public string ApplicantPIC
        {
            get { return applicantPIC; }
            set { applicantPIC = value; }
        }

        private string approverPIC;

        public string ApproverPIC
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

    class RequestBuilder : BuilderBase
    {
        #region Constructors

        #endregion
        #region Properties
        private string ticketNumber;
        private DateTime dateRequested;
        private string applicantPIC;
        private string approverPIC;
        private string comment;
        #endregion
        #region Methods

        #endregion
        #region Events

        #endregion

        public override bool TryBuild(out ControlMObjectBase controlMObject)
        {
            throw new NotImplementedException();
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        public static Request BuildSample() =>
            new Request
            {
                DateRequested = DateTime.Today
                ,
                ApplicantPIC = "mchenf@icloud.com"
                ,
                ApproverPIC = "BabyCat@cute.cute.com"
                ,
                SpecialComment = "Meow Meow Moew"
                ,
                TicketNumber = "INC00000132233"
                ,
                Requests = new ObservableCollection<MAgentRequest> { new MAgentRequest() }
            };

        public override void Populate(string Property, object Value)
        {
            switch (Property)
            {
                case "TicketNumber":
                    ticketNumber = (string)Value;
                    break;
                case "DateRequested":
                    dateRequested = (DateTime)Value;
                    break;
                case "ApplicantPIC":
                    applicantPIC = (string)Value;
                    break;
                case "ApproverPIC":
                    approverPIC = (string)Value;
                    break;
                case "SpecialComment":
                    comment = (string)Value;
                    break;
                default:
                    break;
            }
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
