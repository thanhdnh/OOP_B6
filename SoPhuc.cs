public class SoPhuc
{
    private int thuc, ao;
    public SoPhuc(int thuc, int ao)
    {
        this.thuc = thuc;
        this.ao = ao;
    }

    public static SoPhuc operator +(SoPhuc a, SoPhuc b)
    {
        return new SoPhuc(a.thuc + b.thuc, a.ao + b.ao);
    }
    public static SoPhuc operator ++(SoPhuc a)
    {
        return new SoPhuc(++a.thuc, ++a.ao);
    }
    public override string ToString()
    {
        return "(" + this.thuc + "+" + this.ao + "*i)";
    }
}