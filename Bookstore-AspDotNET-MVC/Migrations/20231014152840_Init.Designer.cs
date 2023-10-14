﻿// <auto-generated />
using System;
using Bookstore_AspDotNET_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookstore_AspDotNET_MVC.Migrations
{
    [DbContext(typeof(BOOKSTOREContext))]
    [Migration("20231014152840_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.AddressDetail", b =>
                {
                    b.Property<long>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("address_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressName")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("address_name");

                    b.Property<long>("WarrdId")
                        .HasColumnType("bigint")
                        .HasColumnName("warrd_id");

                    b.HasKey("AddressId")
                        .HasName("PK__address___CAA247C8D3EE980F");

                    b.HasIndex("WarrdId");

                    b.ToTable("address_detail");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Author", b =>
                {
                    b.Property<long>("IdAuthor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_author")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("author_name");

                    b.HasKey("IdAuthor")
                        .HasName("PK__author__7411B254ED283315");

                    b.ToTable("author");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Book", b =>
                {
                    b.Property<long>("IdBook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_book")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("book_name");

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint")
                        .HasColumnName("category_id");

                    b.Property<string>("DescribeBook")
                        .HasColumnType("nvarchar(MAX)")
                        .HasColumnName("describe_book");

                    b.Property<long>("IdAuthor")
                        .HasColumnType("bigint")
                        .HasColumnName("id_author");

                    b.Property<long>("IdCompany")
                        .HasColumnType("bigint")
                        .HasColumnName("id_company");

                    b.Property<string>("Picture")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("picture");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(19,2)")
                        .HasColumnName("price");

                    b.Property<DateTime>("PublishDay")
                        .HasColumnType("date")
                        .HasColumnName("publish_day");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int")
                        .HasColumnName("total_quantity");

                    b.HasKey("IdBook")
                        .HasName("PK__book__DAE712E8BD98D29E");

                    b.HasIndex("CategoryId");

                    b.HasIndex("IdAuthor");

                    b.HasIndex("IdCompany");

                    b.ToTable("book");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.BookDiscount", b =>
                {
                    b.Property<long>("IdBook")
                        .HasColumnType("bigint")
                        .HasColumnName("id_book");

                    b.Property<long>("IdDiscount")
                        .HasColumnType("bigint")
                        .HasColumnName("id_discount");

                    b.HasKey("IdBook", "IdDiscount");

                    b.HasIndex("IdDiscount");

                    b.ToTable("book_discount");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Category", b =>
                {
                    b.Property<long>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("category_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.HasKey("CategoryId");

                    b.ToTable("category");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Discount", b =>
                {
                    b.Property<long>("IdDiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_discount")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentDiscount")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("contentDiscount");

                    b.Property<int>("DiscountPercent")
                        .HasColumnType("int")
                        .HasColumnName("discount_percent");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("date")
                        .HasColumnName("endTime");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("date")
                        .HasColumnName("startTime");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.HasKey("IdDiscount")
                        .HasName("PK_discount");

                    b.ToTable("discount");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.District", b =>
                {
                    b.Property<long>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("district_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DistrictName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("district_name");

                    b.Property<string>("DistrictPrefix")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("district_prefix");

                    b.Property<long?>("ProvinceId")
                        .HasColumnType("bigint")
                        .HasColumnName("province_id");

                    b.HasKey("DistrictId");

                    b.HasIndex(new[] { "ProvinceId" }, "_province_id");

                    b.ToTable("district");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Item", b =>
                {
                    b.Property<long>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("item_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("IdBook")
                        .HasColumnType("bigint")
                        .HasColumnName("id_book");

                    b.Property<int>("QuantityBooks")
                        .HasColumnType("int")
                        .HasColumnName("quantity_books");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("ItemId");

                    b.HasIndex("IdBook");

                    b.HasIndex("UserId");

                    b.ToTable("items");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("order_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AddressId")
                        .HasColumnType("bigint")
                        .HasColumnName("address_id");

                    b.Property<long?>("IdPayment")
                        .HasColumnType("bigint")
                        .HasColumnName("id_payment");

                    b.Property<string>("NameOfCustomer")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("name_of_customer");

                    b.Property<DateTime?>("OrderDay")
                        .HasColumnType("date")
                        .HasColumnName("order_day");

                    b.Property<int?>("OrderStatus")
                        .HasColumnType("int")
                        .HasColumnName("order_status");

                    b.Property<string>("PhoneOfCustomer")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("phone_of_customer");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(19,2)")
                        .HasColumnName("total_price");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("OrderId");

                    b.HasIndex("AddressId");

                    b.HasIndex("IdPayment");

                    b.HasIndex("UserId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.OrderDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("IdBook")
                        .HasColumnType("bigint")
                        .HasColumnName("id_book");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint")
                        .HasColumnName("order_id");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(19,2)")
                        .HasColumnName("price");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.HasIndex("IdBook");

                    b.HasIndex("OrderId");

                    b.ToTable("order_detail");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Payment", b =>
                {
                    b.Property<long>("IdPayment")
                        .HasColumnType("bigint")
                        .HasColumnName("id_payment");

                    b.Property<int?>("PaymentStatus")
                        .HasColumnType("int")
                        .HasColumnName("payment_status");

                    b.Property<string>("PaymentType")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("payment_type");

                    b.HasKey("IdPayment");

                    b.ToTable("payment");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Province", b =>
                {
                    b.Property<long>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("province_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProvinceCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("province_code");

                    b.Property<string>("ProvinceName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("province_name");

                    b.HasKey("ProvinceId");

                    b.ToTable("province");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.PublishingCompany", b =>
                {
                    b.Property<long>("IdCompany")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_company")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("company_name");

                    b.HasKey("IdCompany")
                        .HasName("PK__publishi__5D0E9F0627D8EE34");

                    b.ToTable("publishing_company");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Review", b =>
                {
                    b.Property<long>("IdBook")
                        .HasColumnType("bigint")
                        .HasColumnName("id_book");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.Property<string>("Comments")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("comments");

                    b.Property<int>("Star")
                        .HasColumnType("int")
                        .HasColumnName("star");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("datetime")
                        .HasColumnName("time");

                    b.HasKey("IdBook", "UserId")
                        .HasName("PK__review__317CF198E2C01A3A");

                    b.HasIndex("UserId");

                    b.ToTable("review");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Role", b =>
                {
                    b.Property<long>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_role")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("role_name");

                    b.HasKey("IdRole")
                        .HasName("PK__roles__3D48441D607836CF");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.UserAddress", b =>
                {
                    b.Property<long>("AddressId")
                        .HasColumnType("bigint")
                        .HasColumnName("address_id");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("AddressId", "UserId")
                        .HasName("PK__user_add__2139A4B8579DB4A4");

                    b.HasIndex("UserId");

                    b.ToTable("user_address");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.UserRole", b =>
                {
                    b.Property<long>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("user_role_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("IdRole")
                        .HasColumnType("bigint")
                        .HasColumnName("id_role");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("UserRoleId");

                    b.HasIndex("IdRole");

                    b.HasIndex("UserId");

                    b.ToTable("user_role");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Userinfor", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("user_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("gender")
                        .IsFixedLength(true);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("phone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("username");

                    b.HasKey("UserId")
                        .HasName("PK__userinfo__B9BE370FD79949DA");

                    b.ToTable("userinfor");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Ward", b =>
                {
                    b.Property<long>("WardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ward_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("DistrictId")
                        .HasColumnType("bigint")
                        .HasColumnName("district_id");

                    b.Property<string>("WardName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ward_name");

                    b.Property<string>("WardPrefix")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("ward_prefix");

                    b.HasKey("WardId");

                    b.HasIndex("DistrictId");

                    b.ToTable("ward");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.AddressDetail", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Ward", "Warrd")
                        .WithMany("AddressDetails")
                        .HasForeignKey("WarrdId")
                        .HasConstraintName("FK_address_detail_ward")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Warrd");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Book", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_BOOK_CATEGORY")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Author", "IdAuthorNavigation")
                        .WithMany("Books")
                        .HasForeignKey("IdAuthor")
                        .HasConstraintName("FK_BOOK_AUTHOR")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookstore_AspDotNET_MVC.Models.PublishingCompany", "IdCompanyNavigation")
                        .WithMany("Books")
                        .HasForeignKey("IdCompany")
                        .HasConstraintName("FK_BOOK_COMANY")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("IdAuthorNavigation");

                    b.Navigation("IdCompanyNavigation");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.BookDiscount", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Book", "IdBookNavigation")
                        .WithMany("BookDiscounts")
                        .HasForeignKey("IdBook")
                        .HasConstraintName("FK_book_discount_book")
                        .IsRequired();

                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Discount", "IdDiscountNavigation")
                        .WithMany("BookDiscounts")
                        .HasForeignKey("IdDiscount")
                        .HasConstraintName("FK_book_discount_discount")
                        .IsRequired();

                    b.Navigation("IdBookNavigation");

                    b.Navigation("IdDiscountNavigation");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.District", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceId")
                        .HasConstraintName("FK_district_province");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Item", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Book", "IdBookNavigation")
                        .WithMany("Items")
                        .HasForeignKey("IdBook")
                        .HasConstraintName("FK_ITEM_BOOK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Userinfor", "User")
                        .WithMany("Items")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_ITEM_USERINFOR")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdBookNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Order", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.AddressDetail", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId")
                        .HasConstraintName("FK_ODERS_ADDRESSDETAIL");

                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Payment", "IdPaymentNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("IdPayment")
                        .HasConstraintName("FK_orders_payment");

                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Userinfor", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_ORDERS_USERINFOR");

                    b.Navigation("Address");

                    b.Navigation("IdPaymentNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.OrderDetail", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Book", "IdBookNavigation")
                        .WithMany("OrderDetails")
                        .HasForeignKey("IdBook")
                        .HasConstraintName("FK_ORDERDETAIL_BOOK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_ORDERDETAIL_ORDERS")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdBookNavigation");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Review", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Book", "IdBookNavigation")
                        .WithMany("Reviews")
                        .HasForeignKey("IdBook")
                        .HasConstraintName("FK_REVIEW_BOOK")
                        .IsRequired();

                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Userinfor", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_REVIEW_USERINFOR")
                        .IsRequired();

                    b.Navigation("IdBookNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.UserAddress", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.AddressDetail", "Address")
                        .WithMany("UserAddresses")
                        .HasForeignKey("AddressId")
                        .HasConstraintName("FK_USERADDRESS_ADDRESSDETAIL")
                        .IsRequired();

                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Userinfor", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_USERADDRESS_USERINFOR")
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.UserRole", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Role", "IdRoleNavigation")
                        .WithMany("UserRoles")
                        .HasForeignKey("IdRole")
                        .HasConstraintName("FK_USERROLE_ROLE");

                    b.HasOne("Bookstore_AspDotNET_MVC.Models.Userinfor", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_USERROLE_USERINFOR");

                    b.Navigation("IdRoleNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Ward", b =>
                {
                    b.HasOne("Bookstore_AspDotNET_MVC.Models.District", "District")
                        .WithMany("Wards")
                        .HasForeignKey("DistrictId")
                        .HasConstraintName("FK_ward_district")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.AddressDetail", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("UserAddresses");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Book", b =>
                {
                    b.Navigation("BookDiscounts");

                    b.Navigation("Items");

                    b.Navigation("OrderDetails");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Discount", b =>
                {
                    b.Navigation("BookDiscounts");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.District", b =>
                {
                    b.Navigation("Wards");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Payment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Province", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.PublishingCompany", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Userinfor", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");

                    b.Navigation("UserAddresses");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Bookstore_AspDotNET_MVC.Models.Ward", b =>
                {
                    b.Navigation("AddressDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
