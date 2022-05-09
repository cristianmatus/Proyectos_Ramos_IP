/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package institucioneducacional;

/**
 *
 * @author Matute
 */
public class Persona {
    
    private String nombre;
    private String apellido;
    private String rut;
    private String estadoCivil;
    private int edad;

    
    public String GetNombre()
    {
        return this.nombre;
    }
    public String GetApellido()
    {
        return this.apellido;
    }
    public String GetRut()
    {
        return this.rut;
    }
    public String GetEstadoCivil()
    {
        return this.estadoCivil;
    }
    public int GetEdad()
    {
        return this.edad;
    }

    
    public void SetNombre(String nombre)
    {
        this.nombre = nombre;
    }
    public void SetApellido(String apellido)
    {
        this.apellido = apellido;
    }
    public void SetRut(String rut)
    {
        this.rut = rut;
    }
    public void SetEstadoCivil(String estadoCivil)
    {
        this.estadoCivil = estadoCivil;
    }
    public void SetEdad(int edad)
    {
        this.edad = edad;
    }
    
    public void CambioEst(String estadoCivil)
    {
        this.estadoCivil = estadoCivil;
        System.out.println("Usted a cambiado su estado civil a: " + this.estadoCivil);
    }
    
    public void tuDatos()
    {
        String nombre;
        String apellido;
        String rut;
        String estadocivil;
        int edad;
        nombre = this.nombre;
        System.out.println("Nombre =  " + nombre );
        apellido = this.apellido;
        System.out.println("Apellido =  " + apellido );
        rut = this.rut;
        System.out.println("Apellido =  " + rut );
        estadocivil = this.estadoCivil;
        System.out.println("Estado civil =  " + estadocivil );
        edad = this.edad;
        System.out.println("Edad =  " + edad);
    }

}
