/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejemplopolimorfismo;

/**
 *
 * @author Matute
 */
public abstract class Persona {
    
    private String nombre;
    private int edad;
    
    public Persona()
    {
        
    }
    
    public String getNombre()
    {
        return nombre;
    }
    
    public void setNombre(String nombre)
    {
        this.nombre = nombre;
    }
    
    public int getEdad()
    {
        return edad;
    }
    
    public void setEdad(int edad)
    {
        this.edad = edad;
    }
    
    public void Hablar()
    {
        System.out.println("Hablar");
    }
    
    public abstract void Bailar();//los metodos abstractos se implementan sin cuerpo
}
