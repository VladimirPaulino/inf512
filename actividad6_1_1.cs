using System;

public class animal
{
    protected int altitude=0;
    public void eat()
    {
        Console.WriteLine("Puede comer ");
    }
}
public class kryptonian: animal
{
    private string kryptonite = "Los kryptonianos son debiles a la kryptonita ";
    public void kryptoniteWeakness()
    {
        Console.WriteLine(kryptonite);
    }
}
public class bird: animal
{
    private int eggs=0;
    public int takeOff()
    {
        altitude += 3500;
        return altitude;
    }
    public int land()
    {
        if (altitude < 3500)
        {
            altitude -= 3500;
        }
        
        return altitude;
    }
    public void fly()
    {
        if (altitude >= 3500)
        {
            Console.WriteLine("Esta volando ");
        }
        else
        {
            Console.WriteLine("No esta volando, sigue en tierra.");
        }
    }
    public int layEggs()
    {
        eggs += 1;
        return eggs;
    }

    public void buildNest()
    {
        if (eggs > 0)
        {
            Console.Write("El ave tiene huevos, puede construir un nido. ");
        }
        else if (eggs<=0) 
        { 
            Console.WriteLine("No necesita construir nido, el ave no tiene huevos. "); 
        }
    }
}
public class superman: kryptonian
{
    public int TakeOff()
    {
        altitude += 5000;
        return altitude;
    }
    public int Land()
    {
        if (altitude >= 5000)
        {
            altitude -= 5000;
        }
        return altitude;
    }
    public void leapBuilding()
    {
        if (altitude >= 5000)
        {
            Console.WriteLine("Superman no necesita saltar el edificio, ya esta volando ");
        }
        else
            Console.WriteLine("Superman salta el edificio ");
    }
    public void stopBullet()
    {
        Console.WriteLine("Superman detiene las balas ");
    }
}
class Tester
{
    static void Main()
    {
        bird ave= new bird();
        superman superheroe= new superman();
        Console.WriteLine("Ave\n");
        ave.eat();
        ave.fly();
        ave.takeOff();
        ave.fly();
        ave.land();
        ave.buildNest();
        ave.layEggs();
        ave.buildNest();
        Console.WriteLine("\n\n");
        Console.WriteLine("Superman\n");
        superheroe.eat();
        superheroe.kryptoniteWeakness();
        superheroe.leapBuilding();
        superheroe.TakeOff();
        superheroe.leapBuilding();
        superheroe.Land();
        superheroe.stopBullet();

    }

}

