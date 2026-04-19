namespace ClassesHerança;

public class Aluno : Pessoa 
{
    public string Matricula { get; set; }
    public Curso CursoAluno { get; set; }

    public Aluno(string nome = "", string cpf = "", string rg = "", string idade = "0", DateOnly nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "", string matricula = "", Curso? cursoAluno = null)
    : base(nome, cpf, rg, idade, nascimento, endereco, numero, complemento)
    {
        Matricula = matricula;
        CursoAluno = cursoAluno ?? new Curso();
    }

    public override string ToString()
    {
        // Ajustado para o formato: Nome – Matricula - Nome do curso
        return $"{Nome} – {Matricula} - {CursoAluno.Nome}";
    }

    public override List<(string campo, string valor)> RetornarDados()
    {
        return new List<(string campo, string valor)>
        {
            ("Nome", Nome), ("Cpf", Cpf), ("Rg", Rg), ("Idade", Idade),
            ("Nascimento", Nascimento.ToString("dd/MM/yyyy")),
            ("Matricula", Matricula), ("Curso", CursoAluno.Nome)
        };
    }
}
