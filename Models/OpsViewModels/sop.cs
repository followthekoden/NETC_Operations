using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NETCOperations.Data;

namespace NETCOperations.Models.OpsViewModels
{
    public class sop
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime Edited { get; set; }
        public string shortDescription { get; set; }

    }

}
