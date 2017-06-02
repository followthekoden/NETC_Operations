using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Remotion.Linq.Clauses;

namespace NETCOperations.Models.OpsViewModels
{
    public class callbackModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Group { get; set; }
        [Phone]
        [Required]
        public string Primary { get; set; }
        [Phone]
        public string Secondary { get; set; }
    }
}
