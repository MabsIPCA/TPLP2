using System;
using System.Collections.Generic;
using System.Text;

namespace TPLP2.Classes
{

    /// <summary>
    /// Purpose:
    /// Created by: Miguel & Leonel
    /// Created on: 18 Abril 2020
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    /// 

    public class Produto_Encomenda
    {
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }

        public Produto_Encomenda(int id,int qt)
        {
            IdProduto = id;
            Quantidade = qt;
        }
    }


    public class Encomenda
    {
        #region Attributes
        public int IdEncomenda { set; get; }
        public DateTime DataEncomenda { set; get; }
        public int IdTransportadora { set; get; }
        public int NColaborador { set; get; }
        public int IdCliente { set; get; }

        public List<Produto_Encomenda> Produtos;

        public bool Enviada { set; get; }
        public bool Entrege { set; get; }
        public DateTime DataEntrega { set; get; }
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Encomenda(int tr, int ca, int cl)
        {
            DataEncomenda = DateTime.Now;
            IdTransportadora = tr;
            NColaborador = ca;
            IdCliente = cl;
            Entrege = false;
            Enviada = false;
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        public float CalcularCusto(List<Produto> lista_produ)
        {
            float custoFinal=0;
            Produtos.ForEach(delegate (Produto_Encomenda p_enc)
            {
                lista_produ.ForEach(delegate (Produto p_all) {
                    if (p_enc.IdProduto == p_all.IdProduto)
                    {
                        custoFinal += (p_all.Preco * p_enc.Quantidade);
                    }
                });
            });
            return custoFinal;
        }
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Encomenda()
        {
        }
        #endregion

        #endregion
    }
}
