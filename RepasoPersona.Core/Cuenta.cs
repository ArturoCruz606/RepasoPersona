namespace RepasoPersona.Core
{
    public class Cuenta:Ente_Con_Saldo
    {
        public int CBU { get; set; }
        public Persona Cliente { get; set; }
        public Cuenta() => Saldo = 0;
        public Cuenta(int cbu, Persona cliente, int saldo){
            CBU = cbu;
            Cliente = cliente;
            Saldo = saldo;
        } 
    }
}