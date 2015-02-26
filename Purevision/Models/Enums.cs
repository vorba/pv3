using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Purevision.Web.Models
{
    public class Enums
    {
        public enum BookkeepingProcessType
        {
            [Display(Name = "Select type")]
            Unselected,
            Rescue,
            Training,
            [Display(Name = "New / Manual")]
            NewManual,
            Maintenance
        }

        public enum BusinessType
        {
            [Display(Name = "Select type")]
            Unselected,
            Company,
            Partership,
            Trust,
            [Display(Name = "Sole Proprietor")]
            SoleProprietor
        }

        public enum TaskFrequency
        {
            [Display(Name = "Select frequency")]
            Unselected,
            Weekly,
            [Display(Name = "Bi-weekly")]
            Biweekly,
            Monthly,
            Quarterly
        }

        public enum Correspondance
        {
            [Display(Name = "Select method")]
            Unselected,
            Email,
            Fax,
            [Display(Name = "Hard Copy")]
            HardCopy,
            Post
        }

        public enum YesNo
        {
            [Display(Name = "Yes / No")]
            Unselected,
            Yes,
            No
        }

        public enum YesNoMaybe
        {
            [Display(Name = "Yes / No / Maybe")]
            Unselected,
            Yes,
            No,
            Maybe
        }
    }
}