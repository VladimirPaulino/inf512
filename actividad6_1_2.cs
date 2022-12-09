using System;

abstract class f
{
    private string x;
    private double y;
    private long z;
    protected byte w;
    public f(string x, double y, long z, byte w)
    {
        this.x = x;
        this.y = y; 
        this.z = z;
        this.w = w;
    }
    public string getX()
    {
        return x;
    }
    public double getY()
    {
        return y;
    }
    public long getZ()
    {
        return z;
    }
    public byte getW()
    {
        return w;
    }
    public abstract void verObjeto();

}
class g: f
{
    private int s=9998833;
    public g(string nombre, double valor1, long valor2, byte valor3) : base(nombre,valor1,valor2,valor3)
    {

    }
    public override void verObjeto()
    {
        Console.WriteLine("El mensaje de la cadena es: "+getX());
        Console.WriteLine("El valor en la variable Y es: "+getY());
        Console.WriteLine("El valor en la variable Z es: "+getZ());
        Console.WriteLine("El valor en la variable W es: "+getW());
        Console.WriteLine("El valor de la variable S es: " + s);
    }
}
class tester
{
    static void Main()
    {
        g instancia = new g("Ferreiras, Castro", 12.34E+12, 987364354, 34);
        instancia.verObjeto();
    }
}
