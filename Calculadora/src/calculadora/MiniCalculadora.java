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
public class MiniCalculadora {
    
    private int numero1;
    private int numero2;
    
    public MiniCalculadora()
    {
        
    }
    
    public MiniCalculadora(int n1, int n2)
    {
        this.numero1 = n1;
        this.numero2 = n2;
    }
    
    public int Getnumero1()
    {
        return this. numero1;
    }
    
    public void Setnumero1 (int numero1)
    {
        this.numero1 = numero1;
    }
    
    public int Getnumero2()
    {
        return this.numero2;
    }
    
    public void Setnumero2(int numero2)
    {
        this.numero2 = numero2;
    }
    
    public int Suma()
    {
        int resultado;
        resultado = this.numero1 + this.numero2;
        return resultado;
    }
    
    public void Resta()
    {
        int resultado;
        resultado = this.numero1 - this.numero2;
        System.out.println("El resultado de la resta es : " + resultado);
    }
    
    public float Dividir()
    {
        float resultado;
        
        if (this.numero2 != 0)
        {
            resultado = this.numero1 / this.numero2;
            return resultado;
        }
        else
        {
            System.out.println("No se puede dividir por 0");
            return 0;
        }
    }
    
    //agregar el metodo multiplicar
    public int multiplicacion()
    {
        int resultado;
        
        if(this.numero2 !=0)
        {
            resultado = this.numero1 * this.numero2;
            return resultado;
        }
        else
        {
            System.out.println("No se puede multiplicar por 0");
            return 0;
        }
    }
    
    public int multiplicación(int numero3)
    {
        int resultado;
        
        resultado = this.numero1 * this.numero2 * numero3;
        
        return resultado;
    }
}
