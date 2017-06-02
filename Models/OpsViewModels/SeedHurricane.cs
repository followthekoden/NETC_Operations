using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NETCOperations.Data;

namespace NETCOperations.Models.OpsViewModels
{
    public class SeedHurricane
    {
        public static void InitializeHurricane(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.HurricaneServerModel.Any())
                {
                    return;
                }

                context.HurricaneServerModel.AddRange(

    new HurricaneServerModel
    {
        HostName = "C27or4ssfly001",
        Application = "FastData",
        Enviroment = "Production",
        Purpose = "FASTDATA Production Database Server",
        Location = "Saufley Field",
        Bldg = 2434,
        Room = 101,
        Rack = "01-05-03",
        Primary = "Bill Wood",
        Secondary = "Brian Beasley",
        Hurricane = true

    },

  new HurricaneServerModel
  {
      HostName = "C27sq9wsfly002",
      Application = "AIM",
      Enviroment = "Production",
      Purpose = "SQL DB Cluster C27SQ9WSFLY002 for eDMZ",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-10-05",
      Primary = "Christipher Stark",
      Secondary = "Ken Garrett",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "C27vm9vsfly001",
      Application = "eDMZ",
      Enviroment = "Production",
      Purpose = "Replace Public ESX Host (C27VM9VSFLY001)",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-10-06",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "C27vm9vsfly002",
      Application = "eDMZ",
      Enviroment = "Production",
      Purpose = "eDMZ - ESX VMware 2 CSA",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-10-06",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "C27vm9vsfly003",
      Application = "eDMZ",
      Enviroment = "Production",
      Purpose = "Replace Private ESX Host ()",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-10-05",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "C27vm9vsfly004",
      Application = "eDMZ",
      Enviroment = "Production",
      Purpose = "Replace Private ESX Host (C27VM9VMSFLY003",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-10-05",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "C27vm9vsfly005",
      Application = "eDMZ",
      Enviroment = "Production",
      Purpose = "eDMZ - VMware V Center CSA",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-10-06",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "C27wb4ssfly001",
      Application = "FastData",
      Enviroment = "Production",
      Purpose = "FASTDATA Production Web  Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 101,
      Rack = "01-05-03",
      Primary = "Bill Wood",
      Secondary = "Brian Beasley",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Pens200196",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "CiscoWorks LAN Management system",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "Bryan Ussery",
      Secondary = "Steven Garcia",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Pens200197",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "Intermapper 5.6 (NIPRNET) SFLY",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-07",
      Primary = "Charlie Tibbs",
      Secondary = "Charlie Tibbs",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Pens22343",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Netbackup Master Media Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "3-19",
      Primary = "Don Payne",
      Secondary = "Nancy Lockwood",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "PENS22344",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "WIN2008 Upgrade - NetBackUp Server 2 of 6 replacement  media server - Pens22344",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-19",
      Primary = "Don Payne",
      Secondary = "Don Payne",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "PENS22345",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "NETBACKUP Media Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-19",
      Primary = "Brenda McCreary",
      Secondary = "Donald Payne",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Pens22346",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "WIN2008 Upgrade - NetBackUp Server 4 of 6 replacement media server -  Pens22346",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 101,
      Rack = "",
      Primary = "Nancy Lockwood",
      Secondary = "Don Payne",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Pens22347",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "Support Systems - NetBackup - Media Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-19",
      Primary = "Nancy Lockwood",
      Secondary = "Don Payne",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Pens22348",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "Support Systems - NetBackup - Media Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-19",
      Primary = "Don Payne",
      Secondary = "Nancy Lockwood",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu000000",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "CETARS  DB",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 101,
      Rack = "01-05-02",
      Primary = "Mike Japp",
      Secondary = "Loi Nguyen",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu000001",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "CETARS DB",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 101,
      Rack = "01-05-03",
      Primary = "Connie Thomsen",
      Secondary = "Emma Griffin",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu196058",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "EM7 Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-06",
      Primary = "Steve Simpkins",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu196059",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "EM7 Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-06",
      Primary = "Steve Simpkins",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu196060",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "EM7 Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-06",
      Primary = "Steve Simpkins",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu196061",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "EM7 Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-06",
      Primary = "Steve Simpkins",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu196062",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "EM7 Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-06",
      Primary = "Steve Simpkins",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu196063",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "EM7 Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-06",
      Primary = "Steve Simpkins",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu196064",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "EM7 Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-06",
      Primary = "Steve Simpkins",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu22019",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "Support Systems - NetBackup - Adic Tape Library",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 101,
      Rack = "ROW 1",
      Primary = "Don Payne",
      Secondary = "Nancy Lockwood",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu26133",
      Application = "NeL",
      Enviroment = "Production",
      Purpose = "ETMDS GCAT",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 101,
      Rack = "01-05-02",
      Primary = "ILE",
      Secondary = "ILE",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu27001",
      Application = "NeL",
      Enviroment = "Production",
      Purpose = "Clustered Oracle RDBMS Database Server - 1 of 2",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 101,
      Rack = "01-05-02",
      Primary = "Samson McNealy",
      Secondary = "Paul Boshard",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Penu27002",
      Application = "NeL",
      Enviroment = "Production",
      Purpose = "Clustered Oracle RDBMS Database Server - 2 of 2",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 101,
      Rack = "01-05-03",
      Primary = "Paul Boshard",
      Secondary = "Daniel Latourelle",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434d0001",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "Central DC",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-18",
      Primary = "NETC_TRANET_AD@navy.mil",
      Secondary = "NETC_TRANET_AD@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434d0002",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "TRANET - Central Domain Controller",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-18",
      Primary = "NETC_TRANET_AD@navy.mil",
      Secondary = "NETC_TRANET_AD@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434d0003",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "Primary Domain Controller",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-18",
      Primary = "NETC_TRANET_AD@navy.mil",
      Secondary = "NETC_TRANET_AD@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434d0004",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "Domain Controller",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-18",
      Primary = "NETC_TRANET_AD@navy.mil",
      Secondary = "NETC_TRANET_AD@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434d0007",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "TRANET - Domain Controller",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-18",
      Primary = "NETC_TRANET_AD@navy.mil",
      Secondary = "NETC_TRANET_AD@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434d0008",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "TRANET - Domain Controller",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-18",
      Primary = "NETC_TRANET_AD@navy.mil",
      Secondary = "NETC_TRANET_AD@navy.mil",
      Hurricane = true,

  },

  new HurricaneServerModel
  {
      HostName = "SAF002434D1008",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "ESSPER SFLY Primary Active Directory srv upgrade to Win 2008",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "Douglas Spivey",
      Secondary = "Marc Stone",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434m0002",
      Application = "Tranet",
      Enviroment = "Production",
      Purpose = "File Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-18",
      Primary = "NETC_TRANET_AD@navy.mil",
      Secondary = "NETC_TRANET_AD@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434m1040",
      Application = "NeL",
      Enviroment = "Production",
      Purpose = "GCAT NIPR Windows NAS Server (1 of 2)",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-06",
      Primary = "ILE",
      Secondary = "ILE",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434m1228",
      Application = "NeL",
      Enviroment = "Production",
      Purpose = "Windows NFS Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-06",
      Primary = "ILE Team",
      Secondary = "ILE Team",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434m1229",
      Application = "NeL",
      Enviroment = "Production",
      Purpose = "Windows NFS Server",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-06",
      Primary = "ILE Team",
      Secondary = "ILE Team",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1007",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "VMWare - Production Host 1 of 10",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1008",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "VMWare - Production Host 2 of 10",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1009",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "Support Systems - VMWare - Prod Host 3 of 10",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1010",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "VMWare - Production Host 4 of 10",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1011",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "VMWare - Production Host",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1012",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "VMWare - Production Host",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1013",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "VMWare - Production Host",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1014",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "VMWare - Production Host",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1015",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "VMWare - Production Host",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1016",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "VMWare - Production Host",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1021",
      Application = "NeL",
      Enviroment = "Development",
      Purpose = "GCAT NIPR Windows ESX VMware Host (1 of 2)",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 101,
      Rack = "01-02-10",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1022",
      Application = "NeL",
      Enviroment = "Development",
      Purpose = "GCAT NIPR Windows ESX VMware Host (2 of 2)",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 101,
      Rack = "01-02-10",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1157",
      Application = "NeL",
      Enviroment = "Production",
      Purpose = "GCAT NIPR Windows ESX VMware Host",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-07",
      Primary = "Systems",
      Secondary = "Systems",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434v1158",
      Application = "NeL",
      Enviroment = "Production",
      Purpose = "GCAT NIPR Windows ESX VMware Host",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 102,
      Rack = "02-13-07",
      Primary = "Systems",
      Secondary = "Systems",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "Saf002434V2000",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "ESXi Host Prod 1 of 8",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "3-12",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAF002434VC014",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "WIN2008 Upgrade for Vcenter 5.5 PROD Build NX3000-SAF002434VC014",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "3-14",
      Primary = "Douglas Spivey",
      Secondary = "",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAF002438D1040S",
      Application = "TRANET",
      Enviroment = "Production",
      Purpose = "Physical Domain Controller - 2438",
      Location = "Saufley Field",
      Bldg = 2438,
      Room = 1,
      Rack = "1",
      Primary = "NETC_SYSTEMS@navy.mil",
      Secondary = "NETC_SYSTEMS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0001",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Replacement hardware for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0002",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Hardware replacement for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0003",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Hardware replacement for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0004",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Hardware replacement for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0005",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Hardware replacement for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0006",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Hardware replacement for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0007",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Hardware replacement for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0008",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Hardware replacement for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0009",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Hardware replacement for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0010",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Hardware replacement for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  },

  new HurricaneServerModel
  {
      HostName = "SAFSSIM0011",
      Application = "Support Systems",
      Enviroment = "Production",
      Purpose = "Hardware replacement for the SSIM tech refresh",
      Location = "Saufley Field",
      Bldg = 2434,
      Room = 106,
      Rack = "03-36",
      Primary = "NETC_HBSS@navy.mil",
      Secondary = "NETC_HBSS@navy.mil",
      Hurricane = true

  }

);
                context.SaveChanges();
            }
        }
    }
}
