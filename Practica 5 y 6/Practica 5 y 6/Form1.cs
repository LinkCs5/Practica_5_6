using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5_y_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void dinero_ingresado_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void boton_Calcular_Click(object sender, EventArgs e)
        {
            if(!decimal.TryParse(Monto_Pagar.Text, out decimal montoTotal)
                || !decimal.TryParse(dinero_ingresado.Text,out decimal montoPagado))
            {
                MessageBox.Show("Por favor, ingrese montos válidos.");
                return;
            }

            decimal cambio = montoPagado - montoTotal;
            cambio_total.Text = "$"+cambio.ToString("0.00");

            CambioMinimo cambioMinimo = new CambioMinimo(cambio);

            listBox1.Items.Clear();
            foreach (Moneda moneda in cambioMinimo.CalcularCambioMinimo())
            {
                listBox1.Items.Add($"{moneda.Cantidad} moneda(s) de {moneda.Valor:C}");
            }

        }

        private void cambio_total_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void total_pagar_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

        }

        private void cambio_Click(object sender, EventArgs e)
        {

        }

        private void cambio_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


public class Moneda
{
    public decimal Valor { get; set; }
    public int Cantidad { get; set; }

}

public class CambioMinimo
{
    private decimal _cambio;
    private readonly List<Moneda> _demoninaciones = new List<Moneda>()
    {
        new Moneda {Valor = 100},
        new Moneda {Valor = 50 },
        new Moneda {Valor = 20},
        new Moneda {Valor  = 10},
        new Moneda {Valor = 5},
        new Moneda {Valor = 1},
        new Moneda {Valor = 0.5m},
        new Moneda {Valor = 0.2m},
        new Moneda {Valor = 0.01m}
    };

    public CambioMinimo(decimal cambio)
    {
        _cambio = cambio;
    }

    public List<Moneda> CalcularCambioMinimo()
    {
        List<Moneda> cantidadMonedas = new List<Moneda>();
        foreach (Moneda moneda in _demoninaciones)
        {
            int cantidad = (int)(_cambio / moneda.Valor);
            if(cantidad > 0)
            {
                cantidadMonedas.Add(new Moneda { Valor = moneda.Valor, Cantidad = cantidad });
                _cambio -= cantidad * moneda.Valor;
            }
        }
        return cantidadMonedas;
    }
    
}