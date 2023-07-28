using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula15Atividade
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string usuarioCadastro = txtUsuario.Text;
            string senha = txtSenha.Text;
            string nome = txtCompleto.Text;
            int idade = 2023 - int.Parse(txtNascimento.Text);
            
            
            Usuario usuario = new Usuario( usuarioCadastro, senha);
            Cliente cliente = new Cliente(nome , idade, usuario);
            Program.clientes.Add(cliente);

            atualizaInterface();


        }
    

        public void atualizaInterface()
        {
            listView1.Clear();
            for (int i = 0; i < Program.clientes.Count; i++)
            {

                listView1.Items.Add(Program.clientes[i].nome);

                return;
            }


        }
    
    }



}
