using System;
using RepasoPersona.Core;
using Xunit;

namespace RepasoPersona.Test
{
    public class CuentaTest
    {
        public Cuenta Paypal { get; set; }
        public PersonaTest() => Paypal = new Persona(100,"Juan", 0);

        [Fact]
        public void Constructor()
        {
            Assert.Equal(100, Paypal.CBU);
            Assert.Equal("Juan", Paypal.Cliente.Nombre);
            Assert.Equal(0, Paypal.Saldo);
        }
    }
}