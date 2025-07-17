class program 
{
	static void Main(string[] args)
	{
		Mascota m = new Mascota("lupe", 3, "iguana");
		m.MostrarInfo();
		Console.WriteLine("Edad humana: " + m.CalcularEdadHumana());

		m.SetEdad(4);
		Console.WriteLine("Edad: " + m.GetEdad());

		Mascota n = new Mascota("filogonio", 3, "gato");

		m.SetEdad(9);
		Console.WriteLine("Edad: " + m.GetEdad());	
	}
}

class MostrarEdad(string lupe, int edad, int edadHumana, bool años){
int edad = 4;
int edadHumana = 7 ;
bool años (edad * edadHumana) ;true  

	Console.WriteLine(lupe, " tiene ", años " años humanos");


class MostrarInfo(string filogonio, int edad02, int edadHumana02, bool años){
int edad02 = 9;
int edadHumana02 = 7 ;
bool años (edad * edadHumana) ;true 

	Console.WriteLine(filogonio, " tiene ", años " años humanos");

}

End program
