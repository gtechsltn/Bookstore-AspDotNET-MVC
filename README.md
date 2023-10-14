
# Hệ thống website bán sách

## Setup Environment
+ Windows 11 version 22H2
+ Visual Studio 2019
+ SQL Server 2019
+ SQL Server Magament Studio
+ ASP.NET MVC Core 5.0

## ⚔️ KẾ HOẠCH XÂY DỰNG DỰ ÁN
### 🧰 CÁC CÔNG NGHỆ, KĨ THUẬT ÁP DỤNG:
-	Hệ quản trị CSDL: MS SQL Server
-	Web Server: asp.net MVC (.NET Core), Razor engine
-	Style: Scss, Boostrap
-	Call API: ajax.
-	Ứng dụng các stote lưu trữ: Session, cookie,…
-	Ứng dụng các kỹ thuật: Bundle, minify và Caching,..
-	Áp dụng các kỹ thuật về bảo mật

### ⏲️THỜI GIAN: 13/06/2022 ➡️ 18/07/2022 (TRONG 5 TUẦN)
Tiến trình: ✔️ Đã hoàn thiện, ‼️ Có vấn đề

| THỜI GIAN | CÔNG VIỆC| GHI CHÚ |
| :---:| :---| :--- |
| 13/06/2022➡️19/06/2022 <br/>(1 tuần)  | -	Phân tích, thiết kế hệ thống✔️  <br/>-	Xây dựng database✔️  <br/>-	Cấu hình server: kết nối csdl, xây dựng các entity, thêm các thư viện khác,…✔️  |- 15/06: hoàn thiện PT&TK hệ thống <br/>- 16/06: hoàn thiện database <br/> -17/06 ➡️ 19/06: hoàn thiện cấu hình server  <br/> | 
| 20/06/2022 ➡️ 26/06/2022 <br/>(1 tuần)  | `-Xây dựng trang đăng nhập`✔️: sử dụng session-cookie, phân quyền theo role user.<br/><br/>`- Quản lý sách`✔️ <br/> + Load ds các sách ra bảng dữ liệu, có phân trang <br/> + Thêm/sửa: hiện thị subform để nhập thông tin <br/>	+ Xóa: nhấn vào nút Xóa của sách cần xóa trên bảng dữ liệu <br/><br/>`- Quản lý đơn hàng `✔️ <br/> + Load Ds đơn hàng: hiện thị ds đơn hàng lọc theo trạng thái, tgian, có phân trang <br/> + Nhấn chọn 1 đơn hàng bất kỳ để xem chi tiết<br/> + Duyệt đơn: duyệt những đơn đang chờ duyệt <br/> + Hủy đơn: Hủy những đơn đang chờ duyệt <br/>  |  | 
| 27/06/2022 ➡️ 03/07/2022 <br/>(1 tuần)  | `-	Quản lý Tài khoản` ✔️ <br/> + Load ds các tài khoản ra bảng dữ liệu, có phân trang <br/> +	Thêm: tạo subform để nhập dữ liệu khi nhấn <br/> +	Xóa: nhấn vào nút Xóa của Tài khoản cần xóa trên bảng dữ liệu <br/> +	Reset mật khẩu: nhấn vào nút Reset của TK cần reset trên bảng dữ liệu <br/><br/>`- Quản lý Đánh giá`✔️  <br/> +	Load ds các sách được thống kê bình luận ra bảng dữ liệu, có phân trang <br/> +	Xem chi tiết bình luận của sách <br/> +	Thêm: nhập nội dung bình luận r nhấn nút thêm <br/> +	Xóa bình luận: nhấn chọn bình luận cần xóa <br/><br/>`-	Quản lý các khuyến mãi`✔️  <br/>  +	Load ds các Khuyến ra bảng dữ liệu, có phân trang <br/>  +	Thêm/ sửa: tạo subform để nhập thông tin cần thêm/sửa <br/>  +	Xóa: chọn khuyến mãi cần xóa trên bảng dữ liệu <br/><br/>`-Thống kê doanh thu`✔️  <br/>  +	Tổng lợi nhuận của cửa hàng <br/>  +	Tổng số đơn đặt <br/>  +	Tổng doanh thu trung bình/năm <br/>  +	Tổng số người dùng <br/>  +	Thống kê biểu đồ cột về doanh thu theo tháng của một năm tùy chọn(optional).|  | 
| 04/07/2022 ➡️ 10/07/2022 <br/>(1 tuần) | `-	Xây dựng trang chủ:`✔️ <br/> + 	Header:  <br/>   •	Nút xem thông tin cá nhân <br/>   •	Nút đi đến giỏ hàng <br/>   •	Nút đăng xuất(nếu đăng nhập) <br/>   •	Thanh tìm kiếm(optional) <br/> + 	Footer: Hiện thị thông tin cơ bản về cửa hàng: giới thiệu,địa chỉ, liên kết,..  <br/> + 	Hiển thị Ds các thể loại sách: khi nhấn vào 1 thể loại sẽ ra ds các sách có thể loại đó <br/> + 	Hiện thị các Banner: áp dụng slider <br/> + 	Hiển thị top 10 sách có nhìu lượt mua: thống kê theo số đơn order <br/> + 	Hiển thị top 10 sách mới: sách có ngày xuất bản gần đây nhất <br/> + 	Hiện thị sách gợi ý(nếu có đăng nhập): những cuốn sách cùng thể loại/tác giả mà khách đã mua gần đây <br/> + 	Hiện thị ds các sách có trong thệ thống: áp dụng phân trang <br/> <br/>`-	Xây dựng trang chi tiết sách`✔️ <br/> + 	Hiện thị các thông tin chi tiết của sách: tên sách, tác giả, nxb, giá bán, khuyến mãi, mô tả sách,..  <br/> + 	Xây chức năng thêm giỏ hàng: nhập số lượng và nút nhấn thêm giỏ hàng (sử dụng ajax) <br/> + 	 Hiện thị  Ds các sách cùng tác giả của cuốn đó <br/> + 	Hiện thị Ds sách các bình luận <br/> + 	Xây dựng chức năng bình luận: nhập bình luận vào ô input và nhấn gửi(sử dụng ajax) <br/> + 	Hiện thị Ds các sách gợi ý khác. <br/> <br/>`-	Xây dựng trang thể loại:`✔️ Sẽ hiện thị ds các sách theo thể loại đã chọn trước đó |  | 
| 11/07/2022 ➡️ 18/07/2022 <br/>(1 tuần) | `-	Xây dựng trang giỏ hàng:`✔️ <br/> + 	Load ds các giỏ hàng của khách  <br/> + 	Xem chi tiết sách: chuyển đến trang chi tiết <br/> + 	Xóa giỏ hàng <br/> + 	Hiệu chỉnh số lượng sách mua <br/> + 	Tự động tính tổng tiền <br/> + 	Nút mua hàng: nhấn nút mua hàng để chuyển đến trang thanh toán <br/> <br/>`✔️-Xây dựng trang thanh toán trực tuyến (optional) `✔️ <br/> + Nhập thông tin khách cần đặt hàng: họ tên, sđt, địa chỉ <br/> + 	Chọn phương thức thanh toán <br/> <br/>`-	Xây dựng trang thông tin cá nhân`✔️ <br/> + 	Load thông tin cá nhân người dùng <br/> + 	Có thể hiệu chỉnh thông tin: email, sđt, giới tính, năm sinh. <br/> + 	Đổi mật khẩu <br/> <br/>`-	Xây dựng trang lịch sử mua hàng`✔️ <br/> + 	Load ds các đơn hàng mà khách đã và đang mua(có phân trang) <br/> + 	Chức năng xem chi tiết đơn hàng: hiển thị chi tiết đơn hàng(sử dụng ajax) <br/> + 	Chức năng mua lại đơn hàng |  | 
