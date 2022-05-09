/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package institucioneducacional;
import java.util.Scanner;

/**
 *
 * @author Matute
 */
public class InstitucionEducacional {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Scanner entrada = new Scanner (System.in);
        
        System.out.println("---------------------------------------------");
        System.out.println("...Menu información casa de estudio...");
        System.out.println("");
        System.out.println("1. Area Docente");
        System.out.println("2. Area Alumnos");
        System.out.println("3. Area personal");
        System.out.println("");
        System.out.println("--------------------------------------------");
        System.out.println("Ingrese opcion:");
        
        int opcion = entrada.nextInt();
        String opcion2;
        opcion2 = entrada.next();
       
        String nom; 
        String ape;
        String rut;
        String est;
        int edad;
        String depa;
        String carr;
        int año;
        int num;
        String sec;
        
        Persona p;
        Docente d;
        Alumno a;
        PersonalAdministrativo pa;
       
        switch (opcion)
        {
            case 1:
                
                System.out.println("Ingrese nombre: ");
                nom = entrada.next();
                System.out.println("Ingrese apellido: ");
                ape = entrada.next();
                System.out.println("Ingrese rut: ");
                rut = entrada.next();
                System.out.println("Ingrese estado civil: ");
                est = entrada.next();
                System.out.println("Ingrese edad: ");
                edad = entrada.nextInt();
                System.out.println("Ingrese departamento: ");
                depa = entrada.next();
                
                p = new Persona(nom, ape, rut, est, edad);
                p.tuDatos();
                d.cambioDepartamento();
                

                break;
                
            case 2:
                
                System.out.println("Ingrese nombre: ");
                nom = entrada.next();
                System.out.println("Ingrese apellido: ");
                ape = entrada.next();
                System.out.println("Ingrese rut: ");
                rut = entrada.next();
                System.out.println("Ingrese estado civil: ");
                est = entrada.next();
                System.out.println("Ingrese edad: ");
                edad = entrada.nextInt();
                System.out.println("Ingrese carrera: ");
                carr = entrada.next();
                
                
                p = new Persona(nom, ape, rut, est, edad);
                a.MatriculaCarrera();
                break;
                
            case 3:
                System.out.println("Ingrese nombre: ");
                nom = entrada.next();
                System.out.println("Ingrese apellido: ");
                ape = entrada.next();
                System.out.println("Ingrese rut: ");
                rut = entrada.next();
                System.out.println("Ingrese estado civil: ");
                est = entrada.next();
                System.out.println("Ingrese edad: ");
                edad = entrada.nextInt();
                System.out.println("Ingrese año ingreso: ");
                año = entrada.nextInt();
                System.out.println("Ingrese numero empleado: ");
                num = entrada.nextInt();
                System.out.println("Ingrese seccion: ");
                sec = entrada.next();
                
                
                p = new Persona(nom, ape, rut, est, edad);
                pa.incorporacion();
                pa.empleado();
                pa.seccion();
                
                break;
        }
    }
    
}
