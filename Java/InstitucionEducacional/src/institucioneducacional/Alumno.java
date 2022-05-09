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
public class Alumno extends Persona {
    
    private String carrera;
    
    
    public String GetCarrera()
    {
        return this.carrera;
    }
    
    public void SetCarrera(String carrera)
    {
        this.carrera = carrera;
    }
    
    public void MatriculaCarrera(String carrera)
    {
        String matricula;
        matricula = this.carrera;
        System.out.println("Se cambio a la carrera de: " + matricula );        
    }
    
    public void cambioCarrera(String carrera)
    {
        this.carrera = carrera;
        System.out.println("Se cambio a la carrera: " + this.carrera);
    }
}
