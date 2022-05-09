/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Matute
 */
public class Vendedor 
{
    public String nombre;
    public String rut;
    public int edad;
    public String sexo;
    
    public Vendedor(String nombre, String rut, int edad, String sexo)
    {
        this.nombre = nombre;
        this.rut = rut;
        this.edad = edad;
        this.sexo = sexo;
    }
    
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
}
