using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util
{
    public class PetAPartirDoCsv
    {
        public Pet ConvertTexto(string linha)
        {            
            string[]? propriedades = linha.Split(';');
            
            return new Pet(Guid.Parse(propriedades[0]),
            propriedades[1],
            int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }
    }
}
