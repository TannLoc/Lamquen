namespace Bai1_LamquenvoiC_
{
    class Program
    {
        public static void GetNumber(ref int x, ref int y)
        {
            x = 5;
            y = 10;
        }

        static void NhapMang(int[,]a,out int n)
        {
            Console.Write("Nhap n = ");
            n=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) 
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"Nhap a[{i}, {j}] = ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
        }

        static void XuatMang(int[,]a,int n)
        {
            for(int i=0; i < n;i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void INCC(int[,]a,int n)
        {
            Console.Write("Cac gia tri tren duong cheo chinh: ");
            for(int i=0; i < n; i++)
            {
                Console.Write(a[i, i] + " ");
            }
        }

        static bool KTSNT(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        static void xuatSNT(int[,]a,int n)
        {
            Console.Write("\nCac so nguyen to: ");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (KTSNT(a[i, j]))
                        Console.Write(a[i, j] + " ");
        }

        static int TinhTong(int[,] a,int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    tong += a[i, j];
            return tong;
        }

        static void TongSNT(int[,] a, int n)
        {
            int tongSNT = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (KTSNT(a[i, j]))
                        tongSNT += a[i, j];
                }
            Console.WriteLine($"Tong cac so nguyen to: {tongSNT}");
        }

        static void TongPhanTuTrenDongK(int[,] a, int n)
        {
            int k;
            int tong = 0;
            Console.Write("Nhap dong can tinh tong: ");
            k = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < n; j++)
                tong += a[k, j];
            Console.Write("Tong phan tu tren dong k = {0}",tong);
        }

        static int DemPhanTuAm(int[,] a, int n, int count)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < 0)
                        count++;
                }
            return count;
        }
        static int DemPhanTuDuong(int[,] a, int n, int count)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0)
                        count++;
                }
            return count;
        }
        static int DemPhanTuX(int[,] a, int n, int count, int x)
        {
            Console.Write("Nhap gia tri can dem: ");
            x = Convert.ToInt32(Console.Read());
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == x)
                        count++;
                }
            return count;
        }

        static bool KTSHT(int n)
        {
            int s = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    s += i;
            if (s == n)
                return true;
            return false;
        }

        static void XuatSHT(int[,]a,int n)
        {
            Console.Write("Cac so hoan thien: ");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (KTSHT(a[i, j]))
                        Console.Write(a[i, j]);
                }
        }

        static void XuatViTriPhantuCoGiaTriBangM(int[,] a, int n)
        {
            int m, s = 0;
            Console.Write("Nhap gia tri m: ");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (s == m)
                        break;
                    if (m % a[i,j]==0)
                    {
                        s += a[i, j];
                        
                    }
                }
        }

        static int DemPhanTuNhoHonX(int[,] a, int n, int count, int x)
        {
            Console.Write("Nhap gia tri can dem: ");
            x = Convert.ToInt32(Console.Read());
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < x)
                        count++;
                }
            return count;
        }

        static void TongPhanTuTrenDongChan(int[,] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i % 2 == 0)
                        tong += a[i, j];
            Console.Write("Tong phan tu tren dong chan = {0}", tong);
        }

        static bool KTMTDonVi(int[,]a,int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (a[i, i] == 1)
                        return true;
            return false;        
        }

        static void Nhap2MaTran(int[,] a,out int n, int[,] b,out int m)
        {
            Console.Write("Nhap ma tran 1: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Nhap a[{i}, {j}] = ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            Console.Write("Nhap ma tran 2: ");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Nhap b[{i}, {j}] = ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            
        }

        static void CongHaiMaTran(int[,] a, int n, int[,] b, int m,int[,] c)
        {
            if (n == m)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        c[i, j] = a[i, j] + b[i, j];

                    }
            }
        }
        static void NhanHaiMaTran(int[,] a, int n, int[,] b, int m, int[,] c)
        {
            if (n == m)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < n; k++)
                            c[i,j] += a[i,k] * b[k,j];

                    }
            }
        }
        static void Main(string[] args)
        {
            //int a = 0, b = 0;
            //GetNumber(ref a, ref b);
            //Console.WriteLine("a={0}\nb={1}", a, b);

            //DateTime value = new DateTime(2014, 11, 20);
            //Console.WriteLine(value);
            //Console.WriteLine(value == DateTime.Today);
            //string simepleTime = "2000/11/20";
            //DateTime time = DateTime.Parse(simepleTime);
            //Console.WriteLine(time);
            //DateTime currDay = DateTime.Now;
            //Console.WriteLine(currDay);
            //Console.ReadLine();

            const int MAX = 10;
            int[,] a = new int[MAX, MAX];
            int[,] b = new int[MAX, MAX];
            int[,] c = new int[MAX, MAX];
            int n, m, x, z, count = 0;
            //NhapMang(a,out n);
            //XuatMang(a, n);
            //INCC(a, n);
            //xuatSNT(a, n);
            //Console.WriteLine("Tong cac phan tu trong mang: {0}", TinhTong(a, n));
            //TongSNT(a, n);
            //TongPhanTuTrenDongK(a, n);
            //Console.WriteLine($"Cac phan tu am trong mang {DemPhanTuAm(a, n, count)}");
            //XuatSHT(a, n);
            Nhap2MaTran(a,out n, b,out m);
            Console.WriteLine("Ma tran 1: ");
            XuatMang(a, n);
            Console.WriteLine("Ma tran 2: ");
            XuatMang(b, m);
            CongHaiMaTran(a, n, b, m, c);
            Console.WriteLine("Cong 2 ma tran: ");
            XuatMang(c, n);
            NhanHaiMaTran(a, n, b, m, c);
            Console.WriteLine("Nhan 2 ma tran: ");
            XuatMang(c, n);
            Console.Read();

        }
    }
}