
public class Validador {
    
    public boolean ValidaLogin(Usuario u)
    {
        return u.getUsuario().equals("demo") && u.getPass().equals("abc");
        
    }
    
    
}
