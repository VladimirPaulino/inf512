using System;

interface pet
{
    string getName();
    void setName(string n);
    void play();
}
abstract class Animal
{
    protected int legs;
    protected Animal(int legs)
    {
        this.legs = legs;
    }
    public virtual void walk()
    {
        Console.WriteLine("Este individuo puede andar");
    }
    public abstract void eat();
}
class cat: Animal, pet
{
    private string name;
    private string comida;
    
    public cat(int legs,string raza): base(legs)
    {
        Console.WriteLine("La raza del gato es: " + raza);
    }
    public string getName()
    {
        return name;
    }
    public void setName(string n)
    {
        name = n;
    }
    public override void eat()
    {
        Console.WriteLine("Que le vas a dar de comer al gato?");
        comida=Console.ReadLine();
        comida = comida.ToUpper();
        if (comida == "PURINA")
        {
            Console.WriteLine("" + comida + " es la mejor opcion de comida para el gato");
        }
        else
            Console.WriteLine("Le vendria mejor otro alimento ");
    }
    public override void walk()
    {
        if (legs > 0 && legs >= 4)
        {
            Console.WriteLine("El gato camina/anda en " + legs + " Patas");
        }
        else
            Console.WriteLine("El gato tiene una discapacidad, pobrecito hay que operarlo ");
    }
    public void play()
    {
        Console.WriteLine("Tu mascota esta feliz de jugar contigo ");
    }
}
class fish: Animal, pet
{
    private string name;
    public fish(int legs, string raza, string tipo):base (legs)
    {
        tipo = tipo.ToUpper();
        if (tipo == "DULCE")
        {
            Console.WriteLine("Ten cuidado con el agua salobre");
        }
        else
            Console.WriteLine("Tu pez estara bien, en " + tipo + " ojo con el cloro!");
    }
    public string getName()
    {
        return name;
    }
    public void setName(string n)
    {
        name = n;
    }
    public void play()
    {
        Console.WriteLine("Jugar, ten cuidado porque puede matar al pez ");
    }
    public override void walk()
    {
        Console.WriteLine("Caminar: El pez no tiene patas para caminar, tiene aletas para nadar ");
    }
    public override void eat()
    {
        Console.WriteLine("No le des de comer mas de 2 veces al dia ");
    }
}
class spider: Animal
{
    public spider(int legs,string raza,string tipo,string shelter):base (legs)
    {
        Console.WriteLine("La araña vive segura en " + shelter);
    }
    public override void eat()
    {
        Console.WriteLine("Se alimenta de insectos pequeños ");
    }
}
class tester
{
    static void Main()
    {
        cat gato = new cat(3,"Viralata");
        gato.setName("tico");
        gato.getName();
        gato.walk();
        Console.WriteLine("\n");
        cat gatoderaza = new cat(4,"Ragdoll");
        gatoderaza.setName("Deiky");
        gatoderaza.getName();
        gatoderaza.walk();
        gatoderaza.eat();
        gatoderaza.play();
        Console.WriteLine("\n");
        fish pez=new fish(0,"Goldfish","Dulce");
        pez.setName("Pecesito");
        pez.getName();
        pez.walk();
        pez.eat();
        pez.play();
        Console.WriteLine("\n");
        spider araña=new spider(8,"Viuda negra","salvaje","Tanque de vidrio");
        araña.eat();
    }
}
