using Cadastro;

namespace Repositorio;

public class ClienteRepositorio
{
    public List<Cliente> clientes = new List<Cliente>();

    public void ImprimirCliente(Cliente cliente)
    {
        Console.WriteLine("ID: " + cliente.id);
        Console.WriteLine("Nome:  " + cliente.nome);
        Console.WriteLine("Desconto: " + cliente.desconto.ToString("0.00"));
        Console.WriteLine("Data Nascimento: " + cliente.dataNascimento);
        Console.WriteLine("Data Cadastro: " + cliente.cadastradoEm);
        Console.WriteLine("----------------------------");

    }

    public void ExibirClientes()
    {
        Console.Clear();

        foreach (var cliente in clientes)
        {
            ImprimirCliente(cliente);
        }

        Console.ReadKey();
    }

    public void EditarCliente()
    {

        Console.Clear();
        Console.Write("Informe o código do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.id == int.Parse(codigo));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado!");
            Console.ReadKey();
            return;
        }

        ImprimirCliente(cliente);

        Console.Write("Nome do Cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Data de Nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.Write("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);


        cliente.nome = nome;
        cliente.dataNascimento = dataNascimento;
        cliente.desconto = desconto;
        cliente.cadastradoEm = DateTime.Now;

        Console.WriteLine("Cliente alterado com sucesso! [Enter]");
        ImprimirCliente(cliente);
        Console.ReadKey();
    }

    public void CadastrarCliente()
    {
        Console.Write("Nome do Cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Data de Nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.Write("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        var cliente = new Cliente();
        cliente.id = clientes.Count + 1;
        cliente.nome = nome;
        cliente.dataNascimento = dataNascimento;
        cliente.desconto = desconto;
        cliente.cadastradoEm = DateTime.Now;

        clientes.Add(cliente);

        Console.WriteLine("Cliente cadastrado com sucesso! [Enter]");
        ImprimirCliente(cliente);
        Console.ReadKey();
    }

    public void ExcluirCliente()
    {

        Console.Clear();
        Console.Write("Informe o código do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.id == int.Parse(codigo));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado!");
            Console.ReadKey();
            return;
        }

        ImprimirCliente(cliente);

        clientes.Remove(cliente);

        Console.WriteLine("Cliente removido com sucesso! [Enter]");

        Console.ReadKey();

    }

}