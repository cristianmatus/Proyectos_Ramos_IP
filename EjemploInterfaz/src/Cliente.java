import java.util.ArrayList;

public class Cliente {

  
    private ArrayList<String> Interes; //cuando es mas de una opcion se colecciona en una lista
    private String nombre;
    private String apellido;
    private String direccion;
    private int tipocliente;
    private String sexo;
    
    public Cliente()
    {
        
    }
    
    public Cliente(ArrayList<String> Interes, String nombre, String apellido, 
            String direccion, int tipocliente, String sexo)
    {
        this.Interes = Interes;
        this.nombre = nombre;
        this.apellido = apellido;
        this.direccion = direccion;
        this.tipocliente = tipocliente;
        this.sexo = sexo;
    }
    
        public ArrayList<String> getInteres() {
        return Interes;
    }

    public void setInteres(ArrayList<String> Interes) {
        this.Interes = Interes;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public int getTipocliente() {
        return tipocliente;
    }

    public void setTipocliente(int tipocliente) {
        this.tipocliente = tipocliente;
    }

    public String getSexo() {
        return sexo;
    }

    public void setSexo(String sexo) {
        this.sexo = sexo;
    }
    
    
}
