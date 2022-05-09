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
public class Secretaria extends Persona{
    
    private String tipear;
    
    public Secretaria()
    {
        
    }
    
    public String getTipear()
    {
        return tipear;
    }
    
    public void setTipear()
    {
        this.tipear = tipear;
    }
    
    public void Tipear()
    {
        System.out.println("Tipea como secretaria");
    }
    
    @Override //sobreescritura de metodo
    public void Hablar()
    {
        System.out.println("Habla como secretaria");
    }

    @Override
    public void Bailar() {

    }
}
