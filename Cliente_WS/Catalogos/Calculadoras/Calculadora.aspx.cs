using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_WS.Catalogos.Calculadoras
{
    public partial class Calculadora : System.Web.UI.Page
    {
        SW_Calculadora.Calculadora_ServiceSoapClient Cliente_SW;  
        protected void Page_Load(object sender, EventArgs e)
        {
            Cliente_SW = new SW_Calculadora.Calculadora_ServiceSoapClient();

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            //recupero los datos de formulario 
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);

            double resultado = Cliente_SW.Suma(a, b);
            lblresultado.Text = resultado.ToString();   
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            //recupero los datos de formulario 
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);

            double resultado = Cliente_SW.Resta(a, b);
            lblresultado.Text = resultado.ToString();
        }

        protected void btnMUltiplcar_Click(object sender, EventArgs e)
        {
            //recupero los datos de formulario 
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);

            double resultado = Cliente_SW.multiplicacion(a, b);
            lblresultado.Text = resultado.ToString();
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            //recupero los datos de formulario 
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);

            double resultado = Cliente_SW.Divicion(a, b);
            lblresultado.Text = resultado.ToString();
        }
    }
}