// See https://aka.ms/new-console-template for more information
using ConsoleApp_123tarde;
using ConsoleApp_123tarde.Heranca;
using Microsoft.VisualBasic;

Produto p1 = new Produto(1, "Mouse paraguai", 10.90M);
Produto p2 = new Produto(2, "Teclado lenovo", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco(1,
    " 15906304",
    " Mario Miziara",
    " 91",
    " Sobral",
    " Taquaritinga"
    );

Cliente c1 = new Cliente(1, "Fernando", "991340447", e1);
Cliente c2 = new Cliente(2, "Victoria", "991340447", e1);
Cliente c3 = new Cliente(3, "Rafael", "991340447", e1);
Cliente c4 = new Cliente(4, "Lucas", "9913409876", e1);
Cliente c5 = new Cliente(5, "Eduardo", "991340447", e1);


Console.WriteLine(c1.GetEndereco().EnderecoCompleto());
c1.GetEndereco().setRua(" Prudente de Morais ");
Console.WriteLine(c1.GetEndereco().EnderecoCompleto());
c1.GetEndereco().AtualizarEndereco(" Julio de Moraes ", " 585 ", " Rua Augusta ");
Console.WriteLine(c1.GetEndereco().EnderecoCompleto());


Carro car = new Carro();
car.cor = "vermelho";
car.quantidadedeRodas = 4;
car.quantidadedeAcentos = 5;
car.TemMotor = true;

Bicicleta bicicleta = new Bicicleta();
bicicleta.cor = "Azul";
bicicleta.quantidadedeRodas = 2;
bicicleta.quantidadedeAcentos = 1;
bicicleta.TemMotor = false;

Aviao avinhao = new Aviao();
avinhao.cor =  "branco";
avinhao.quantidadedeRodas = 18;
avinhao.quantidadedeAcentos = 158;
avinhao.TemMotor = true;

List<Veiculo> veiculoLista = new List<Veiculo>();
veiculoLista.Add(car);
veiculoLista.Add(avinhao);
veiculoLista.Add(bicicleta);

foreach (var item in veiculoLista)
{
    Console.WriteLine("Qtd itens da lista " + veiculoLista.Count);
}

//crie uma lista de produtos com 400 produtos 
//outra lista de clientes com 250 clientes

Random rand = new Random();
List<Produto> lsProduto = new List<Produto>();

for (int i = 1; i< rand.Next(200,500); i++)
{
    Produto p = new Produto(i, "Produto tal " + i, i / 2 * 15);
    lsProduto.Add(p);
}

foreach (var item in lsProduto)
{
    Console.WriteLine(item.ExibirProdutos());
}

List<Cliente> lsCliente = new List<Cliente>();

for (int i = 1; i <= 250; i++)
{
    Endereco e = new Endereco(1, "Rua ", "1 60909090 "," 1 "," Meu pau ", " São Paulo ");
    Cliente c = new Cliente(i, "Kadhz "+i, "16090909 "+i, e);
    lsCliente.Add(c);

}
foreach(var item in lsCliente)
{
    Console.WriteLine(item.ExibirCliente());
}

