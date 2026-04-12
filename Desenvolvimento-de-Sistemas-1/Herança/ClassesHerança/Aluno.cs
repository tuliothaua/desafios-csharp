namespace ClassesHerança;
//Túlio Thauã Dutra
public class Aluno : Pessoa
{
    public string Matricula { get; set; }
    public Curso? Curso { get; set; }

    public Aluno(string nome = "", string cpf = "", string rg = "", int idade = 0, DateTime nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "", string matricula = "", Curso? curso = null) : base(nome, cpf, rg, idade, nascimento, endereco, numero, complemento)
    {
        Matricula = matricula;
        Curso = curso;
    }
}