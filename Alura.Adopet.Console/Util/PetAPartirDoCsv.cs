using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util
{
    public static class PetAPartirDoCsv
    {
        public static Pet ConverteDoTexto(this string linha)
        {
            if(!ValidaLinha(linha) || !ValidaGuid(linha))
                return null;
            string[]? propriedades = linha.Split(';');

            return new Pet(Guid.Parse(propriedades[0]),
            propriedades[1],
            int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }

        private static bool ValidaLinha(string linha)
        {
            if(string.IsNullOrEmpty(linha) || linha.Split(';').Count() != 3)
                return false;  
            return true;
        }

        private static bool ValidaGuid(string linha)
        {
            if(!Guid.TryParse(linha.Split(';')[0], out Guid guidResult))
                return false;
            return true;
        }
    }
}