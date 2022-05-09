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
public class Docente extends Persona{
   
    private String departamento;

    
    public String GetDepartamento()
    {
        return this.departamento;
    }
    
    public void SetDepartamento(String departamento)
    {
        this.departamento = departamento;
    }

    public void cambioDepartamento()
    {
        String resultado;
        resultado = this.departamento;
        System.out.println("departamento =  " + resultado );
    }
}
