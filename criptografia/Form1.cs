using System;                       /***********************************/
using System.Collections.Generic;   /** Autor: Wellington             **/
using System.ComponentModel;        /** Data criação: 12/03/2012      **/
using System.Data;                  /***********************************/
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace criptografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            char[] alfabeto = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
          
            int deslocamento = 3;
            string cripto = "";
          
            //recebe a entrada do texto informado
            string texto = richTextBoxEntrada.Text.ToLower();
           
            for (int i = 0; i < texto.Length; i++)
            {
                for (int j = 0; j < alfabeto.Length; j++)
                {
                    //verfica se a letra é igual a do alfabeto
                    if (texto[i] == alfabeto[j])
                    {
                        //aplica o algoritmo
                        int posicao = (j + deslocamento) % 26;
                        //pega a letra do resultado do algoritmo
                        cripto += alfabeto[posicao].ToString();
                    }
                    //se no texto conter um '<espaço>' adciona 
                    //esse espaço na resposta da cripto
                    if (texto[i] == ' ')
                    {
                        j = 26;
                        cripto += " ";
                    }
                }
            }

            richTextBoxSaida.Text = cripto;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            richTextBoxEntrada.Text = "";
            richTextBoxSaida.Text = "";
        }
        
    }
}
