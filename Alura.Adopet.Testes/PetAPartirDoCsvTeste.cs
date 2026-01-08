using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Testes
{
    public class PetAPartirDoCsvTeste
    {
        [Fact]
        public void QuandoStringForValidaDEveRetornarUmPet()
        {
            //Arrange
            string linha = "3fa85f64-5717-4562-b3fc-2c963f66afa6;Lima Limão;1";
            var conversor = new PetAPartirDoCsv();

            //Act   
            Pet pet = conversor.ConvertTexto(linha);

            //Asset
            Assert.NotNull(pet);
        }
    }
}
