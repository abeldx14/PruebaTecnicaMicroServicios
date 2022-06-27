using NUnit.Framework;
using PruebaTecnicaMicroServicios.Entidades;

namespace PruebasUnitarias
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetPersona_DevolverPersona()
        {
            //Personatest[] perTest = new Personatest[7] { new perTest { id= } }
            Persona[] resultadoPersona = new Persona[1] { new Persona { Id= 1 
                                                                        ,nombre = "persona1test"
                                                                        ,genero = "masculino"
                                                                        ,edad = 30
                                                                        ,identificacion = 11112222
                                                                        ,direccion = "micasadirecion"
                                                                        ,telefono = 99999999}};
            int indice = 1;
            Persona resultadoEsperado = resultadoPersona[1];

            //Personas.GetPersona
            //Persona resultadoActual = Persona.Equals(resultadoPersona, indice);
            CollectionAssert.Equals(resultadoPersona, resultadoEsperado);
        }
    }
}