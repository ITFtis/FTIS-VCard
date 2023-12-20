using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FTIS_IDCARD.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<F22cmmEmpDa1> F22cmmEmpDa1 { get; set; }
        public virtual DbSet<F22cmmEmpDa4> F22cmmEmpDa4 { get; set; }
        public virtual DbSet<F22cmmEmpDa5> F22cmmEmpDa5 { get; set; }
        public virtual DbSet<F22cmmEmpDa6> F22cmmEmpDa6 { get; set; }
        public virtual DbSet<F22cmmEmpDa7> F22cmmEmpDa7 { get; set; }
        public virtual DbSet<F22cmmEmpDa8> F22cmmEmpDa8 { get; set; }
        public virtual DbSet<F22cmmEmpDa9> F22cmmEmpDa9 { get; set; }
        public virtual DbSet<F22cmmEmpData> F22cmmEmpData { get; set; }
        public virtual DbSet<F22cmmGrade> F22cmmGrade { get; set; }
        public virtual DbSet<F22cmmProjectData> F22cmmProjectData { get; set; }
        public virtual DbSet<F22cmmTitle> F22cmmTitle { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<F22cmmCounty> F22cmmCounty { get; set; }
        public virtual DbSet<F22cmmDep> F22cmmDep { get; set; }
        public virtual DbSet<F22cmmTown> F22cmmTown { get; set; }
        public virtual DbSet<F22Holiday> F22Holiday { get; set; }
        public virtual DbSet<F22MamWTrecord> F22MamWTrecord { get; set; }
        public virtual DbSet<F22ManHour> F22ManHour { get; set; }
        public virtual DbSet<F22ManVacationAP> F22ManVacationAP { get; set; }
        public virtual DbSet<F22ManVacationList> F22ManVacationList { get; set; }
        public virtual DbSet<F22OptionMQ> F22OptionMQ { get; set; }
        public virtual DbSet<F22OptoinMWT> F22OptoinMWT { get; set; }
        public virtual DbSet<F22Qdate> F22Qdate { get; set; }
        public virtual DbSet<F22QdateManHour> F22QdateManHour { get; set; }
        public virtual DbSet<F22VacationBasicData> F22VacationBasicData { get; set; }
        public virtual DbSet<F22VacationRule> F22VacationRule { get; set; }
        public virtual DbSet<F22VAPFlowStatus> F22VAPFlowStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.Fno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.mno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da01)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da05)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da06)
                .HasPrecision(4, 1);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da07)
                .HasPrecision(4, 1);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da08)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da09)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da11a)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da11)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da12)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da14a)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da14)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da15)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da19)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa1>()
                .Property(e => e.da22)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa4>()
                .Property(e => e.Fno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa4>()
                .Property(e => e.mno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa4>()
                .Property(e => e.da404)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa4>()
                .Property(e => e.da405)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa5>()
                .Property(e => e.Fno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa5>()
                .Property(e => e.mno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa5>()
                .Property(e => e.da504)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa5>()
                .Property(e => e.da505)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa5>()
                .Property(e => e.da507)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa6>()
                .Property(e => e.Fno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa6>()
                .Property(e => e.mno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa6>()
                .Property(e => e.da603)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa7>()
                .Property(e => e.Fno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa7>()
                .Property(e => e.mno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa7>()
                .Property(e => e.da702)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa8>()
                .Property(e => e.Fno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa8>()
                .Property(e => e.mno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa8>()
                .Property(e => e.da802)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa9>()
                .Property(e => e.Fno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpDa9>()
                .Property(e => e.mno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.Fno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.Mno)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.IsQuit)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.DCode)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.TCode)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.GCode)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.MpCode)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.CkNo1)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.CkNo2)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.CkNo3)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.CkNo4)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.CkNo5)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.AgentNo)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.kpino1)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.kpino2)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.kpino3)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.kpino4)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.kpino5)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.UseQuit)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.QuitNo)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.UseTrainning)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.IsOT2V)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.Telext)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.UpdateMan)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmEmpData>()
                .Property(e => e.DCode_)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmGrade>()
                .Property(e => e.GCode)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.PrjID)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.PjNo)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.CkNo1)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.CkNo2)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.CkNo3)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.CkNo4)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.IsClosed)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.PCheck)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.HDYOT)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.ckrpt)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.PjNoM)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmProjectData>()
                .Property(e => e.PjUseM)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmTitle>()
                .Property(e => e.TCode)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmCounty>()
                .Property(e => e.CountyID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmCounty>()
                .Property(e => e.CID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmCounty>()
                .Property(e => e.CountyCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmDep>()
                .Property(e => e.DCode)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmDep>()
                .Property(e => e.DCkNo1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmDep>()
                .Property(e => e.DCkNo2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmDep>()
                .Property(e => e.DCkNo3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmDep>()
                .Property(e => e.DAdmino)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmDep>()
                .Property(e => e.DCkTopNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmDep>()
                .Property(e => e.IsUsed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmDep>()
                .Property(e => e.DCode_)
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmTown>()
                .Property(e => e.TownCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmTown>()
                .Property(e => e.CountyCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22cmmTown>()
                .Property(e => e.ZipCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22Holiday>()
                .Property(e => e.hday)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22Holiday>()
                .Property(e => e.Htype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22MamWTrecord>()
                .Property(e => e.Mno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22MamWTrecord>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<F22MamWTrecord>()
                .Property(e => e.Ttype)
                .IsUnicode(false);

            modelBuilder.Entity<F22ManHour>()
                .Property(e => e.Mno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManHour>()
                .Property(e => e.NHour)
                .HasPrecision(4, 1);

            modelBuilder.Entity<F22ManHour>()
                .Property(e => e.AHour)
                .HasPrecision(4, 1);

            modelBuilder.Entity<F22ManHour>()
                .Property(e => e.VHour)
                .HasPrecision(4, 1);

            modelBuilder.Entity<F22ManHour>()
                .Property(e => e.Daytype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManHour>()
                .Property(e => e.IsDday)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManVacationAP>()
                .Property(e => e.MNO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManVacationAP>()
                .Property(e => e.VAPquantity)
                .HasPrecision(4, 1);

            modelBuilder.Entity<F22ManVacationAP>()
                .Property(e => e.AgnetID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManVacationAP>()
                .Property(e => e.Admin21)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManVacationAP>()
                .Property(e => e.Admin22)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManVacationAP>()
                .Property(e => e.Admin23)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManVacationAP>()
                .Property(e => e.Admin24)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManVacationAP>()
                .Property(e => e.Admin25)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManVacationAP>()
                .Property(e => e.Admin55)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManVacationList>()
                .Property(e => e.mno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22ManVacationList>()
                .Property(e => e.Quantity)
                .HasPrecision(3, 1);

            modelBuilder.Entity<F22ManVacationList>()
                .Property(e => e.Used)
                .HasPrecision(3, 1);

            modelBuilder.Entity<F22OptionMQ>()
                .Property(e => e.Mno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22OptoinMWT>()
                .Property(e => e.Mno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22QdateManHour>()
                .Property(e => e.Class1)
                .HasPrecision(3, 1);

            modelBuilder.Entity<F22QdateManHour>()
                .Property(e => e.Class2)
                .HasPrecision(3, 1);

            modelBuilder.Entity<F22QdateManHour>()
                .Property(e => e.Class3)
                .HasPrecision(3, 1);

            modelBuilder.Entity<F22QdateManHour>()
                .Property(e => e.Class9)
                .HasPrecision(3, 1);

            modelBuilder.Entity<F22VacationBasicData>()
                .Property(e => e.VName)
                .IsFixedLength();

            modelBuilder.Entity<F22VacationBasicData>()
                .Property(e => e.VUnit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22VacationBasicData>()
                .Property(e => e.Vnum)
                .HasPrecision(3, 1);

            modelBuilder.Entity<F22VacationBasicData>()
                .Property(e => e.IsHrCK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22VacationRule>()
                .Property(e => e.Vunit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F22VacationRule>()
                .Property(e => e.VAPquantity)
                .HasPrecision(4, 1);
        }
    }
}
