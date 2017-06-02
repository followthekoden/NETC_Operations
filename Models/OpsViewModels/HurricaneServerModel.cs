using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCOperations.Models.OpsViewModels
{
    public class HurricaneServerModel
    {
        public int Id { get; set; }
        public string HostName { get; set; }
        public string Application { get; set; }
        public string Enviroment { get; set; }
        public string Purpose { get; set; }
        public string Location { get; set; }
        public int Bldg { get; set; }
        public int Room { get; set; }
        public string Rack { get; set; }
        public string Primary { get; set; }
        public string Secondary { get; set; }
        public bool Hurricane { get; set; }
    }
}
