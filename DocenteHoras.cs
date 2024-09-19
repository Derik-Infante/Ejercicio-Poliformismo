 public class DocenteHoras : Empleado
        {
            protected int Horas {get; set;}
            protected decimal tarifa = 800;
            public DocenteHoras(string Nombre, string Nss, int Horas) : base(Nombre, Nss)
            {
                this.Horas = Horas;
               
            }
        public override decimal Ingreso()
        {
            int horasPorDefult = 40;
            decimal comision = 1.6m;
            decimal valorsueldo;
                
            if(this.Horas <= horasPorDefult){
                valorsueldo = this.Horas * this.tarifa;
                return valorsueldo;
            }
            else{
                valorsueldo =this.Horas * this.tarifa + ((this.Horas - 40)*this.tarifa * comision);
                return valorsueldo;
            }
               
        }

    public override string ToString()
    {
        return $"Nombre: {Nombre}\nNss: {Nss}\nSueldo: {Ingreso()}\nTarifa: {tarifa} ";
    }
}