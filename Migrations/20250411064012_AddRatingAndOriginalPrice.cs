using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductListApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingAndOriginalPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "RatingCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name", "OriginalPrice", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { "Graphic t-shirt with colorful rainbow pattern", "/images/gradient-tshirt.jpg", "Gradient Graphic T-shirt", null, 145m, 25, 3.8999999999999999, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name", "OriginalPrice", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { "Classic polo shirt with contrast tipping", "/images/polo-tipping.jpg", "Polo with Tipping Details", null, 180m, 30, 4.5, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name", "OriginalPrice", "Price", "Rating", "RatingCount" },
                values: new object[] { "Striped t-shirt with raglan sleeves", "/images/black-striped-tshirt.jpg", "Black Striped T-shirt", 160m, 120m, 5.0, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name", "OriginalPrice", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { "Skinny fit stretch denim jeans", "/images/skinny-jeans.jpg", "Skinny Fit Jeans", 260m, 240m, 15, 3.5, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name", "OriginalPrice", "Price", "Rating", "RatingCount" },
                values: new object[] { "Classic checkered pattern long sleeve shirt", "/images/checkered-shirt.jpg", "Checkered Shirt", null, 180m, 4.5999999999999996, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name", "OriginalPrice", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { "Orange striped t-shirt with contrast sleeves", "/images/sleeve-striped-tshirt.jpg", "Sleeve Striped T-shirt", 160m, 130m, 22, 4.5, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name", "OriginalPrice", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { "Vertical striped long sleeve button-up shirt", "/images/vertical-striped-shirt.jpg", "Vertical Striped Shirt", 232m, 212m, 12, 5.0, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name", "OriginalPrice", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { "Orange graphic t-shirt with printed design", "/images/courage-tshirt.jpg", "Courage Graphic T-shirt", null, 145m, 20, 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name", "OriginalPrice", "Price", "Quantity", "Rating", "RatingCount" },
                values: new object[] { "Classic denim bermuda shorts", "/images/bermuda-shorts.jpg", "Loose Fit Bermuda Shorts", null, 80m, 25, 3.0, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RatingCount",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Laptop cao cấp với màn hình 13 inch, CPU Intel Core i7", "/images/laptop-dell.jpg", "Laptop Dell XPS 13", 1299.99m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Điện thoại thông minh với camera tiên tiến và chip A16", "/images/iphone15.jpg", "iPhone 15 Pro", 999.99m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Điện thoại Android flagship với màn hình AMOLED", "/images/galaxy-s25.jpg", "Samsung Galaxy S25", 899.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Tai nghe chống ồn cao cấp với âm thanh HiFi", "/images/sony-headphones.jpg", "Tai nghe Sony WH-1000XM5", 349.99m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Máy tính bảng nhẹ với hiệu suất mạnh mẽ", "/images/ipad-air.jpg", "iPad Air", 599.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Máy ảnh mirrorless full-frame chuyên nghiệp", "/images/canon-r6.jpg", "Máy ảnh Canon EOS R6", 2499.99m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Đồng hồ thông minh với tính năng theo dõi sức khỏe", "/images/apple-watch.jpg", "Đồng hồ thông minh Apple Watch Series 9", 399.99m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Loa không dây chống nước với pin dung lượng cao", "/images/jbl-charge.jpg", "Loa Bluetooth JBL Charge 5", 179.99m, 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Bàn phím gaming với switch GX Blue", "/images/logitech-keyboard.jpg", "Bàn phím cơ Logitech G Pro", 129.99m, 40 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 10, "Chuột gaming với cảm biến quang học 26K DPI", "/images/razer-mouse.jpg", "Chuột gaming Razer DeathAdder V3", 69.99m, 50 },
                    { 11, "Màn hình gaming QHD 165Hz với G-Sync", "/images/lg-monitor.jpg", "Màn hình LG UltraGear 27\"", 399.99m, 12 },
                    { 12, "Máy chơi game cầm tay với màn hình OLED 7 inch", "/images/nintendo-switch.jpg", "Nintendo Switch OLED", 349.99m, 15 },
                    { 13, "Ổ cứng SSD NVMe với tốc độ đọc/ghi cao", "/images/samsung-ssd.jpg", "SSD Samsung 970 EVO Plus 1TB", 149.99m, 30 },
                    { 14, "Balo chống sốc cho laptop 15.6 inch", "/images/targus-backpack.jpg", "Balo laptop Targus", 79.99m, 25 },
                    { 15, "Máy lọc không khí kết hợp quạt làm mát", "/images/dyson-purifier.jpg", "Máy lọc không khí Dyson", 499.99m, 10 }
                });
        }
    }
}
