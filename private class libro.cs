//Crea la clase secundaria
private class libros {
    //Definimos las variables tipo string que vamos a usar
    private string titulo="", autor="";
    //Definimos las variables tipo Int que vamos a usar
    private int codigo, paginas;
	//llama la variable donde está guardado el título del libro
    public string gettitulo(){
        //Escribe lo que esté guardado en la variable
        return this.titulo;
    }
    //Guarda el nombre del libro en la variable título
public string settitulo(string nombrel){
    //Iguala una variable a otra para usarla fuera de la clase
        return this.titulo=nombrel;
}
//llama la variable donde está guardado el nombre del autor
    public string getautor(){
        //Escribe lo que esté guardado en la variable
        return this.autor;
    }
    //Guarda el nombre del autor en la variable autor
public string setautor(string nombrea){
    //Iguala una variable a otra para usarla fuera de la clase
        return this.autor=nombrea;
}
//llama la variable donde está guardado el codigo del libro
    public int getcodigo(){
        //Escribe lo que esté guardado en la variable
        return this.codigo;
    }
    //Guarda el código del libro en la variable codigo
public int setcodigo(int code){
    //Iguala una variable a otra para usarla fuera de la clase
       return this.codigo=code;
}
//llama la variable donde esta guardado el número de páginas
    public int getpaginas(){
        //Escribe lo que está guardado en la variable
       return this.paginas;

    //Guarda el numero de páginas en la variable paginas
public int setpaginas (int npagi){ 
    //Iguala una variable a otra para usarla fuera de la clase
       return this.paginas=npagi;
}
//Escribe el mensaje completo de el libro que buscamos
public void tostring(){ Console.WriteLine ("El libro "+this.titulo+" con ISBN "+this.codigo+" creado por el autor "+this.autor+" tiene "+this.paginas+"páginas.");
}
} 
}