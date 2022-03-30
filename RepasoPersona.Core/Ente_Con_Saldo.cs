using System;

namespace RepasoPersona.Core
{
    public abstract class Ente_Con_Saldo
    {
        public virtual double Saldo { get; set; }
        public Ente_Con_Saldo() => Saldo = 0;
        public Ente_Con_Saldo(double efectivo) => Saldo = efectivo;

        
        public void Debitar(double monto){
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Saldo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            Saldo -= monto;
        }
        public void Acreditar(double monto){
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            Saldo += monto;
        }
    }
}