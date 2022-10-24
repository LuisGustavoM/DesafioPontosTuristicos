using CleanArchMvc.Domain.Validation;

namespace Domain.Entities
{
    public class PontosTuristicos
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string Referencia { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public DateTime DataHoraCadastro { get; private set; }
        public PontosTuristicos(string nome, string descricao, string referencia, string cidade, string estado, DateTime dataHoraCadastro)
        {
            ValidateDomain(nome, descricao, referencia, cidade, estado);
            DataHoraCadastro = dataHoraCadastro;
        }

        public PontosTuristicos(Guid id, string nome, string descricao, string referencia, string cidade, string estado, DateTime dataHoraCadastro)
        {
            Id = id;
            DataHoraCadastro = dataHoraCadastro;
            ValidateDomain(nome, descricao, referencia, cidade, estado);
        }

        private void ValidateDomain(string nome, string descricao, string referencia, string cidade, string estado)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome),
                "Nome inválido. Campo obrigatório!");

            DomainExceptionValidation.When(nome.Length > 100,
                "Nome inválido. Tamanho máximo de 100 caracteres!");

            DomainExceptionValidation.When(string.IsNullOrEmpty(descricao),
                "Descrição inválida. Campo obrigatório!");

            DomainExceptionValidation.When(descricao.Length > 100,
                "Descrição inválida. Tamanho máximo de 100 caracteres!");

            DomainExceptionValidation.When(string.IsNullOrEmpty(cidade), "Cidade inválida. Campo obrigatório!");

            DomainExceptionValidation.When(string.IsNullOrEmpty(estado), "Estado inválido. Campo obrigatório!");

            Nome = nome;
            Descricao = descricao;
            Referencia = referencia;
            Cidade = cidade;
            Estado = estado;

        }

    }
}
