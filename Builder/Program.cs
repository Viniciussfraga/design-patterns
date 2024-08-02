//instancia director
using Builder.ConcreteBuilder;
using Builder.Director;

Fabricante fabricante = new Fabricante();

//instancia do concreteBuilder 
NotebookBuilder notebookBuilder= new NotebookBuilder();
DesktopBuilder desktopBuilder= new DesktopBuilder();

//cria objts conforome o builder
fabricante.Build(notebookBuilder);
fabricante.Build(desktopBuilder);

Console.ReadKey();