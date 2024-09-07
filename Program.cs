using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

// Adiciona os hóspedes na lista
hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando os dias reservados e a suíte
Reserva reserva = new Reserva(diasReservados: 5);

// Cadastra a suíte na reserva
reserva.CadastrarSuite(suite);

// Cadastra os hóspedes na reserva, verificando a capacidade da suíte
try
{
    reserva.CadastrarHospedes(hospedes);
}
catch (Exception e)
{
    Console.WriteLine($"Erro: {e.Message}");
}

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
