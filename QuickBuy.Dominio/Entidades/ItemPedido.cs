using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validade()
        {
            LimparMensagemValidacao();

            if (ProdutoId <= 0)
                AdicionarCritica("Produto não informado!");
            if (Quantidade <= 0)
                AdicionarCritica("Quantidade de Produtos não informado!");
        }
    }
}
