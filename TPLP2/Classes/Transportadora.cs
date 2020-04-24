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
    public class Transportadora:Empresa
    {
        #region Attributes
        public int IdTransportadora { set; get; }
        public int NVeiculos { set; get; }
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Transportadora(string nome, int con, string mor, int nv, int id) :base(nome,con,mor)
        {
            NVeiculos = nv;
            Nome = nome;
            Contacto = con;
            Morada = mor;
            IdTransportadora = id;
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
        ~Transportadora()
        {
        }
        #endregion

        #endregion
    }
}
