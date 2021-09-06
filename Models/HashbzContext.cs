using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hazhbz.Models
{
    public partial class HashbzContext : DbContext
    {
        public HashbzContext()
        {
        }

        public HashbzContext(DbContextOptions<HashbzContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Affiliate> Affiliate { get; set; }
        public virtual DbSet<AffiliateProducts> AffiliateProducts { get; set; }
        public virtual DbSet<AffiliateProductsV> AffiliateProductsV { get; set; }
        public virtual DbSet<Apdetails> Apdetails { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<MediaType> MediaType { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ProductImageVideo> ProductImageVideo { get; set; }
        public virtual DbSet<ProductVideo> ProductVideo { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreUser> StoreUser { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<Subscription> Subscription { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              //  optionsBuilder.UseSqlServer("Server=LAPTOP-ATCC4QH4;Database=Hashbz;User Id=sa; Password=kenw000d;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Affiliate>(entity =>
            {
                entity.Property(e => e.AffiliateId).HasColumnName("AffiliateID");

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<AffiliateProducts>(entity =>
            {
                entity.HasKey(e => e.AffiliateProductId);

                entity.Property(e => e.AffiliateProductId).HasColumnName("AffiliateProductID");

                entity.Property(e => e.AffiliateId).HasColumnName("AffiliateID");

                entity.Property(e => e.Doc)
                    .HasColumnName("DOC")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Urltitle).HasColumnName("URLTitle");
            });

            modelBuilder.Entity<AffiliateProductsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AffiliateProducts_V");

                entity.Property(e => e.AffiliateId).HasColumnName("AffiliateID");

                entity.Property(e => e.AffiliateProductId).HasColumnName("AffiliateProductID");

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.Doc)
                    .HasColumnName("DOC")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Urltitle).HasColumnName("URLTitle");

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<Apdetails>(entity =>
            {
                entity.ToTable("APDetails");

                entity.Property(e => e.ApdetailsId).HasColumnName("APDetailsID");

                entity.Property(e => e.AffiliateProductsId).HasColumnName("AffiliateProductsID");

                entity.Property(e => e.MediaTypeId).HasColumnName("MediaTypeID");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category1)
                    .HasColumnName("Category")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.City1)
                    .HasColumnName("City")
                    .HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_City_Country");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Country1)
                    .HasColumnName("Country")
                    .HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(255);

                entity.Property(e => e.CurrencyCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.BlockNo).HasMaxLength(50);

                entity.Property(e => e.BuildingNo).HasMaxLength(50);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FlatVillaNo).HasMaxLength(50);

                entity.Property(e => e.Landmark).HasMaxLength(50);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RoadNo).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Customers_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Customers_Country");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Location1)
                    .HasColumnName("Location")
                    .HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Location_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Location_Country");
            });

            modelBuilder.Entity<MediaType>(entity =>
            {
                entity.Property(e => e.MediaTypeId).HasColumnName("MediaTypeID");

                entity.Property(e => e.MediaType1)
                    .HasColumnName("MediaType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductTitle).HasColumnType("ntext");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetails_Orders");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.BlockNo).HasMaxLength(50);

                entity.Property(e => e.BuildingNo).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FlatVillaNo).HasMaxLength(50);

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Landmark).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RoadNo).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.Amount).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PackageName).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.Property(e => e.ProductImageId).HasColumnName("ProductImageID");

                entity.Property(e => e.CoverPic).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageExtension).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<ProductImageVideo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductImageVideo");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ImageExtension).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductImageId).HasColumnName("ProductImageID");

                entity.Property(e => e.ProductUrl).HasColumnName("ProductURL");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VideoId).HasColumnName("VideoID");

                entity.Property(e => e.YoutubeUrl)
                    .HasColumnName("YoutubeURL")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ProductVideo>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.Property(e => e.VideoId).HasColumnName("VideoID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.YoutubeUrl)
                    .HasColumnName("YoutubeURL")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Products_Category");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_Products_SubCategory");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.StoreId)
                    .HasColumnName("StoreID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Building).HasMaxLength(300);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CommercialName).HasMaxLength(300);

                entity.Property(e => e.CommercialRegNo).HasMaxLength(300);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DisplayEmail)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayPhone)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(50);

                entity.Property(e => e.FacebookUrl).HasColumnName("FacebookURL");

                entity.Property(e => e.GooglePlusUrl).HasColumnName("GooglePlusURL");

                entity.Property(e => e.InstagramUrl).HasColumnName("InstagramURL");

                entity.Property(e => e.Landmark).HasMaxLength(300);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.Road).HasMaxLength(300);

                entity.Property(e => e.StoreName).HasMaxLength(300);

                entity.Property(e => e.StoreNo).ValueGeneratedOnAdd();

                entity.Property(e => e.TaxNo).HasMaxLength(300);

                entity.Property(e => e.TwitterUrl).HasColumnName("TwitterURL");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Store_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Store_Country");
            });

            modelBuilder.Entity<StoreUser>(entity =>
            {
                entity.Property(e => e.StoreUserId).HasColumnName("StoreUserID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreUser)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_StoreUser_Store");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StoreUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_StoreUser_Users");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SubCategory")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_SubCategory_Category");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Subscription)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subscription_Store");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.EmailId)
                    .HasName("emailuniq")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
