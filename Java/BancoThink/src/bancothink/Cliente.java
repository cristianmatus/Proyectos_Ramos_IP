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
public class Cliente {
    
    private String rut;
    private String nombre;
    private String apellidoPaterno;
    private String apellidoMaterno;
    private String telefono;
    private String numeroCredito;
    private String direccionParticular;
    private String direccionLaboral;
    private int meses;
    private double sueldo;
    private double credito;
    private double cuotas;
    private String fechaAutorización;
    private String fechaEntrega;
    private double valorCuota;
    
    public Cliente(String rut, String nombre, String apellidoPaterno,
            String apellidoMaterno, String telefono, String numeroCredito,
            String direccionParticular, String direccionLaboral,
            int meses, double sueldo, double credito, double cuota, 
            String fechaAutorizacion, String fechaEntrega, double valorCuota)
    {
        this.rut = rut;
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;
        this.apellidoMaterno = apellidoMaterno;
        this.telefono = telefono;
        this.numeroCredito = numeroCredito;
        this.direccionParticular = direccionParticular;
        this.direccionLaboral = direccionLaboral;
        this.meses = meses;
        this.sueldo = sueldo;
        this.credito = credito;
        this.cuotas = cuota;
        this.fechaAutorización = fechaAutorizacion;
        this.fechaEntrega = fechaEntrega;
        this.valorCuota = valorCuota;
    }


    public String getRut() {
        return rut;
    }

    public void setRut(String rut) {
        this.rut = rut;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidoPaterno() {
        return apellidoPaterno;
    }

    public void setApellidoPaterno(String apellidoPaterno) {
        this.apellidoPaterno = apellidoPaterno;
    }

    public String getApellidoMaterno() {
        return apellidoMaterno;
    }

    public void setApellidoMaterno(String apellidoMaterno) {
        this.apellidoMaterno = apellidoMaterno;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getNumeroCredito() {
        return numeroCredito;
    }

    public void setNumeroCredito(String numeroCredito) {
        this.numeroCredito = numeroCredito;
    }

    public String getDireccionParticular() {
        return direccionParticular;
    }

    public void setDireccionParticular(String direccionParticular) {
        this.direccionParticular = direccionParticular;
    }

    public String getDireccionLaboral() {
        return direccionLaboral;
    }

    public void setDireccionLaboral(String direccionLaboral) {
        this.direccionLaboral = direccionLaboral;
    }

    public int getMeses() {
        return meses;
    }

    public void setMeses(int meses) {
        this.meses = meses;
    }

    public double getSueldo() {
        return sueldo;
    }

    public void setSueldo(double sueldo) {
        this.sueldo = sueldo;
    }

    public double getCredito() {
        return credito;
    }

    public void setCredito(double credito) {
        this.credito = credito;
    }

    public double getCuotas() {
        return cuotas;
    }

    public void setCuotas(double cuotas) {
        this.cuotas = cuotas;
    }

    public String getFechaAutorización() {
        return fechaAutorización;
    }

    public void setFechaAutorización(String fechaAutorización) {
        this.fechaAutorización = fechaAutorización;
    }

    public String getFechaEntrega() {
        return fechaEntrega;
    }

    public void setFechaEntrega(String fechaEntrega) {
        this.fechaEntrega = fechaEntrega;
    }
    
    public double getValorCuota() {
        return valorCuota;
    }

    public void setValorCuota(double valorCuota) {
        this.valorCuota = valorCuota;
    }
    
}
