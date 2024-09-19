using System.Diagnostics.Contracts;

public class Administrativo : DocenteFijo
{
    public Administrativo(string Nombre, string Nss, decimal sueldo, bool meta) : base(Nombre, Nss, sueldo, meta)
    {
    }

    public override decimal Ingreso()
    {
        return base.Ingreso();
    }

    public override decimal Bonificaciones()
    {
        return base.Bonificaciones();
    }
    public override string ToString()
    {
        return base.ToString();
    }
}

