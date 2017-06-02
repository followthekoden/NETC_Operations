using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NETCOperations.Data;

namespace NETCOperations.Models.OpsViewModels
{
    public class SeedDatasco
    {
        public static void Initializesco(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.scoViewModel.Any())
                {
                    return;
                }

                context.scoViewModel.AddRange(

 new scoViewModel
 {
     HostName = "BAN002000D0001",
     Location = "Bangor",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "BAN002000D0001S",
     Location = "Bangor",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "BAN002000D0002",
     Location = "Bangor",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "BAN002000D0002N",
     Location = "Bangor",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "David Scobey",
     APocSecondary = "David Scobey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "BAN002000D0002S",
     Location = "Bangor",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "BAN002000R0001",
     Location = "Bangor",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "BAN002000R0001N",
     Location = "Bangor",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "BAN00200D0001N",
     Location = "Bangor",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "David Scobey",
     APocSecondary = "Roy Whitaker",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "BANALTIRIS0002",
     Location = "Bangor",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "BANSSIM0019",
     Location = "Bangor",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "BANSSIM019",
     Location = "Bangor",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "C27AD9WSFLY001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Douglas Spivey",
     APocSecondary = "Marc Stone",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27cx5wsfly001",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil   ",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27cx5wsfly002",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "Charlie Odom   ",
     APocSecondary = "    ",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27cx5wsfly003",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27cx5wsfly004",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27cx5wsfly005",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "c27cx9wsfly001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = "",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "c27cx9wsfly002",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = "",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "c27cx9wsfly003",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = "",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "C27or4ssfly001",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Bill Wood",
     APocSecondary = "Brian Beasley",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27re9wsfly001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "James Pruett",
     APocSecondary = "John Edwards",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "C27re9wsfly002",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "James Pruett",
     APocSecondary = "John Edwards",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "C27sq9wsfly002",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Christipher Stark",
     APocSecondary = "Ken Garrett",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vgrlk001",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vgrlk002",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vgrlk003",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vgrlk004",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vgrlk005",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vsfly001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vsfly002",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vsfly003",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vsfly004",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vsfly005",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Terry J. Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27vm9vsfly006",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27wb4ssfly001",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Bill Wood",
     APocSecondary = "Brian Beasley",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "C27wb5wsfly001",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "Robert Rayburn",
     APocSecondary = "Michael Rowe",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CAP002220D0001",
     Location = "Camp Pendleton",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CAP002220D0002",
     Location = "Camp Pendleton",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CAP002369D0001",
     Location = "Camp Pendleton",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "CAP002369D0002",
     Location = "Camp Pendleton",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "CAP002369M0002",
     Location = "Camp Pendleton",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "CAP023195R0001",
     Location = "Camp Pendleton",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "CHL002681D0001",
     Location = "China Lake",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "CHL002681D0002",
     Location = "China Lake",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHL002681R0001",
     Location = "China Lake",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "CHP000244D0001",
     Location = "Cherry Point",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244D0002",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244FV001",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244MV003",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244MV004",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244MV005",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244MV006",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244MV007",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244MV008",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244MV009",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244MV010",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244MV011",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244MV012",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244QV002",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244R0001",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "CHP000244V0004",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244V0005",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244V0006",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "CHP000244V0007",
     Location = "Cherry Point",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "COC000010D0001",
     Location = "Corpus Christi",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "COC000010D0002",
     Location = "Corpus Christi",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "COS000512D0002S",
     Location = "Corry Station",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "COS001099D0001",
     Location = "Corry Station",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "COS001099D0002",
     Location = "Corry Station",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "COS001099R0001",
     Location = "Corry Station",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "COS001099R0001S",
     Location = "Corry Station",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "COS003744D0001S",
     Location = "Corry Station",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "COS003744D0002S",
     Location = "Corry Station",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "COS003782D0001",
     Location = "Corry Station",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "COS003782D0002",
     Location = "Corry Station",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "COSALTIRIS0001",
     Location = "Corry Station",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DAH001520D0001",
     Location = "Dahlgren",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "DAH001520D0002",
     Location = "Dahlgren",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "DAH001520D0002S",
     Location = "Dahlgren",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "DAH001520R0001",
     Location = "Dahlgren",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DAH001520R0001S",
     Location = "Dahlgren",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DAH01520D0001S",
     Location = "Dahlgren",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "DAH01520D0002S",
     Location = "Dahlgren",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DAHALTIRIS0001",
     Location = "Dahlgren",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DAN000127D0001",
     Location = "Dam Neck",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "DAN000127D0001S",
     Location = "Dam Neck",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "Jason Blackburn (Deleted)",
     APocPrimary = "Jason Blackburn (Deleted)",
     APocSecondary = "David Davis",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "DAN000127D0002",
     Location = "Dam Neck",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "DAN000127D0002S",
     Location = "Dam Neck",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DAN000127M0005",
     Location = "Dam Neck",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DAN000127M0005S",
     Location = "Dam Neck",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DAN000420D0001",
     Location = "Dam Neck",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "DAN000420D0002",
     Location = "Dam Neck",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "DAN000420R0001",
     Location = "Dam Neck",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DAN000420R0001S",
     Location = "Dam Neck",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DAN00127D0002S",
     Location = "Dam Neck",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "DANALTIRIS0001",
     Location = "Dam Neck",
     OSPocPrimary = "Stephanie Noski",
     OSPocSecondary = "Tony Borelli",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "EGL000845R0001",
     Location = "Eglin",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "EGL008843D0001",
     Location = "Eglin",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "EGL008849D0002",
     Location = "Eglin",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "EGL00884D0001",
     Location = "Eglin",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "EVE002120D0001",
     Location = "Everett",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "EVE002120D0001S",
     Location = "Everett",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "EVE002120R0001S",
     Location = "Everett",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Jeff Dawson",
     APocSecondary = "Chris Riggs",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "EVE002200D0001",
     Location = "Everett",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL000001R0001",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL00002BD0001",
     Location = "Great Lakes",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRL00002BR0002",
     Location = "Great Lakes",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Clark Taft",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL000236D0001",
     Location = "Great Lakes",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl000236d0002",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL000616D0001",
     Location = "Great Lakes",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl000616d0002",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400b0001",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400D0001",
     Location = "Great Lakes",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRL003400D0002",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400d0010",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400d0011",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400d0101",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400D1001",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400d1002",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400d1003",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRL003400D1004",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m0002",
     Location = "Great Lakes",
     OSPocPrimary = "GL Ops Staff (847) 688-3456 x304",
     OSPocSecondary = "Ben Seelye (847) 688-4222 x133",
     APocPrimary = "GL Ops Staff (847) 688-3456 x304",
     APocSecondary = "Ben Seelye (847) 688-4222 x133",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m0006",
     Location = "Great Lakes",
     OSPocPrimary = "GL Ops Staff (847) 688-3456 x304",
     OSPocSecondary = "Ben Seelye (847) 688-4222 x133",
     APocPrimary = "GL Ops Staff (847) 688-3456 x304",
     APocSecondary = "Ben Seelye (847) 688-4222 x133",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m0007",
     Location = "Great Lakes",
     OSPocPrimary = "GL Ops Staff (847) 688-3456 x304",
     OSPocSecondary = "Ben Seelye (847) 688-4222 x133",
     APocPrimary = "GL Ops Staff (847) 688-3456 x304",
     APocSecondary = "Ben Seelye (847) 688-4222 x133",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m0008",
     Location = "Great Lakes",
     OSPocPrimary = "GL Ops Staff (847) 688-3456 x304",
     OSPocSecondary = "Ben Seelye (847) 688-4222 x133",
     APocPrimary = "GL Ops Staff (847) 688-3456 x304",
     APocSecondary = "Ben Seelye (847) 688-4222 x133",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m0009",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m0011",
     Location = "Great Lakes",
     OSPocPrimary = "GL Ops Staff (847) 688-3456 x304",
     OSPocSecondary = "Ben Seelye (847) 688-4222 x133",
     APocPrimary = "GL Ops Staff (847) 688-3456 x304",
     APocSecondary = "Ben Seelye (847) 688-4222 x133",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m0030",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRL003400M1016",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = " Douglas Spivey",
     APocSecondary = " Eric Morgan",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m1029",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m1030",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m1031",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "grl003400m1091",
     Location = "Great Lakes",
     OSPocPrimary = " NETC_SYSTEMS@navy.mil",
     OSPocSecondary = " NETC_SYSTEMS@navy.mil",
     APocPrimary = " Don Payne",
     APocSecondary = " Don Payne",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1097",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m1204",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m1204",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m1207",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Mercer Sport (John)",
     dbaadmin = "N/A",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1209",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Shane Garrett / Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1210",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Don Payne",
     APocSecondary = "Nancy Lockwood",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400m1211",
     Location = "Great Lakes",
     OSPocPrimary = " NETC_SYSTEMS@navy.mil",
     OSPocSecondary = " NETC_SYSTEMS@navy.mil",
     APocPrimary = " Don Payne",
     APocSecondary = " Don Payne",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1401",
     Location = "Great Lakes",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1402",
     Location = "Great Lakes",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1443",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1444",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1445",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1446",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1447",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1448",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1449",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400m1450",
     Location = "Great Lakes",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grl003400m1457",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "David Davis",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1465",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Tibbs",
     APocSecondary = "Charlie Tibbs",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1466",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRL003400M1467",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "grl003400m1468",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "John Edwards",
     APocSecondary = "Clark Taft",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1471",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1472",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1473",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1474",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1475",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1476",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1477",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1478",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1479",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Edwards",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1480",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Reynolds ",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1481",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Reynolds",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1482",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Loi Nguyen",
     APocSecondary = "Larry Reynolds ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1483",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1484",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1485",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRL003400M1486",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Loi Nguyen",
     APocSecondary = "Mark Brockway",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRL003400M1487",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Loi Nguyen",
     APocSecondary = "Mark Brockway",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRL003400M1491",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Mercer Sport",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRL003400M1492",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Mercer Sport",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRL003400MV100",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400v1001",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400v1002",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400v1004",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400v1005",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grl003400v1008",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Kenneth Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400v1009",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Kenneth Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400v1010",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Kenneth Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grl003400v1011",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Kenneth Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRL007105D0001",
     Location = "Great Lakes",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlaltiris0003",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlhbss1013",
     Location = "Great Lakes",
     OSPocPrimary = "Jeff Dawson",
     OSPocSecondary = "Jason Sims",
     APocPrimary = "Jeff Dawson",
     APocSecondary = "Jason Sims",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlhbss1015",
     Location = "Great Lakes",
     OSPocPrimary = "Jeff Dawson",
     OSPocSecondary = "Jason Sims",
     APocPrimary = "Jeff Dawson",
     APocSecondary = "Jason Sims",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRLSSIM0012",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRLSSIM0013",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRLSSIM0014",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRLSSIM0015",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRLSSIM0016",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRLSSIM0017",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlssim012",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "Ray Delemos",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlssim013",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "Ray Delemos",
     APocSecondary = "Micah Butler",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlssim014",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "Ray Delemos",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlssim015",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "Ray Delemos",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlssim016",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "Ray Delemos",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlssim017",
     Location = "Great Lakes",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "Ray Delemos",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "grlu000000",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Connie Thomsen",
     APocSecondary = "Emma Griffin",
     dbaadmin = "Terry Lewis / Randy Faircloth",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu000001",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Connie Thomsen ",
     APocSecondary = "DeMina Green",
     dbaadmin = "Terry Lewis/Randy Faircloth",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010154",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlu010155",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlu010156",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlu010157",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlu010158",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlu010159",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlu010160",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010161",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010162",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010163",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010164",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010165",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010166/grlu010167",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010168/grlu010169",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010170/grlu010171",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010172/grlu010173",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu010174/grlu010175",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu010176/grlu010177",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu013073/Grlu013074",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White ",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu013075/Grlu013076",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White ",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu013077",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu013078",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu013079",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu013080",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "(None)",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu013081",
     Location = "Great Lakes",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "(None)",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu13101",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Bill Johnson/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu13102",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Bill Johnson/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu13150",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlu13151",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu13152",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlu13153",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlu13154",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Grlu13155",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "grlu13156",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13157",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13158",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13159",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13160",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13161",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13162",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13163",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13164",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13165",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13166",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13167",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13168",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13169",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13170",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13171",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13172",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13173",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13174",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13175",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "grlu13176",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu5005",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "Stephen Lambert",
     APocPrimary = "NETPDTC_Unix@navy.mil",
     APocSecondary = "Stephen Lambert",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu5009",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "Kevin Coker",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu5117",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "Kevin Coker",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Grlu5119",
     Location = "Great Lakes",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "Lawana Slade",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRO000518D0001",
     Location = "Groton",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRO000518D0001S",
     Location = "Groton",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GRO000518D0002",
     Location = "Groton",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRO000518D0002N",
     Location = "Groton",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GRO000518D0002S",
     Location = "Groton",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GUL000343D0001",
     Location = "Gulfport",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000343D0002",
     Location = "Gulfport",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Gul000344fv001",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Cory Schick",
     APocSecondary = "Pete Fiero",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344MV003",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Pete Fierro",
     APocSecondary = "Kirk O'neill",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344MV004",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Cory Schick",
     APocSecondary = "Kirk O'neill",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Gul000344mv006",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Cory Schick",
     APocSecondary = "Kirk O'neill",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Gul000344mv007",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Kirk O'Neill ",
     APocSecondary = "Micah Pate",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344MV008",
     Location = "Gulfport",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Kirk O'neil",
     APocSecondary = "Cory Schick",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344MV009",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Kirk O'neil",
     APocSecondary = "Cory Schick",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344MV010",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Pete Fierro",
     APocSecondary = "Cory Schick",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344MV011",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344MV012",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Cory Schick",
     APocSecondary = "Cory Schick",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Gul000344QV002",
     Location = "Gulfport",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Micah Pate",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344R0001",
     Location = "Gulfport",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "GUL000344V0004",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Kirk O'neill",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344V0005",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Kirk O'neill",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344V0006",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Pete Fierro",
     APocSecondary = "Cory Schick",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "GUL000344V0007",
     Location = "Gulfport",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Cory Schick",
     APocSecondary = "Kirk O'neill",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC000848R0001",
     Location = "Jacksonville",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "JAC00848ED0001",
     Location = "Jacksonville",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848ED0002",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EFV001",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV003",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV004",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV005",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV006",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV007",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV008",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV009",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV010",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV011",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV012",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV013",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EMV014",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EQV002",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EV0004",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EV0005",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EV0006",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EV0007",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EV0008",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JAC00848EV0009",
     Location = "Jacksonville",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "JACALTIRIS0001",
     Location = "Jacksonville",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KEE004331D0001",
     Location = "Keesler AFB",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KEE004331D0002",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KEE004331FV001",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KEE004331MV003",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KEE004331MV004",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KEE004331MV005",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Kirk O'Neill",
     APocSecondary = "Micah Pate",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KEE004331MV006",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KEE004331MV007",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Kirk O'Neill",
     APocSecondary = "Cory Schick",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KEE004331MV008",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Kirk O'neill",
     APocSecondary = "Cory Schick",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KEE004331MV009",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KEE004331MV010",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KEE004331MV011",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KEE004331QV002",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KEE004331R0001",
     Location = "Keesler AFB",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KEE004331V0004",
     Location = "Keesler AFB",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Pete Fioro",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KEE004331V0005",
     Location = "KEESLER",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KEE004331V0006",
     Location = "Keesler",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KIB001065D0001",
     Location = "Kings Bay",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KIB001065D0001N",
     Location = "Kings Bay",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "David Scobey",
     APocSecondary = "David Scobey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KIB001065D0001S",
     Location = "Kings Bay",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KIB001065D0002",
     Location = "Kings Bay",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KIB001065D0002N",
     Location = "Kings Bay",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "David Scobey",
     APocSecondary = "David Scobey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KIB001065D0002S",
     Location = "Kings Bay",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KIB001065D002",
     Location = "Kings Bay",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "KIB001065R0001",
     Location = "Kings Bay",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KIB001065R0001N",
     Location = "Kings Bay",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KIN002741D0001",
     Location = "Kingsville",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "KIN002741D0002",
     Location = "Kingsville",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAC010215D0001",
     Location = "Lackland",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAC010215D0002",
     Location = "Lackland",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAC010215FV001",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAC010215MV003",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAC010215MV004",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAC010215MV006",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Pete Fierro",
     APocSecondary = "Kirk O'neill",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LAC010215MV007",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Kirk O'Neill",
     APocSecondary = "Micah Pate",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LAC010215MV008",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Cory Schick",
     APocSecondary = "Kirk O'neill",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LAC010215MV009",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Pete Fierro",
     APocSecondary = "Micah Pate",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LAC010215MV010",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Kirk Oneill",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LAC010215MV011",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LAC010215MV012",
     Location = "Lackland",
     OSPocPrimary = "Cory Schick",
     OSPocSecondary = "",
     APocPrimary = "Kirck Oneil",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LAC010215QV002",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "Tony Borelli",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAC010215R0001",
     Location = "Lackland",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LAC010215V0004",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Cory Schick",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Lac010215v0005",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAC010215V0006",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAC010215V0007",
     Location = "Lackland",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "Kirk O'neill",
     APocSecondary = "Pete Fierro",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAK000001D0001",
     Location = "Lakehurst",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAK000001D0002",
     Location = "Lakehurst",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LAK000001R0001",
     Location = "Lakehurst",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LEM000738D0001",
     Location = "Lemoore",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LEM000738D0002",
     Location = "Lemoore",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LEM000738R0001",
     Location = "Lemoore",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LEM000799F0001",
     Location = "Lemoore",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "LIC003602D0001",
     Location = "Little Creek",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "LIC003602D0002",
     Location = "Little Creek",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MAY001388D0001",
     Location = "Mayport",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MAY001388D0002",
     Location = "Mayport",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MAY001388R0001",
     Location = "Mayport",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "MAY001556D0001S",
     Location = "Mayport",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MAY001556R0001S",
     Location = "Mayport",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "MER000150D0001",
     Location = "Meridian",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330D0001",
     Location = "Meridian",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330FV001",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330FV015",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV003",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV004",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV006",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV007",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV008",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV009",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV010",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV011",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV012",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV013",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV014",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV017",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV018",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV020",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV021",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV022",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV023",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV024",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV025",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV026",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV027",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330MV028",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330QV016",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330R0001",
     Location = "Meridian",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "MER000330V0004",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0005",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0006",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0007",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0008",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0009",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0025",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0026",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0027",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0028",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0029",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MER000330V0030",
     Location = "Meridian",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515FV001",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515MV003",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515MV004",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515MV005",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515MV006",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515MV007",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515MV008",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515MV009",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515MV010",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515QV002",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515V0004",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MIR007515V0005",
     Location = "Miramar",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "MON00629AR0001",
     Location = "Monterey",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEL000499R0001N",
     Location = "New London",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEL000518D0001N",
     Location = "New London",
     OSPocPrimary = "David Scobey",
     OSPocSecondary = "",
     APocPrimary = "David Scobey",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEL000518R0001",
     Location = "New London",
     OSPocPrimary = "NETPDTC_HBSS@navy.mil",
     OSPocSecondary = "NETPDTC_HBSS@navy.mil",
     APocPrimary = "Ray Delemos",
     APocSecondary = "Jeff Dawson",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEL000518R0001N",
     Location = "New London",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEL000519D0001",
     Location = "New London",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEL000519D0002",
     Location = "New London",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEL000519R0001N",
     Location = "New London",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEL000533R0001N",
     Location = "New London",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEL000607R0001N",
     Location = "New London",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NELALTIRIS0001N",
     Location = "New London",
     OSPocPrimary = "Ray Delemos",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEO00H100D0001",
     Location = "New Orleans",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEO00H100D0002",
     Location = "New Orleans",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEO00H100R0001",
     Location = "New Orleans",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NER000222D0001",
     Location = "New River",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER000222D0002",
     Location = "New River",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER000255D0001",
     Location = "New River",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NER000255D0002",
     Location = "New River",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NER0AS222FV001",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222MV003",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222MV004",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222MV005",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222MV006",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222MV007",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222MV008",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222MV009",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222MV010",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222MV011",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222MV012",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222QV002",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "(N635) Tony Borelli",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222V0004",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222V0005",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222V0006",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NER0AS222V0007",
     Location = "New River",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEW000370R0001",
     Location = "Newport",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEW000440D0001",
     Location = "Newport",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEW000440D0002",
     Location = "Newport",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEW000440R0001",
     Location = "Newport",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEW000446D0001",
     Location = "Newport",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEW000446D0002",
     Location = "Newport",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEW001268D0001S",
     Location = "Newport",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEW001268D0002S",
     Location = "Newport",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NEW001268R0001S",
     Location = "Newport",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEW01268D0001S",
     Location = "Newport",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEW01268D0002S",
     Location = "Newport",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NEWALTIRIS0002",
     Location = "Newport",
     OSPocPrimary = "Ray Delemos",
     OSPocSecondary = "Cory Schick",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NIS000698D0001",
     Location = "North Island",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NIS000698D0002",
     Location = "North Island",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NIS000698M0006",
     Location = "North Island",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NNA000195D0001s",
     Location = "NAS Norfolk",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NNA000N30D0001",
     Location = "NAS Norfolk",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NNA000N30D0002",
     Location = "NAS Norfolk",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NNA000N30M0005",
     Location = "NAS Norfolk",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NNAALTIRIS0002",
     Location = "NAS Norfolk",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NNACEP162D0001N",
     Location = "NAS Norfolk",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NNACEP162D0001S",
     Location = "NAS Norfolk",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil ",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NNACEP166R0001S",
     Location = "NAS Norfolk",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NNACEP195R0001S",
     Location = "NAS Norfolk",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NNASDA334R0001",
     Location = "NAS Norfolk",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NNASSIM0018",
     Location = "NAS Norfolk",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NNASSIM018",
     Location = "NAS Norfolk",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "NWC000041D0001",
     Location = "North West Chesapeake",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "NWC000041D0001S",
     Location = "North West Chesapeake",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil ",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "OCE000223D0001",
     Location = "Oceana",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "OCE000223D0002",
     Location = "Oceana",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PAN000350D0001",
     Location = "Panama City",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PAN000350D0002",
     Location = "Panama City",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PAN000350D002",
     Location = "Panama City",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PAN000437R0001",
     Location = "Panama City",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEH000089R0001N",
     Location = "Pearl Harbor",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEH001262D0001",
     Location = "Pearl Harbor",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEH001262D0001N",
     Location = "Pearl Harbor",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "David Scobey",
     APocSecondary = "Roy Whitaker",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEH001262D0001s",
     Location = "Pearl Harbor",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEH001262D0002",
     Location = "Pearl Harbor",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEH001262D0002N",
     Location = "Pearl Harbor",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "David Scobey",
     APocSecondary = "David Scobey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEH001262D0002S",
     Location = "Pearl Harbor",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEH001262D002",
     Location = "Pearl Harbor",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEH001262R0001N",
     Location = "Pearl Harbor",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEH001262Z0001",
     Location = "Pearl Harbor",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000603D0001N",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603D0001S",
     Location = "NASP",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603D0002N",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Pen000603d1032s",
     Location = "NASP",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "Systems",
     APocSecondary = "Systems",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603d1033s",
     Location = "NASP",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "Tranet",
     APocSecondary = "Tranet",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603E0001N",
     Location = "NASP",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603f0001s",
     Location = "NASP",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603M0002N",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bob Rayburn",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603M0003N",
     Location = "NASP",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603M0008N",
     Location = "NASP",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603M0010N",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603M0011N",
     Location = "NASP",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "pen000603m0013n",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "pen000603m0014n",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "pen000603m0015n",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Charlie Odom",
     APocSecondary = " Richard Griffin ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m0016n",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Charlie Odom",
     APocSecondary = " Richard Griffin ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m0017n",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Charlie Odom",
     APocSecondary = " Richard Griffin ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m0018n",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Charlie Odom",
     APocSecondary = " Richard Griffin ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m0019n",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Terry Lewis",
     APocSecondary = " Terry Lewis",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m0020n",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = "Rick Griffin",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m0021n",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Charlie Odom",
     APocSecondary = " Richard Griffin ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Pen000603m1010s",
     Location = "NASP",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603m1011s",
     Location = "NASP",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603m1012s",
     Location = "NASP",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603m1013s",
     Location = "NASP",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Pen000603m1018s",
     Location = "NASP",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603m1019s",
     Location = "NASP",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603m1021s",
     Location = "NASP",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603m1022s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE",
     APocSecondary = "",
     dbaadmin = "Kenneth Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603m1023s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603M1028S",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603m1034s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "Doug Spivey",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "Doug Spivey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603M1035S",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Doug Spivey",
     APocSecondary = "Doug Spivey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pen000603m1036s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603M1041S",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m1042s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Tibbs",
     APocSecondary = "James Moore",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000603M1043S",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Sam Terry",
     APocSecondary = "Brent Knight",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000603M1044S",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "John Edwards",
     APocSecondary = "Clark Taft",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000603M1045S",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "John Edwards",
     APocSecondary = "Clark Taft",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000603M1046N",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "John Edwards",
     APocSecondary = "Clark Taft",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m1047s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Mercer Sport",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m1049s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "James Bailey",
     APocSecondary = "Bill Ralli",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "pen000603m1050s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "pen000603m1231s",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Paul Boshard",
     APocSecondary = " Paul Boshard",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m1232s",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Paul Boshard",
     APocSecondary = " Paul Boshard",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m1233s",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Paul Boshard",
     APocSecondary = " Paul Boshard",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m1234s",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Charlie Odom",
     APocSecondary = " Charlie Odom",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m1235s",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Charlie Odom",
     APocSecondary = " Richard Griffin ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m1236s",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Richard Griffin ",
     APocSecondary = " Charlie Odom",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen000603m1237s",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = " Charlie Odom",
     APocSecondary = " Richard Griffin ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000603NS001N",
     Location = "NASP",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Clark Taft",
     APocSecondary = "James Pruett",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000603NS001s",
     Location = "NASP",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000603R0001S",
     Location = "NASP",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000603R0002S",
     Location = "NASP",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000603V0011N",
     Location = "NASP",
     OSPocPrimary = "Douglas Spivey",
     OSPocSecondary = "Eric Morgan",
     APocPrimary = "Doug Spivey",
     APocSecondary = "Eric Morgan",
     dbaadmin = "Shane Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603V0012N",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000603V0013N",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000628R0001",
     Location = "NASP",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN000633D0001",
     Location = "NASP",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN000633D0002",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN003258D0001",
     Location = "Sherman Field",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN003258D0002",
     Location = "Sherman Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN003460D0001",
     Location = "Sherman Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN003460D0002",
     Location = "Sherman Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN003460D001",
     Location = "Sherman Field",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN003460R0001",
     Location = "Sherman Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Pen00603d0001s",
     Location = "NASP",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN00603D0002S",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil ",
     APocPrimary = "NETC_SYSTEMS@navy.mil ",
     APocSecondary = "David Davis",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PEN00603E0001S",
     Location = "NASP",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "NETPDTC_SFLY_TRANET_AD@navy.mil�",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN00603M0002S",
     Location = "NASP",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "pen00603m0010s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Micah Pate",
     APocSecondary = "Micah Pate",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PEN00603M0011S",
     Location = "NASP",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PENALTIRIS0001N",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penaltiris0001s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PENALTIRIS0002",
     Location = "NASP",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penaltiris0003s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penaltiris0004s",
     Location = "NASP",
     OSPocPrimary = "Jeff Dawson",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penaltiris0005s",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "Tony Borelli",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PENALTIRIS1S",
     Location = "NASP",
     OSPocPrimary = "Ray Delemos",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PENALTIRIS2S",
     Location = "NASP",
     OSPocPrimary = "Ray Delemos",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penhbss003",
     Location = "NASP",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "Jeff Dawson",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PENHBSS1023",
     Location = "NASP",
     OSPocPrimary = "Jeff Dawson",
     OSPocSecondary = "Jason Sims",
     APocPrimary = "Jeff Dawson",
     APocSecondary = "Jason Sims",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PENHBSS1025",
     Location = "NASP",
     OSPocPrimary = "Jeff Dawson",
     OSPocSecondary = "Jason Sims",
     APocPrimary = "Jeff Dawson",
     APocSecondary = "Jason Sims",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pens0186",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Pens1013",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Douglas Spivey",
     APocSecondary = "Douglas Spivey",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Pens1017",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "Eric Morgan",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pens1020",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Don Payne",
     APocSecondary = "Don Payne",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PENS1234",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bob Rayburn",
     APocSecondary = "Mike Rowe",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pens1359",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Pens200196",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bryan Ussery",
     APocSecondary = "Steven Garcia",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Pens200197",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Tibbs",
     APocSecondary = "Charlie Tibbs",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Pens22343",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Don Payne",
     APocSecondary = "Nancy Lockwood",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PENS22344",
     Location = "Saufley Field",
     OSPocPrimary = " NETC_SYSTEMS@navy.mil",
     OSPocSecondary = " NETC_SYSTEMS@navy.mil",
     APocPrimary = " Don Payne",
     APocSecondary = " Don Payne",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PENS22345",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Brenda McCreary",
     APocSecondary = "Donald Payne",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pens22346",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Nancy Lockwood",
     APocSecondary = "Don Payne",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pens22347",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Nancy Lockwood",
     APocSecondary = "Don Payne",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Pens22348",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Don Payne",
     APocSecondary = "Nancy Lockwood",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PENS255174",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "Douglas Spivey",
     APocPrimary = "Bryan Ussery",
     APocSecondary = "Steven Garcia",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Pens46015",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PENS9441 ",
     Location = "Saufley Field",
     OSPocPrimary = " Clark Taft",
     OSPocSecondary = " Jason Blackburn ",
     APocPrimary = " Clark Taft",
     APocSecondary = " Jason Blackburn ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PENSSIM0021",
     Location = "NASP",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PENSSIM0022",
     Location = "NASP",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PENSSIM0023",
     Location = "NASP",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PENSSIM0024",
     Location = "NASP",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PENSSIM0025",
     Location = "NASP",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penssim021",
     Location = "NASP",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "Jeff Dawson",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penssim022",
     Location = "NASP",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "Jeff Dawson",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penssim023",
     Location = "NASP",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "Jeff Dawson",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penssim025",
     Location = "NASP",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "NETC_SSIM@navy.mil",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu000000",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil   ",
     APocPrimary = "Mike Japp",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu000001",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Connie Thomsen",
     APocSecondary = "Emma Griffin",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu0138",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Kevin Coker",
     APocSecondary = "NETPDTC_Unix@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu1266",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu1267",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu1268",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade  ",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "NETPDTC_UNIX@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu1269",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu1271",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "NETPDTC_UNIX@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu154197",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Loi Nguyen   ",
     APocSecondary = "Gene Hasty   ",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu154229",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Loi Nguyen   ",
     APocSecondary = "Gene Hasty",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu155013",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155014",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "ILE TEAM",
     APocSecondary = "ILE TEAM",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155015",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155016",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "ILE TEAM",
     APocSecondary = "ILE TEAM",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155017",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155018",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "ILE TEAM",
     APocSecondary = "ILE TEAM",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155133",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Dan Latourelle",
     APocSecondary = "Samson McNealy",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu155140",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = " Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155141",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = " Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155142",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = " Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155143",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155144",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "ILE TEAM",
     APocSecondary = "ILE TEAM",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu155194",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Ken Janney",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu155195",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "Kevin Schack",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Shane Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155228",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = " Donna Berkley",
     APocSecondary = " Rick White",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155229",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = " Donna Berkley",
     APocSecondary = " Rick White",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu155230",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = " Donna Berkley",
     APocSecondary = " Rick White",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu155232",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "(None)",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu155233",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu155234",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu155235",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu15568",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Dan Latourelle",
     APocSecondary = "Samson McNealy",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu156019",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu163118",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu163120",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu163122",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu163123",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Gene Hasty",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu163124",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu163125",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu163126",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu164012",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_Unix@navy.mil",
     APocSecondary = "NETPDTC_Unix@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu164013",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil   ",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_Unix@navy.mil ",
     APocSecondary = " NETPDTC_Unix@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu164204",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_Unix@navy.mil",
     APocSecondary = "Lawana Slade",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu166014",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_sfly_serena_support@navy.mil",
     OSPocSecondary = "NETPDTC_sfly_serena_support@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Mathew Buckley",
     dbaadmin = "NETPDTC_sfly_serena_support@navy.mil",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu166015",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_sfly_serena_support@navy.mil",
     OSPocSecondary = "NETPDTC_sfly_serena_support@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Mathew Buckley",
     dbaadmin = "NETPDTC_sfly_serena_support@navy.mil",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu166080",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu166081",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu166082",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu166083",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu166084",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu166085/penu166086",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu166134",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu166135",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu166136",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu166137",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu166138",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu166139",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu166178",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Loi Nguyen",
     APocSecondary = "Mercer Sport",
     dbaadmin = "Mercer Sport",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu166180",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Loi Nguyen",
     APocSecondary = "Mercer Sport",
     dbaadmin = "Mercer Sport",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu166182",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Loi Nguyen",
     APocSecondary = "Mercer Sport",
     dbaadmin = "Mercer Sport",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu1816",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "Kevin Coker",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "PENU1818",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_Unix@navy.mil",
     APocSecondary = "NETPDTC_Unix@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu196058",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu196059",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu196060",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu196061",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu196062",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu196063",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu196064",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu22019",
     Location = "Saufley Field",
     OSPocPrimary = "Don Payne",
     OSPocSecondary = "Nancy Lockwood",
     APocPrimary = "Don Payne",
     APocSecondary = "Nancy Lockwood",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu226019",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu226020",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu227105",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu227108",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Gene Hasty",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227110",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227112",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227114",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227116",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227117",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "(None)",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu227146",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu227147",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu227148",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu227149",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu227150",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu227151",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227152",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227153",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227154",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227155",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227156",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227157",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227158",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227159",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227160",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227161",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227162",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227163",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227164",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227165",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227166",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227167",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227168",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227169",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227170",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227171",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu227172",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu23243",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade  ",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil ",
     APocPrimary = "Lawana Slade  ",
     APocSecondary = "NETPDTC_UNIX@navy.mil ",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "penu252018",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker ",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu252019",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu252028",
     Location = "Saufley Field",
     OSPocPrimary = "LawanaSlade     ",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu252029",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu252030",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu252031/penu252032",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu252033",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu252034",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu252035",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu252036",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu252037",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu252085",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu252086",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu252087",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu252088",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu252089/penu252090",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu252096/penu252097",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu252098/penu252099",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu252100/penu252101",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu252106/penu252107",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu261010",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu261011",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu261012",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu261013",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu26133",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Terry lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penu2633",
     Location = "",
     OSPocPrimary = "NETPDTC_UNIX@Navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@Navy.mil",
     APocPrimary = "NETPDTC_UNIX@Navy.mil",
     APocSecondary = "NETPDTC_UNIX@Navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu27001",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu27002",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Paul Boshard",
     APocSecondary = "Daniel Latourelle",
     dbaadmin = "Kenneth Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu2994",
     Location = "Saufley Field",
     OSPocPrimary = "Lawana Slade  ",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "NETPDTC_UNIX@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Penu46010",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46011",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46012",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46013",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Dan Latourelle",
     APocSecondary = "Samson McNealy",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46019",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46020",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46021",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46022",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46023",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46024",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46025",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46026",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "Kevin Coker",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46140",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Dan Latourelle",
     APocSecondary = "Samson McNealy",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46142",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Bill (Johnny) Johnson",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penu46143",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penuacas001",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_ACAS_ALERT@navy.mil",
     APocSecondary = "NETPDTC_ACAS_ALERT@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penuacas002",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_ACAS_ALERT@navy.mil",
     APocSecondary = "NETPDTC_ACAS_ALERT@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penuacas003",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_ACAS_ALERT@navy.mil",
     APocSecondary = "NETPDTC_ACAS_ALERT@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penuacas004",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_ACAS_ALERT@navy.mil",
     APocSecondary = "NETPDTC_ACAS_ALERT@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penuacas005",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_ACAS_ALERT@navy.mil",
     APocSecondary = "NETPDTC_ACAS_ALERT@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "PENUACAS006",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penuacas101",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_ACAS_ALERT@navy.mil",
     APocSecondary = "NETPDTC_ACAS_ALERT@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "penuacas102",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_ACAS_ALERT@navy.mil",
     APocSecondary = "NETPDTC_ACAS_ALERT@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penuacas201",
     Location = "NASP",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "James Pruett",
     APocSecondary = "Steve Houghland",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penuacas501",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_ACAS_ALERT@navy.mil",
     APocSecondary = "NETPDTC_ACAS_ALERT@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Penuacas502",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_UNIX@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "NETPDTC_ACAS_ALERT@navy.mil",
     APocSecondary = "NETPDTC_ACAS_ALERT@navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "POH001300A0001",
     Location = "Port Hueneme",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "POH001300D0001",
     Location = "Port Hueneme",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "POH001300D0002",
     Location = "Port Hueneme",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "POH001300R0002",
     Location = "Port Hueneme",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "POH001419R0001",
     Location = "Port Hueneme",
     OSPocPrimary = "HETC_HBSS@navy.mil",
     OSPocSecondary = "HETC_HBSS@navy.mil",
     APocPrimary = "HETC_HBSS@navy.mil",
     APocSecondary = "HETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "POL000011D0001",
     Location = "Port Loma",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "POL000011D0001S",
     Location = "Port Loma",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "POL000011D0002",
     Location = "Port Loma",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "POL000011D0002S",
     Location = "Port Loma",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "POL000011R0001S",
     Location = "Port Loma",
     OSPocPrimary = "HETC_HBSS@navy.mil",
     OSPocSecondary = "HETC_HBSS@navy.mil",
     APocPrimary = "HETC_HBSS@navy.mil",
     APocSecondary = "HETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "POL000052D0001S",
     Location = "Port Loma",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "POL000052D0002S",
     Location = "Port Loma",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "POL000544D0001N",
     Location = "Port Loma",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "POL000544D0001S",
     Location = "Port Loma",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "POL000544R0001N",
     Location = "Port Loma",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Ray Delemos",
     APocSecondary = "Jeff Dawson",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "POL000564R0001S",
     Location = "Port Loma",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "POM000160D0001",
     Location = "Point Mugu",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "POM000160R0001",
     Location = "Point Mugu",
     OSPocPrimary = "HETC_HBSS@navy.mil",
     OSPocSecondary = "HETC_HBSS@navy.mil",
     APocPrimary = "HETC_HBSS@navy.mil",
     APocSecondary = "HETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "POR000389D0001",
     Location = "Port Hueneme",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAD000011D0001S",
     Location = "San Diego",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAD000544D0002S",
     Location = "San Diego",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAD000562R0001",
     Location = "San Diego",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "HETC_HBSS@navy.mil",
     APocSecondary = "HETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAD003141D0001S",
     Location = "San Diego",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAD003141R0001S",
     Location = "San Diego",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Jeff Dawson",
     APocSecondary = "Chris Riggs",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAD003281D0001S",
     Location = "San Diego",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAD003281R0001S",
     Location = "San Diego",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAD003290D0001",
     Location = "San Diego",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAD003290D0002",
     Location = "San Diego",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAD003290R0001",
     Location = "San Diego",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SADALTIRIS0002",
     Location = "San Diego",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SADSSIM0020",
     Location = "San Diego",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SADSSIM020",
     Location = "San Diego",
     OSPocPrimary = "NETC_SSIM@navy.mil",
     OSPocSecondary = "NETC_SSIM@navy.mil",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf000603v1001",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf000603v1002",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf000603v1003",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf000603v1004",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf000603v1004",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf000603v1005",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf000603v1005",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf000603v1006",
     Location = "NASP",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434A0001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bucky Churchill",
     APocSecondary = "Jeff Dawson",
     dbaadmin = "Shane Garrett/Mercer Sport",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434B0001",
     Location = "Saufley Field",
     OSPocPrimary = " Clark Taft",
     OSPocSecondary = " Jason Blackburn ",
     APocPrimary = " Clark Taft",
     APocSecondary = " Jason Blackburn ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434B0002",
     Location = "Saufley Field",
     OSPocPrimary = " Clark Taft",
     OSPocSecondary = " Jason Blackburn ",
     APocPrimary = " Clark Taft",
     APocSecondary = " Jason Blackburn ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434C1179",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434d0001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434d0002",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434d0003",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434d0004",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434d0007",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434d0008",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434d0009",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "NETPDTC_SFLY_TRANET_AD@navy.mil",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434D1001",
     Location = "Saufley Field",
     OSPocPrimary = " NETC_SYSTEMS@navy.mil",
     OSPocSecondary = " NETC_SYSTEMS@navy.mil",
     APocPrimary = " NETC_SYSTEMS@navy.mil",
     APocSecondary = " NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434D1002",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434D1003",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434D1005",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434D1006",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Doug Spivey",
     APocSecondary = "Marc Stone",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434D1008",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Douglas Spivey",
     APocSecondary = "Marc Stone",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434D1009",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434fv005",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m0001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "NETPDTC_SFLY_TRANET_AD@navy.mil�",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M0001T",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M0002T",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M0003T",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M0004",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "David Davis",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M0004T",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m0005",
     Location = "SaufleyField",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M0012",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434m1021",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bucky Churchill",
     APocSecondary = "Jeff Dawson",
     dbaadmin = "Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1026",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Tina Sabo",
     APocSecondary = "James Moore",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1034",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "John Hart",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1035",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Kirk O'Neill",
     APocSecondary = "John Edwards",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1040",
     Location = "Saufley Field",
     OSPocPrimary = "NETPDTC_Unix@navy.mil",
     OSPocSecondary = "NETPDTC_Unix@navy.mil",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1143",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Samson McNealy   ",
     APocSecondary = "NETC_SYSTEMS@navy.mil   ",
     dbaadmin = "Terry Lewis   ",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1210",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1215",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434m1216",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Shane Garrett / Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1217",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1218",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Dan Latourelle",
     dbaadmin = "Shane Garrett / Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1220",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434m1221",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "Jean Griffin",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Jean Griffin",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434m1222",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1223",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "Jean Griffin",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434m1224",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1225",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434m1226",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434m1227",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1228",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434m1229",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "ILE Team",
     APocSecondary = "ILE Team",
     dbaadmin = "Terry Lewis/Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434m1232",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "Jean Griffin",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "Terry Lewis/Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434m1233",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "Jean Griffin",
     APocPrimary = "Samson McNealy",
     APocSecondary = "Paul Boshard",
     dbaadmin = "Terry Lewis / Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1234",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "ILE",
     APocSecondary = "ILE",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1286",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Loi Nguyen",
     APocSecondary = "Mark Brockway",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1305",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "Terry Lewis ",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1306",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1307",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1313",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1314",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1315",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "saf002434m1316",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1317",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1318",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1319",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1320",
     Location = "Saufley Field",
     OSPocPrimary = "Systems Group",
     OSPocSecondary = "Systems Group",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1321",
     Location = "Saufley Field",
     OSPocPrimary = "Systems Group",
     OSPocSecondary = "Systems Group",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1322",
     Location = "Saufley Field",
     OSPocPrimary = "Systems Group",
     OSPocSecondary = "Systems Group",
     APocPrimary = "Charlie Odom",
     APocSecondary = " ",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434m1344",
     Location = "Saufley Field",
     OSPocPrimary = "Larry Reynolds",
     OSPocSecondary = "Ben Switzer",
     APocPrimary = "Clark Taft",
     APocSecondary = "",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1347",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1348",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "saf002434m1349",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Donna Berkley",
     APocSecondary = "Rick White",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1350",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1352",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Don Leggett",
     APocSecondary = "Thomas Prettyman",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1353",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Don Leggett",
     APocSecondary = "Thomas Prettyman",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1356",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "Ben Switzer",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "saf002434m1357",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = "Rick Griffin",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1358",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Charlie Odom",
     APocSecondary = "Rick Griffin",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1364",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "Ben Switzer",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1365",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "Ben Switzer",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1368",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "Ben Switzer",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1369",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "Ben Switzer",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1372",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = " John Edwards",
     APocSecondary = " Clark Taft",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1373",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "John Edwards",
     APocSecondary = "Clark Taft",
     dbaadmin = "(None)",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1374",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "John Edwards",
     APocSecondary = "Clark Taft",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434M1376",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport (John)",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1377",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1378",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport (John)",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434M1379",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport (John)",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434M1380",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Reynolds",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434M1382",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Reynolds",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1383",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1384",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1385",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1386",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1387",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Reynolds",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1388",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Reynolds",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1390",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1391",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Mercer Sport",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1392",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1393",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1394",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1395",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1396",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1397",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1398",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1399",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = " Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1400",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1401",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1402",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Reynolds",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1403",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Reynolds",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1404",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Reynolds",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1405",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Larry Reynolds",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1406",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1407",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1408",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Mercer Sport",
     APocSecondary = "Loi Nguyen",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1409",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Terry Lewis",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1410",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Terry Lewis",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1411",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Terry Lewis",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1412",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1413",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1414",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1415",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Wendy Rook",
     APocSecondary = "Rick Rhea",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1416",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1417",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1418",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1419",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1420",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1421",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1422",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1423",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1424",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "saf002434m1425",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1426",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1427",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1428",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1429",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1430",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1431",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1432",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1436",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Wendy Rook",
     APocSecondary = "Rick Rhea",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1437",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Wendy Rook",
     APocSecondary = "Richard Rhea",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1438",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Wendy Rook",
     APocSecondary = "Rick Rhea",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1439",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Wendy Rook",
     APocSecondary = "Rick Rhea",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1440",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Wendy Rook",
     APocSecondary = "Rick Rhea",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1441",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Wendy Rook",
     APocSecondary = "Rick Rhea",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1445",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Loi Nguyen",
     APocSecondary = "Mark Brockway",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1446",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Loi Nguyen",
     APocSecondary = "Mark Brockway",
     dbaadmin = "Mercer Sport",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1447",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Loi Nguyen",
     APocSecondary = "Mark Brockway",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1448",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Don Leggett",
     APocSecondary = "Thomas Prettyman",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1451",
     Location = "Saufley Field",
     OSPocPrimary = " NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "",
     APocPrimary = " Ron Brownell",
     APocSecondary = " Ken McCurdy",
     dbaadmin = " Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "saf002434m1452",
     Location = "Saufley Field",
     OSPocPrimary = " NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "",
     APocPrimary = " Ron Brownell",
     APocSecondary = " Ken McCurdy",
     dbaadmin = " Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1453",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Ron Brownell",
     APocSecondary = "Ken McCurdy",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1454",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1455",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1456",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bill Ralli",
     APocSecondary = "James Bailey",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1457",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Mercer Sport",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434M1458",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Mercer Sport",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "saf002434m1459",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Terry Lewis",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1460",
     Location = "Saufley Field",
     OSPocPrimary = " NETC_SYSTEMS@navy.mil",
     OSPocSecondary = " NETC_SYSTEMS@navy.mil",
     APocPrimary = " Terry Lewis",
     APocSecondary = " Terry Lewis",
     dbaadmin = " Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1461",
     Location = "Saufley Field",
     OSPocPrimary = " NETC_SYSTEMS@navy.mil",
     OSPocSecondary = " NETC_SYSTEMS@navy.mil",
     APocPrimary = " Terry Lewis",
     APocSecondary = " Terry Lewis",
     dbaadmin = " Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1462",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Terry Lewis",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1463",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Terry Lewis",
     APocSecondary = "Terry Lewis",
     dbaadmin = "Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434m1465",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1468",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "James Pruett",
     APocSecondary = "James Pruett",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434M1469",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "James Pruett",
     APocSecondary = "John Edwards",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434m1470",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Steve Simpkins",
     APocSecondary = "Doug Spivey",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "saf002434mv001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434mv003",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434mv007",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434mv008",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434mv009",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434mv010",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434mv011",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434MV012",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434MV013",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434MV014",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434MV015",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434MV016",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434MV100",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434NS001",
     Location = "Saufley Field",
     OSPocPrimary = "James Pruett",
     OSPocSecondary = "",
     APocPrimary = "James Pruett",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434NS002",
     Location = "Saufley Field",
     OSPocPrimary = "James Pruett",
     OSPocSecondary = "",
     APocPrimary = "James Pruett",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434Q0001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434q0020",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Bucky Churchill",
     APocSecondary = "Jeff Dawson",
     dbaadmin = "Shane Garrett",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434Q1022",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "John Edwards",
     APocSecondary = "Kirk O'neil",
     dbaadmin = "Shane Garrett/Mercer Sport",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434qv002",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434R0001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434R0001S",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434R0002",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434R0003",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434r0004",
     Location = "Saufley Field",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "",
     APocPrimary = "Ray Delemos",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434R0005",
     Location = "Saufley Field",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434r0006",
     Location = "Saufley Field",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "",
     APocPrimary = "Ray Delemos",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434R0007",
     Location = "Saufley Field",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434R0008",
     Location = "Saufley Field",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434T0025",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434V0014",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434V0015",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434v1001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434v1002",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1003",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434v1004",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434v1005",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434v1006",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1007",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1008",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1009",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1010",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1011",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1012",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1013",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1014",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1015",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1016",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil ",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil ",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1021",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Kenneth Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1022",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "Kenneth Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1122",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434v1123",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_VDI_Support@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_Support@netc.navy.mil",
     APocPrimary = "NETC_VDI_Support@netc.navy.mil",
     APocSecondary = "NETC_VDI_Support@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434v1157",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "Systems",
     APocSecondary = "Systems",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1158",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "Systems",
     APocSecondary = "Systems",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Saf002434v1159",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "Systems",
     APocSecondary = "Systems",
     dbaadmin = "Systems",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434v1160",
     Location = "Saufley Field",
     OSPocPrimary = "Systems",
     OSPocSecondary = "Systems",
     APocPrimary = "Systems",
     APocSecondary = "Systems",
     dbaadmin = "Ken Garrett/Terry Lewis",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Saf002434V2000",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434VC014",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil ",
     APocPrimary = "Douglas Spivey",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002434W0100T",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434W0101T",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002434WM01",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "NETPDTC_SFLY_TRANET_AD@navy.mil�",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAF002438D1040S",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "NETC_SYSTEMS@navy.mil",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAF002438R0001N",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Safaltiris0005",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Safaltiris0006",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Safaltiris0011",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "Safhbss1003",
     Location = "Saufley Field",
     OSPocPrimary = "Jeff Dawson   ",
     OSPocSecondary = "Jason Sims   ",
     APocPrimary = "Jeff Dawson   ",
     APocSecondary = "Jason Sims   ",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Safhbss1005",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "Ken Garrett",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAFQALTIRIS00v1",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAFQALTIRIS00v2",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAFQALTIRIS00v3",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAFQALTIRIS00v4",
     Location = "Saufley Field",
     OSPocPrimary = "ALTIRIS Group",
     OSPocSecondary = "Altiris Group",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAFQALTIRIS00v5",
     Location = "Saufley Field",
     OSPocPrimary = "ALTIRIS Group",
     OSPocSecondary = "Altiris Group",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0001",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0002",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0003",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0004",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0005",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0006",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0007",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0008",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0009",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0010",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAFSSIM0011",
     Location = "Saufley Field",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "sanu1265",
     Location = "NASP",
     OSPocPrimary = "Lawana Slade",
     OSPocSecondary = "NETPDTC_UNIX@navy.mil",
     APocPrimary = "Lawana Slade",
     APocSecondary = "NETPDTC_UNIX@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAR004470D0001",
     Location = "Guam",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Sar004470d0001n",
     Location = "Guam",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "David Scobey",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "SAR004470R0001N",
     Location = "Guam",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "TIN000830D0001",
     Location = "Tinker",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830D0002",
     Location = "Tinker",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830FV001",
     Location = "Tinker",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Cory Schick",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830MV003",
     Location = "Tinker",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Pete Fierro",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830MV004",
     Location = "Tinker",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Cory Schick",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830MV006",
     Location = "Tinker",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Cory Schick",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830MV007",
     Location = "Tinker",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Kirk O'Neill",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830MV008",
     Location = "Tinker",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Micah Pate",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830MV009",
     Location = "Tinker",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830MV010",
     Location = "Tinker",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Pete Fierro",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830MV011",
     Location = "Tinker",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830QV002",
     Location = "Tinker",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "Cory Schick",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830V0004",
     Location = "Tinker",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830V0005",
     Location = "Tinker",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "TIN000830V0006",
     Location = "Tinker",
     OSPocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     OSPocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocPrimary = "NETC_VDI_SUPPORT@netc.navy.mil",
     APocSecondary = "NETC_VDI_SUPPORT@netc.navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "WAI000R30D0001S",
     Location = "Wallops Island",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil",
     APocPrimary = "NETC_TRANET_AD@navy.mil",
     APocSecondary = "NETC_TRANET_AD@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "WAI000R30R0001",
     Location = "Wallops Island",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "WAI000R30R0001S",
     Location = "Wallops Island",
     OSPocPrimary = "NETC_HBSS@navy.mil",
     OSPocSecondary = "NETC_HBSS@navy.mil",
     APocPrimary = "NETC_HBSS@navy.mil",
     APocSecondary = "NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "WAI00R30D0001S",
     Location = "Wallops Island",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "WHF001415D0001",
     Location = "Whiting Field",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "WHF001415D0002",
     Location = "Whiting Field",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "WHF002945M0003",
     Location = "Whiting Field",
     OSPocPrimary = "Systems Support",
     OSPocSecondary = "",
     APocPrimary = "",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "WHI000976D0001",
     Location = "Whidbey Island",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "WHI000976D0002",
     Location = "Whidbey Island",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "WHI000976R0001",
     Location = "Whidbey Island",
     OSPocPrimary = "   NETC_HBSS@navy.mil",
     OSPocSecondary = "   NETC_HBSS@navy.mil",
     APocPrimary = "   NETC_HBSS@navy.mil",
     APocSecondary = "   NETC_HBSS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "WHI002740D0001s",
     Location = "Whidbey Island",
     OSPocPrimary = "",
     OSPocSecondary = "",
     APocPrimary = "David Scobey",
     APocSecondary = "",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "YOK001997D0001",
     Location = "Yokusuka",
     OSPocPrimary = "Clark Taft",
     OSPocSecondary = "Jason Blackburn",
     APocPrimary = "Clark Taft",
     APocSecondary = "Jason Blackburn",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "YOK001997D0002",
     Location = "Yokusuka",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Clark Taft",
     APocSecondary = "NETC_SYSTEMS@navy.mil",
     dbaadmin = "",
     AfterHourCallback = true
 },

 new scoViewModel

 {
     HostName = "Yokaltiris0001",
     Location = "Yokusuka",
     OSPocPrimary = "NETC_SYSTEMS@navy.mil",
     OSPocSecondary = "NETC_SYSTEMS@navy.mil",
     APocPrimary = "Stephanie Noski",
     APocSecondary = "Tony Borelli",
     dbaadmin = "",
     AfterHourCallback = false
 },

 new scoViewModel

 {
     HostName = "YOR001456D0001",
     Location = "York Town",
     OSPocPrimary = "NETC_TRANET_AD@navy.mil�",
     OSPocSecondary = "NETC_TRANET_AD@navy.mil�",
     APocPrimary = "NETC_TRANET_AD@navy.mil�",
     APocSecondary = "NETC_TRANET_AD@navy.mil�",
     dbaadmin = "",
     AfterHourCallback = true
 }
 );
                context.SaveChanges();
            }
        }
    }
}
