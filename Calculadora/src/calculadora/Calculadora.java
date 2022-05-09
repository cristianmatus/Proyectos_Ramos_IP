/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package calculadora;
import java.util.Scanner;
/**
 *
 * @author Matute
 */
public class Calculadora {


    public static void main(String[] args) 
    {
        Scanner entrada = new Scanner(System.in);
        
        System.out.println("Ingrese el primer numero");
        int n1 = entrada.nextInt();
        
        System.out.println("Ingrese el segundo numero");
        int n2 = entrada.nextInt();
        
        MiniCalculadora c = new MiniCalculadora(n1,n2);
        CalculadoraCientifica cc = new CalculadoraCientifica(5000);
        CalculadoraFinanciera cf = new CalculadoraFinanciera();
        
        cc.porcentaje();
        cc.porcentaje(0.30);
        
        
        int suma;
        float div;
        
        div = c.Dividir();
        c.Resta();
        suma = c.Suma();
        System.out.println("La suma es: " + suma);
        System.out.println("La división es: " + div);
    }
    
}
