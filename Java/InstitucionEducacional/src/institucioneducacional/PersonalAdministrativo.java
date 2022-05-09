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
public class PersonalAdministrativo extends Persona{
    
    private int añoIncorporacion;
    private int numeroEmpleado;
    private String despacho;

    
    public int GetañoIncorporacion()
    {
        return this.añoIncorporacion;
    }
    public int GetNumeroEmpleado()
    {
        return this.numeroEmpleado;
    }
    public String GetDespacho()
    {
        return this.despacho;
    }

    
    public void SetañoIncorporacion(int añoIncorporacion)
    {
        this.añoIncorporacion = añoIncorporacion;
    }
    public void SetNumeroEmpleado(int numeroEmpleado)
    {
        this.numeroEmpleado = numeroEmpleado;
    }
    public void SetDespacho(String despacho)
    {
        this.despacho = despacho;
    }

            
    public void incorporacion()
    {
        int año;
        año = this.añoIncorporacion;
        System.out.println("Año de incoporación: " + año);
    }
    public void empleado()
    {
        int numero;
        numero = this.numeroEmpleado;
        System.out.println("Numero empleado: " + numero);
    }
    
    @override
    public void Mostrar()
    {
        System.out.println(this.añoIncorporacion);
        System.out.println(this.despacho);
        System.out.println(this.numeroEmpleado);
        System.out.println(super.GetRut());
        System.out.println(super.GetNombre());
        System.out.println(super.GetApellido());
        System.out.println(super.GetEstadoCivil());
        System.out.println(this.);
        System.out.println(this.);
    }
}
