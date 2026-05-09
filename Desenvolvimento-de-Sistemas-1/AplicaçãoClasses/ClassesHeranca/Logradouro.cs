namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public class Logradouro
{
    public string NomeLogradouro { get; set; }
    public string Tipo { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string CEP { get; set; }

    public Logradouro(string nomelogradouro = "", string tipo = "", string bairro = "", string cidade = "", string estado = "", string cep = "")
    {
        NomeLogradouro = nomelogradouro;
        Tipo = tipo;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        CEP = cep;
    }

    public override string ToString()
    {
        // Ajustado para o formato: Tipo Nome, Cidade/Estado
        return $"{Tipo} {NomeLogradouro}, {Cidade}/{Estado}";
    }
}