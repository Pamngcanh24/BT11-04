using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductListApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Laptop cao cấp với màn hình 13 inch, CPU Intel Core i7", "/images/laptop-dell.jpg", "Laptop Dell XPS 13", 1299.99m, 15 },
                    { 2, "Điện thoại thông minh với camera tiên tiến và chip A16", "/images/iphone15.jpg", "iPhone 15 Pro", 999.99m, 25 },
                    { 3, "Điện thoại Android flagship với màn hình AMOLED", "/images/galaxy-s25.jpg", "Samsung Galaxy S25", 899.99m, 20 },
                    { 4, "Tai nghe chống ồn cao cấp với âm thanh HiFi", "/images/sony-headphones.jpg", "Tai nghe Sony WH-1000XM5", 349.99m, 30 },
                    { 5, "Máy tính bảng nhẹ với hiệu suất mạnh mẽ", "/images/ipad-air.jpg", "iPad Air", 599.99m, 18 },
                    { 6, "Máy ảnh mirrorless full-frame chuyên nghiệp", "/images/canon-r6.jpg", "Máy ảnh Canon EOS R6", 2499.99m, 8 },
                    { 7, "Đồng hồ thông minh với tính năng theo dõi sức khỏe", "/images/apple-watch.jpg", "Đồng hồ thông minh Apple Watch Series 9", 399.99m, 22 },
                    { 8, "Loa không dây chống nước với pin dung lượng cao", "/images/jbl-charge.jpg", "Loa Bluetooth JBL Charge 5", 179.99m, 35 },
                    { 9, "Bàn phím gaming với switch GX Blue", "/images/logitech-keyboard.jpg", "Bàn phím cơ Logitech G Pro", 129.99m, 40 },
                    { 10, "Chuột gaming với cảm biến quang học 26K DPI", "/images/razer-mouse.jpg", "Chuột gaming Razer DeathAdder V3", 69.99m, 50 },
                    { 11, "Màn hình gaming QHD 165Hz với G-Sync", "/images/lg-monitor.jpg", "Màn hình LG UltraGear 27\"", 399.99m, 12 },
                    { 12, "Máy chơi game cầm tay với màn hình OLED 7 inch", "/images/nintendo-switch.jpg", "Nintendo Switch OLED", 349.99m, 15 },
                    { 13, "Ổ cứng SSD NVMe với tốc độ đọc/ghi cao", "/images/samsung-ssd.jpg", "SSD Samsung 970 EVO Plus 1TB", 149.99m, 30 },
                    { 14, "Balo chống sốc cho laptop 15.6 inch", "/images/targus-backpack.jpg", "Balo laptop Targus", 79.99m, 25 },
                    { 15, "Máy lọc không khí kết hợp quạt làm mát", "/images/dyson-purifier.jpg", "Máy lọc không khí Dyson", 499.99m, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
