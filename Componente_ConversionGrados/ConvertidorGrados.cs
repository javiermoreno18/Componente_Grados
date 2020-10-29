using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Grados;

namespace Componente_ConversionGrados
{
    public partial class ConvertidorGrados : UserControl
    {
        double gradosC, gradosF;
        
        public ConvertidorGrados()
        {
            InitializeComponent();
        }

        public void getGradosCyF()
        {
            if (rbCelsius.Checked)
            {
                gradosF = Convert.ToDouble(tbGrados.Text);
                double celsiusConvertido = Grados.conversionFaC(gradosF);
                tbTotal.Text = celsiusConvertido.ToString();
            }
            else
            {
                gradosC = Convert.ToDouble(tbGrados.Text);
                double farenheitConvertido = Grados.conversionCaF(gradosC);
                tbTotal.Text = farenheitConvertido.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tbGrados.Text = " ";
            tbTotal.Text = " ";
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            getGradosCyF();
        }
    }
}
