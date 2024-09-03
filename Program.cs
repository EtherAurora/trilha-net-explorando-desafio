using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>(){
    new Pessoa(nome: "Hóspede 1"),
    new Pessoa(nome: "Hóspede 2")
};

// Cria a suíte
Suite suite = new Suite();
Console.WriteLine("Qual quarto?");

Console.WriteLine("Categorias:");
Console.WriteLine("Standard");
Console.WriteLine("Deluxe");
Console.WriteLine("Premium");
Console.WriteLine("Executiva");

string quarto = Console.ReadLine().ToLower();
switch (quarto){
    case "standard":
    suite = new Suite(tipoSuite: "Standard", capacidade: 2, valorDiaria: 30);
    break;
    case "deluxe":
    suite = new Suite(tipoSuite: "Deluxe", capacidade: 4, valorDiaria: 60);
    break;
    case "premium":
    suite = new Suite(tipoSuite: "Premium", capacidade: 6, valorDiaria: 90);
    break;
    case "executiva":
    suite = new Suite(tipoSuite: "Executiva", capacidade: 8, valorDiaria: 120);
    break;
    default:
    Console.WriteLine("Categoria não valida, por favor tente novamente");
    break;
}
Console.WriteLine("Quantos dias?");
int dias = Convert.ToInt32(Console.ReadLine());

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: dias);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
Console.WriteLine("Aperte Enter para prosseguir");
Console.ReadLine();