using System.ComponentModel;
using System.Net.Mime;
using System.Web.UI.WebControls;

namespace Purevision.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Person
    {
        private DateTime? _agreementSignedOn = DateTime.Now;
        //private Enums.BookkeepingProcessType _bookkeepingProcessType = Enums.BookkeepingProcessType.Unselected;
        //private Enums.BusinessType? _businessType = Enums.BusinessType.Unselected;
        //private Enums.Correspondance _invoiceCorrespondance = Enums.Correspondance.Unselected;
        //private Enums.Correspondance _reportCorrespondance = Enums.Correspondance.Unselected;
        //private Enums.Correspondance _chklistCorrespondance = Enums.Correspondance.Unselected;
        //private Enums.Correspondance _returnCorrespondance = Enums.Correspondance.Unselected;
        //private Enums.YesNo _specialistRequired = Enums.YesNo.Unselected;
        //private Enums.TaskFrequency _processingFrequency = Enums.TaskFrequency.Unselected;

        public Person()
        {
        }

        public int Id { get; set; }

        //[StringLength(10)]
        //[Display(Name = "Name")]
        //public string Name { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Given Name", Prompt = "Given Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Surname", Prompt = "Family Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Prompt = "Email")]
        [DataType("EmailAddress")]
        public string Email { get; set; }

        [Required]
        [StringLength(14)]
        [Display(Prompt = "Phone")]
        //[DataType(DataType.PhoneNumber)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###-###-####}")]
        public string Phone { get; set; }

        [Display(Prompt = "Comments")]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public int? UserId { get; set; }

        // 20150224-coxad Add Person Properties (20)

        [Display(Name = "Business Type", Prompt = "Entity type")]
        public Enums.BusinessType BusinessType { get; set; }
        //{
        //    get { return _businessType; }
        //    set { _businessType = value; }
        //}

        [StringLength(35)]
        [Display(Name = "Name", Prompt = "Business Name")]
        public string BusinessName { get; set; }

        [Display(Name = "Number", Prompt = "Business Number")]
        public string BusinessNumber { get; set; }

        [Display(Name = "PST", Prompt = "PST Number")]
        public string ProvincialSalesTaxNumber { get; set; }

        //public Person ReferredBy { get; set; }
        [Display(Name = "Referred By", Prompt = "Referral Name")]
        public string ReferredBy { get; set; }

        [Display(Name = "Processing", Prompt = "Choose type")]
        //[Range(0, int.MaxValue, ErrorMessage = "Invalid type selected")]
        public Enums.BookkeepingProcessType BookkeepingProcessType { get; set; }
        //{
        //    get { return _bookkeepingProcessType; }
        //    set { _bookkeepingProcessType = value; }
        //}

        [Display(Name = "Specialist required", Prompt = "Yes / No")]
        public Enums.YesNo SpecialistRequired { get; set; }
        //{
        //    get { return _specialistRequired; }
        //    set { _specialistRequired = value; }
        //}

        //public Person SpecialistAssigned { get; set; }
        [Display(Name = "Specialist assigned", Prompt = "Specialist Name")]
        public string SpecialistAssigned { get; set; }

        //public Person MaintenanceBookkeeperAssigned { get; set; }
        [Display(Name = "Maintenance keeper", Prompt = "Bookkeeper Name")]
        public string MaintenanceBookkeeperAssigned { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Process from", Prompt = "Start Date")]
        public DateTime? ProcessingRequiredFrom { get; set; }

        [Display(Name = "Process frequency", Prompt = "Select frequency")]
        public Enums.TaskFrequency ProcessingFrequency { get; set; }
        //{
        //    get { return _processingFrequency; }
        //    set { _processingFrequency = value; }
        //}

        [DataType(DataType.Date)]
        [Display(Name = "Client Agreement signed", Prompt = "Date Signed")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? AgreementSignedOn// { get; set; }
        {
            get { return _agreementSignedOn; }
            set { _agreementSignedOn = value; }
        }

        [DataType(DataType.Date)]
        [Display(Name = "RC59 form signed", Prompt = "Date Signed")]
        public DateTime? BusinessConsentFormSignedOn { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "ROE Web form signed", Prompt = "Date Signed")]
        public DateTime? RecordOfEmploymentFormSignedOn { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Telpay form  signed", Prompt = "Date Signed")]
        public DateTime? TelpayFormSignedOn { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Work to start", Prompt = "Start Date")]
        public DateTime? WorkToStartOn { get; set; }

        [Display(Name = "Returns by")]
        [Description("Method of correspondance for 'Returns'")]
        public Enums.Correspondance ReturnCorrespondance { get; set; }
        //{
        //    get { return _returnCorrespondance; }
        //    set { _returnCorrespondance = value; }
        //}

        [Display(Name = "Send Checklists by", Prompt = "Method of correspondance for 'Checklists'")]
        public Enums.Correspondance ChklistCorrespondance { get; set; }
        //{
        //    get { return _chklistCorrespondance; }
        //    set { _chklistCorrespondance = value; }
        //}

        [Display(Name = "Send Reports by", Prompt = "Method of correspondance for 'Reports'")]
        public Enums.Correspondance ReportCorrespondance { get; set; }
        //{
        //    get { return _reportCorrespondance; }
        //    set { _reportCorrespondance = value; }
        //}

        [Display(Name = "Send Invoices by", Prompt = "Method of correspondance for 'Invoices'")]
        public Enums.Correspondance InvoiceCorrespondance { get; set; }
        //{
        //    get { return _invoiceCorrespondance; }
        //    set { _invoiceCorrespondance = value; }
        //}
    }
}
