/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bancothink;

/**
 *
 * @author Matute
 */
public class Validar{

   
   public boolean ValidaUsuario(Usuario us)
   {
       return us.getUsuario().equals("hola") && us.getClave().equals("123");
   }
   
   
}
