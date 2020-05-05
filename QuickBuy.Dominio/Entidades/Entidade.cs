using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }
        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }
        public abstract void Validade();
        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        protected bool EhValido
        { 
            get { return !MensagemValidacao.Any(); }
        }

    }
}
