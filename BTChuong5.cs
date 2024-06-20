using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

class Program
{
    // Bài tập 1: Quản lý danh sách sinh viên
    static List<SinhVien> danhSachSinhVien = new List<SinhVien>();

    class SinhVien
    {
        public string Ten { get; set; }
        public string Lop { get; set; }
        public int Diem { get; set; }

        public SinhVien(string ten, string lop, int diem)
        {
            Ten = ten;
            Lop = lop;
            Diem = diem;
        }

        public override string ToString()
        {
            return $"Tên: {Ten}, Lớp: {Lop}, Điểm: {Diem}";
        }
    }

    static void ThemSinhVien()
    {
        Console.Write("Nhập tên sinh viên: ");
        string ten = Console.ReadLine();
        Console.Write("Nhập tên lớp: ");
        string lop = Console.ReadLine();
        Console.Write("Nhập điểm: ");
        int diem;
        while (!int.TryParse(Console.ReadLine(), out diem))
        {
            Console.WriteLine("Nhập không hợp lệ. Vui lòng nhập một số.");
            Console.Write("Nhập điểm: ");
        }
        danhSachSinhVien.Add(new SinhVien(ten, lop, diem));
        Console.WriteLine("Thêm sinh viên thành công.");
    }

    static void HienThiDanhSachSinhVien()
    {
        Console.WriteLine("Danh sách sinh viên:");
        foreach (SinhVien sinhVien in danhSachSinhVien)
        {
            Console.WriteLine(sinhVien);
        }
    }

    static void TinhTongDiem()
    {
        int tongDiem = 0;
        foreach (SinhVien sinhVien in danhSachSinhVien)
        {
            tongDiem += sinhVien.Diem;
        }
        Console.WriteLine($"Tổng điểm của tất cả sinh viên: {tongDiem}");
    }

    // Bài tập 2: Từ điển Anh - Việt
    static Dictionary<string, string> tuDien = new Dictionary<string, string>();

    static void ThemTuDien()
    {
        Console.Write("Nhập từ tiếng Anh: ");
        string tuAnh = Console.ReadLine();
        Console.Write("Nhập nghĩa tiếng Việt: ");
        string tuViet = Console.ReadLine();
        tuDien[tuAnh] = tuViet;
        Console.WriteLine("Thêm từ vào từ điển thành công.");
    }

    static void TimNghiaTu()
    {
        Console.Write("Nhập từ tiếng Anh cần tìm: ");
        string tuAnh = Console.ReadLine();
        if (tuDien.TryGetValue(tuAnh, out string tuViet))
        {
            Console.WriteLine($"Nghĩa của từ '{tuAnh}' là: {tuViet}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy từ trong từ điển.");
        }
    }

    // Bài tập 3: Quản lý danh sách sản phẩm
    static ArrayList danhSachSanPham = new ArrayList();

    class SanPham
    {
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public decimal Gia { get; set; }

        public SanPham(string ten, string moTa, decimal gia)
        {
            Ten = ten;
            MoTa = moTa;
            Gia = gia;
        }

        public override string ToString()
        {
            return $"Tên: {Ten}, Mô tả: {MoTa}, Giá: {Gia:C}";
        }
    }

    static void ThemSanPham()
    {
        Console.Write("Nhập tên sản phẩm: ");
        string ten = Console.ReadLine();
        Console.Write("Nhập mô tả sản phẩm: ");
        string moTa = Console.ReadLine();
        Console.Write("Nhập giá sản phẩm: ");
        decimal gia;
        while (!decimal.TryParse(Console.ReadLine(), out gia))
        {
            Console.WriteLine("Nhập không hợp lệ. Vui lòng nhập một số.");
            Console.Write("Nhập giá sản phẩm: ");
        }
        danhSachSanPham.Add(new SanPham(ten, moTa, gia));
        Console.WriteLine("Thêm sản phẩm thành công.");
    }

    static void HienThiDanhSachSanPham()
    {
        Console.WriteLine("Danh sách sản phẩm:");
        foreach (SanPham sanPham in danhSachSanPham)
        {
            Console.WriteLine(sanPham);
        }
    }

