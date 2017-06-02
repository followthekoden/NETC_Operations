using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETCOperations.Models.OpsViewModels
{
    public class scoViewModel
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Host Name")]
        public string HostName { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "Primary OS POC")]
        public string OSPocPrimary { get; set; }
        [Display(Name = "Secondary OS POC")]
        public string OSPocSecondary { get; set; }
        [Display(Name = "Primary A POC")]
        public string APocPrimary { get; set; }
        [Display(Name = "Secondary A POC")]
        public string APocSecondary { get; set; }
        [Display(Name = "DB Admin")]
        public string dbaadmin { get; set; }
        [Required]
        [Display(Name = "Callback")]
        public bool AfterHourCallback { get; set; }

    }
}
