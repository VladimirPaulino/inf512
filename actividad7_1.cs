using System;

interface IFlyer
{
    void takeoff();
    void land();
    void fly();
}
class Vehicle
{
  public string trip()
    {
        return "El viaje va a comenzar... ";
    }
}
class Animal
{
    public string eat()
    {
        return "*Ingiere alimentos*";
    }
}
class Airplane : Vehicle, IFlyer
{
    protected int altitude;
    public void takeoff()
    {
        Console.WriteLine("Ha empezado el viaje");
    }
    public void land()
    {
        Console.WriteLine("Preparese para aterrizar..");
        Console.WriteLine("*Aterrizando..*");
        altitude = 0;
    }
    public void fly()
    {
        altitude = 1000;
        Console.WriteLine("Su altitud actual es de: " + altitude+" Pies");
    }
    public void getTrip()
    {
        Console.WriteLine("" + trip());
    }
}
class Seaplane: Airplane
{
    private string landmaterial="Agua";
    public void acuaticLand()
    {
        Console.WriteLine("Aterrizando en " + landmaterial);
    }
    public void acuaticTakeoff()
    {
        Console.WriteLine("Despegando desde el " + landmaterial);
    }
}
class Helicopter: Airplane
{
    public void Propeller(int Pspeed)
    {
        Console.WriteLine("Las helices se mueven a " + Pspeed + "Km/h"); 
    }
}
class Kryptonian: Animal
{
    protected string sunColorPWUP;
    protected bool weakness;
    public void getEat()
    {
        Console.WriteLine("" + eat());
    }
}
class Superman: Kryptonian, IFlyer
{
    public void Power(string sunColorPWUP)
    {
        sunColorPWUP = sunColorPWUP.ToUpper();
        this.sunColorPWUP = sunColorPWUP;
        if (sunColorPWUP == "ROJO")
        {
            weakness = true;
        }
        else
            weakness = false;
    }
    public void takeoff()
    {
        if (weakness == true)
        {
            Console.WriteLine("Superman no puede despegar esta debil por el sol " + sunColorPWUP);
        }
        else
            Console.WriteLine("Superman despega");
    }
    public void land()
    {
        if (weakness == true)
        {
            Console.WriteLine("Superman no ha volado por su debilidad aun, no necesita aterrizar ");
        }
        else
            Console.WriteLine("Ha descendido, para aterrizar.");
    }
    public void fly()
    {
        if (weakness == true)
        {
            Console.WriteLine("Superman no puede despegar ni volar, se encuentra debil por el sol " + sunColorPWUP);
        }
        else
            Console.WriteLine("Superman vuela... ");
    }
    public void leapBuilding()
    {
        if (weakness == true)
        {
            Console.WriteLine("Superman no puede saltar el edificio, se encuentra debil por el sol " + sunColorPWUP);
        }
        else
            Console.WriteLine("Superman salta el edificio");
    }
    public void stopBullet()
    {
        if (weakness == true)
        {
            Console.WriteLine("Superman puede detener las balas, se encuentra debilitado por el sol " + sunColorPWUP);
        }
        else
            Console.WriteLine("Superman detiene las balas y al malhechor ");
    }

}
class Bird: Animal, IFlyer
{
    public void getFood()
    {
        Console.WriteLine("", eat());
    }
    public void takeoff()
    {
        Console.WriteLine("Bate las alas y emprende el vuelo");
    }
    public void land()
    {
        Console.WriteLine("*Aterriza*");
    }
    public void fly()
    {
        Console.WriteLine("*Volando*");
    }
    public void layEggs(int eggs)
    {
        Console.WriteLine("El ave a puesto " + eggs + " huevos");
    }
    public void buildNest()
    {
        Console.WriteLine("Construyendo nido...");
    }
}
class tester
{
    static void Main()
    {
        Console.WriteLine("----Aeroplano----");
        Airplane aeroplano = new Airplane();
        aeroplano.getTrip();
        aeroplano.takeoff();
        aeroplano.fly();
        aeroplano.land();
        Console.WriteLine("\n------Nave acuatica----");
        Seaplane naveaerea = new Seaplane();
        naveaerea.getTrip();
        naveaerea.acuaticTakeoff();
        naveaerea.fly();
        naveaerea.acuaticLand();
        Console.WriteLine("\n------Helicoptero----");
        Helicopter helicoptero = new Helicopter();
        helicoptero.getTrip();
        helicoptero.Propeller(200);
        helicoptero.takeoff();
        helicoptero.fly();
        helicoptero.land();
        Console.WriteLine("\n------Superman----");
        Superman superheroe = new Superman();
        superheroe.eat();
        superheroe.Power("Amarillo");
        superheroe.takeoff();
        superheroe.fly();
        superheroe.land();
        superheroe.leapBuilding();
        superheroe.stopBullet();
        Console.WriteLine("\n------Superman debilitado----");
        Superman clark = new Superman();
        clark.eat();
        clark.Power("Rojo");
        clark.takeoff();
        clark.fly();
        clark.land();
        clark.leapBuilding();
        clark.stopBullet();
        Console.WriteLine("\n------Pajaro----");
        Bird ave = new Bird();
        ave.eat();
        ave.buildNest();
        ave.layEggs(3);
        ave.takeoff();
        ave.fly();
        ave.land();
    }
}
