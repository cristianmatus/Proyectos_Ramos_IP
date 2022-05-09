/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package calculadora;

/**
 *
 * @author Matute
 */

//extends es la herencia, calculadora cientifica hereda todo lo de mini calculadora
//hereda atributos y metodos
public class CalculadoraCientifica extends MiniCalculadora {
    

    private int numero1;
    
    public CalculadoraCientifica()
    {
        
    }
    
    public CalculadoraCientifica(int n1, int n2, int n3)
    {
        super.Setnumero1(n1);
        super.Setnumero2(n2);
        this.numero1 = n3;
    }
    
    //accion de raiz cuadrada
    
    public void raizCuadrada()
    {
        double resultado;
        resultado = Math.sqrt(this.numero1);
        System.out.println("La raiz cuadrada de: " + this.numero1 + " es: " + resultado);
    }
    // accion de porcentaje
    
    public void porcentaje()
    {
        double resultado;
        resultado = this.numero1 * 0.100;
        System.out.println("El porcentaje sobre 100 de: " + this.numero1 + "es: " + resultado);
    }
    
    public void porcentaje(double n1)
    {
        double resultado;
        resultado = this.numero1 * n1;
        System.out.println("El porcentaje sobre 100 de: " + this.numero1 + "es: " + resultado);
    }
}
