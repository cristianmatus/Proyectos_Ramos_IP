/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Matute
 */
public class Producto 
{
    private String nombre;
    private String tamaño;
    private boolean peso;
    private String color;
    private String marca;
    private int garantia;
    private int codigoBarra;
    
    public Producto(String nombre, String tamaño, boolean peso, String color, String marca, int garantia, int codigobarra)
    {
        this.nombre = nombre;
        this.tamaño = tamaño;
        this.peso = peso;
        this.color = color;
        this.marca = marca;
        this.garantia = garantia;
        this.codigoBarra = codigobarra;
    }
    
    public Producto(String nombre, String tamaño)
    {
        this.nombre = nombre;
        this.tamaño = tamaño;
    }
    
    public Producto(boolean peso, int garantia)
    {
        this.peso = peso;
        this.garantia = garantia;
    }
                
    public void SetNombre(String nombre)
    {
        this.nombre = nombre;
    }
    public void SetTamaño(String tamaño)
    {
        this.tamaño = tamaño;
    }
    public void SetPeso(boolean peso)
    {
        this.peso = peso;
    }    
    public void SetColor(String color)
    {
        this.color = color;
    }
    public void SetMarca(String marca)
    {
        this.marca = marca;
    }
    public void SetGarantia(int garantia)
    {
        this.garantia = garantia;
    }
    public void SetCodigoBarra(int codigoBarra)
    {
        this.codigoBarra = codigoBarra;
    }
    
    public String GetNombre()
    {
        return this.nombre;
    }
    public String GetTamaño()
    {
        return this.tamaño;
    }
    public boolean GetPeso()
    {
        return this.peso;
    }
    public String GetColor()
    {
        return this.color;
    }
    public String GetMarca()
    {
        return this.marca;
    }
    public int GetGarantia()
    {
        return this.garantia;
    }
    public int GetCodigoBarra()
    {
        return this.codigoBarra;
    }
}
