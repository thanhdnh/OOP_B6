public class PhanSo
{
    private int tu, mau;

    public PhanSo(int tu, int mau)
    {
        this.tu = tu;
        this.mau = mau;
    }

    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.tu * b.mau + a.mau * b.tu, a.mau * b.mau);
    }
    public static PhanSo operator -(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.tu * b.mau - a.mau * b.tu, a.mau * b.mau);
    }
    public static PhanSo operator +(PhanSo a)
    {
        return new PhanSo(a.tu, a.mau);
    }
    public static PhanSo operator -(PhanSo a)
    {
        return new PhanSo(-a.tu, a.mau);
    }
    public static int gcd(int a,int b){
        while(b!=0){
          int r = a % b;
          a=b;
          b=r;
        }
        return a;
    }
    public override string ToString()
    {
        int x = tu, y = mau;
        int ucln = Math.Abs(gcd(x,y));
        x/=ucln; y/=ucln;
        return $"{x}/{y}"; //(y < 0) ? $"{-x}/{-y}" : $"{x}/{y}";
    }
}