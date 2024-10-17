using System;
using System.Text;
using System.Windows.Forms;

namespace P_UTF_8_HEX
{
    /// <summary>
    /// Auteur: FauZaPespi
    /// Date: 17.10.2024
    /// Détails: Convertir une chaine de charactère en hexadécimal
    /// </summary>
    public partial class Frm_StringHex : Form
    {
        /// <summary>
        /// Constructeur de class
        /// </summary>
        public Frm_StringHex()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Méthode pour tbxString quand son texte est modifié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxString_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbxHex.Text = ConvertToHex(tbxString.Text);
            }
            catch
            {
                tbxString.Text = "";
                tbxHex.Text = "";
                MessageBox.Show("Le programme n'arrive pas a convertir...", "StringHex.exe");
            }
        }
        /// <summary>
        /// Cette methode prend en parametre Chaine qui est un string comme "Bonjour" et va le convertir en hexadécimal et retourné ce résultat
        /// </summary>
        /// <param name="Chaine">Chaine entré</param>
        /// <returns>Valeur hexadécimal de Chaine</returns>
        private string ConvertToHex(string Chaine)
        {
            byte[] ba = Encoding.Default.GetBytes(Chaine);
            var hexString = BitConverter.ToString(ba);
            return hexString.Replace("-", "|");
        }
    }
}
