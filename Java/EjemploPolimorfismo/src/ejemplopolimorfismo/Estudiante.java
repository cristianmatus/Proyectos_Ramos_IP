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
public class Estudiante extends Persona{
    
    private String carrera;
    
    public Estudiante()
    {
        
    }
    
    public String getCarrera()
    {
        return carrera;
    }
    
    public void setCarrera(String carrera)
    {
        this.carrera = carrera;
    }
    
    public void Estudiar()
    {
        System.out.println("Hablar como estudiante");
    }

    @Override
    public void Bailar() {
       
    }
            
}