    static void TimSanPham()
    {
        Console.Write("Nhập tên sản phẩm cần tìm: ");
        string ten = Console.ReadLine();
        bool timThay = false;
        foreach (SanPham sanPham in danhSachSanPham)
        {
            if (sanPham.Ten.Equals(ten, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(sanPham);
                timThay = true;
                break;
            }
        }
        if (!timThay)
        {
            Console.WriteLine("Không tìm thấy sản phẩm.");
        }
    }

    // Bài tập 4: Tìm giá trị lớn nhất
    static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    static void TestMax()
    {
        Console.WriteLine("Max giữa 3 và 7 là: " + Max(3, 7));
        Console.WriteLine("Max giữa 3.5 và 2.7 là: " + Max(3.5, 2.7));
        Console.WriteLine("Max giữa 'apple' và 'banana' là: " + Max("apple", "banana"));
    }

    // Bài tập 5: Generic Stack Class
    class MyStack<T>
    {
        private List<T> elements = new List<T>();

        public void Push(T item)
        {
            elements.Add(item);
        }

        public T Pop()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Stack is empty.");
            T item = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return item;
        }
    }

    static void TestMyStack()
    {
        MyStack<int> stackInt = new MyStack<int>();
        stackInt.Push(1);
        stackInt.Push(2);
        stackInt.Push(3);
        Console.WriteLine("Pop từ stack số nguyên: " + stackInt.Pop());

        MyStack<string> stackString = new MyStack<string>();
        stackString.Push("Hello");
        stackString.Push("World");
        Console.WriteLine("Pop từ stack chuỗi: " + stackString.Pop());
    }

    // Bài tập 6: Sử dụng Hashtable
    static void TestHashtable()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(1, "one");
        hashtable.Add(2, "two");
        hashtable.Add(3, "three");

        Console.WriteLine("Contains key 2: " + hashtable.ContainsKey(2));
        Console.WriteLine("Contains value 'three': " + hashtable.ContainsValue("three"));

        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }

    // Bài tập 7: Sử dụng từ điển
    static void TestDictionary()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary[1] = "one";
        dictionary[2] = "two";
        dictionary[3] = "three";

        Console.WriteLine("Contains key 2: " + dictionary.ContainsKey(2));

        if (dictionary.TryGetValue(3, out string value))
        {
            Console.WriteLine("Value for key 3: " + value);
        }

        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    static void Main(string[] args)
    {
        bool running = true;
        Console.OutputEncoding = Encoding.UTF8;
        while (running)
        {
            Console.WriteLine("Chọn bài tập:");
            Console.WriteLine("1. Quản lý danh sách sinh viên");
            Console.WriteLine("2. Từ điển Anh - Việt");
            Console.WriteLine("3. Quản lý danh sách sản phẩm");
            Console.WriteLine("4. Tìm giá trị lớn nhất");
            Console.WriteLine("5. Generic Stack Class");
            Console.WriteLine("6. Sử dụng Hashtable");
            Console.WriteLine("7. Sử dụng từ điển");
            Console.WriteLine("8. Thoát");
            Console.Write("Chọn một tùy chọn: ");
            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    QuảnLýSinhVienMenu();
                    break;
                case "2":
                    TuDienMenu();
                    break;
                case "3":
                    QuanLySanPhamMenu();
                    break;
                case "4":
                    TestMax();
                    break;
                case "5":
                    TestMyStack();
                    break;
                case "6":
                    TestHashtable();
                    break;
                case "7":
                    TestDictionary();
                    break;
                case "8":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ, vui lòng thử lại.");
                    break;
            }
        }
    }

    static void QuảnLýSinhVienMenu()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Quản lý sinh viên:");
            Console.WriteLine("1. Thêm sinh viên mới");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tính tổng điểm của tất cả sinh viên");
            Console.WriteLine("4. Quay lại menu chính");
            Console.Write("Chọn một tùy chọn: ");
            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    ThemSinhVien();
                    break;
                case "2":
                    HienThiDanhSachSinhVien();
                    break;
                case "3":
                    TinhTongDiem();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ, vui lòng thử lại.");
                    break;
            }
        }
    }

    static void TuDienMenu()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Từ điển Anh - Việt:");
            Console.WriteLine("1. Thêm từ mới");
            Console.WriteLine("2. Tìm nghĩa của từ");
            Console.WriteLine("3. Quay lại menu chính");
            Console.Write("Chọn một tùy chọn: ");
            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    ThemTuDien();
                    break;
                case "2":
                    TimNghiaTu();
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ, vui lòng thử lại.");
                    break;
            }
        }
    }

    static void QuanLySanPhamMenu()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Quản lý sản phẩm:");
            Console.WriteLine("1. Thêm sản phẩm mới");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tìm kiếm sản phẩm theo tên");
            Console.WriteLine("4. Quay lại menu chính");
            Console.Write("Chọn một tùy chọn: ");
            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    ThemSanPham();
                    break;
                case "2":
                    HienThiDanhSachSanPham();
                    break;
                case "3":
                    TimSanPham();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ, vui lòng thử lại.");
                    break;
            }
        }
    }
}
