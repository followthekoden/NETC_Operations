using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NETCOperations.Data;
namespace NETCOperations.Models.OpsViewModels
{
    public class SeedDataCallback
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.callbackModel.Any())
                {
                    return;

                }

                context.callbackModel.AddRange(


  new callbackModel
  {
      Name = "Anderson, Laurine",
      Group = "MyEducation",
      Primary = "850-525-7322 / 850-525-2539",
      Secondary = "850-478-7523"

  },

  new callbackModel
  {
      Name = "Bailey, James",
      Group = "NEAS / EDS / NFLTO",
      Primary = "850-525-4725",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Beasley, Brian",
      Group = "DBA",
      Primary = "850-377-7999",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Belanger, Terry",
      Group = "COMM",
      Primary = "850-206-2880",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Berkley, Donna",
      Group = "SOA",
      Primary = "850-261-6126",
      Secondary = "850944-4671"

  },

  new callbackModel
  {
      Name = "Blackmon, David",
      Group = "",
      Primary = "850-346-0021",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Borelli, Tony",
      Group = "ALTIRIS",
      Primary = "774-249-5843",
      Secondary = "850-725-0854"

  },

  new callbackModel
  {
      Name = "Boshard, Paul",
      Group = "NEL/ILE",
      Primary = "850-791-1316",
      Secondary = "850-994-2885"

  },

  new callbackModel
  {
      Name = "Bowling, Fusako",
      Group = "ROTC",
      Primary = "850-934-5066",
      Secondary = "850-206-8522"

  },

  new callbackModel
  {
      Name = "Bowman, Gwen",
      Group = "CARIS",
      Primary = "850-587-5247",
      Secondary = "850-712-5256"

  },

  new callbackModel
  {
      Name = "Brice, Thomas",
      Group = "Systems Eng.",
      Primary = "850-505-9565",
      Secondary = "850-292-1594"

  },

  new callbackModel
  {
      Name = "Brockway, Mark",
      Group = "CeTARS",
      Primary = "850-492-1572",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Brownell, Ron",
      Group = "Serena",
      Primary = "850-341-6930",
      Secondary = "850-261-9871"

  },

  new callbackModel
  {
      Name = "Buckley, Matthew",
      Group = "Unix",
      Primary = "601-480-9559",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Campbell, Nathan",
      Group = "Networking",
      Primary = "",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Capehart, Tom",
      Group = "DAR / SSIM",
      Primary = "478-951-1838",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Carter, Nick",
      Group = "NCMIS",
      Primary = "850-457-0303",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Christian, Ozzie",
      Group = "TRANET",
      Primary = "850-261-9399",
      Secondary = "850-356-8296 / 850-261-8095"

  },

  new callbackModel
  {
      Name = "Churchill, Bucky",
      Group = "DAR / SSIM",
      Primary = "850-516-1640",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Collins, Tim",
      Group = "VDI",
      Primary = "850-549-6243",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Colquett, Stephen",
      Group = "VDI",
      Primary = "334-488-3917",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Conway, Steven",
      Group = "ILE / LAS",
      Primary = "850-434-9220",
      Secondary = "850-418-5543"

  },

  new callbackModel
  {
      Name = "Cooper, Mike",
      Group = "DBA",
      Primary = "251-979-5178",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Davis, David",
      Group = "TRANET",
      Primary = "",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Davis, Laura",
      Group = "LAS",
      Primary = "850-450-3067",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Delemos, Raymond",
      Group = "CeTARS",
      Primary = "Not on call",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "DIAZ, ELIUT",
      Group = "NKO",
      Primary = "850-221-3484",
      Secondary = "850-492-9053"

  },

  new callbackModel
  {
      Name = "Faircloth, Randy",
      Group = "DBA",
      Primary = "850-457-2755",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Garrett, Shane",
      Group = "DBA",
      Primary = "850-418-5228",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Green, Demina",
      Group = "CeTARS",
      Primary = "850-723-3390",
      Secondary = "850-432-1616"

  },

  new callbackModel
  {
      Name = "Hamilton, James",
      Group = "COMM",
      Primary = "850-473-5927",
      Secondary = "850-292-4844"

  },

  new callbackModel
  {
      Name = "Hasty, Ernest",
      Group = "NCMIS",
      Primary = "850-503-2075",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Horacek, David",
      Group = "COMM",
      Primary = "850-457-4476",
      Secondary = "850-418-0757"

  },

  new callbackModel
  {
      Name = "Johnson, William R",
      Group = "NKO",
      Primary = "850-434-8622",
      Secondary = "850-418-0956 / 850-261-9871"

  },

  new callbackModel
  {
      Name = "Latourelle, Dan",
      Group = "ILE",
      Primary = "850-477-8891",
      Secondary = "850-477-8891"

  },

  new callbackModel
  {
      Name = "Lawrence, David",
      Group = "SSIM",
      Primary = "850-261-6733",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Le, Linh",
      Group = "CARIS",
      Primary = "850-944-1434",
      Secondary = "850-417-9640"

  },

  new callbackModel
  {
      Name = "Leggett, Don",
      Group = "eTRMS / NETC",
      Primary = "850-474-1812",
      Secondary = "850-261-0479"

  },

  new callbackModel
  {
      Name = "Lewis, Terry",
      Group = "DBA",
      Primary = "850-937-2748",
      Secondary = "850-384-0144"

  },

  new callbackModel
  {
      Name = "Lockwood, Nancy",
      Group = "NetBackup",
      Primary = "850-748-1665",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Martin, Scott",
      Group = "ROTC",
      Primary = "850-607-4969",
      Secondary = "850-941-0121"

  },

  new callbackModel
  {
      Name = "Mata, Joseph",
      Group = "Fastdata",
      Primary = "850-530-0749",
      Secondary = "850-994-2366"

  },

  new callbackModel
  {
      Name = "McCurdy, Kenneth",
      Group = "Serena",
      Primary = "850-501-4788",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Miller, Jim",
      Group = "NKO",
      Primary = "850-429-1879",
      Secondary = "850-207-9245"

  },

  new callbackModel
  {
      Name = "Monnot, Don",
      Group = "NEAS",
      Primary = "850-456-7014",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Moore, James",
      Group = "COMM",
      Primary = "850-791-1309",
      Secondary = "850-206-7612 / 850-607-2416"

  },

  new callbackModel
  {
      Name = "Morgan, Eric",
      Group = "Windows Systems",
      Primary = "850-417-6183",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Nemanic, Janet",
      Group = "",
      Primary = "",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Nguyen, Loi",
      Group = "Cetars",
      Primary = "850-346-3208",
      Secondary = "850-944-3598"

  },

  new callbackModel
  {
      Name = "Noski, Stephanie",
      Group = "ALTIRIS",
      Primary = "850-944-8080",
      Secondary = "850-572-8082"

  },

  new callbackModel
  {
      Name = "Odom, Charlie",
      Group = "Windows Systems/C27 servers/AIM",
      Primary = "850-549-5836",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "O'Neal, Kirk",
      Group = "VDI",
      Primary = "850-525-6210",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Otis, Kathy",
      Group = "Facilities",
      Primary = "850-324-1389",
      Secondary = "850-418-0805"

  },

  new callbackModel
  {
      Name = "Pate, Micah",
      Group = "VDI",
      Primary = "850-974-7283",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Payne, Donald",
      Group = "NetBackup",
      Primary = "850-430-9294",
      Secondary = "850-748-2175"

  },

  new callbackModel
  {
      Name = "Petersen, Aaron",
      Group = "DBA",
      Primary = "850-572-4912",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Prettyman, Thomas",
      Group = "",
      Primary = "850-582-7714",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Pruett, Scott",
      Group = "ACAS",
      Primary = "850-449-3352",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Ralli, William",
      Group = "NIGHTS / NEAS / EDS / NFLTO",
      Primary = "850-453-4081",
      Secondary = "850-382-8791"

  },

  new callbackModel
  {
      Name = "Rayburn, Robert",
      Group = "Websites",
      Primary = "850-380-5931",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Remesch, Anita",
      Group = "",
      Primary = "",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Reynolds, Larry",
      Group = "CeTARS",
      Primary = "850-380-5053",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Rick Rhea",
      Group = "Netfocus",
      Primary = "850-602-3667",
      Secondary = "850-916-0590"

  },

  new callbackModel
  {
      Name = "Rogers, Martin",
      Group = "HBSS",
      Primary = "850-573-4249",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Rook, Wendy",
      Group = "Netfocus",
      Primary = "850-712-5001",
      Secondary = "850-457-4612"

  },

  new callbackModel
  {
      Name = "Rowe, Michael",
      Group = "Websites",
      Primary = "850-698-8498",
      Secondary = "850-686-2513"

  },

  new callbackModel
  {
      Name = "Sabo, Tina",
      Group = "COMM",
      Primary = "850-791-1303",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Schack, Kevin",
      Group = "NKO",
      Primary = "850-450-7019",
      Secondary = "850-937-9743"

  },

  new callbackModel
  {
      Name = "Schick, Cory",
      Group = "VDI",
      Primary = "850-516-6104",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Scobey, David",
      Group = "HBSS / RSD Civilian",
      Primary = "850-449-6689",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Seelye, Ben",
      Group = "Great Lakes Task Manager",
      Primary = "262-344-9078",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Sellers, Melisse",
      Group = "LAS",
      Primary = "850-473-5914",
      Secondary = "850-554-2210"

  },

  new callbackModel
  {
      Name = "Simpkins, Steven",
      Group = "Windows Systems",
      Primary = "850-912-9661",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Slade, Lawana",
      Group = "UNIX",
      Primary = "850-530-3770",
      Secondary = "850-712-6092"

  },

  new callbackModel
  {
      Name = "Smith, Austin",
      Group = "ILE Team",
      Primary = "",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Smith, Tracy",
      Group = "DBA",
      Primary = "850-944-1940",
      Secondary = "850-712-6092"

  },

  new callbackModel
  {
      Name = "Spivey, Doug",
      Group = "Windows Systems",
      Primary = "850-525-4537",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Sport, Mercer",
      Group = "DBA",
      Primary = "850-516-6971",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Stone, Marc",
      Group = "Windows Systems",
      Primary = "850-206-6870",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Switzer, Benjamin",
      Group = "NIGHTS / SAS",
      Primary = "850-587-2933",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Tibbs, Charlie",
      Group = "Networking",
      Primary = "850-497-2091",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Townsend, Levadie",
      Group = "MyEducation",
      Primary = "850-969-9238",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Tran, Tien",
      Group = "NCMIS",
      Primary = "850-716-3266",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Vivar, Melissa",
      Group = "DODVES",
      Primary = "850-473-6229",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Walker, Stan",
      Group = "Serena",
      Primary = "850-473-5860",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Wallace, Kenneth",
      Group = "Networking",
      Primary = "850-384-9791",
      Secondary = "850-457-4612"

  },

  new callbackModel
  {
      Name = "Wetzel, Levi",
      Group = "WebSites",
      Primary = "850-723-0209",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Whitaker, Roy",
      Group = "VDI",
      Primary = "850-436-6639",
      Secondary = "850-418-0608"

  },

  new callbackModel
  {
      Name = "White, Rick",
      Group = "SOA",
      Primary = "850-516-3013",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "White, Shantra",
      Group = "DBA",
      Primary = "850-306-3217",
      Secondary = "850-479-3883"

  },

  new callbackModel
  {
      Name = "Williams, Nina",
      Group = "TRANET GPO",
      Primary = "850-261-5664",
      Secondary = ""

  },

  new callbackModel
  {
      Name = "Wood, Bill",
      Group = "Fastdata",
      Primary = "850-382-8020",
      Secondary = ""
  });

                context.SaveChanges();
            }
        }
    }
}
