using AtividadePOO11.Entities;


namespace AtividadePOO11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome do departamento: ");
            String deptNome = Console.ReadLine();
            
            Console.WriteLine("Entre os dados do funcionário: ");

            Console.Write("Nome: ");
            String nome = Console.ReadLine();

            Console.Write("Nivel (Junior/Intermediario/Senior):");
            String NivelAux = Console.ReadLine();

            

            if (NivelAux.ToUpper() == "JUNIOR")
            {
                NivelAux = "Junior";
            }
            else if (NivelAux.ToUpper() == "INTERMEDIARIO")
            {
                NivelAux = "Intermediario";
            }
            else if (NivelAux.ToUpper() == "SENIOR")
            {
                NivelAux = "Senior";
            }
            else
            {
                Console.WriteLine("DIGITE UMA OPÇÃO VÁLIDA! :)");
            }

            NivelTrabalhador Nivel = Enum.Parse<NivelTrabalhador>(NivelAux);


            Console.Write("Base salarial: ");
            double BaseSalarial = Convert.ToDouble(Console.ReadLine());
                                    
            Departamento departamento = new Departamento(deptNome);
            Trabalhador trabalhador = new Trabalhador(nome, Nivel, BaseSalarial, departamento);

            Console.Write("Quantos contratos para este trabalhador? ");
            int ContratosAux = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ContratosAux; i++)
            {
                Console.Write($"Entre os dados do contrato #{i+1}: ");

                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double ValorHora = Convert.ToDouble(Console.ReadLine());

                Console.Write("Duração (Horas): ");
                int Horas = Convert.ToInt32(Console.ReadLine());

                ContratoHora contrato = new ContratoHora(data, ValorHora, Horas);
                trabalhador.AddContrato(contrato);               
            }

            Console.WriteLine();

            Console.Write("Entre o mes e o ano para calcular a renda (MM/YYYY): ");
            String DataRenda = Console.ReadLine();

            int Mes = int.Parse(DataRenda.Substring(0, 2));

            int Ano = int.Parse(DataRenda.Substring(3));

            Console.WriteLine($"Nome: {trabalhador.Nome}");

            Console.WriteLine($"Departamento: {trabalhador.Departamento.Nome}");

            Console.WriteLine($"Renda para {DataRenda}: {trabalhador.Renda(Ano, Mes).ToString("F2")}");

            Console.ReadKey();
        }
    }
}
