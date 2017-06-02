using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace NETCOperations.Models.OpsViewModels
{
    public class PowerLogsViewModel
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Display (Name = "Day")]
        public string Day { get; set; }

        [Display (Name = "KVA")]
        public int kva { get; set; }
        [Display(Name = "Kw")]
        public int Kw { get; set; }
        [Display(Name = "A")]
        public int A { get; set; }
        [Display(Name = "B")]
        public int B { get; set; }
        [Display(Name = "C")]
        public int C { get; set; }
        [Display(Name = "pf")]
        public double  pf { get; set; }
        [Display(Name = "UPS Room Temp")]
        public double ups { get; set; }


    }
}
