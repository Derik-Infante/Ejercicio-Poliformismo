public abstract class Empleado{
    public string Nombre {get ; set;}
    public string Nss {get; set;}

    public Empleado(string Nombre, string Nss){
        this.Nombre = Nombre;
        this.Nss = Nss;
    }

    public abstract decimal Ingreso();

    public override abstract string ToString();

}