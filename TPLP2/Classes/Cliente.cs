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
    public class Cliente : Pessoa
    {
        #region Attributes
        public int IdCliente { set; get; }
        public int NIF { set; get; }
        public string Empresa { set; get; }
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Cliente( string n, int c, string m, DateTime d, int id,int nif, string empresa) : base(n,c,m,d)
        {
            IdCliente = id;
            Nome = n;
            Contacto = c;
            Morada = m;
            DataNascimento = d;
            Empresa = empresa;
            NIF = nif;
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
        ~Cliente()
        {
        }
        #endregion

        #endregion
    }
}
