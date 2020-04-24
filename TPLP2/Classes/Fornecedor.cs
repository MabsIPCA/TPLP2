using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    public class Fornecedor:Empresa
    {
        #region Attributes
        public int IdFornecedor { set; get; }
        public string Categoria { set; get; }
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Fornecedor(string nome, int con, string mor, string cat,int id):base(nome,con,mor)
        {
            IdFornecedor = id;
            Nome = nome;
            Contacto = con;
            Morada = mor;
            Categoria = cat;
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
        ~Fornecedor()
        {
        }
        #endregion

        #endregion
    }
}
