public class DocenteFijo : Empleado, IBonificaciones

{
    decimal sueldo {get; set;}
     decimal bonificacion = 0.10m;
    bool meta {get; set;} 
    public DocenteFijo(string Nombre, string Nss, decimal sueldo, bool meta) 
                                :base(Nombre, Nss){
        this.sueldo = sueldo;

    }
    public override decimal Ingreso()
    {
        return sueldo;
    }
            public virtual decimal Bonificaciones(){
               if(meta == true){

                return sueldo*bonificacion;

               }
                else{

                    return (sueldo*bonificacion)/2;
                }
            }

    public override string ToString()
    {
        return $"Nombre: {Nombre}\nNss: {Nss}\nSueldo: {Ingreso()}\nBonificacion: {Bonificaciones()} ";
    }
}

internal interface IBonificaciones
{
    decimal Bonificaciones();
}