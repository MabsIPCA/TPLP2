using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class Colaborador : Pessoa
    {
        #region Attributes
        public string Categoria { set; get; }
        public int NColaborador { set; get; }
        public DateTime DataContratado { set; get; }
        public int DuracaoContrato { set; get; }
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Colaborador(string n, int c, string m, DateTime d,string cat, int nc, DateTime dc, int dcmeses):base(n,c,m,d)
        {
            Nome = n;
            Contacto = c;
            Morada = m;
            DataNascimento = d;
            Categoria = cat;
            NColaborador = nc;
            DataContratado = dc;
            DuracaoContrato = dcmeses;
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        public string fimContrato()
        {
            DateTime fimContrato = this.DataContratado.AddMonths(this.DuracaoContrato);
            string tempo = fimContrato.Subtract(DateTime.Now).ToString("d", CultureInfo.CreateSpecificCulture("pt-PT"));
            return tempo;
        }
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Colaborador()
        {
        }
        #endregion

        #endregion
    }
}
