using System;
using RepasoPersona.Core;
using Xunit;

namespace RepasoPersona.Test
{
    public class CuentaTest
    {
        public Cuenta Paypal { get; set; }
        public CuentaTest() => Paypal = new Cuenta(100,null, 0);

        [Fact]
        public void Constructor()
        {
            Assert.Equal(100, Paypal.CBU);
            Assert.Equal(null, Paypal.Cliente);
            Assert.Equal(0, Paypal.Saldo);
        }

        [Fact]
        public void AcreditarPositivo()
        {
            double esperado = 1000;
            Paypal.Acreditar(esperado);
            
            Assert.Equal(esperado, Paypal.Saldo, 3);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-157.34)]
        public void AcreditarCeroONegativo(double monto)
        {
            var ex = Assert.Throws<ArgumentException>(() => Paypal.Acreditar(0));
            Assert.Equal("El monto tiene que ser mayor a cero.", ex.Message);
        }

        [Fact]
        public void Debitar()
        {
            double monto = 500.45;
            double debito = 135.45;
            Paypal.Acreditar(monto);
            Paypal.Debitar(debito);

            Assert.Equal(monto - debito, Paypal.Saldo, 2);
        }

        [Fact]
        public void DebitarInsuficiente()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => Paypal.Debitar(1000));
            Assert.Equal("El monto supera al saldo de la cuenta.", ex.Message);
        }
    }
}