using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
#nullable disable

namespace InfoJp.Server.Models
{
    public partial class InfoJPContext : DbContext
    {
        public InfoJPContext()
        {
        }

        public InfoJPContext(DbContextOptions<InfoJPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AktuelniTekstovi> AktuelniTekstovis { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<KalendarObaveza> KalendarObavezas { get; set; }
        public virtual DbSet<MejlCimpPrijava> MejlCimpPrijavas { get; set; }
        public virtual DbSet<PitanjaIodgovori> PitanjaIodgovoris { get; set; }
        public virtual DbSet<Placanje> Placanjes { get; set; }
        public virtual DbSet<PravnoLice> PravnoLices { get; set; }
        public virtual DbSet<Pretplatnik> Pretplatniks { get; set; }
        public virtual DbSet<Pretplatum> Pretplata { get; set; }
        public virtual DbSet<PrijavaSeminar> PrijavaSeminars { get; set; }
        public virtual DbSet<PrijavaVebinar> PrijavaVebinars { get; set; }
        public virtual DbSet<Seminari> Seminaris { get; set; }
        public virtual DbSet<UcesnikSeminar> UcesnikSeminars { get; set; }
        public virtual DbSet<UcesnikVebinar> UcesnikVebinars { get; set; }
        public virtual DbSet<Urednici> Urednicis { get; set; }
        public virtual DbSet<Vebinari> Vebinaris { get; set; }
        public virtual DbSet<Vesti> Vestis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=DESKTOP-F7QTG0F;Database=InfoJP;Integrated Security=True;");
               //optionsBuilder.UseSqlServer("Server=VLADANOVI;Database=InfoJP;Integrated Security=True;");
                optionsBuilder.UseSqlServer("Data Source=194.106.180.42,1433;Initial Catalog=infojprs_InfoJp;Integrated Security=False;User ID=infojprs_andjaLuka;Password=Andja#Luka123;Connect Timeout=15;Encrypt=False;Packet Size=4096");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AktuelniTekstovi>(entity =>
            {
                entity.ToTable("AktuelniTekstovi");

                entity.Property(e => e.Datum).HasColumnType("date");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail);

                entity.HasIndex(e => e.NormalizedUserName)
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<KalendarObaveza>(entity =>
            {
                entity.ToTable("KalendarObaveza");

                entity.Property(e => e.NaslovniDatum).HasMaxLength(500);
            });

            modelBuilder.Entity<MejlCimpPrijava>(entity =>
            {
                entity.ToTable("MejlCimpPrijava");

                entity.Property(e => e.Datum).HasColumnType("date");
            });

            modelBuilder.Entity<PitanjaIodgovori>(entity =>
            {
                entity.ToTable("PitanjaIOdgovori");
            });

            modelBuilder.Entity<Placanje>(entity =>
            {
                entity.ToTable("Placanje");

                entity.Property(e => e.Naziv).HasMaxLength(500);
            });

            modelBuilder.Entity<PravnoLice>(entity =>
            {
                entity.ToTable("PravnoLice");

                entity.Property(e => e.Pib)
                    .HasMaxLength(20)
                    .HasColumnName("PIB");

                entity.Property(e => e.PostanskiBrojImesto).HasColumnName("PostanskiBrojIMesto");

                entity.Property(e => e.UlicaIbroj).HasColumnName("UlicaIBroj");
            });

            modelBuilder.Entity<Pretplatnik>(entity =>
            {
                entity.ToTable("Pretplatnik");

                entity.Property(e => e.EmailEkonomiste).HasMaxLength(200);

                entity.Property(e => e.EmailPravnika).HasMaxLength(200);

                entity.Property(e => e.EmailPravnogLica).HasMaxLength(200);

                entity.Property(e => e.EmailRukovodioca).HasMaxLength(200);

                entity.Property(e => e.Faks).HasMaxLength(50);

                entity.Property(e => e.Pib)
                    .HasMaxLength(20)
                    .HasColumnName("PIB");

                entity.Property(e => e.PostanskiBrojImesto).HasColumnName("PostanskiBrojIMesto");

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.Property(e => e.UlicaIbroj).HasColumnName("UlicaIBroj");
            });

            modelBuilder.Entity<Pretplatum>(entity =>
            {
                entity.Property(e => e.DatumKraja).HasColumnType("date");

                entity.Property(e => e.DatumPocetka).HasColumnType("date");

                entity.HasOne(d => d.IdPlacanjeNavigation)
                    .WithMany(p => p.Pretplata)
                    .HasForeignKey(d => d.IdPlacanje)
                    .HasConstraintName("FK_Pretplata_Placanje");

                entity.HasOne(d => d.IdPretplatnikNavigation)
                    .WithMany(p => p.Pretplata)
                    .HasForeignKey(d => d.IdPretplatnik)
                    .HasConstraintName("FK_Pretplata_Pretplatnik");
            });

            modelBuilder.Entity<PrijavaSeminar>(entity =>
            {
                entity.ToTable("PrijavaSeminar");

                entity.Property(e => e.DatumPrijave).HasColumnType("date");

                entity.HasOne(d => d.IdSeminaraNavigation)
                    .WithMany(p => p.PrijavaSeminars)
                    .HasForeignKey(d => d.IdSeminara)
                    .HasConstraintName("FK_PrijavaSeminar_Seminari");

                entity.HasOne(d => d.IdUcesnikNavigation)
                    .WithMany(p => p.PrijavaSeminars)
                    .HasForeignKey(d => d.IdUcesnik)
                    .HasConstraintName("FK_PrijavaSeminar_UcesnikSeminar");
            });

            modelBuilder.Entity<PrijavaVebinar>(entity =>
            {
                entity.ToTable("PrijavaVebinar");

                entity.Property(e => e.DatumPrijave).HasColumnType("date");

                entity.HasOne(d => d.IdUcesnikaNavigation)
                    .WithMany(p => p.PrijavaVebinars)
                    .HasForeignKey(d => d.IdUcesnika)
                    .HasConstraintName("FK_PrijavaVebinar_UcesnikVebinar");

                entity.HasOne(d => d.IdVebinaraNavigation)
                    .WithMany(p => p.PrijavaVebinars)
                    .HasForeignKey(d => d.IdVebinara)
                    .HasConstraintName("FK_PrijavaVebinar_Vebinari");
            });

            modelBuilder.Entity<Seminari>(entity =>
            {
                entity.ToTable("Seminari");

                entity.Property(e => e.NazivSeminara)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<UcesnikSeminar>(entity =>
            {
                entity.ToTable("UcesnikSeminar");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Ime).HasMaxLength(100);

                entity.Property(e => e.KontaktTelefon).HasMaxLength(50);

                entity.Property(e => e.Prezime).HasMaxLength(100);

                entity.Property(e => e.RadnoMesto).HasMaxLength(200);

                entity.HasOne(d => d.IdPravnoLiceNavigation)
                    .WithMany(p => p.UcesnikSeminars)
                    .HasForeignKey(d => d.IdPravnoLice)
                    .HasConstraintName("FK_UcesnikSeminar_PravnoLice");
            });

            modelBuilder.Entity<UcesnikVebinar>(entity =>
            {
                entity.ToTable("UcesnikVebinar");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Ime).HasMaxLength(100);

                entity.Property(e => e.KontaktTelefon).HasMaxLength(50);

                entity.Property(e => e.Prezime).HasMaxLength(100);

                entity.Property(e => e.RadnoMesto).HasMaxLength(300);

                entity.HasOne(d => d.IdPravnoLiceNavigation)
                    .WithMany(p => p.UcesnikVebinars)
                    .HasForeignKey(d => d.IdPravnoLice)
                    .HasConstraintName("FK_UcesnikVebinar_PravnoLice");
            });

            modelBuilder.Entity<Urednici>(entity =>
            {
                entity.ToTable("Urednici");

                entity.Property(e => e.ImeIprezime).HasColumnName("ImeIPrezime");
            });

            modelBuilder.Entity<Vebinari>(entity =>
            {
                entity.ToTable("Vebinari");

                entity.Property(e => e.NaizvVebinara)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Vesti>(entity =>
            {
                entity.ToTable("Vesti");

                entity.Property(e => e.Datum).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
