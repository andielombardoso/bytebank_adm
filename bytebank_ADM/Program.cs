using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro Malazartes";

//Diretor roberta = new Diretor("987654321", 5000);
//roberta.Nome = "Roberta Silva";

//GerenciadorDeBonificacoes gerenciador = new GerenciadorDeBonificacoes();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(roberta.Nome);
//Console.WriteLine("Total de bonificações: "+ gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionários: "+ Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("O novo salário de Pedro é: " + pedro.Salario);
//Console.WriteLine("O novo salário de Roberta é: " + roberta.Salario);
#endregion

//CalculoBonificacao();

UsarSistema();

void CalculoBonificacao()
{
    GerenciadorDeBonificacoes gerenciador = new GerenciadorDeBonificacoes();

    Auxiliar ulisses = new Auxiliar("466545");
    ulisses.Nome = "Ulisses Souza";
    
    Designer igor = new Designer("898622");
    igor.Nome = "Igor Santos";

    GerenteDeContas camila = new GerenteDeContas("323155");
    camila.Nome = "Camila Pereira";

    Diretor paula = new Diretor("745456");
    paula.Nome = "Paula Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(paula);

    Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("54546");
    ingrid.Nome = "Ingrid Gomes";
    ingrid.Login = "ingrid@email.com";
    ingrid.Senha = "182";

    GerenteDeContas leticia = new GerenteDeContas("65652");
    leticia.Nome = "Leticia Melo";
    leticia.Login = "leticia@email.com";
    leticia.Senha = "281";

    ParceiroComercial iago = new ParceiroComercial();
    iago.Login = "iago@parceiro.com";
    iago.Senha = "9852";

    sistema.Logar(ingrid, "ingrid@email.com", "182");
    sistema.Logar(leticia, "leticia@email.com", "123");
    sistema.Logar(iago, "iago@parceiro.com", "9852");
}

