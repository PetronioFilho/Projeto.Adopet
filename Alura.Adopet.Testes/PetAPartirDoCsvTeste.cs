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

            //Act   
            Pet pet = linha.ConverteDoTexto();

            //Asset
            Assert.NotNull(pet);
        }

        [Fact]
        public void QuandoStringForNula()
        {
            //Arrange
            string linha = null;

            //Act   
            Pet pet = linha.ConverteDoTexto();

            //Asset
            Assert.Null(pet);
        }

        [Fact]
        public void QuandoStringForVazia()
        {
            //Arrange
            string linha = "";

            //Act   
            Pet pet = linha.ConverteDoTexto();

            //Asset
            Assert.Null(pet);
        }

        [Fact]
        public void QuandoAStringNaoEstiverCompletada()
        {
            //Arrange
            string linha = "3fa85f64-5717-4562-b3fc-2c963f66afa6;Lima Limão";

            //Act   
            Pet pet = linha.ConverteDoTexto();

            //Asset
            Assert.Null(pet);
        }

        [Fact]
        public void QuandoAStringForMaiorQueOEstabelecido()
        {
            //Arrange
            string linha = "3fa85f64-5717-4562-b3fc-2c963f66afa6;Lima Limão;1;1;1";

            //Act   
            Pet pet = linha.ConverteDoTexto();

            //Asset
            Assert.Null(pet);
        }

        [Fact]
        public void QuandoOGuidForInvalido()
        {
            //Arrange
            string linha = "'';Lima Limão;1";

            //Act   
            Pet pet = linha.ConverteDoTexto();

            //Asset
            Assert.Null(pet);
        }
    }
}
