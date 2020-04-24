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
    public class Produto
    {
        #region Attributes
        public int IdProduto { set; get; }
        public string Nome { set; get; }
        public string Descri { set; get; }
        public string Categoria { set; get; }
        public int IdFornecedor { set; get; }
        public float Preco { set; get; }
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Produto(int id,string n,string des,string ca, int f, float p)
        {
            IdProduto = id;
            Nome = n;
            Categoria = ca;
            IdFornecedor = f;
            Preco = p;
            Descri = des;

        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Produto()
        {
        }
        #endregion

        #endregion
    }
}
