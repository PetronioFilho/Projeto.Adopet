using Alura.Adopet.Console.Servicos;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes
{
    public class UnitTest1
    {
        [Fact]
        public async Task ListaPetsDEveRetornarUmaListaNaoVazia()
        {
            //Arrange
            var clientPet = new HttpClientPet();

            //Act
            var lista = await clientPet.ListPetsAsync();

            //Assert
            Assert.NotNull(lista);
            Assert.NotEmpty(lista);
        }

        [Fact]
        public async Task QuandoApiForaDeveRetornarUmaExcecao()
        {
            //Arrange
            var clientPet = new HttpClientPet(uri: "http://localhost:1111");

            //Act + Assert
            await Assert.ThrowsAnyAsync<Exception>(() => clientPet.ListPetsAsync());
        }
    }
}