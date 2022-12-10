using System;

abstract class Estado
{
	protected string status;
	protected string marca;
	protected int temperatura;
	public Estado(string status, string marca)
	{
		status = status.ToUpper();
		if (status == "ENCENDIDO" )
		{
			this.status = status;
			temperatura = 17;
		}
		else if(status == "APAGADO")
		{
			this.status = "STAND BY";
			temperatura =0;
		}
		else
		{
			Console.WriteLine("Error la instruccion : " + status+ " no es posible.");
			status= null;
			Console.WriteLine("Las instrucciones posibles del aire acondicionado son: Encendido y apagado o stand by.");
		}
		marca= marca.ToUpper();
		if (marca == "SAMSUNG" || marca == "HAIER" || marca == "NEDOCA")
		{
            this.marca = marca;
        }
		else
		{
			Console.WriteLine("La marca ingresada: "+marca+" es invalida");
			marca= null;
			Console.WriteLine("Las marcas permitidas son: Samsung, Haier y Nedoca");
		}
		
	}
	public string getEstado()
	{
		return this.status;
	}
	public string getMarca()
	{
		return this.marca;
	}
	public abstract void getInfoEstado();
}
class ControlT: Estado
{
	private int fan=0;
	public ControlT(string Estatus,string brand):base(Estatus, brand)
	{
		
	}
	public void subirTemperatura()
	{
		if (status == "ENCENDIDO" && marca != null && temperatura > 17)
		{
            temperatura -= 1;
        }
		else if (status== "ENCENDIDO" && marca != null && temperatura <= 17)
		{
			Console.WriteLine("Temperatura minima es 17");
		}
		else if (status == "STAND BY" && marca != null)
		{
			Console.WriteLine("Para subir la temperatura el aire debe estar encendido.");
		}
        else if (status == null && marca == null)
        {
			Console.WriteLine("Error: aire acondicionado desconocido, subir temperatura no puede ser ejecutado.");
		}
		
		
	}
	public void bajarTemperatura()
	{
		if (status=="ENCENDIDO" && marca!=null &&  temperatura < 28)
		{
			temperatura += 1;
		}
		else if (status=="ENCENDIDO" && marca!=null && temperatura >= 28)
		{
			Console.WriteLine("La temperatura maxima es 28 ");
		}
		else if (status == "STAND BY" && marca != null)
		{
			Console.WriteLine("Para bajar la temperatura el aire debe estar encendido.");
		}
        else if (status == null && marca == null)
        {
            Console.WriteLine("Error: aire acondicionado desconocido, bajar temperatura no puede ser ejecutado.");
        }


    }
	public void subirVelocidadFan()
	{
		if (status=="ENCENDIDO"&& marca!=null && fan == 0 && fan < 4)
		{
			fan += 1;
		}
		else if (status=="ENCENDIDO"&& marca!=null && fan > 0 && fan == 4)
		{
            Console.WriteLine("El abanico del aire acondicionado se encuentra a maxima velocidad");
        }
		else if (status == "STAND BY" && marca!=null)
		{
			Console.WriteLine("Para subir la velocidad del abanico el aire acondicionado debe estar encendido.");
		}
        else if (status == null && marca == null)
        {
            Console.WriteLine("Error: aire acondicionado desconocido, subir velocidad del abanico no puede ser ejecutado.");
        }

    }
	public void bajarVelocidadFan()
	{
		if (status=="ENCENDIDO"&& marca != null && fan == 0)
		{
			Console.WriteLine("No se puede disminuir la velocidad del abanico, velocidad actual es 0.");
		}
		else if (status=="ENCENDIDO" && marca != null && fan > 0)
		{
			fan-=1;
		}
        else if (status == "STAND BY" && marca!=null)
        {
            Console.WriteLine("Para bajar la velocidad del abanico el aire debe de estar encendido.");
        }
		else if (status==null&& marca==null)
		{
            Console.WriteLine("Error: aire acondicionado desconocido, bajar velocidad del abanico no puede ser ejecutado.");
        }
    }
	public override void getInfoEstado()
	{
		if (status !=null && marca !=null)
		{
            Console.WriteLine("Marca: " + getMarca());
            Console.WriteLine("El estado actual del aire acondicionado es: " + getEstado());
            Console.WriteLine("Temperatura del aire acondicionado: " + temperatura);
            Console.WriteLine("Velocidad del abanico A/C: " + fan);
        }
		else
		{
			Console.WriteLine("Error de info de estado: aire acondicionado desconocido.");
		}
	}
}
class tester
{
	static void Main()
	{
		ControlT AC1 = new("Apagado", "samsung");
        AC1.getInfoEstado();
        AC1.subirTemperatura();
		AC1.bajarTemperatura();
		AC1.subirVelocidadFan();
		AC1.bajarVelocidadFan();
        Console.WriteLine("\n");
        ControlT AC2 = new("Congelame", "daikin");
        AC2.subirTemperatura();
        AC2.bajarTemperatura();
        AC2.subirVelocidadFan();
        AC2.bajarVelocidadFan();
        AC2.getInfoEstado();
        Console.WriteLine("\n");
        ControlT AC3 = new("Encendido", "Nedoca");
        AC3.getInfoEstado();
        AC3.subirTemperatura();
        AC3.bajarTemperatura();
        AC3.subirVelocidadFan();
        AC3.bajarVelocidadFan();
		AC3.getInfoEstado();

    }
}