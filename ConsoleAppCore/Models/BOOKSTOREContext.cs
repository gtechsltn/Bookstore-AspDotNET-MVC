using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class BOOKSTOREContext : DbContext
    {
        public BOOKSTOREContext()
        {
        }

        public BOOKSTOREContext(DbContextOptions<BOOKSTOREContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddressDetail> AddressDetails { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookDiscount> BookDiscounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<PublishingCompany> PublishingCompanies { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserAddress> UserAddresses { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Userinfor> Userinfors { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=BOOKSTORE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressDetail>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK__address___CAA247C8D3EE980F");

                entity.ToTable("address_detail");

                entity.HasIndex(e => e.WarrdId, "IX_address_detail_warrd_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.AddressName)
                    .HasMaxLength(45)
                    .HasColumnName("address_name");

                entity.Property(e => e.WarrdId).HasColumnName("warrd_id");

                entity.HasOne(d => d.Warrd)
                    .WithMany(p => p.AddressDetails)
                    .HasForeignKey(d => d.WarrdId)
                    .HasConstraintName("FK_address_detail_ward");
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.IdAuthor)
                    .HasName("PK__author__7411B254ED283315");

                entity.ToTable("author");

                entity.Property(e => e.IdAuthor).HasColumnName("id_author");

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(50)
                    .HasColumnName("author_name");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.IdBook)
                    .HasName("PK__book__DAE712E8BD98D29E");

                entity.ToTable("book");

                entity.HasIndex(e => e.CategoryId, "IX_book_category_id");

                entity.HasIndex(e => e.IdAuthor, "IX_book_id_author");

                entity.HasIndex(e => e.IdCompany, "IX_book_id_company");

                entity.Property(e => e.IdBook).HasColumnName("id_book");

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("book_name");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.DescribeBook).HasColumnName("describe_book");

                entity.Property(e => e.IdAuthor).HasColumnName("id_author");

                entity.Property(e => e.IdCompany).HasColumnName("id_company");

                entity.Property(e => e.Picture)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("picture");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PublishDay)
                    .HasColumnType("date")
                    .HasColumnName("publish_day");

                entity.Property(e => e.TotalQuantity).HasColumnName("total_quantity");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_BOOK_CATEGORY");

                entity.HasOne(d => d.IdAuthorNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.IdAuthor)
                    .HasConstraintName("FK_BOOK_AUTHOR");

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.IdCompany)
                    .HasConstraintName("FK_BOOK_COMANY");
            });

            modelBuilder.Entity<BookDiscount>(entity =>
            {
                entity.HasKey(e => new { e.IdBook, e.IdDiscount });

                entity.ToTable("book_discount");

                entity.HasIndex(e => e.IdDiscount, "IX_book_discount_id_discount");

                entity.Property(e => e.IdBook).HasColumnName("id_book");

                entity.Property(e => e.IdDiscount).HasColumnName("id_discount");

                entity.HasOne(d => d.IdBookNavigation)
                    .WithMany(p => p.BookDiscounts)
                    .HasForeignKey(d => d.IdBook)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_book_discount_book");

                entity.HasOne(d => d.IdDiscountNavigation)
                    .WithMany(p => p.BookDiscounts)
                    .HasForeignKey(d => d.IdDiscount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_book_discount_discount");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.HasKey(e => e.IdDiscount);

                entity.ToTable("discount");

                entity.Property(e => e.IdDiscount).HasColumnName("id_discount");

                entity.Property(e => e.ContentDiscount)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("contentDiscount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.EndTime)
                    .HasColumnType("date")
                    .HasColumnName("endTime");

                entity.Property(e => e.StartTime)
                    .HasColumnType("date")
                    .HasColumnName("startTime");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("district");

                entity.HasIndex(e => e.ProvinceId, "_province_id");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.DistrictName)
                    .HasMaxLength(100)
                    .HasColumnName("district_name");

                entity.Property(e => e.DistrictPrefix)
                    .HasMaxLength(100)
                    .HasColumnName("district_prefix");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_district_province");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("items");

                entity.HasIndex(e => e.IdBook, "IX_items_id_book");

                entity.HasIndex(e => e.UserId, "IX_items_user_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.IdBook).HasColumnName("id_book");

                entity.Property(e => e.QuantityBooks).HasColumnName("quantity_books");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.IdBookNavigation)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.IdBook)
                    .HasConstraintName("FK_ITEM_BOOK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ITEM_USERINFOR");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.HasIndex(e => e.AddressId, "IX_orders_address_id");

                entity.HasIndex(e => e.IdPayment, "IX_orders_id_payment");

                entity.HasIndex(e => e.UserId, "IX_orders_user_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.IdPayment).HasColumnName("id_payment");

                entity.Property(e => e.NameOfCustomer)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("name_of_customer");

                entity.Property(e => e.OrderDay)
                    .HasColumnType("date")
                    .HasColumnName("order_day");

                entity.Property(e => e.OrderStatus).HasColumnName("order_status");

                entity.Property(e => e.PhoneOfCustomer)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone_of_customer");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("total_price");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_ODERS_ADDRESSDETAIL");

                entity.HasOne(d => d.IdPaymentNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdPayment)
                    .HasConstraintName("FK_orders_payment");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ORDERS_USERINFOR");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("order_detail");

                entity.HasIndex(e => e.IdBook, "IX_order_detail_id_book");

                entity.HasIndex(e => e.OrderId, "IX_order_detail_order_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdBook).HasColumnName("id_book");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.IdBookNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.IdBook)
                    .HasConstraintName("FK_ORDERDETAIL_BOOK");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_ORDERDETAIL_ORDERS");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.IdPayment);

                entity.ToTable("payment");

                entity.Property(e => e.IdPayment)
                    .ValueGeneratedNever()
                    .HasColumnName("id_payment");

                entity.Property(e => e.PaymentStatus).HasColumnName("payment_status");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("payment_type");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("province");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(20)
                    .HasColumnName("province_code");

                entity.Property(e => e.ProvinceName)
                    .HasMaxLength(100)
                    .HasColumnName("province_name");
            });

            modelBuilder.Entity<PublishingCompany>(entity =>
            {
                entity.HasKey(e => e.IdCompany)
                    .HasName("PK__publishi__5D0E9F0627D8EE34");

                entity.ToTable("publishing_company");

                entity.Property(e => e.IdCompany).HasColumnName("id_company");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(45)
                    .HasColumnName("company_name");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => new { e.IdBook, e.UserId })
                    .HasName("PK__review__317CF198E2C01A3A");

                entity.ToTable("review");

                entity.HasIndex(e => e.UserId, "IX_review_user_id");

                entity.Property(e => e.IdBook).HasColumnName("id_book");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .HasColumnName("comments");

                entity.Property(e => e.Star).HasColumnName("star");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.HasOne(d => d.IdBookNavigation)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.IdBook)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REVIEW_BOOK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REVIEW_USERINFOR");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__roles__3D48441D607836CF");

                entity.ToTable("roles");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.HasKey(e => new { e.AddressId, e.UserId })
                    .HasName("PK__user_add__2139A4B8579DB4A4");

                entity.ToTable("user_address");

                entity.HasIndex(e => e.UserId, "IX_user_address_user_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USERADDRESS_ADDRESSDETAIL");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USERADDRESS_USERINFOR");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("user_role");

                entity.HasIndex(e => e.IdRole, "IX_user_role_id_role");

                entity.HasIndex(e => e.UserId, "IX_user_role_user_id");

                entity.Property(e => e.UserRoleId).HasColumnName("user_role_id");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK_USERROLE_ROLE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_USERROLE_USERINFOR");
            });

            modelBuilder.Entity<Userinfor>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__userinfo__B9BE370FD79949DA");

                entity.ToTable("userinfor");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.ToTable("ward");

                entity.HasIndex(e => e.DistrictId, "IX_ward_district_id");

                entity.Property(e => e.WardId).HasColumnName("ward_id");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.WardName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ward_name");

                entity.Property(e => e.WardPrefix)
                    .HasMaxLength(20)
                    .HasColumnName("ward_prefix");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Wards)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_ward_district");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
