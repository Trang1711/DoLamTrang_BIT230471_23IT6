using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class SinhVien
{
    public string MSSV { get; set; }
    public string HoTen { get; set; }
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }

    public double DiemTrungBinh
    {
        get { return (DiemToan + DiemLy + DiemHoa) / 3; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        try
        {
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();

            NhapSoLuongSinhVien(out int soLuongSinhVien);
            NhapThongTinSinhVien(danhSachSinhVien, soLuongSinhVien);
            HienThiThongTinSinhVien(danhSachSinhVien);
            HienThiSinhVienDiemTrungBinhLonHon9_5(danhSachSinhVien);
            Console.WriteLine($"Số sinh viên có điểm trung bình lớn hơn 5.0: {DemSinhVienDiemTrungBinhLonHon5(danhSachSinhVien)}");
            SapXepSinhVienTheoDiemTrungBinh(danhSachSinhVien);
            SapXepSinhVienTheoHoTen(danhSachSinhVien);
            GhiThongTinSinhVienVaoFile(danhSachSinhVien);
            DocThongTinSinhVienTuFile();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã có lỗi xảy ra: " + ex.Message);
        }
    }

    static void NhapSoLuongSinhVien(out int soLuongSinhVien)
    {
        while (true)
        {
            try
            {
                Console.Write("Nhập số lượng sinh viên: ");
                soLuongSinhVien = int.Parse(Console.ReadLine());
                if (soLuongSinhVien <= 0) throw new ArgumentException("Số lượng sinh viên phải lớn hơn 0.");
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
    }

    static void NhapThongTinSinhVien(List<SinhVien> danhSachSinhVien, int soLuongSinhVien)
    {
        for (int i = 0; i < soLuongSinhVien; i++)
        {
            try
            {
                SinhVien sv = new SinhVien();

                Console.Write("Nhập MSSV: ");
                sv.MSSV = Console.ReadLine();

                Console.Write("Nhập họ tên: ");
                sv.HoTen = Console.ReadLine();

                Console.Write("Nhập điểm Toán: ");
                sv.DiemToan = double.Parse(Console.ReadLine());

                Console.Write("Nhập điểm Lý: ");
                sv.DiemLy = double.Parse(Console.ReadLine());

                Console.Write("Nhập điểm Hóa: ");
                sv.DiemHoa = double.Parse(Console.ReadLine());

                danhSachSinhVien.Add(sv);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                i--; // Để người dùng nhập lại thông tin sinh viên
            }
        }
    }

    static void HienThiThongTinSinhVien(List<SinhVien> danhSachSinhVien)
    {
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh:F2}");
        }
    }

    static void HienThiSinhVienDiemTrungBinhLonHon9_5(List<SinhVien> danhSachSinhVien)
    {
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 9.5)
            {
                Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh:F2}");
                break;
            }
        }
    }

    static int DemSinhVienDiemTrungBinhLonHon5(List<SinhVien> danhSachSinhVien)
    {
        int count = 0;
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 5.0)
            {
                count++;
            }
        }
        return count;
    }

    static void SapXepSinhVienTheoDiemTrungBinh(List<SinhVien> danhSachSinhVien)
    {
        danhSachSinhVien.Sort((sv1, sv2) => sv1.DiemTrungBinh.CompareTo(sv2.DiemTrungBinh));
        Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo điểm trung bình:");
        HienThiThongTinSinhVien(danhSachSinhVien);
    }

    static void SapXepSinhVienTheoHoTen(List<SinhVien> danhSachSinhVien)
    {
        danhSachSinhVien.Sort((sv1, sv2) => sv1.HoTen.CompareTo(sv2.HoTen));
        Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo họ tên:");
        HienThiThongTinSinhVien(danhSachSinhVien);
    }

    static void GhiThongTinSinhVienVaoFile(List<SinhVien> danhSachSinhVien)
    {
        try
        {
            Console.Write("Nhập tên file để ghi: ");
            string tenFile = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(tenFile))
            {
                foreach (var sv in danhSachSinhVien)
                {
                    writer.WriteLine($"{sv.MSSV},{sv.HoTen},{sv.DiemToan},{sv.DiemLy},{sv.DiemHoa},{sv.DiemTrungBinh:F2}");
                }
            }

            Console.WriteLine("Đã ghi thông tin sinh viên vào file thành công.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }

    static void DocThongTinSinhVienTuFile()
    {
        try
        {
            Console.Write("Nhập tên file để đọc: ");
            string tenFile = Console.ReadLine();

            using (StreamReader reader = new StreamReader(tenFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    SinhVien sv = new SinhVien
                    {
                        MSSV = data[0],
                        HoTen = data[1],
                        DiemToan = double.Parse(data[2]),
                        DiemLy = double.Parse(data[3]),
                        DiemHoa = double.Parse(data[4])
                    };

                    Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh:F2}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }
}
