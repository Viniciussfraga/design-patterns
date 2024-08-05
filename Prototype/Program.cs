using Prototype;
using Prototype.Exercicio;

//Aula Prototype
// Soldado soldado = new Soldado();
// soldado.Nome = "Soldado";
// soldado.Arma = "Fuzil";
// soldado.Acessorio = new Acessorio {Nome = "Capacete"};

// Soldado soldadoClone1 = (Soldado)soldado.Clone();
// soldadoClone1.Nome = "Soldado clone1";
// soldadoClone1.Arma = "Bazuca";
// soldadoClone1.Acessorio.Nome = "Visor Noturno";

// Soldado soldadoClone2 = (Soldado)soldado.Clone();
// soldadoClone2.Nome = "Soldado clone2";
// soldadoClone2.Arma = "Metralhadora";
// soldadoClone2.Acessorio.Nome = "Colete";

// Console.WriteLine(">> Objeto original");
// Console.WriteLine($"{soldado.Nome} - {soldado.Arma}");
// Console.WriteLine($"{soldado.Acessorio.Nome}");

// Console.WriteLine(">> Objeto Clone1");
// Console.WriteLine($"{soldadoClone1.Nome} - {soldadoClone1.Arma}");
// Console.WriteLine($"{soldadoClone1.Acessorio.Nome}");

// Console.WriteLine(">> Objeto Clone2");
// Console.WriteLine($"{soldadoClone2.Nome} - {soldadoClone2.Arma}");
// Console.WriteLine($"{soldadoClone2.Acessorio.Nome}");

//Exercicio Prototype
Programador programador = new Programador();
programador.Nome = "Vinicius";
programador.Cargo = "Programador Pl";
programador.Linguagem = "C#";

Programador programadorClone = (Programador)programador.Clone();
programadorClone.Nome = "Fabio";
programadorClone.Cargo = "Programador Jr";

Console.WriteLine(programador);
Console.WriteLine(programadorClone);

Engenheiro Engenheiro = new Engenheiro();
Engenheiro.Nome = "Vinicius Fraga";
Engenheiro.Cargo = "Engenheiro Software";
Engenheiro.Especialidade = "Softwares";

Engenheiro EngenheiroClone = (Engenheiro)Engenheiro.Clone();
EngenheiroClone.Nome = "Amanda";
EngenheiroClone.Cargo = "Fluidos";

Console.WriteLine(Engenheiro);
Console.WriteLine(EngenheiroClone);

Console.ReadLine();