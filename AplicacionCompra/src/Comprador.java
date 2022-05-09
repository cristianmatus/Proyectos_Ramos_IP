/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Matute
 */
public class Comprador 
{
    //atributos, metodos (variables, constantes e instrucciones de acciones
    
    //todos los verdes son atributos y los negros variables
    
    //declarar los atributos de la clase comprador
    private String nombre;
    private String rut;
    private int edad;
    private String sexo;
    private String metodoPago;
    private boolean esEmpresa;
    
    //constructor forma 1: aqui puedes darle estos mismo valores a todos los objetos
    
//    public Comprador()
//    {
//        this.nombre = "cristian";
//        this.rut = "1-9";
//        this.edad = 29;
//        this.sexo = "M";
//        this.metodoPago = "tarjeta de credito";
//        this.esEmpresa = false;
//    }
    
    //constructor forma 2, la mas optima
    public Comprador(String nombre, String rut, int edad, String sexo, String metodopago, boolean esempresa)
    {
        this.nombre = nombre;
        this.rut = rut;
        this.edad = edad;
        this.sexo = sexo;
        this.metodoPago = metodopago;
        this.esEmpresa = esempresa;
    }
    
    //sobrecarga
    
    public Comprador(String nombre)
    {
        this.nombre = nombre;
    }
    
    public Comprador(int edad)
    {
        this.edad = edad;
    }
    
    
    
    //el metodo set permite modificar el valor del atributo
    public void SetNombre(String nombre)
    {
        this.nombre = nombre;
    }
    public void SetRut(String rut)
    {
        this.rut = rut;
    }
    public void SetEdad(int edad)
    {
        this.edad = edad;
    }
    public void SetSexo(String sexo)
    {
        this.sexo = sexo;
    }
    public void SetMetodoPago (String metodoPago)
    {
        this.metodoPago = metodoPago;
    }
    public void SetEsEmpresa(boolean esEmpresa)
    {
        this.esEmpresa = esEmpresa;
    }
    
    //metodo get permite vizualizar el valor del atributo
    public String GetNombre()
    {
        return this.nombre;
    }
    public String GetRut()
    {
        return this.rut;
    }
    public int GetEdad()
    {
        return this.edad;
    }
    public String GetSexo()
    {
        return this.sexo;
    }
    public String GetMetodoPago()
    {
        return this.metodoPago;
    }
    public boolean GetEsEmpresa()
    {
        return this.esEmpresa;
    }
   
    
    //acciones = Metodos
    public int suma(int num1, int num2)
    {
        int resultado;
        
        resultado = num1 + num2;
        
        return resultado;
    }
    
    public void saludo()//metodo que no restorna
    {
        System.out.println("Hola a todos");//mostrar el mensaje con salto de linea
    }
}
