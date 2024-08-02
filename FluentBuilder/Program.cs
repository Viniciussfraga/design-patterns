using FluentBuilder;

var emailBuilder = new EmailBuilder()
                    .To("enviar@gmail.com")
                    .From("receber@gmail.com")
                    .Subject("teste")
                    .Body("Microsoft Build 2021\n\t25 a 27 de Maio 2021\n\tNovidades Windows,Azure")
                    .CriarEmail();

Console.WriteLine(emailBuilder.ToString());
Console.ReadLine();