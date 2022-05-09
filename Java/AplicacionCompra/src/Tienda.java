/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Matute
 */
public class Tienda 
{
    private String nombre;
    private String horaAtencion;
    private String direccion;
    private String medioPago;
    private int telefono;
    
    
    public Tienda(String nombre, String horaatencion, String direccion, String mediopago, int telefono)
    {
        this.nombre = nombre;
        this.horaAtencion = horaatencion;
        this.direccion = direccion;
        this.medioPago = mediopago;
        this.telefono = telefono;
    }
            
    public Tienda(String nombre, String horaatencion)
    {
        this.nombre = nombre;
        this.horaAtencion = horaatencion;
    }
    
    public void SetNombre(String nombre)
    {
        this.nombre = nombre;
    }
    public void SetHoraAtencion(String horaAtencion)
    {
        this.horaAtencion = horaAtencion;
    }
    public void SetDireccion(String direccion)
    {
        this.direccion = direccion;
    }
    public void SetMedioPago(String medioPago)
    {
        this.medioPago = medioPago;
    }
    public void SetTelefono(int telefono)
    {
        this.telefono = telefono;
    }
    
    public String GetNombre()
    {
        return this.nombre;
    }
    public String GetHoraAtencion()
    {
        return this.horaAtencion;
    }
    public String GetDireccion()
    {
        return this.direccion;
    }
    public String GetMedioPago()
    {
        return this.medioPago;
    }
    public int GetTelefono()
    {
        return this.telefono;
    }
    
}
