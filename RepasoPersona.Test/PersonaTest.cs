using System;
using Xunit;
using RepasoPersona.Core;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        public Persona ElAndres { get; set; }
        [Fact]
        public void Constructor()
        {
            ElAndres = new Persona("Pepito", "Gomez", 0);
            Assert.Equal("Pepito", ElAndres.Nombre);
            Assert.Equal("Gomez", ElAndres.Apellido);
            Assert.Equal(0, ElAndres.Efectivo);
        }
    }
}
