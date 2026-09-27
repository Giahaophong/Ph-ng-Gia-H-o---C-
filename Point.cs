using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

class Point
{
    // =========================
    // 1. FIELD
    // =========================
    private double x;
    private double y;

    // =========================
    // 2. PROPERTY
    // =========================
    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    // =========================
    // 3. CONSTRUCTOR
    // Default Constructor
    // =========================
    public Point()
    {
        x = 0;
        y = 0;
    }

    // Constructor có tham số
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // =========================
    // 4. METHOD INPUT
    // =========================
    public void Input()
    {
        Console.Write("Nhập x: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Nhập y: ");
        y = double.Parse(Console.ReadLine());
    }

    // =========================
    // 5. METHOD OUTPUT
    // =========================
    public void Output()
    {
        Console.WriteLine("(" + x + ", " + y + ")");
    }

    // =========================
    // 6. OVERRIDE TOSTRING
    // =========================
    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }

    // =========================
    // 7. TOÁN TỬ +
    // A + B
    // =========================
    public static Point operator +(Point A, Point B)
    {
        return new Point(A.x + B.x, A.y + B.y);
    }

    // =========================
    // 8. TOÁN TỬ -
    // A - B
    // =========================
    public static Point operator -(Point A, Point B)
    {
        return new Point(A.x - B.x, A.y - B.y);
    }

    // =========================
    // 9. LẤY ÂM
    // -A
    // =========================
    public static Point operator -(Point A)
    {
        return new Point(-A.x, -A.y);
    }

    // =================================================
    // (a) KHOẢNG CÁCH - PHƯƠNG THỨC THÀNH VIÊN
    // =================================================
    public double KhoangCach(Point B)
    {
        double dx = x - B.x;
        double dy = y - B.y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    // =================================================
    // (a) KHOẢNG CÁCH - PHƯƠNG THỨC TĨNH
    // =================================================
    public static double KhoangCach(Point A, Point B)
    {
        double dx = A.x - B.x;
        double dy = A.y - B.y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    // =================================================
    // (b) TRUNG ĐIỂM - PHƯƠNG THỨC THÀNH VIÊN
    // =================================================
    public Point TrungDiem(Point B)
    {
        return new Point(
            (x + B.x) / 2,
            (y + B.y) / 2
        );
    }

    // =================================================
    // (b) TRUNG ĐIỂM - PHƯƠNG THỨC TĨNH
    // =================================================
    public static Point TrungDiem(Point A, Point B)
    {
        return new Point(
            (A.x + B.x) / 2,
            (A.y + B.y) / 2
        );
    }

    public void Bai2()
    {
        // ==========================================
        // Nhập điểm A
        // ==========================================
        Console.WriteLine("NHẬP ĐIỂM A");
        Point A = new Point();
        A.Input();

        // ==========================================
        // Nhập điểm B
        // ==========================================
        Console.WriteLine("\nNHẬP ĐIỂM B");
        Point B = new Point();
        B.Input();

        // ==========================================
        // Xuất A, B
        // ==========================================
        Console.WriteLine("\n--- HAI ĐIỂM ---");
        Console.WriteLine("A = " + A);
        Console.WriteLine("B = " + B);

        // ==========================================
        // (a) KHOẢNG CÁCH
        // ==========================================

        // Phương thức thành viên
        double kc1 = A.KhoangCach(B);

        Console.WriteLine("\n--- KHOẢNG CÁCH ---");
        Console.WriteLine("Phương thức thành viên: " + kc1);

        // Phương thức tĩnh
        double kc2 = Point.KhoangCach(A, B);

        Console.WriteLine("Phương thức tĩnh: " + kc2);

        // ==========================================
        // (b) TRUNG ĐIỂM
        // ==========================================

        // Phương thức thành viên
        Point I1 = A.TrungDiem(B);

        Console.WriteLine("\n--- TRUNG ĐIỂM ---");
        Console.WriteLine("Phương thức thành viên: I = " + I1);

        // Phương thức tĩnh
        Point I2 = Point.TrungDiem(A, B);

        Console.WriteLine("Phương thức tĩnh: I = " + I2);

        // ==========================================
        // PHÉP TOÁN +
        // ==========================================
        Point C = A + B;

        Console.WriteLine("\n--- PHÉP TOÁN ---");
        Console.WriteLine("A + B = " + C);

        // ==========================================
        // PHÉP TOÁN -
        // ==========================================
        Point D = A - B;

        Console.WriteLine("A - B = " + D);

        // ==========================================
        // LẤY ÂM
        // ==========================================
        Point E = -A;

        Console.WriteLine("-A = " + E);

        Console.ReadKey();
    }
}
