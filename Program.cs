//Crea la clase primaria
public class Biblioteca {
    //Se define como Main para que sea la clase primaria
	public static void Main(string[] args){
        //Declaramos las bariables libros como nuevas
		libro LaTelarañaDeCharlotte=new libro ();
		libro CienAñosDeSoledad=new libro ();
        //Asigna un valos a cada variable
        //A la variable código un valor Int
		LaTelarañaDeCharlotte.setcodigo("98765");
        //A la variable autor un valor String
		LaTelarañaDeCharlotte.setautor("Elwyn");
        //A la variable paginas un valor Int
		LaTelarañaDeCharlotte.setpaginas("192");
        //a la variable titulo un valor String
        LaTelarañaDeCharlotte.settitulo("La telaraña de Charlotte");

        //Asigna un valos a cada variable
        //A la variable código un valor Int
		CienAñosDeSoledad.setcodigo("98764");
        //A la variable autor un valor String
		CienAñosDeSoledad.setautor("Gabo");
        //A la variable paginas un valor Int
		CienAñosDeSoledad.setpaginas("496");
        //A la variable titulo un valor String
        CienAñosDeSoledad.settitulo("Cien años de soledad");
                //Usa el condicional If para comparar la cantidad de paginas(get.ppaginas)
            	if (LaTelarañaDeCharlotte.getpaginas >= CienAñosDeSoledad.getpaginas) {
                    //Escribe la respuesta para el condicional verdadero
                	Console.WriteLine ("La telaraña de Charlotte Tiene Mas Paginas");
            	}
		else { //Escribe la respuesta para el condicional falso
                	Console.WriteLine ("Cien años de soledad Tiene Mas Paginas");
            	}

    }
}