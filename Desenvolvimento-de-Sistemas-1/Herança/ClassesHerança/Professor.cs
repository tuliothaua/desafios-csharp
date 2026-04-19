namespace ClassesHerança;

public class Professor : Funcionario
{
    public string AreaAtuacao { get; set; }
    public string Titulacao { get; set; }

    public Professor(string nome = "", string cpf = "", string rg = "", string idade = "0", DateOnly nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "", string matricula = "", decimal salario = 0, string areaAtuacao = "", string titulacao = "")
    : base(nome, cpf, rg, idade, nascimento, endereco, numero, complemento, matricula, salario)
    {
        AreaAtuacao = areaAtuacao;
        Titulacao = titulacao;
    }

    public override string ToString()
    {
        // Ajustado para o formato: Nome – Matricula – Titulação – Área Atuação
        return $"{Nome} – {Matricula} – {Titulacao} – {AreaAtuacao}";
    }

    public override List<(string campo, string valor)> RetornarDados()
    {
        return new List<(string campo, string valor)>
        {
            ("Nome", Nome), ("Matricula", Matricula), ("Titulação", Titulacao), ("Área", AreaAtuacao)
        };
    }
}
