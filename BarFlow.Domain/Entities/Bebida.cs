
using BarFlow.Domain.Enums;

namespace BarFlow.Domain.Entities
{
    public class Bebida
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; } = null!;

        public TipoBebida Tipo { get; private set; }

        public bool Ativa { get; private set; }

        public decimal Preco { get; private set; }

        protected Bebida() { } // Para EF Core

        public Bebida(Guid id, string Nome, TipoBebida Tipo, decimal Preco, bool Ativa)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                throw new ArgumentException("O nome da bebida é obrigatório.");
            }
            if (Preco <= 0)
            {
                throw new ArgumentException("O preço deve ser maior que zero.");
            }
            this.Id = Id;
            this.Nome = Nome;
            this.Tipo = Tipo;
            this.Preco = Preco;
            this.Ativa = Ativa;

        }

        public void Desativar(bool Ativa)
        {
            if (!Ativa)
            {
                throw new Exception("A bebida já está desativada.");
            }
            Ativa = false;
        }

        public void AtualizarPreco(decimal NovoPreco)
        {
            if (Preco <= 0)
                throw new ArgumentException("O preço não deve ser negativo ou zero.");

            Preco = NovoPreco;

        }

        public void AtualizarDados(string nome, TipoBebida tipo, decimal preco)
        {
            Validar(nome, preco);

            Nome = nome;
            Tipo = tipo;
            Preco = preco;
        }

        private void Validar(string nome, decimal preco)
        {
            if (string.IsNullOrWhiteSpace(nome)) { 
                throw new Exception("O nome da bebida é obrigatório.");
            }
            if (nome.Length < 2)
            {
                throw new Exception("O nome da bebida deve ter pelo menos 2 caracteres.");
            }
            if (preco <= 0)
            {
                throw new Exception("O preço da bebida deve ser maior que zero.");
            }
        }
    }


}
