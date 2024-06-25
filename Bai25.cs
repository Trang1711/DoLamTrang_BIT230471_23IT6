using System;
using System.Text;

// Interface KPIEvaluator
public interface KPIEvaluator
{
    double TinhKPI();
}

// Lớp trừu tượng Person
public abstract class Person
{
    // Các thuộc tính
    public string Ten { get; set; }
    public int Tuoi { get; set; }
    public string GioiTinh { get; set; }
    protected string tai_khoan_ngan_hang; // Trường protected

    // Constructor
    public Person(string ten, int tuoi, string gioiTinh)
    {
        Ten = ten;
        Tuoi = tuoi;
        GioiTinh = gioiTinh;
    }

    // Phương thức trừu tượng
    public abstract string LayVaiTro();

    // Phương thức
    public void DatTaiKhoanNganHang(string taiKhoan)
    {
        tai_khoan_ngan_hang = taiKhoan;
    }
}

// Lớp TeachingAssistant
public class TeachingAssistant : Person, KPIEvaluator
{
    // Các thuộc tính
    public string MaNhanVien { get; set; }
    private int soLuongKhoaHoc;

    // Constructor
    public TeachingAssistant(string ten, int tuoi, string gioiTinh, string maNhanVien, int soLuongKhoaHoc)
        : base(ten, tuoi, gioiTinh)
    {
        MaNhanVien = maNhanVien;
        this.soLuongKhoaHoc = soLuongKhoaHoc;
    }

    // Ghi đè phương thức từ Person
    public override string LayVaiTro()
    {
        return "Trợ giảng";
    }

    // Ghi đè phương thức từ KPIEvaluator
    public double TinhKPI()
    {
        return soLuongKhoaHoc * 5;
    }
}

// Lớp Lecturer
public class Lecturer : Person, KPIEvaluator
{
    // Các thuộc tính
    public string MaNhanVien { get; set; }
    private int soLuongBaiBao;

    // Constructor
    public Lecturer(string ten, int tuoi, string gioiTinh, string maNhanVien, int soLuongBaiBao)
        : base(ten, tuoi, gioiTinh)
    {
        MaNhanVien = maNhanVien;
        this.soLuongBaiBao = soLuongBaiBao;
    }

    // Ghi đè phương thức từ Person
    public override string LayVaiTro()
    {
        return "Giảng viên";
    }

    // Ghi đè phương thức từ KPIEvaluator
    public double TinhKPI()
    {
        return soLuongBaiBao * 7;
    }
}

// Lớp Professor
public class Professor : Lecturer
{
    // Trường static
    public static int soLuongGiaoSu = 0;

    // Các thuộc tính
    private int soLuongDuAn;

    // Constructor
    public Professor(string ten, int tuoi, string gioiTinh, string maNhanVien, int soLuongBaiBao, int soLuongDuAn)
        : base(ten, tuoi, gioiTinh, maNhanVien, soLuongBaiBao)
    {
        this.soLuongDuAn = soLuongDuAn;
        soLuongGiaoSu++;
    }

    // Ghi đè phương thức từ Person
    public override string LayVaiTro()
    {
        return "Giáo sư";
    }
}

// Chương trình chính
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;
        do
        {
            Console.Write("Nhập số nguyên n (2 đến 10): ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out n);
            if (isValidInput && n >= 2 && n <= 10)
                break;
            else
                Console.WriteLine("Nhập sai! Vui lòng nhập lại.");
        } while (true);

        Person[] mangDoiTuong = NhapMangDoiTuong(n);
        HienThiMangDoiTuong(mangDoiTuong);

        // Hiển thị số lượng Professor đã tạo
        Console.WriteLine($"\nTổng số Giáo sư đã tạo: {Professor.soLuongGiaoSu}");

        Console.ReadLine();
    }

    // Hàm nhập mảng đối tượng
    static Person[] NhapMangDoiTuong(int n)
    {
        Person[] mangDoiTuong = new Person[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập đối tượng thứ {i + 1}:");
            string loaiDoiTuong;
            do
            {
                Console.Write("Nhập loại đối tượng (ta/lec/gs): ");
                loaiDoiTuong = Console.ReadLine().ToLower();
                if (loaiDoiTuong == "ta" || loaiDoiTuong == "lec" || loaiDoiTuong == "gs")
                    break;
                else
                    Console.WriteLine("Loại đối tượng không hợp lệ! Vui lòng nhập lại.");
            } while (true);

            Console.Write("Nhập tên: ");
            string ten = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập giới tính: ");
            string gioiTinh = Console.ReadLine();

            switch (loaiDoiTuong)
            {
                case "ta":
                    Console.Write("Nhập mã nhân viên: ");
                    string maNhanVienTA = Console.ReadLine();
                    Console.Write("Nhập số lượng khóa học: ");
                    int soLuongKhoaHoc = int.Parse(Console.ReadLine());
                    mangDoiTuong[i] = new TeachingAssistant(ten, tuoi, gioiTinh, maNhanVienTA, soLuongKhoaHoc);
                    break;
                case "lec":
                    Console.Write("Nhập mã nhân viên: ");
                    string maNhanVienLec = Console.ReadLine();
                    Console.Write("Nhập số lượng bài báo: ");
                    int soLuongBaiBao = int.Parse(Console.ReadLine());
                    mangDoiTuong[i] = new Lecturer(ten, tuoi, gioiTinh, maNhanVienLec, soLuongBaiBao);
                    break;
                case "gs":
                    Console.Write("Nhập mã nhân viên: ");
                    string maNhanVienGS = Console.ReadLine();
                    Console.Write("Nhập số lượng bài báo: ");
                    int soLuongBaiBaoGS = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số lượng dự án: ");
                    int soLuongDuAn = int.Parse(Console.ReadLine());
                    mangDoiTuong[i] = new Professor(ten, tuoi, gioiTinh, maNhanVienGS, soLuongBaiBaoGS, soLuongDuAn);
                    break;
            }
        }
        return mangDoiTuong;
    }

    // Hàm hiển thị mảng đối tượng
    static void HienThiMangDoiTuong(Person[] mangDoiTuong)
    {
        Console.WriteLine("\nThông tin các đối tượng trong mảng:");
        for (int i = 0; i < mangDoiTuong.Length; i++)
        {
            Console.WriteLine($"\nĐối tượng {i + 1}:");
            Console.WriteLine($"Tên: {mangDoiTuong[i].Ten}");
            Console.WriteLine($"Tuổi: {mangDoiTuong[i].Tuoi}");
            Console.WriteLine($"Giới tính: {mangDoiTuong[i].GioiTinh}");
            Console.WriteLine($"Vai trò: {mangDoiTuong[i].LayVaiTro()}");
            Console.WriteLine($"KPI: {((KPIEvaluator)mangDoiTuong[i]).TinhKPI()}");
        }
    }
}
