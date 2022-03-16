using System;
using Xunit;
using RepasoPersona.Core;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        public Persona ElAndres { get; set; }
        public PersonaTest() => ElAndres = new Persona("Pepito", "Gomez", 0);
        [Fact]
        public void Constructor()
        {
            Assert.Equal("Pepito", ElAndres.Nombre);
            Assert.Equal("Gomez", ElAndres.Apellido);
            Assert.Equal(0, ElAndres.Efectivo);
        }
        [Fact]
        public void AcreditarPositivo(){
            double esperado = 1000;
            ElAndres.Acreditar(esperado);
            Assert.Equal(esperado, ElAndres.Efectivo, 3);
        }
    }
}
