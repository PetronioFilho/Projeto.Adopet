using Alura.Adopet.Console.Comandos;

internal class Program
{
    private static async Task Main(string[] args)
    {
        ComandosDoSistema comandos = new();

        Console.ForegroundColor = ConsoleColor.Green;

        try
        {
            string comando = args[0].Trim();
            IComando? cmd = comandos[comando];

            if (cmd is not null)
            {
                await cmd.ExecutarAsync(args);
            }
            else
            {
                Console.WriteLine("Comando inválido! Utilize 'adopet help' para ver a lista de comandos disponíveis.");
            }
        }
        catch (Exception ex)
        {
            // mostra a exceção em vermelho
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}