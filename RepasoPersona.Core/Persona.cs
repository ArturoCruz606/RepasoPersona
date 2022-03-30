using System;
using System.Collections.Generic;
using System.Linq;
namespace RepasoPersona.Core
{
    public class Persona:Ente_Con_Saldo
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public override double Saldo => base.Saldo + SumaCuentas;
        public List<Cuenta> Cuentas { get; set; }
        public Persona() => Saldo = 0;
        public Persona(string nombre, string apellido, double efectivo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Saldo = efectivo;
            Cuentas = new List<Cuenta>();
        }
        public double SumaCuentas => Cuentas.Sum(x => x.Saldo);
        public void AgregarCuenta(int cbu) => Cuentas.Add(new Cuenta{
            CBU = cbu
        });
    }
}
