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
    public class Empresa
    {
        #region Attributes
        public string Nome { set; get; }
        public int Contacto { set; get; }
        public string Morada { set; get; }
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Empresa(string nome, int con, string mor)
        {
            Nome = nome;
            Contacto = con;
            Morada = mor;
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
        ~Empresa()
        {
        }
        #endregion

        #endregion
    }
}
