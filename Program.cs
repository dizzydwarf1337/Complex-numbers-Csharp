using System;

class Zespolona
{
    public Zespolona(double re = 0, double im = 0)
    {
        this.re = re;
        this.im = im;
}
    private double re;
    public double Re
    {
        get { return re; }
        set { re = value; }
    }
    private double im;
    public double Im
    {
        get { return im; }
        set { im = value; }
    }
    public override string ToString()
    {
        if (im < 0)
        {
            string liczba = $"{re}{im}i";
            return liczba;
        }
        else
        {
            string liczba = $"{re}+{im}i";
            return liczba;
        }
    }
    public void Dodaj(Zespolona z)
    {
        this.re += z.re;
        this.im += z.im;
}
    public Zespolona Plus(Zespolona z)
    {
        var nowa = new Zespolona();
        nowa.Re = this.re + z.re;
	    nowa.Im = this.im+ z.im;
	    return nowa;
    }
    public static Zespolona operator +(Zespolona a, Zespolona b)
    {
        var nowa = new Zespolona();
        nowa.Re = a.re+ b.re;
	nowa.Im = a.Im+ b.im;
	return nowa;
    }
    public static Zespolona operator -(Zespolona a, Zespolona b)
    {
        var nowa = new Zespolona();
        nowa.Re = a.re - b.re;
        nowa.Im = a.Im - b.im;
        return nowa;
    }
    public static Zespolona operator *(Zespolona a, Zespolona b)
    {
        var nowa = new Zespolona();
        nowa.Re = a.re*b.re - a.im*b.im;
        nowa.Im = a.re*b.im + b.re*a.im;
        return nowa;
    }
    public static Zespolona operator /(Zespolona a, Zespolona b)
    {
        var nowa = new Zespolona();
        nowa.Re = (a.re*b.re+a.im*b.im)/(b.re*b.re+b.im*b.im);
        nowa.Im = (a.im*b.re-a.re*b.im)/ (b.re * b.re + b.im * b.im);
        return nowa;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        var z = new Zespolona();
        z.Re = 3;
        z.Im = -2;
        var z1 = new Zespolona(1,3);
        var z2 = new Zespolona(3,-2);
        var z3 = new Zespolona(2, 4);
        Console.WriteLine(z1+z2);
        Console.WriteLine(z2-z3);
        Console.WriteLine(z3*z1);
        Console.WriteLine(z1/z2);
    }
}
