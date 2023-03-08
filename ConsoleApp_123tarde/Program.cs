// See https://aka.ms/new-console-template for more information
using ConsoleApp_123tarde;

Console.WriteLine("Hello, World!");




Console.WriteLine("oi");
Console.WriteLine("Hello World");


Produto p1 = new Produto(1,"mouse xing ling", 10.90M);
Produto p2 = new Produto(2, "Teclado Redragon", 100M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(30M);
p1.setDescricao("mouse Razer");

Console.WriteLine(p1.getDescricao()+ " " + p1.getValor());

//cliente , 

Cliente c1 = new Cliente(1," Cliente : Carlos Eduardo "," 32524444" );

Console.WriteLine(c1.getId() + c1.getNome() + "Telefone:" + c1.getTelefone());