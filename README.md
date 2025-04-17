# 📚 DSA Library - Quản lý Thư viện 
## 📘 Mô tả Dự Án

**DSA Library** là ứng dụng quản lý thư viện sách được phát triển bằng C#, sử dụng cấu trúc **Cây Nhị Phân Tìm Kiếm (Binary Search Tree - BST)** làm nền tảng lưu trữ và xử lý dữ liệu.

Dự án được xây dựng trong khuôn khổ môn học **Cấu trúc Dữ liệu và Giải thuật**, giúp sinh viên:

- Hiểu cách vận dụng cây nhị phân để lưu trữ dữ liệu có thứ tự.
- Thực hành các thao tác chèn, tìm kiếm, xóa, duyệt cây, lọc dữ liệu.
- Kết hợp thuật toán với ứng dụng thực tế (giao diện Windows Forms )
## 🏗 Cấu trúc thư mục

- **LibraryManagement/**: Thư mục chứa toàn bộ mã nguồn chương trình C#
- **LibraryManagement.sln**: File solution mở bằng Visual Studio
- **SQLQuery_addbooks.sql**: File script để tạo và thêm dữ liệu vào CSDL SQL Server

## 💡 Tính năng cơ bản
- In thư viện hiện tại 
- Chèn sách 
- Tìm sách theo khoảng thời gian 
- Xóa sách theo khoảng thời gian 
- Cập nhật sách
- In sách theo thời gian (sort theo thời gian) 
- Tìm sách mới nhất/ cũ nhất (min, max)

## 💡 Tính năng bổ sung
- Tìm theo tên sách
- Tìm tác giả
- Tìm theo thể loại 
- Xóa sách theo ID 
- Sort theo tên
- Sort theo thể loại 
- Sort theo tác giả
  
## 🚀 Hướng Dẫn Chạy Dự Án

### **Bước 1: Tải Dự Án**

1. Truy cập vào link GitHub: [dsa_library trên GitHub](https://github.com/thilinnd/dsa_library).
2. Tải về mã nguồn bằng cách nhấn vào **Code** và chọn **Download ZIP**.
3. Giải nén tệp ZIP vào một thư mục trên máy tính của bạn.

### **Bước 2: Mở Dự Án Trong Visual Studio**

1. Mở **Visual Studio**.
2. Chọn **File** → **Open** → **Project/Solution**.
3. Duyệt đến thư mục đã giải nén và chọn **`LibraryManagement.sln`**.
4. Nhấn **Open** để mở dự án trong Visual Studio.

### **Bước 3: Cấu Hình Cơ Sở Dữ Liệu**

1. Mở file **SQLQuery_addbooks.sql**.
2. Mở **SQL Server Management Studio (SSMS)** hoặc công cụ SQL tương tự và kết nối đến cơ sở dữ liệu.
3. Chạy các câu lệnh trong **SQLQuery_addbooks.sql** để tạo bảng và thêm dữ liệu vào cơ sở dữ liệu SQL Server.

### **Bước 4: Chạy Dự Án**

1. Trong **Visual Studio**, nhấn **Start** (hoặc nhấn **F5**) để chạy ứng dụng.
2. **Visual Studio** sẽ biên dịch và mở ứng dụng **Windows Forms**.
3. Bạn có thể sử dụng các tính năng như thêm sách, tìm kiếm sách theo tên, tìm kiếm theo thời gian, xóa sách, v.v.

## Lưu Ý

- Đảm bảo rằng **SQL Server** đã được cài đặt và cấu hình đúng để kết nối với cơ sở dữ liệu.
- Nếu có lỗi kết nối cơ sở dữ liệu, hãy kiểm tra lại cấu hình trong mã nguồn và file **SQLQuery_addbooks.sql**.


