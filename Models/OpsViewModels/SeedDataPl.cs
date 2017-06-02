using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NETCOperations.Data;

namespace NETCOperations.Models.OpsViewModels
{
    public class SeedDataPl
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.PowerLogsViewModel.Any())
                {
                    return;
                }
                context.PowerLogsViewModel.AddRange(
                    new PowerLogsViewModel

                    {
                        Date = DateTime.Parse("7/31/2015"),
                        Day = "F",
                        kva = 124,
                        Kw = 106,
                        A = 141,
                        B = 161,
                        C = 140,
                        pf = 0.85,
                        ups = 63.7
                    },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/1/2015"),
     Day = "Sa",
     kva = 125,
     Kw = 106,
     A = 142,
     B = 164,
     C = 140,
     pf = 0.85,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/2/2015"),
     Day = "Su",
     kva = 123,
     Kw = 106,
     A = 141,
     B = 163,
     C = 140,
     pf = 0.86,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/3/2015"),
     Day = "Mo",
     kva = 123,
     Kw = 105,
     A = 143,
     B = 163,
     C = 140,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/4/2015"),
     Day = "Tu",
     kva = 124,
     Kw = 106,
     A = 143,
     B = 165,
     C = 140,
     pf = 0.85,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/5/2015"),
     Day = "W",
     kva = 124,
     Kw = 107,
     A = 144,
     B = 165,
     C = 141,
     pf = 0.86,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/6/2015"),
     Day = "Th",
     kva = 124,
     Kw = 105,
     A = 142,
     B = 167,
     C = 140,
     pf = 0.85,
     ups = 64.9
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/7/2015"),
     Day = "F",
     kva = 125,
     Kw = 107,
     A = 144,
     B = 165,
     C = 141,
     pf = 0.86,
     ups = 64.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/8/2015"),
     Day = "Sa",
     kva = 125,
     Kw = 106,
     A = 144,
     B = 167,
     C = 139,
     pf = 0.85,
     ups = 65.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/9/2015"),
     Day = "Su",
     kva = 123,
     Kw = 104,
     A = 141,
     B = 160,
     C = 139,
     pf = 0.85,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/10/2015"),
     Day = "Mo",
     kva = 124,
     Kw = 106,
     A = 143,
     B = 164,
     C = 140,
     pf = 0.85,
     ups = 64.9
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/11/2015"),
     Day = "Tu",
     kva = 127,
     Kw = 104,
     A = 144,
     B = 166,
     C = 140,
     pf = 0.82,
     ups = 64.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/12/2015"),
     Day = "W",
     kva = 124,
     Kw = 106,
     A = 143,
     B = 164,
     C = 140,
     pf = 0.85,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/13/2015"),
     Day = "Th",
     kva = 123,
     Kw = 106,
     A = 144,
     B = 164,
     C = 140,
     pf = 0.86,
     ups = 63
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/14/2015"),
     Day = "F",
     kva = 123,
     Kw = 105,
     A = 142,
     B = 164,
     C = 139,
     pf = 0.85,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/15/2015"),
     Day = "Sa",
     kva = 124,
     Kw = 107,
     A = 144,
     B = 164,
     C = 138,
     pf = 0.86,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/16/2015"),
     Day = "Su",
     kva = 123,
     Kw = 104,
     A = 142,
     B = 161,
     C = 140,
     pf = 0.85,
     ups = 63
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/17/2015"),
     Day = "Mo",
     kva = 124,
     Kw = 106,
     A = 144,
     B = 164,
     C = 137,
     pf = 0.85,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/18/2015"),
     Day = "Tu",
     kva = 123,
     Kw = 106,
     A = 142,
     B = 166,
     C = 138,
     pf = 0.86,
     ups = 64.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/19/2015"),
     Day = "W",
     kva = 123,
     Kw = 106,
     A = 139,
     B = 163,
     C = 138,
     pf = 0.86,
     ups = 64.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/20/2015"),
     Day = "Th",
     kva = 123,
     Kw = 105,
     A = 141,
     B = 163,
     C = 139,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/21/2015"),
     Day = "F",
     kva = 124,
     Kw = 105,
     A = 142,
     B = 164,
     C = 139,
     pf = 0.85,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/22/2015"),
     Day = "Sa",
     kva = 124,
     Kw = 107,
     A = 144,
     B = 167,
     C = 140,
     pf = 0.86,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/23/2015"),
     Day = "Su",
     kva = 124,
     Kw = 105,
     A = 140,
     B = 162,
     C = 140,
     pf = 0.85,
     ups = 64.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/24/2015"),
     Day = "Mo",
     kva = 123,
     Kw = 106,
     A = 142,
     B = 161,
     C = 137,
     pf = 0.86,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/25/2015"),
     Day = "Tu",
     kva = 124,
     Kw = 106,
     A = 142,
     B = 165,
     C = 137,
     pf = 0.85,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/26/2015"),
     Day = "W",
     kva = 123,
     Kw = 103,
     A = 141,
     B = 160,
     C = 139,
     pf = 0.84,
     ups = 63
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/27/2015"),
     Day = "Th",
     kva = 123,
     Kw = 104,
     A = 141,
     B = 163,
     C = 138,
     pf = 0.85,
     ups = 63
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/28/2015"),
     Day = "F",
     kva = 123,
     Kw = 104,
     A = 140,
     B = 161,
     C = 138,
     pf = 0.85,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/29/2015"),
     Day = "Sa",
     kva = 125,
     Kw = 106,
     A = 142,
     B = 165,
     C = 137,
     pf = 0.85,
     ups = 61.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/30/2015"),
     Day = "Su",
     kva = 122,
     Kw = 105,
     A = 142,
     B = 162,
     C = 137,
     pf = 0.86,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/31/2015"),
     Day = "Mo",
     kva = 123,
     Kw = 106,
     A = 142,
     B = 163,
     C = 139,
     pf = 0.86,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/1/2015"),
     Day = "Tu",
     kva = 124,
     Kw = 105,
     A = 143,
     B = 163,
     C = 136,
     pf = 0.85,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/2/2015"),
     Day = "W",
     kva = 124,
     Kw = 106,
     A = 143,
     B = 164,
     C = 138,
     pf = 0.85,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/3/2015"),
     Day = "Th",
     kva = 123,
     Kw = 106,
     A = 144,
     B = 164,
     C = 140,
     pf = 0.86,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/4/2015"),
     Day = "F",
     kva = 122,
     Kw = 103,
     A = 143,
     B = 163,
     C = 136,
     pf = 0.84,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/5/2015"),
     Day = "Sa",
     kva = 124,
     Kw = 106,
     A = 144,
     B = 163,
     C = 139,
     pf = 0.85,
     ups = 63.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/6/2015"),
     Day = "Su",
     kva = 122,
     Kw = 105,
     A = 142,
     B = 163,
     C = 136,
     pf = 0.86,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/7/2015"),
     Day = "Mo",
     kva = 123,
     Kw = 105,
     A = 143,
     B = 161,
     C = 138,
     pf = 0.85,
     ups = 61.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/8/2015"),
     Day = "Tu",
     kva = 124,
     Kw = 106,
     A = 142,
     B = 160,
     C = 138,
     pf = 0.85,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/9/2015"),
     Day = "W",
     kva = 122,
     Kw = 104,
     A = 142,
     B = 161,
     C = 147,
     pf = 0.85,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/10/2015"),
     Day = "Th",
     kva = 123,
     Kw = 107,
     A = 144,
     B = 165,
     C = 142,
     pf = 0.87,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/11/2015"),
     Day = "F",
     kva = 124,
     Kw = 107,
     A = 145,
     B = 163,
     C = 141,
     pf = 0.86,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/12/2015"),
     Day = "Sa",
     kva = 124,
     Kw = 106,
     A = 144,
     B = 166,
     C = 139,
     pf = 0.85,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/13/2015"),
     Day = "Su",
     kva = 124,
     Kw = 105,
     A = 141,
     B = 162,
     C = 137,
     pf = 0.85,
     ups = 62.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/14/2015"),
     Day = "Mo",
     kva = 124,
     Kw = 106,
     A = 142,
     B = 161,
     C = 139,
     pf = 0.85,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/15/2015"),
     Day = "Tu",
     kva = 123,
     Kw = 105,
     A = 142,
     B = 160,
     C = 136,
     pf = 0.85,
     ups = 65.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/16/2015"),
     Day = "W",
     kva = 124,
     Kw = 106,
     A = 142,
     B = 163,
     C = 136,
     pf = 0.85,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/17/2015"),
     Day = "Th",
     kva = 123,
     Kw = 106,
     A = 143,
     B = 162,
     C = 139,
     pf = 0.86,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/18/2015"),
     Day = "F",
     kva = 123,
     Kw = 104,
     A = 141,
     B = 164,
     C = 138,
     pf = 0.85,
     ups = 65.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/19/2015"),
     Day = "Sa",
     kva = 123,
     Kw = 104,
     A = 144,
     B = 164,
     C = 139,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/20/2015"),
     Day = "Su",
     kva = 122,
     Kw = 103,
     A = 144,
     B = 160,
     C = 135,
     pf = 0.84,
     ups = 65.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/21/2015"),
     Day = "Mo",
     kva = 122,
     Kw = 104,
     A = 143,
     B = 162,
     C = 137,
     pf = 0.85,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/22/2015"),
     Day = "Tu",
     kva = 122,
     Kw = 104,
     A = 140,
     B = 164,
     C = 137,
     pf = 0.85,
     ups = 64.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/23/2015"),
     Day = "W",
     kva = 119,
     Kw = 104,
     A = 139,
     B = 160,
     C = 133,
     pf = 0.87,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/24/2015"),
     Day = "Th",
     kva = 123,
     Kw = 107,
     A = 144,
     B = 161,
     C = 137,
     pf = 0.87,
     ups = 63.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/25/2015"),
     Day = "F",
     kva = 119,
     Kw = 103,
     A = 139,
     B = 157,
     C = 133,
     pf = 0.87,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/26/2015"),
     Day = "Sa",
     kva = 121,
     Kw = 103,
     A = 140,
     B = 158,
     C = 132,
     pf = 0.85,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/27/2015"),
     Day = "Su",
     kva = 119,
     Kw = 101,
     A = 138,
     B = 156,
     C = 132,
     pf = 0.85,
     ups = 64.9
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/28/2015"),
     Day = "Mo",
     kva = 119,
     Kw = 102,
     A = 139,
     B = 155,
     C = 135,
     pf = 0.86,
     ups = 63
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/29/2015"),
     Day = "Tu",
     kva = 120,
     Kw = 101,
     A = 141,
     B = 153,
     C = 135,
     pf = 0.84,
     ups = 64.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("9/30/2015"),
     Day = "W",
     kva = 119,
     Kw = 102,
     A = 139,
     B = 159,
     C = 135,
     pf = 0.86,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/1/2015"),
     Day = "Th",
     kva = 120,
     Kw = 103,
     A = 139,
     B = 157,
     C = 135,
     pf = 0.86,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/2/2015"),
     Day = "F",
     kva = 120,
     Kw = 102,
     A = 141,
     B = 157,
     C = 133,
     pf = 0.85,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/3/2015"),
     Day = "Sa",
     kva = 120,
     Kw = 104,
     A = 140,
     B = 157,
     C = 133,
     pf = 0.87,
     ups = 64.9
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/4/2015"),
     Day = "Su",
     kva = 120,
     Kw = 102,
     A = 137,
     B = 156,
     C = 132,
     pf = 0.85,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/5/2015"),
     Day = "Mo",
     kva = 120,
     Kw = 102,
     A = 140,
     B = 158,
     C = 133,
     pf = 0.85,
     ups = 65.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/6/2015"),
     Day = "Tu",
     kva = 120,
     Kw = 101,
     A = 139,
     B = 155,
     C = 134,
     pf = 0.84,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/7/2015"),
     Day = "W",
     kva = 119,
     Kw = 102,
     A = 139,
     B = 152,
     C = 137,
     pf = 0.86,
     ups = 64.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/8/2015"),
     Day = "Th",
     kva = 119,
     Kw = 102,
     A = 139,
     B = 157,
     C = 133,
     pf = 0.86,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/9/2015"),
     Day = "F",
     kva = 119,
     Kw = 101,
     A = 139,
     B = 157,
     C = 134,
     pf = 0.85,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/10/2015"),
     Day = "Sa",
     kva = 118,
     Kw = 101,
     A = 137,
     B = 156,
     C = 131,
     pf = 0.86,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/11/2015"),
     Day = "Su",
     kva = 118,
     Kw = 101,
     A = 137,
     B = 157,
     C = 132,
     pf = 0.86,
     ups = 64.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/12/2015"),
     Day = "Mo",
     kva = 118,
     Kw = 102,
     A = 139,
     B = 156,
     C = 131,
     pf = 0.86,
     ups = 61.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/13/2015"),
     Day = "Tu",
     kva = 118,
     Kw = 102,
     A = 137,
     B = 156,
     C = 133,
     pf = 0.86,
     ups = 63.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/14/2015"),
     Day = "W",
     kva = 120,
     Kw = 104,
     A = 140,
     B = 156,
     C = 134,
     pf = 0.87,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/15/2015"),
     Day = "Th",
     kva = 118,
     Kw = 101,
     A = 137,
     B = 157,
     C = 133,
     pf = 0.86,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/16/2015"),
     Day = "F",
     kva = 119,
     Kw = 103,
     A = 139,
     B = 155,
     C = 137,
     pf = 0.87,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/17/2015"),
     Day = "Sa",
     kva = 120,
     Kw = 102,
     A = 138,
     B = 156,
     C = 134,
     pf = 0.85,
     ups = 61.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/18/2015"),
     Day = "Su",
     kva = 119,
     Kw = 101,
     A = 139,
     B = 154,
     C = 132,
     pf = 0.85,
     ups = 60.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/19/2015"),
     Day = "Mo",
     kva = 119,
     Kw = 103,
     A = 139,
     B = 160,
     C = 134,
     pf = 0.87,
     ups = 64.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/20/2015"),
     Day = "Tu",
     kva = 118,
     Kw = 103,
     A = 138,
     B = 156,
     C = 132,
     pf = 0.87,
     ups = 61.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/21/2015"),
     Day = "W",
     kva = 118,
     Kw = 100,
     A = 137,
     B = 157,
     C = 134,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/22/2015"),
     Day = "Th",
     kva = 118,
     Kw = 102,
     A = 138,
     B = 154,
     C = 130,
     pf = 0.86,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/23/2015"),
     Day = "F",
     kva = 119,
     Kw = 102,
     A = 138,
     B = 157,
     C = 132,
     pf = 0.86,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/24/2015"),
     Day = "Sa",
     kva = 118,
     Kw = 101,
     A = 138,
     B = 156,
     C = 132,
     pf = 0.86,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/25/2015"),
     Day = "Su",
     kva = 118,
     Kw = 100,
     A = 136,
     B = 155,
     C = 132,
     pf = 0.85,
     ups = 64.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/26/2015"),
     Day = "Mo",
     kva = 119,
     Kw = 101,
     A = 139,
     B = 157,
     C = 135,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/27/2015"),
     Day = "Tu",
     kva = 120,
     Kw = 102,
     A = 139,
     B = 156,
     C = 133,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/28/2015"),
     Day = "W",
     kva = 118,
     Kw = 102,
     A = 138,
     B = 156,
     C = 132,
     pf = 0.86,
     ups = 63
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/29/2015"),
     Day = "Th",
     kva = 117,
     Kw = 100,
     A = 137,
     B = 156,
     C = 132,
     pf = 0.85,
     ups = 64.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/30/2015"),
     Day = "F",
     kva = 117,
     Kw = 99,
     A = 137,
     B = 154,
     C = 131,
     pf = 0.85,
     ups = 61.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("10/31/2015"),
     Day = "Sa",
     kva = 118,
     Kw = 102,
     A = 137,
     B = 155,
     C = 132,
     pf = 0.86,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/1/2015"),
     Day = "Su",
     kva = 117,
     Kw = 101,
     A = 137,
     B = 156,
     C = 132,
     pf = 0.86,
     ups = 64.9
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/2/2015"),
     Day = "Mo",
     kva = 118,
     Kw = 102,
     A = 138,
     B = 158,
     C = 132,
     pf = 0.86,
     ups = 63.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/3/2015"),
     Day = "Tu",
     kva = 118,
     Kw = 101,
     A = 138,
     B = 154,
     C = 133,
     pf = 0.86,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/4/2015"),
     Day = "W",
     kva = 118,
     Kw = 100,
     A = 137,
     B = 156,
     C = 132,
     pf = 0.85,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/5/2015"),
     Day = "Th",
     kva = 118,
     Kw = 101,
     A = 138,
     B = 155,
     C = 132,
     pf = 0.86,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/6/2015"),
     Day = "F",
     kva = 118,
     Kw = 101,
     A = 137,
     B = 154,
     C = 132,
     pf = 0.86,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/7/2015"),
     Day = "Sa",
     kva = 119,
     Kw = 101,
     A = 139,
     B = 155,
     C = 132,
     pf = 0.85,
     ups = 64.9
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/8/2015"),
     Day = "Su",
     kva = 117,
     Kw = 100,
     A = 137,
     B = 154,
     C = 132,
     pf = 0.85,
     ups = 62.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/9/2015"),
     Day = "Mo",
     kva = 117,
     Kw = 103,
     A = 136,
     B = 154,
     C = 131,
     pf = 0.88,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/10/2015"),
     Day = "Tu",
     kva = 117,
     Kw = 101,
     A = 138,
     B = 157,
     C = 133,
     pf = 0.86,
     ups = 61.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/11/2015"),
     Day = "W",
     kva = 117,
     Kw = 100,
     A = 136,
     B = 154,
     C = 132,
     pf = 0.85,
     ups = 65.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/12/2015"),
     Day = "Th",
     kva = 118,
     Kw = 101,
     A = 136,
     B = 155,
     C = 133,
     pf = 0.86,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/13/2015"),
     Day = "F",
     kva = 118,
     Kw = 100,
     A = 137,
     B = 156,
     C = 133,
     pf = 0.85,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/14/2015"),
     Day = "Sa",
     kva = 118,
     Kw = 102,
     A = 138,
     B = 156,
     C = 133,
     pf = 0.86,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/15/2015"),
     Day = "Su",
     kva = 117,
     Kw = 100,
     A = 138,
     B = 153,
     C = 132,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/16/2015"),
     Day = "Mo",
     kva = 117,
     Kw = 100,
     A = 138,
     B = 155,
     C = 131,
     pf = 0.85,
     ups = 61.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/17/2015"),
     Day = "Tu",
     kva = 117,
     Kw = 101,
     A = 136,
     B = 155,
     C = 134,
     pf = 0.86,
     ups = 66.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/18/2015"),
     Day = "W",
     kva = 118,
     Kw = 101,
     A = 137,
     B = 156,
     C = 132,
     pf = 0.86,
     ups = 65.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/19/2015"),
     Day = "Th",
     kva = 117,
     Kw = 101,
     A = 138,
     B = 154,
     C = 132,
     pf = 0.86,
     ups = 63.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/20/2015"),
     Day = "F",
     kva = 118,
     Kw = 101,
     A = 137,
     B = 155,
     C = 132,
     pf = 0.86,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/21/2015"),
     Day = "Sa",
     kva = 118,
     Kw = 101,
     A = 136,
     B = 155,
     C = 133,
     pf = 0.86,
     ups = 65.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/22/2015"),
     Day = "Su",
     kva = 117,
     Kw = 100,
     A = 136,
     B = 154,
     C = 132,
     pf = 0.85,
     ups = 63.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/23/2015"),
     Day = "Mo",
     kva = 117,
     Kw = 100,
     A = 136,
     B = 155,
     C = 131,
     pf = 0.85,
     ups = 64.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/24/2015"),
     Day = "Tu",
     kva = 118,
     Kw = 99,
     A = 137,
     B = 156,
     C = 132,
     pf = 0.84,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/25/2015"),
     Day = "W",
     kva = 116,
     Kw = 100,
     A = 136,
     B = 156,
     C = 132,
     pf = 0.86,
     ups = 65.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/26/2015"),
     Day = "Th",
     kva = 117,
     Kw = 99,
     A = 136,
     B = 154,
     C = 129,
     pf = 0.85,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/27/2015"),
     Day = "F",
     kva = 118,
     Kw = 99,
     A = 137,
     B = 154,
     C = 137,
     pf = 0.84,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/28/2015"),
     Day = "Sa",
     kva = 117,
     Kw = 101,
     A = 137,
     B = 156,
     C = 134,
     pf = 0.86,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/29/2015"),
     Day = "Su",
     kva = 117,
     Kw = 98,
     A = 136,
     B = 154,
     C = 132,
     pf = 0.84,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("11/30/2015"),
     Day = "Mo",
     kva = 118,
     Kw = 101,
     A = 137,
     B = 158,
     C = 134,
     pf = 0.86,
     ups = 61.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/1/2015"),
     Day = "Tu",
     kva = 117,
     Kw = 101,
     A = 136,
     B = 154,
     C = 132,
     pf = 0.86,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/2/2015"),
     Day = "W",
     kva = 116,
     Kw = 99,
     A = 134,
     B = 153,
     C = 132,
     pf = 0.85,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/3/2015"),
     Day = "Th",
     kva = 117,
     Kw = 100,
     A = 135,
     B = 152,
     C = 132,
     pf = 0.85,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/4/2015"),
     Day = "F",
     kva = 116,
     Kw = 99,
     A = 133,
     B = 154,
     C = 130,
     pf = 0.85,
     ups = 63.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/5/2015"),
     Day = "Sa",
     kva = 117,
     Kw = 101,
     A = 135,
     B = 152,
     C = 132,
     pf = 0.86,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/6/2015"),
     Day = "Su",
     kva = 115,
     Kw = 99,
     A = 133,
     B = 149,
     C = 131,
     pf = 0.86,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/7/2015"),
     Day = "Mo",
     kva = 116,
     Kw = 99,
     A = 135,
     B = 152,
     C = 133,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/8/2015"),
     Day = "Tu",
     kva = 116,
     Kw = 99,
     A = 136,
     B = 153,
     C = 132,
     pf = 0.85,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/9/2015"),
     Day = "W",
     kva = 116,
     Kw = 98,
     A = 136,
     B = 152,
     C = 132,
     pf = 0.84,
     ups = 64.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/10/2015"),
     Day = "Th",
     kva = 115,
     Kw = 99,
     A = 135,
     B = 152,
     C = 130,
     pf = 0.86,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/11/2015"),
     Day = "F",
     kva = 116,
     Kw = 99,
     A = 136,
     B = 151,
     C = 131,
     pf = 0.85,
     ups = 63.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/12/2015"),
     Day = "Sa",
     kva = 117,
     Kw = 100,
     A = 134,
     B = 153,
     C = 131,
     pf = 0.85,
     ups = 61.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/13/2015"),
     Day = "Su",
     kva = 115,
     Kw = 98,
     A = 135,
     B = 152,
     C = 128,
     pf = 0.85,
     ups = 65.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/14/2015"),
     Day = "Mo",
     kva = 116,
     Kw = 100,
     A = 134,
     B = 151,
     C = 131,
     pf = 0.86,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/15/2015"),
     Day = "Tu",
     kva = 116,
     Kw = 100,
     A = 136,
     B = 152,
     C = 132,
     pf = 0.86,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/16/2015"),
     Day = "W",
     kva = 116,
     Kw = 98,
     A = 133,
     B = 153,
     C = 131,
     pf = 0.84,
     ups = 61.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/17/2015"),
     Day = "Th",
     kva = 116,
     Kw = 99,
     A = 134,
     B = 153,
     C = 132,
     pf = 0.85,
     ups = 65.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/18/2015"),
     Day = "F",
     kva = 116,
     Kw = 100,
     A = 135,
     B = 152,
     C = 131,
     pf = 0.86,
     ups = 66
 },
 
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/20/2015"),
     Day = "Su",
     kva = 115,
     Kw = 98,
     A = 135,
     B = 152,
     C = 128,
     pf = 0.85,
     ups = 59.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/21/2015"),
     Day = "Mo",
     kva = 116,
     Kw = 98,
     A = 135,
     B = 152,
     C = 128,
     pf = 0.84,
     ups = 61.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/22/2015"),
     Day = "Tu",
     kva = 116,
     Kw = 99,
     A = 135,
     B = 151,
     C = 128,
     pf = 0.85,
     ups = 61.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/23/2015"),
     Day = "W",
     kva = 117,
     Kw = 99,
     A = 133,
     B = 154,
     C = 127,
     pf = 0.85,
     ups = 61.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/24/2015"),
     Day = "Th",
     kva = 116,
     Kw = 98,
     A = 135,
     B = 152,
     C = 128,
     pf = 0.84,
     ups = 68.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/25/2015"),
     Day = "F",
     kva = 116,
     Kw = 99,
     A = 134,
     B = 152,
     C = 130,
     pf = 0.85,
     ups = 68.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/26/2015"),
     Day = "Sa",
     kva = 116,
     Kw = 99,
     A = 136,
     B = 155,
     C = 129,
     pf = 0.85,
     ups = 66
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/27/2015"),
     Day = "Su",
     kva = 116,
     Kw = 96,
     A = 133,
     B = 152,
     C = 129,
     pf = 0.83,
     ups = 66.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/28/2015"),
     Day = "Mo",
     kva = 116,
     Kw = 99,
     A = 134,
     B = 150,
     C = 128,
     pf = 0.85,
     ups = 67.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/29/2015"),
     Day = "Tu",
     kva = 116,
     Kw = 99,
     A = 135,
     B = 153,
     C = 130,
     pf = 0.85,
     ups = 61.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/30/2015"),
     Day = "W",
     kva = 117,
     Kw = 98,
     A = 136,
     B = 151,
     C = 131,
     pf = 0.84,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("12/31/2015"),
     Day = "Th",
     kva = 116,
     Kw = 100,
     A = 132,
     B = 152,
     C = 131,
     pf = 0.86,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/1/2016"),
     Day = "F",
     kva = 117,
     Kw = 99,
     A = 135,
     B = 153,
     C = 129,
     pf = 0.85,
     ups = 61.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/2/2016"),
     Day = "Sa",
     kva = 117,
     Kw = 99,
     A = 136,
     B = 153,
     C = 132,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/3/2016"),
     Day = "Su",
     kva = 116,
     Kw = 99,
     A = 136,
     B = 153,
     C = 130,
     pf = 0.85,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/4/2016"),
     Day = "Mo",
     kva = 116,
     Kw = 98,
     A = 135,
     B = 150,
     C = 128,
     pf = 0.84,
     ups = 66.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/5/2016"),
     Day = "Tu",
     kva = 118,
     Kw = 99,
     A = 136,
     B = 155,
     C = 129,
     pf = 0.84,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/6/2016"),
     Day = "W",
     kva = 118,
     Kw = 99,
     A = 136,
     B = 155,
     C = 129,
     pf = 0.84,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/7/2016"),
     Day = "Th",
     kva = 117,
     Kw = 99,
     A = 137,
     B = 152,
     C = 132,
     pf = 0.85,
     ups = 65.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/8/2016"),
     Day = "F",
     kva = 118,
     Kw = 101,
     A = 134,
     B = 153,
     C = 132,
     pf = 0.86,
     ups = 66.9
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/9/2016"),
     Day = "Sa",
     kva = 117,
     Kw = 99,
     A = 137,
     B = 152,
     C = 130,
     pf = 0.85,
     ups = 70.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/10/2016"),
     Day = "Su",
     kva = 117,
     Kw = 99,
     A = 133,
     B = 152,
     C = 131,
     pf = 0.85,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/11/2016"),
     Day = "Mo",
     kva = 117,
     Kw = 99,
     A = 134,
     B = 154,
     C = 131,
     pf = 0.85,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/12/2016"),
     Day = "Tu",
     kva = 116,
     Kw = 99,
     A = 134,
     B = 152,
     C = 132,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/13/2016"),
     Day = "W",
     kva = 117,
     Kw = 99,
     A = 134,
     B = 155,
     C = 130,
     pf = 0.85,
     ups = 65.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/14/2016"),
     Day = "Th",
     kva = 117,
     Kw = 99,
     A = 133,
     B = 152,
     C = 130,
     pf = 0.85,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/15/2016"),
     Day = "F",
     kva = 117,
     Kw = 100,
     A = 136,
     B = 154,
     C = 132,
     pf = 0.85,
     ups = 66.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/16/2016"),
     Day = "Sa",
     kva = 118,
     Kw = 101,
     A = 136,
     B = 156,
     C = 132,
     pf = 0.86,
     ups = 61.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/17/2016"),
     Day = "Su",
     kva = 117,
     Kw = 100,
     A = 135,
     B = 153,
     C = 132,
     pf = 0.85,
     ups = 60.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/18/2016"),
     Day = "Mo",
     kva = 116,
     Kw = 100,
     A = 133,
     B = 152,
     C = 131,
     pf = 0.86,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/19/2016"),
     Day = "Tu",
     kva = 117,
     Kw = 100,
     A = 133,
     B = 152,
     C = 133,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/20/2016"),
     Day = "W",
     kva = 116,
     Kw = 98,
     A = 135,
     B = 152,
     C = 131,
     pf = 0.84,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/21/2016"),
     Day = "Th",
     kva = 116,
     Kw = 99,
     A = 135,
     B = 154,
     C = 132,
     pf = 0.85,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/22/2016"),
     Day = "F",
     kva = 116,
     Kw = 98,
     A = 136,
     B = 152,
     C = 133,
     pf = 0.84,
     ups = 57.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/23/2016"),
     Day = "Sa",
     kva = 117,
     Kw = 99,
     A = 132,
     B = 153,
     C = 132,
     pf = 0.85,
     ups = 58.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/24/2016"),
     Day = "Su",
     kva = 116,
     Kw = 99,
     A = 135,
     B = 150,
     C = 129,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/25/2016"),
     Day = "Mo",
     kva = 117,
     Kw = 99,
     A = 136,
     B = 154,
     C = 132,
     pf = 0.85,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/26/2016"),
     Day = "Tu",
     kva = 118,
     Kw = 100,
     A = 136,
     B = 154,
     C = 132,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/27/2016"),
     Day = "W",
     kva = 116,
     Kw = 99,
     A = 134,
     B = 152,
     C = 132,
     pf = 0.85,
     ups = 59.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/28/2016"),
     Day = "Th",
     kva = 117,
     Kw = 99,
     A = 135,
     B = 151,
     C = 129,
     pf = 0.85,
     ups = 58.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/29/2016"),
     Day = "F",
     kva = 116,
     Kw = 100,
     A = 134,
     B = 154,
     C = 131,
     pf = 0.86,
     ups = 59.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/30/2016"),
     Day = "Sa",
     kva = 117,
     Kw = 99,
     A = 134,
     B = 152,
     C = 132,
     pf = 0.85,
     ups = 57.9
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("1/31/2016"),
     Day = "Su",
     kva = 116,
     Kw = 100,
     A = 133,
     B = 154,
     C = 129,
     pf = 0.86,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/1/2016"),
     Day = "Mo",
     kva = 117,
     Kw = 99,
     A = 134,
     B = 155,
     C = 132,
     pf = 0.85,
     ups = 60.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/2/2016"),
     Day = "Tu",
     kva = 116,
     Kw = 99,
     A = 136,
     B = 152,
     C = 131,
     pf = 0.85,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/3/2016"),
     Day = "W",
     kva = 117,
     Kw = 100,
     A = 136,
     B = 154,
     C = 132,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/4/2016"),
     Day = "Th",
     kva = 117,
     Kw = 100,
     A = 134,
     B = 154,
     C = 132,
     pf = 0.85,
     ups = 65.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/5/2016"),
     Day = "F",
     kva = 117,
     Kw = 100,
     A = 133,
     B = 154,
     C = 133,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/6/2016"),
     Day = "Sa",
     kva = 117,
     Kw = 100,
     A = 134,
     B = 152,
     C = 130,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/7/2016"),
     Day = "Su",
     kva = 117,
     Kw = 98,
     A = 132,
     B = 152,
     C = 129,
     pf = 0.84,
     ups = 58.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/8/2016"),
     Day = "Mo",
     kva = 117,
     Kw = 99,
     A = 136,
     B = 153,
     C = 132,
     pf = 0.85,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/9/2016"),
     Day = "Tu",
     kva = 117,
     Kw = 99,
     A = 136,
     B = 152,
     C = 132,
     pf = 0.85,
     ups = 58.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/10/2016"),
     Day = "W",
     kva = 117,
     Kw = 99,
     A = 134,
     B = 151,
     C = 129,
     pf = 0.85,
     ups = 63.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/11/2016"),
     Day = "Th",
     kva = 117,
     Kw = 100,
     A = 136,
     B = 152,
     C = 132,
     pf = 0.85,
     ups = 59.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/12/2016"),
     Day = "F",
     kva = 116,
     Kw = 99,
     A = 133,
     B = 152,
     C = 130,
     pf = 0.85,
     ups = 60
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/13/2016"),
     Day = "Sa",
     kva = 116,
     Kw = 98,
     A = 134,
     B = 150,
     C = 132,
     pf = 0.84,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/14/2016"),
     Day = "Su",
     kva = 115,
     Kw = 98,
     A = 133,
     B = 150,
     C = 128,
     pf = 0.85,
     ups = 61.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/15/2016"),
     Day = "Mo",
     kva = 114,
     Kw = 97,
     A = 133,
     B = 150,
     C = 127,
     pf = 0.85,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/16/2016"),
     Day = "Tu",
     kva = 114,
     Kw = 97,
     A = 133,
     B = 148,
     C = 128,
     pf = 0.85,
     ups = 65.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/17/2016"),
     Day = "W",
     kva = 114,
     Kw = 97,
     A = 133,
     B = 150,
     C = 129,
     pf = 0.85,
     ups = 59.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/18/2016"),
     Day = "Th",
     kva = 114,
     Kw = 96,
     A = 132,
     B = 147,
     C = 128,
     pf = 0.84,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/19/2016"),
     Day = "F",
     kva = 114,
     Kw = 96,
     A = 132,
     B = 149,
     C = 129,
     pf = 0.84,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/20/2016"),
     Day = "Sa",
     kva = 114,
     Kw = 97,
     A = 132,
     B = 150,
     C = 127,
     pf = 0.85,
     ups = 61.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/21/2016"),
     Day = "Su",
     kva = 112,
     Kw = 95,
     A = 131,
     B = 148,
     C = 126,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/22/2016"),
     Day = "Mo",
     kva = 114,
     Kw = 98,
     A = 132,
     B = 149,
     C = 127,
     pf = 0.86,
     ups = 61.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/23/2016"),
     Day = "Tu",
     kva = 113,
     Kw = 95,
     A = 130,
     B = 147,
     C = 128,
     pf = 0.84,
     ups = 59.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/24/2016"),
     Day = "W",
     kva = 113,
     Kw = 96,
     A = 131,
     B = 147,
     C = 127,
     pf = 0.85,
     ups = 58.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/25/2016"),
     Day = "Th",
     kva = 113,
     Kw = 96,
     A = 132,
     B = 147,
     C = 129,
     pf = 0.85,
     ups = 58.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/26/2016"),
     Day = "F",
     kva = 113,
     Kw = 98,
     A = 133,
     B = 148,
     C = 128,
     pf = 0.87,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/27/2016"),
     Day = "Sa",
     kva = 113,
     Kw = 96,
     A = 131,
     B = 146,
     C = 128,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/28/2016"),
     Day = "Su",
     kva = 113,
     Kw = 95,
     A = 129,
     B = 146,
     C = 128,
     pf = 0.84,
     ups = 59.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("2/29/2016"),
     Day = "Mo",
     kva = 113,
     Kw = 97,
     A = 131,
     B = 146,
     C = 129,
     pf = 0.86,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/1/2016"),
     Day = "Tu",
     kva = 110,
     Kw = 95,
     A = 128,
     B = 143,
     C = 125,
     pf = 0.86,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/2/2016"),
     Day = "W",
     kva = 112,
     Kw = 93,
     A = 128,
     B = 144,
     C = 124,
     pf = 0.83,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/3/2016"),
     Day = "Th",
     kva = 110,
     Kw = 94,
     A = 128,
     B = 143,
     C = 125,
     pf = 0.85,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/4/2016"),
     Day = "F",
     kva = 113,
     Kw = 98,
     A = 132,
     B = 147,
     C = 128,
     pf = 0.87,
     ups = 58.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/5/2016"),
     Day = "Sa",
     kva = 113,
     Kw = 97,
     A = 130,
     B = 148,
     C = 128,
     pf = 0.86,
     ups = 66
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/6/2016"),
     Day = "Su",
     kva = 112,
     Kw = 95,
     A = 129,
     B = 146,
     C = 126,
     pf = 0.85,
     ups = 59.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/7/2016"),
     Day = "Mo",
     kva = 113,
     Kw = 97,
     A = 131,
     B = 145,
     C = 125,
     pf = 0.86,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/8/2016"),
     Day = "Tu",
     kva = 113,
     Kw = 95,
     A = 132,
     B = 148,
     C = 126,
     pf = 0.84,
     ups = 58.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/9/2016"),
     Day = "W",
     kva = 112,
     Kw = 95,
     A = 130,
     B = 146,
     C = 125,
     pf = 0.85,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/10/2016"),
     Day = "Th",
     kva = 112,
     Kw = 95,
     A = 129,
     B = 148,
     C = 124,
     pf = 0.85,
     ups = 59.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/11/2016"),
     Day = "F",
     kva = 112,
     Kw = 96,
     A = 129,
     B = 146,
     C = 125,
     pf = 0.86,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/12/2016"),
     Day = "Sa",
     kva = 113,
     Kw = 96,
     A = 132,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 59.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/13/2016"),
     Day = "Su",
     kva = 111,
     Kw = 96,
     A = 128,
     B = 145,
     C = 125,
     pf = 0.86,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/14/2016"),
     Day = "Mo",
     kva = 112,
     Kw = 96,
     A = 128,
     B = 146,
     C = 128,
     pf = 0.86,
     ups = 59.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/15/2016"),
     Day = "Tu",
     kva = 110,
     Kw = 94,
     A = 127,
     B = 140,
     C = 123,
     pf = 0.85,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/16/2016"),
     Day = "W",
     kva = 109,
     Kw = 93,
     A = 128,
     B = 140,
     C = 124,
     pf = 0.85,
     ups = 60.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/17/2016"),
     Day = "Th",
     kva = 110,
     Kw = 94,
     A = 128,
     B = 142,
     C = 124,
     pf = 0.85,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/18/2016"),
     Day = "F",
     kva = 112,
     Kw = 95,
     A = 130,
     B = 144,
     C = 124,
     pf = 0.85,
     ups = 59.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/19/2016"),
     Day = "Sa",
     kva = 111,
     Kw = 95,
     A = 128,
     B = 144,
     C = 124,
     pf = 0.86,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/20/2016"),
     Day = "Su",
     kva = 110,
     Kw = 94,
     A = 128,
     B = 141,
     C = 125,
     pf = 0.85,
     ups = 59.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/21/2016"),
     Day = "Mo",
     kva = 111,
     Kw = 94,
     A = 130,
     B = 145,
     C = 125,
     pf = 0.85,
     ups = 64.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/22/2016"),
     Day = "Tu",
     kva = 110,
     Kw = 92,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.84,
     ups = 59.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/23/2016"),
     Day = "W",
     kva = 110,
     Kw = 95,
     A = 130,
     B = 146,
     C = 125,
     pf = 0.86,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/24/2016"),
     Day = "Th",
     kva = 111,
     Kw = 95,
     A = 128,
     B = 143,
     C = 124,
     pf = 0.86,
     ups = 60.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/25/2016"),
     Day = "F",
     kva = 110,
     Kw = 93,
     A = 131,
     B = 142,
     C = 125,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/26/2016"),
     Day = "Sa",
     kva = 110,
     Kw = 93,
     A = 128,
     B = 142,
     C = 124,
     pf = 0.85,
     ups = 59.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/27/2016"),
     Day = "Su",
     kva = 110,
     Kw = 93,
     A = 128,
     B = 143,
     C = 125,
     pf = 0.85,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/28/2016"),
     Day = "Mo",
     kva = 110,
     Kw = 93,
     A = 127,
     B = 143,
     C = 126,
     pf = 0.85,
     ups = 59.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/29/2016"),
     Day = "Tu",
     kva = 111,
     Kw = 93,
     A = 128,
     B = 143,
     C = 127,
     pf = 0.84,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/30/2016"),
     Day = "W",
     kva = 110,
     Kw = 93,
     A = 128,
     B = 144,
     C = 126,
     pf = 0.85,
     ups = 59.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("3/31/2016"),
     Day = "Th",
     kva = 110,
     Kw = 93,
     A = 129,
     B = 147,
     C = 126,
     pf = 0.85,
     ups = 62.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/1/2016"),
     Day = "F",
     kva = 112,
     Kw = 96,
     A = 129,
     B = 142,
     C = 126,
     pf = 0.86,
     ups = 64.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/2/2016"),
     Day = "Sa",
     kva = 113,
     Kw = 97,
     A = 131,
     B = 144,
     C = 126,
     pf = 0.86,
     ups = 60.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/3/2016"),
     Day = "Su",
     kva = 110,
     Kw = 93,
     A = 129,
     B = 144,
     C = 124,
     pf = 0.85,
     ups = 60.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/4/2016"),
     Day = "Mo",
     kva = 111,
     Kw = 94,
     A = 129,
     B = 148,
     C = 127,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/5/2016"),
     Day = "Tu",
     kva = 111,
     Kw = 95,
     A = 131,
     B = 146,
     C = 125,
     pf = 0.86,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/6/2016"),
     Day = "W",
     kva = 110,
     Kw = 94,
     A = 128,
     B = 144,
     C = 124,
     pf = 0.85,
     ups = 61.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/7/2016"),
     Day = "Th",
     kva = 111,
     Kw = 95,
     A = 130,
     B = 144,
     C = 126,
     pf = 0.86,
     ups = 60.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/8/2016"),
     Day = "F",
     kva = 110,
     Kw = 93,
     A = 128,
     B = 142,
     C = 124,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/9/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 96,
     A = 131,
     B = 145,
     C = 125,
     pf = 0.86,
     ups = 57.9
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/10/2016"),
     Day = "Su",
     kva = 112,
     Kw = 95,
     A = 131,
     B = 143,
     C = 123,
     pf = 0.85,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/11/2016"),
     Day = "Mo",
     kva = 112,
     Kw = 95,
     A = 130,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 59.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/12/2016"),
     Day = "Tu",
     kva = 112,
     Kw = 97,
     A = 132,
     B = 144,
     C = 126,
     pf = 0.87,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/13/2016"),
     Day = "W",
     kva = 112,
     Kw = 95,
     A = 129,
     B = 145,
     C = 128,
     pf = 0.85,
     ups = 60.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/14/2016"),
     Day = "Th",
     kva = 112,
     Kw = 95,
     A = 130,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/15/2016"),
     Day = "F",
     kva = 112,
     Kw = 96,
     A = 132,
     B = 144,
     C = 125,
     pf = 0.86,
     ups = 60.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/16/2016"),
     Day = "Sa",
     kva = 110,
     Kw = 94,
     A = 129,
     B = 144,
     C = 124,
     pf = 0.85,
     ups = 59.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/17/2016"),
     Day = "Su",
     kva = 110,
     Kw = 92,
     A = 128,
     B = 140,
     C = 122,
     pf = 0.84,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/18/2016"),
     Day = "Mo",
     kva = 110,
     Kw = 93,
     A = 127,
     B = 144,
     C = 123,
     pf = 0.85,
     ups = 59.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/19/2016"),
     Day = "Tu",
     kva = 110,
     Kw = 93,
     A = 127,
     B = 144,
     C = 123,
     pf = 0.85,
     ups = 59.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/20/2016"),
     Day = "W",
     kva = 110,
     Kw = 93,
     A = 128,
     B = 144,
     C = 122,
     pf = 0.85,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/21/2016"),
     Day = "Th",
     kva = 110,
     Kw = 94,
     A = 128,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 60.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/22/2016"),
     Day = "F",
     kva = 110,
     Kw = 94,
     A = 129,
     B = 144,
     C = 126,
     pf = 0.85,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/23/2016"),
     Day = "Sa",
     kva = 110,
     Kw = 93,
     A = 128,
     B = 143,
     C = 126,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/24/2016"),
     Day = "Su",
     kva = 110,
     Kw = 93,
     A = 128,
     B = 141,
     C = 125,
     pf = 0.85,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/25/2016"),
     Day = "Mo",
     kva = 110,
     Kw = 93,
     A = 128,
     B = 142,
     C = 124,
     pf = 0.85,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/26/2016"),
     Day = "Tu",
     kva = 110,
     Kw = 93,
     A = 125,
     B = 143,
     C = 125,
     pf = 0.85,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/27/2016"),
     Day = "W",
     kva = 110,
     Kw = 94,
     A = 128,
     B = 142,
     C = 126,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/28/2016"),
     Day = "Th",
     kva = 110,
     Kw = 92,
     A = 129,
     B = 144,
     C = 124,
     pf = 0.84,
     ups = 60.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/29/2016"),
     Day = "F",
     kva = 111,
     Kw = 93,
     A = 128,
     B = 144,
     C = 124,
     pf = 0.84,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("4/30/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 93,
     A = 128,
     B = 146,
     C = 124,
     pf = 0.83,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/1/2016"),
     Day = "Su",
     kva = 110,
     Kw = 92,
     A = 129,
     B = 144,
     C = 124,
     pf = 0.84,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/2/2016"),
     Day = "Mo",
     kva = 111,
     Kw = 94,
     A = 128,
     B = 146,
     C = 124,
     pf = 0.85,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/3/2016"),
     Day = "Tu",
     kva = 110,
     Kw = 93,
     A = 129,
     B = 145,
     C = 125,
     pf = 0.85,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/4/2016"),
     Day = "W",
     kva = 110,
     Kw = 94,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/5/2016"),
     Day = "Th",
     kva = 112,
     Kw = 94,
     A = 129,
     B = 144,
     C = 124,
     pf = 0.84,
     ups = 59.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/6/2016"),
     Day = "F",
     kva = 110,
     Kw = 94,
     A = 128,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 61.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/7/2016"),
     Day = "Sa",
     kva = 111,
     Kw = 95,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.86,
     ups = 60.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/8/2016"),
     Day = "Su",
     kva = 111,
     Kw = 95,
     A = 128,
     B = 145,
     C = 126,
     pf = 0.86,
     ups = 63
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/9/2016"),
     Day = "Mo",
     kva = 110,
     Kw = 94,
     A = 128,
     B = 145,
     C = 125,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/10/2016"),
     Day = "Tu",
     kva = 111,
     Kw = 93,
     A = 129,
     B = 144,
     C = 126,
     pf = 0.84,
     ups = 62.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/11/2016"),
     Day = "W",
     kva = 111,
     Kw = 94,
     A = 130,
     B = 143,
     C = 124,
     pf = 0.85,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/12/2016"),
     Day = "Th",
     kva = 112,
     Kw = 94,
     A = 129,
     B = 144,
     C = 126,
     pf = 0.84,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/13/2016"),
     Day = "F",
     kva = 111,
     Kw = 94,
     A = 128,
     B = 145,
     C = 125,
     pf = 0.85,
     ups = 64.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/14/2016"),
     Day = "Sa",
     kva = 110,
     Kw = 96,
     A = 130,
     B = 143,
     C = 127,
     pf = 0.87,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/15/2016"),
     Day = "Su",
     kva = 111,
     Kw = 94,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/16/2016"),
     Day = "Mo",
     kva = 111,
     Kw = 94,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/17/2016"),
     Day = "Tu",
     kva = 110,
     Kw = 94,
     A = 129,
     B = 144,
     C = 126,
     pf = 0.85,
     ups = 63.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/18/2016"),
     Day = "W",
     kva = 111,
     Kw = 95,
     A = 128,
     B = 146,
     C = 125,
     pf = 0.86,
     ups = 68
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/19/2016"),
     Day = "Th",
     kva = 110,
     Kw = 94,
     A = 131,
     B = 145,
     C = 124,
     pf = 0.85,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/20/2016"),
     Day = "F",
     kva = 112,
     Kw = 95,
     A = 132,
     B = 145,
     C = 126,
     pf = 0.85,
     ups = 63.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/21/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 93,
     A = 130,
     B = 143,
     C = 125,
     pf = 0.83,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/22/2016"),
     Day = "Su",
     kva = 111,
     Kw = 93,
     A = 128,
     B = 144,
     C = 124,
     pf = 0.84,
     ups = 61.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/23/2016"),
     Day = "Mo",
     kva = 112,
     Kw = 95,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 60.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/24/2016"),
     Day = "Tu",
     kva = 111,
     Kw = 94,
     A = 132,
     B = 146,
     C = 124,
     pf = 0.85,
     ups = 62.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/25/2016"),
     Day = "W",
     kva = 111,
     Kw = 94,
     A = 130,
     B = 146,
     C = 127,
     pf = 0.85,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/26/2016"),
     Day = "Th",
     kva = 112,
     Kw = 95,
     A = 132,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/27/2016"),
     Day = "F",
     kva = 111,
     Kw = 95,
     A = 130,
     B = 144,
     C = 126,
     pf = 0.86,
     ups = 63
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/28/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 95,
     A = 128,
     B = 145,
     C = 126,
     pf = 0.85,
     ups = 63.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/29/2016"),
     Day = "Su",
     kva = 110,
     Kw = 93,
     A = 129,
     B = 144,
     C = 123,
     pf = 0.85,
     ups = 63
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/30/2016"),
     Day = "Mo",
     kva = 110,
     Kw = 93,
     A = 128,
     B = 142,
     C = 124,
     pf = 0.85,
     ups = 62.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("5/31/2016"),
     Day = "Tu",
     kva = 111,
     Kw = 94,
     A = 131,
     B = 144,
     C = 124,
     pf = 0.85,
     ups = 58.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/1/2016"),
     Day = "W",
     kva = 111,
     Kw = 95,
     A = 129,
     B = 143,
     C = 126,
     pf = 0.86,
     ups = 68.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/2/2016"),
     Day = "Th",
     kva = 112,
     Kw = 95,
     A = 129,
     B = 144,
     C = 126,
     pf = 0.85,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/3/2016"),
     Day = "F",
     kva = 112,
     Kw = 95,
     A = 131,
     B = 146,
     C = 125,
     pf = 0.85,
     ups = 67.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/4/2016"),
     Day = "Sa",
     kva = 111,
     Kw = 95,
     A = 131,
     B = 143,
     C = 126,
     pf = 0.86,
     ups = 68.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/5/2016"),
     Day = "Su",
     kva = 112,
     Kw = 95,
     A = 129,
     B = 144,
     C = 121,
     pf = 0.85,
     ups = 61.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/6/2016"),
     Day = "Mo",
     kva = 111,
     Kw = 94,
     A = 129,
     B = 147,
     C = 124,
     pf = 0.85,
     ups = 65.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/7/2016"),
     Day = "Tu",
     kva = 111,
     Kw = 94,
     A = 130,
     B = 145,
     C = 126,
     pf = 0.85,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/8/2016"),
     Day = "W",
     kva = 110,
     Kw = 95,
     A = 129,
     B = 143,
     C = 124,
     pf = 0.86,
     ups = 59.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/9/2016"),
     Day = "Th",
     kva = 110,
     Kw = 94,
     A = 129,
     B = 145,
     C = 124,
     pf = 0.85,
     ups = 60.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/10/2016"),
     Day = "F",
     kva = 110,
     Kw = 93,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 60.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/11/2016"),
     Day = "Sa",
     kva = 110,
     Kw = 95,
     A = 131,
     B = 144,
     C = 124,
     pf = 0.86,
     ups = 61.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/12/2016"),
     Day = "Su",
     kva = 111,
     Kw = 95,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.86,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/13/2016"),
     Day = "Mo",
     kva = 111,
     Kw = 94,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 61.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/14/2016"),
     Day = "Tu",
     kva = 112,
     Kw = 94,
     A = 128,
     B = 146,
     C = 127,
     pf = 0.84,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/15/2016"),
     Day = "W",
     kva = 111,
     Kw = 95,
     A = 130,
     B = 146,
     C = 126,
     pf = 0.86,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/16/2016"),
     Day = "Th",
     kva = 111,
     Kw = 96,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.86,
     ups = 65.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/17/2016"),
     Day = "F",
     kva = 112,
     Kw = 94,
     A = 129,
     B = 147,
     C = 126,
     pf = 0.84,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/18/2016"),
     Day = "Sa",
     kva = 113,
     Kw = 95,
     A = 130,
     B = 148,
     C = 128,
     pf = 0.84,
     ups = 58.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/19/2016"),
     Day = "Su",
     kva = 112,
     Kw = 94,
     A = 129,
     B = 145,
     C = 127,
     pf = 0.84,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/20/2016"),
     Day = "Mo",
     kva = 112,
     Kw = 95,
     A = 131,
     B = 147,
     C = 127,
     pf = 0.85,
     ups = 59
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/21/2016"),
     Day = "Tu",
     kva = 111,
     Kw = 95,
     A = 131,
     B = 144,
     C = 127,
     pf = 0.86,
     ups = 61.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/22/2016"),
     Day = "W",
     kva = 112,
     Kw = 94,
     A = 130,
     B = 146,
     C = 125,
     pf = 0.84,
     ups = 58.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/23/2016"),
     Day = "Th",
     kva = 110,
     Kw = 95,
     A = 128,
     B = 144,
     C = 124,
     pf = 0.86,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/24/2016"),
     Day = "F",
     kva = 112,
     Kw = 95,
     A = 132,
     B = 145,
     C = 125,
     pf = 0.85,
     ups = 59.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/25/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 95,
     A = 128,
     B = 144,
     C = 128,
     pf = 0.85,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/26/2016"),
     Day = "Su",
     kva = 110,
     Kw = 93,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.85,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/27/2016"),
     Day = "Mo",
     kva = 111,
     Kw = 95,
     A = 130,
     B = 144,
     C = 124,
     pf = 0.86,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/28/2016"),
     Day = "Tu",
     kva = 112,
     Kw = 94,
     A = 131,
     B = 145,
     C = 124,
     pf = 0.84,
     ups = 60.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/29/2016"),
     Day = "W",
     kva = 112,
     Kw = 96,
     A = 131,
     B = 147,
     C = 126,
     pf = 0.86,
     ups = 61.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("6/30/2016"),
     Day = "Th",
     kva = 111,
     Kw = 93,
     A = 129,
     B = 143,
     C = 124,
     pf = 0.84,
     ups = 60.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/1/2016"),
     Day = "F",
     kva = 112,
     Kw = 95,
     A = 130,
     B = 144,
     C = 127,
     pf = 0.85,
     ups = 66.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/2/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 95,
     A = 130,
     B = 145,
     C = 125,
     pf = 0.85,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/3/2016"),
     Day = "Su",
     kva = 110,
     Kw = 93,
     A = 130,
     B = 144,
     C = 124,
     pf = 0.85,
     ups = 64.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/4/2016"),
     Day = "Mo",
     kva = 110,
     Kw = 93,
     A = 129,
     B = 145,
     C = 125,
     pf = 0.85,
     ups = 65.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/5/2016"),
     Day = "Tu",
     kva = 111,
     Kw = 95,
     A = 129,
     B = 144,
     C = 124,
     pf = 0.86,
     ups = 64.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/6/2016"),
     Day = "W",
     kva = 111,
     Kw = 94,
     A = 129,
     B = 146,
     C = 125,
     pf = 0.85,
     ups = 65.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/7/2016"),
     Day = "Th",
     kva = 111,
     Kw = 94,
     A = 130,
     B = 146,
     C = 125,
     pf = 0.85,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/8/2016"),
     Day = "F",
     kva = 112,
     Kw = 96,
     A = 130,
     B = 144,
     C = 126,
     pf = 0.86,
     ups = 64.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/9/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 96,
     A = 131,
     B = 144,
     C = 126,
     pf = 0.86,
     ups = 64.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/10/2016"),
     Day = "Su",
     kva = 112,
     Kw = 94,
     A = 131,
     B = 143,
     C = 126,
     pf = 0.84,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/11/2016"),
     Day = "Mo",
     kva = 112,
     Kw = 94,
     A = 131,
     B = 145,
     C = 126,
     pf = 0.84,
     ups = 63.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/12/2016"),
     Day = "Tu",
     kva = 112,
     Kw = 94,
     A = 132,
     B = 147,
     C = 125,
     pf = 0.84,
     ups = 63.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/13/2016"),
     Day = "W",
     kva = 112,
     Kw = 95,
     A = 130,
     B = 145,
     C = 124,
     pf = 0.85,
     ups = 62.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/14/2016"),
     Day = "Th",
     kva = 112,
     Kw = 94,
     A = 130,
     B = 146,
     C = 125,
     pf = 0.84,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/15/2016"),
     Day = "F",
     kva = 112,
     Kw = 96,
     A = 131,
     B = 145,
     C = 125,
     pf = 0.86,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/16/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 95,
     A = 131,
     B = 144,
     C = 126,
     pf = 0.85,
     ups = 61
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/17/2016"),
     Day = "Su",
     kva = 111,
     Kw = 93,
     A = 129,
     B = 144,
     C = 125,
     pf = 0.84,
     ups = 63
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/18/2016"),
     Day = "Mo",
     kva = 112,
     Kw = 96,
     A = 132,
     B = 147,
     C = 127,
     pf = 0.86,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/19/2016"),
     Day = "Tu",
     kva = 112,
     Kw = 96,
     A = 132,
     B = 145,
     C = 128,
     pf = 0.86,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/20/2016"),
     Day = "W",
     kva = 112,
     Kw = 96,
     A = 131,
     B = 145,
     C = 125,
     pf = 0.86,
     ups = 62.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/21/2016"),
     Day = "Th",
     kva = 110,
     Kw = 95,
     A = 129,
     B = 145,
     C = 125,
     pf = 0.86,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/22/2016"),
     Day = "F",
     kva = 112,
     Kw = 95,
     A = 131,
     B = 145,
     C = 128,
     pf = 0.85,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/23/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 94,
     A = 130,
     B = 146,
     C = 126,
     pf = 0.84,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/24/2016"),
     Day = "Su",
     kva = 111,
     Kw = 95,
     A = 129,
     B = 144,
     C = 124,
     pf = 0.86,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/25/2016"),
     Day = "Mo",
     kva = 112,
     Kw = 96,
     A = 131,
     B = 145,
     C = 125,
     pf = 0.86,
     ups = 62.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/26/2016"),
     Day = "Tu",
     kva = 112,
     Kw = 96,
     A = 129,
     B = 144,
     C = 127,
     pf = 0.86,
     ups = 61.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/27/2016"),
     Day = "W",
     kva = 111,
     Kw = 96,
     A = 131,
     B = 142,
     C = 127,
     pf = 0.86,
     ups = 64.4
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/28/2016"),
     Day = "Th",
     kva = 111,
     Kw = 95,
     A = 128,
     B = 141,
     C = 126,
     pf = 0.86,
     ups = 61.3
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/29/2016"),
     Day = "F",
     kva = 112,
     Kw = 95,
     A = 131,
     B = 146,
     C = 127,
     pf = 0.85,
     ups = 62.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/30/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 96,
     A = 130,
     B = 144,
     C = 126,
     pf = 0.86,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("7/31/2016"),
     Day = "Su",
     kva = 111,
     Kw = 95,
     A = 129,
     B = 144,
     C = 124,
     pf = 0.86,
     ups = 63.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/1/2016"),
     Day = "Mo",
     kva = 112,
     Kw = 96,
     A = 131,
     B = 147,
     C = 126,
     pf = 0.86,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/2/2016"),
     Day = "Tu",
     kva = 112,
     Kw = 95,
     A = 131,
     B = 146,
     C = 126,
     pf = 0.85,
     ups = 64.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/3/2016"),
     Day = "W",
     kva = 110,
     Kw = 94,
     A = 129,
     B = 144,
     C = 124,
     pf = 0.85,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/4/2016"),
     Day = "Th",
     kva = 112,
     Kw = 95,
     A = 129,
     B = 144,
     C = 126,
     pf = 0.85,
     ups = 60.8
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/5/2016"),
     Day = "F",
     kva = 110,
     Kw = 94,
     A = 130,
     B = 143,
     C = 124,
     pf = 0.85,
     ups = 61.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/6/2016"),
     Day = "Sa",
     kva = 113,
     Kw = 96,
     A = 132,
     B = 144,
     C = 128,
     pf = 0.85,
     ups = 64.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/7/2016"),
     Day = "Su",
     kva = 112,
     Kw = 94,
     A = 130,
     B = 143,
     C = 126,
     pf = 0.84,
     ups = 61.5
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/8/2016"),
     Day = "Mo",
     kva = 112,
     Kw = 96,
     A = 129,
     B = 145,
     C = 126,
     pf = 0.86,
     ups = 62.6
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/9/2016"),
     Day = "Tu",
     kva = 112,
     Kw = 96,
     A = 130,
     B = 146,
     C = 128,
     pf = 0.86,
     ups = 61.7
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/10/2016"),
     Day = "W",
     kva = 112,
     Kw = 96,
     A = 131,
     B = 146,
     C = 125,
     pf = 0.86,
     ups = 64
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/11/2016"),
     Day = "Th",
     kva = 112,
     Kw = 96,
     A = 132,
     B = 146,
     C = 127,
     pf = 0.86,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/12/2016"),
     Day = "F",
     kva = 111,
     Kw = 94,
     A = 130,
     B = 143,
     C = 126,
     pf = 0.85,
     ups = 64.2
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/13/2016"),
     Day = "Sa",
     kva = 112,
     Kw = 96,
     A = 130,
     B = 146,
     C = 127,
     pf = 0.86,
     ups = 62.1
 },
 new PowerLogsViewModel

 {
     Date = DateTime.Parse("8/14/2016"),
     Day = "Su",
     kva = 112,
     Kw = 94,
     A = 130,
     B = 144,
     C = 127,
     pf = 0.84,
     ups = 63.1
 });
                context.SaveChanges();
            }
        }
    }
}
