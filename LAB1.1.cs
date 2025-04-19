/*
// bai1 Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
[tên], bạn [tuổi] tuổi!".
using System;
using System.Text;
namespace LAB1_1
{
class Program
{
static void Main(string[] args)
{
// Đầu ra của bảng điều khiển cấu hình được Tiếng Việt
Console.OutputEncoding = Encoding.UTF8;

//1. khai báo biến
string ten;
int tuoi;
//2. nhập giá trị
Console.Write("Nhập tên của bạn: ");
ten = Console.ReadLine();

Console.Write("Nhập tuổi của bạn: ");
tuoi = int.Parse(Console.ReadLine()); //chuyển đổi (parse) một chuỗi ký tự thành số nguyên (int).

//3. hiển thị kết quả
Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi! ");
}
}
}

*/

/*
//bai2 Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
chiều rộng.

using System;
using System.Text;
namespace LAB1_1
{
class program
{
public void Main(string[] args)
{
Console.OutputEncoding = Encoding.UTF8;//đảm bảo hiển thị tiếng Việt đúng trên console.
//1. khai báo biến
double chieudai, chieurong , dientich;
//2. nhập giá trị
Console.WriteLine(" nhập chiều dài hình chữ nhật :");
chieudai = double.Parse(Console.ReadLine());

Console.WriteLine(" nhập chiều rộng hình chữ nhật :");
chieurong = double.Parse(Console.ReadLine());

//3. tính diện tích
dientich = chieudai * chieurong;

// 4. Hiển thị kết quả
Console.WriteLine($"Diện tích hình chữ nhật là: {dientich}");


}
}
}*/

/*
//bai3 Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
using System;
using System.Text;
namespace LAB1_1
{
class program
{
public void Main(string[] args)
{
Console.OutputEncoding = Encoding.UTF8;
// 1. Khai báo biến
double doC, doF;
// 2. Nhập giá trị
Console.Write("Nhập nhiệt độ (°C): ");
doC = double.Parse(Console.ReadLine());
// 3. Chuyển đổi sang độ F
doF = (doC * 9 / 5) + 32;
// 4. Hiển thị kết quả
Console.WriteLine($"{doC}°C tương đương {doF}°F");

}
}
}
*/



/*
//bai4 Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn
hay không.

using System;
using System.Text;

namespace LAB1_1
{
class Program
{
static void Main(string[] args)
{
Console.OutputEncoding = Encoding.UTF8;
// 1. Khai báo biến
int songuyen;
// 2. Nhập giá trị
Console.Write("Nhập một số nguyên: ");
songuyen = int.Parse(Console.ReadLine());
// 3. Kiểm tra số chẵn
bool laSoChan = songuyen % 2 == 0;

// 4. Hiển thị kết quả
if (laSoChan)
{
Console.WriteLine($"{songuyen} là số chẵn.");
}
else
{
Console.WriteLine($"{songuyen} là số lẻ.");
}
}
}
}*/



/*
//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
using System;
using System.Text;

namespace LAB1_1
{
class Program
{
static void Main(string[] args)
{
Console.OutputEncoding = Encoding.UTF8;
// 1. Khai báo biến
double sothunhat, sothuhai, tong, tich;
// 2. Nhập giá trị
Console.WriteLine("Nhập số thứ nhất:");
sothunhat = double.Parse(Console.ReadLine());

Console.WriteLine("Nhập số thứ hai:");
sothuhai = double.Parse(Console.ReadLine());

// 3. Tính tổng và tích
tong = sothunhat + sothuhai;
tich = sothunhat * sothuhai;

// 4. Hiển thị kết quả
Console.WriteLine($"Tổng của {sothunhat} và {sothuhai} là: {tong}");
Console.WriteLine($"Tích của {sothunhat} và {sothuhai} là: {tich}");
}
}
}
*/
