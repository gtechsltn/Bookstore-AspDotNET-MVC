using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore_AspDotNET_MVC.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "author",
                columns: table => new
                {
                    id_author = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    author_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__author__7411B254ED283315", x => x.id_author);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    category_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "discount",
                columns: table => new
                {
                    id_discount = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startTime = table.Column<DateTime>(type: "date", nullable: false),
                    endTime = table.Column<DateTime>(type: "date", nullable: false),
                    contentDiscount = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    discount_percent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discount", x => x.id_discount);
                });

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    id_payment = table.Column<long>(type: "bigint", nullable: false),
                    payment_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    payment_status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment", x => x.id_payment);
                });

            migrationBuilder.CreateTable(
                name: "province",
                columns: table => new
                {
                    province_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    province_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    province_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_province", x => x.province_id);
                });

            migrationBuilder.CreateTable(
                name: "publishing_company",
                columns: table => new
                {
                    id_company = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__publishi__5D0E9F0627D8EE34", x => x.id_company);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id_role = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role_name = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__roles__3D48441D607836CF", x => x.id_role);
                });

            migrationBuilder.CreateTable(
                name: "userinfor",
                columns: table => new
                {
                    user_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    age = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    gender = table.Column<int>(type: "int", fixedLength: true, nullable: false),
                    password = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    phone = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userinfo__B9BE370FD79949DA", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "district",
                columns: table => new
                {
                    district_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    district_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    district_prefix = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    province_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_district", x => x.district_id);
                    table.ForeignKey(
                        name: "FK_district_province",
                        column: x => x.province_id,
                        principalTable: "province",
                        principalColumn: "province_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    id_book = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    book_name = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    describe_book = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    picture = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    price = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
                    publish_day = table.Column<DateTime>(type: "date", nullable: false),
                    total_quantity = table.Column<int>(type: "int", nullable: false),
                    id_author = table.Column<long>(type: "bigint", nullable: false),
                    category_id = table.Column<long>(type: "bigint", nullable: false),
                    id_company = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__book__DAE712E8BD98D29E", x => x.id_book);
                    table.ForeignKey(
                        name: "FK_BOOK_AUTHOR",
                        column: x => x.id_author,
                        principalTable: "author",
                        principalColumn: "id_author",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOOK_CATEGORY",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOOK_COMANY",
                        column: x => x.id_company,
                        principalTable: "publishing_company",
                        principalColumn: "id_company",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_role",
                columns: table => new
                {
                    user_role_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_role = table.Column<long>(type: "bigint", nullable: true),
                    user_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_role", x => x.user_role_id);
                    table.ForeignKey(
                        name: "FK_USERROLE_ROLE",
                        column: x => x.id_role,
                        principalTable: "roles",
                        principalColumn: "id_role",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_USERROLE_USERINFOR",
                        column: x => x.user_id,
                        principalTable: "userinfor",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ward",
                columns: table => new
                {
                    ward_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ward_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ward_prefix = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    district_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ward", x => x.ward_id);
                    table.ForeignKey(
                        name: "FK_ward_district",
                        column: x => x.district_id,
                        principalTable: "district",
                        principalColumn: "district_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "book_discount",
                columns: table => new
                {
                    id_book = table.Column<long>(type: "bigint", nullable: false),
                    id_discount = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book_discount", x => new { x.id_book, x.id_discount });
                    table.ForeignKey(
                        name: "FK_book_discount_book",
                        column: x => x.id_book,
                        principalTable: "book",
                        principalColumn: "id_book",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_book_discount_discount",
                        column: x => x.id_discount,
                        principalTable: "discount",
                        principalColumn: "id_discount",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    item_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantity_books = table.Column<int>(type: "int", nullable: false),
                    id_book = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.item_id);
                    table.ForeignKey(
                        name: "FK_ITEM_BOOK",
                        column: x => x.id_book,
                        principalTable: "book",
                        principalColumn: "id_book",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ITEM_USERINFOR",
                        column: x => x.user_id,
                        principalTable: "userinfor",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "review",
                columns: table => new
                {
                    id_book = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    star = table.Column<int>(type: "int", nullable: false),
                    time = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__review__317CF198E2C01A3A", x => new { x.id_book, x.user_id });
                    table.ForeignKey(
                        name: "FK_REVIEW_BOOK",
                        column: x => x.id_book,
                        principalTable: "book",
                        principalColumn: "id_book",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_REVIEW_USERINFOR",
                        column: x => x.user_id,
                        principalTable: "userinfor",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "address_detail",
                columns: table => new
                {
                    address_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address_name = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    warrd_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__address___CAA247C8D3EE980F", x => x.address_id);
                    table.ForeignKey(
                        name: "FK_address_detail_ward",
                        column: x => x.warrd_id,
                        principalTable: "ward",
                        principalColumn: "ward_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    order_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_of_customer = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
                    order_day = table.Column<DateTime>(type: "date", nullable: true),
                    order_status = table.Column<int>(type: "int", nullable: true),
                    phone_of_customer = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    total_price = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
                    address_id = table.Column<long>(type: "bigint", nullable: true),
                    user_id = table.Column<long>(type: "bigint", nullable: true),
                    id_payment = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_ODERS_ADDRESSDETAIL",
                        column: x => x.address_id,
                        principalTable: "address_detail",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_payment",
                        column: x => x.id_payment,
                        principalTable: "payment",
                        principalColumn: "id_payment",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORDERS_USERINFOR",
                        column: x => x.user_id,
                        principalTable: "userinfor",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_address",
                columns: table => new
                {
                    address_id = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__user_add__2139A4B8579DB4A4", x => new { x.address_id, x.user_id });
                    table.ForeignKey(
                        name: "FK_USERADDRESS_ADDRESSDETAIL",
                        column: x => x.address_id,
                        principalTable: "address_detail",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_USERADDRESS_USERINFOR",
                        column: x => x.user_id,
                        principalTable: "userinfor",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "order_detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    id_book = table.Column<long>(type: "bigint", nullable: false),
                    order_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_detail", x => x.id);
                    table.ForeignKey(
                        name: "FK_ORDERDETAIL_BOOK",
                        column: x => x.id_book,
                        principalTable: "book",
                        principalColumn: "id_book",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDERDETAIL_ORDERS",
                        column: x => x.order_id,
                        principalTable: "orders",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_address_detail_warrd_id",
                table: "address_detail",
                column: "warrd_id");

            migrationBuilder.CreateIndex(
                name: "IX_book_category_id",
                table: "book",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_book_id_author",
                table: "book",
                column: "id_author");

            migrationBuilder.CreateIndex(
                name: "IX_book_id_company",
                table: "book",
                column: "id_company");

            migrationBuilder.CreateIndex(
                name: "IX_book_discount_id_discount",
                table: "book_discount",
                column: "id_discount");

            migrationBuilder.CreateIndex(
                name: "_province_id",
                table: "district",
                column: "province_id");

            migrationBuilder.CreateIndex(
                name: "IX_items_id_book",
                table: "items",
                column: "id_book");

            migrationBuilder.CreateIndex(
                name: "IX_items_user_id",
                table: "items",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_detail_id_book",
                table: "order_detail",
                column: "id_book");

            migrationBuilder.CreateIndex(
                name: "IX_order_detail_order_id",
                table: "order_detail",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_address_id",
                table: "orders",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_id_payment",
                table: "orders",
                column: "id_payment");

            migrationBuilder.CreateIndex(
                name: "IX_orders_user_id",
                table: "orders",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_review_user_id",
                table: "review",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_address_user_id",
                table: "user_address",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_id_role",
                table: "user_role",
                column: "id_role");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_user_id",
                table: "user_role",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ward_district_id",
                table: "ward",
                column: "district_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book_discount");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "order_detail");

            migrationBuilder.DropTable(
                name: "review");

            migrationBuilder.DropTable(
                name: "user_address");

            migrationBuilder.DropTable(
                name: "user_role");

            migrationBuilder.DropTable(
                name: "discount");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "address_detail");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropTable(
                name: "userinfor");

            migrationBuilder.DropTable(
                name: "author");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "publishing_company");

            migrationBuilder.DropTable(
                name: "ward");

            migrationBuilder.DropTable(
                name: "district");

            migrationBuilder.DropTable(
                name: "province");
        }
    }
}
