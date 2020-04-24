using System;

namespace TPLP2.Classes
{
    /// <summary>
    /// Purpose:
    /// Created by: Miguel & Leonel
    /// Created on: 18 Abril 2020
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes
        public string Nome { set; get; }
        public int Contacto { set; get; }
        public string Morada { set; get; }
        public DateTime DataNascimento { set; get; }
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa(string n, int c ,string m,DateTime d)
        {
            Nome = n;
            Contacto = c;
            Morada = m;
            DataNascimento = d;
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        private static int CalcularIdade(DateTime dn)
        {
            int idade = 0;
            idade = DateTime.Now.Year - dn.Year;
            if (DateTime.Now.DayOfYear < dn.DayOfYear)
                idade = idade - 1;

            return idade;
        }
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
        }
    #endregion

    #endregion
}
}

