using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAspNet_Core.Models;

namespace WebAspNet_Core.Context

{
    public partial class TokenizationServiceDAOTokenVaultContext : DbContext
    {
        public TokenizationServiceDAOTokenVaultContext()
        {
        }

        public TokenizationServiceDAOTokenVaultContext(DbContextOptions<TokenizationServiceDAOTokenVaultContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MappingLgpdtoken> MappingLgpdtoken { get; set; }
        public virtual DbSet<MappingPaymentToken> MappingPaymentToken { get; set; }
        
        public virtual DbSet<Otpadministration> Otpadministration { get; set; }
        public virtual DbSet<TokenRequestorRegistration> TokenRequestorRegistration { get; set; }
        public virtual DbSet<TokenServiceProviderConfig> TokenServiceProviderConfig { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=DESKTOP-BGBIQTU;user=sa;password=sil495798;Database=TokenizationService.DAO.TokenVault;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MappingLgpdtoken>(entity =>
            {
                entity.HasKey(e => new { e.TokenRequestorId, e.TokenReferenceId });

                entity.ToTable("MappingLGPDToken");

                entity.HasIndex(e => e.Lgpdtoken)
                    .HasName("IX_LGPDToken");

                entity.HasIndex(e => e.TokenRequestorId)
                    .HasName("IX_TokenRequestorID");

                entity.Property(e => e.TokenRequestorId)
                    .HasColumnName("TokenRequestorID")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TokenReferenceId)
                    .HasColumnName("TokenReferenceID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Bin)
                    .IsRequired()
                    .HasColumnName("BIN")
                    .HasMaxLength(6);

                entity.Property(e => e.CardHolderDataCiphered)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValidation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cpfciphered)
                    .IsRequired()
                    .HasColumnName("CPFCiphered")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Cpflength).HasColumnName("CPFLength");

                entity.Property(e => e.EventCounter).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Last4DigitsPan)
                    .IsRequired()
                    .HasColumnName("Last4DigitsPAN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lgpdtoken)
                    .IsRequired()
                    .HasColumnName("LGPDToken")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.LgpdtokenLength).HasColumnName("LGPDTokenLength");

                entity.Property(e => e.PcikeyIndex)
                    .IsRequired()
                    .HasColumnName("PCIKeyIndex")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TimerEventExpiration).HasColumnType("datetime");

                entity.Property(e => e.TokenExpirationDate)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TokenReferenceIdlength).HasColumnName("TokenReferenceIDLength");

                entity.HasOne(d => d.TokenRequestor)
                    .WithMany(p => p.MappingLgpdtoken)
                    .HasForeignKey(d => d.TokenRequestorId)
                    .HasConstraintName("FK_dbo.MappingLGPDToken_dbo.TokenRequestorRegistration_TokenRequestorID");
            });

            modelBuilder.Entity<MappingPaymentToken>(entity =>
            {
                entity.HasKey(e => new { e.TokenRequestorId, e.TokenReferenceId });

                entity.HasIndex(e => e.PaymentToken)
                    .HasName("IX_PaymentToken");

                entity.HasIndex(e => e.TokenRequestorId)
                    .HasName("IX_TokenRequestorID");

                entity.Property(e => e.TokenRequestorId)
                    .HasColumnName("TokenRequestorID")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TokenReferenceId)
                    .HasColumnName("TokenReferenceID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AccountAndCardHolderDataAndDeviceDataCiphered)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Atc).HasColumnName("ATC");

                entity.Property(e => e.Bin)
                    .IsRequired()
                    .HasColumnName("BIN")
                    .HasMaxLength(6);

                entity.Property(e => e.CodeValidation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EmvkeyIndex)
                    .IsRequired()
                    .HasColumnName("EMVKeyIndex")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EventCounter).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Last4DigitsPan)
                    .IsRequired()
                    .HasColumnName("Last4DigitsPAN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Panciphered)
                    .IsRequired()
                    .HasColumnName("PANCiphered")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PanexpirationDateCiphered)
                    .IsRequired()
                    .HasColumnName("PANExpirationDateCiphered")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Panlength).HasColumnName("PANLength");

                entity.Property(e => e.PaymentToken)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.PcikeyIndex)
                    .IsRequired()
                    .HasColumnName("PCIKeyIndex")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TimerEventExpiration).HasColumnType("datetime");

                entity.Property(e => e.TokenExpirationDate)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TokenReferenceIdlength).HasColumnName("TokenReferenceIDLength");

                entity.HasOne(d => d.TokenRequestor)
                    .WithMany(p => p.MappingPaymentToken)
                    .HasForeignKey(d => d.TokenRequestorId)
                    .HasConstraintName("FK_dbo.MappingPaymentToken_dbo.TokenRequestorRegistration_TokenRequestorID");
            });

            

            modelBuilder.Entity<Otpadministration>(entity =>
            {
                entity.HasKey(e => e.OtpadmId);

                entity.ToTable("OTPAdministration");

                entity.Property(e => e.OtpadmId)
                    .HasColumnName("OTPAdmId")
                    .HasMaxLength(96)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastDateBlocked).HasColumnType("datetime");

                entity.Property(e => e.LastDateChangePin).HasColumnType("datetime");

                entity.Property(e => e.LastDateLogin).HasColumnType("datetime");

                entity.Property(e => e.PasswordAdm)
                    .HasMaxLength(96)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TokenRequestorRegistration>(entity =>
            {
                entity.HasKey(e => e.TokenRequestorId);

                entity.Property(e => e.TokenRequestorId)
                    .HasColumnName("TokenRequestorID")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Bin)
                    .HasColumnName("BIN")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EmvkeyIndex)
                    .IsRequired()
                    .HasColumnName("EMVKeyIndex")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FinalRangeBin)
                    .IsRequired()
                    .HasColumnName("FinalRangeBIN")
                    .HasMaxLength(9);

                entity.Property(e => e.InitialRangeBin)
                    .IsRequired()
                    .HasColumnName("InitialRangeBIN")
                    .HasMaxLength(9);

                entity.Property(e => e.LabelImkac)
                    .IsRequired()
                    .HasColumnName("LabelIMKac")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.LabelPci)
                    .IsRequired()
                    .HasColumnName("LabelPCI")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PcikeyIndex)
                    .IsRequired()
                    .HasColumnName("PCIKeyIndex")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TokenBin)
                    .HasColumnName("TokenBIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionAmountMaximumPolicy)
                    .IsRequired()
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<TokenServiceProviderConfig>(entity =>
            {
                entity.HasKey(e => e.TokenServiceProviderCode);

                entity.Property(e => e.TokenServiceProviderCode)
                    .HasMaxLength(3)
                    .ValueGeneratedNever();
            });
        }
    }
}
