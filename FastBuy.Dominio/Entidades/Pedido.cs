using FastBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FastBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioID { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }


        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }


        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItensPedidos.Any())
                AdicionarCritica("Critica: Pedido não pode ficar sem item de pedido");
            if (string.IsNullOrEmpty(CEP)) 
                AdicionarCritica("CEP não pode ser nulo");
        }

    }
}
