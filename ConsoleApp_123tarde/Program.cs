// See https://aka.ms/new-console-template for more information
using ConsoleApp_123tarde;




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
