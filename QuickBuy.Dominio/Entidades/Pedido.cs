using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public String CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validade()
        {
            LimparMensagemValidacao();
            if (!ItensPedido.Any())
                AdicionarCritica("Pedido não pode ficar sem nenhum item");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP deve estar Preenchido");
        }
    }
}
