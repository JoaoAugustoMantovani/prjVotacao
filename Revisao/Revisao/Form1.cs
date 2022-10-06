using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Input;
using Microsoft.VisualBasic;

namespace Revisao
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            
        }          

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
           

        }

        int nulo, andre, ciro, jair, lula, simone;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTotal.Enabled = false;
            groupBox1.Enabled = false;
            btnConfirm.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void rdbAndre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAndre.Checked == true)
            {
                PbCand.ImageLocation = @"E:/2AMS/DS/Revisao/Revisao/Revisao/imgs/andre.jpg";
            }
        }

        private void rdbCiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCiro.Checked == true)
            {
                PbCand.ImageLocation = @"E:/2AMS/DS/Revisao/Revisao/Revisao/imgs/ciro.jpg";
            }
        }

        private void rdbJair_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJair.Checked == true)
            {
                PbCand.ImageLocation = @"E:/2AMS/DS/Revisao/Revisao/Revisao/imgs/bolsonaro.jpg";
            }
        }

        private void rdbLula_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLula.Checked == true)
            {
                PbCand.ImageLocation = @"E:/2AMS/DS/Revisao/Revisao/Revisao/imgs/lula.jpg";
            }
        }

        private void rdbSimone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSimone.Checked == true)
            {
                PbCand.ImageLocation = @"E:/2AMS/DS/Revisao/Revisao/Revisao/imgs/simone.jpg";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                btnTotal.Enabled = false;
                groupBox1.Enabled = false;
                btnConfirm.Enabled = false;
                MessageBox.Show("O campo Titulo de Eleitor deve ser preenchido obrigatóriamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTitulo.Focus();
            }
            else
            {
                groupBox1.Enabled = true;
                btnConfirm.Enabled = true;
                btnTotal.Enabled = true;
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                btnTotal.Enabled = false;
                groupBox1.Enabled = false;
                btnConfirm.Enabled = false;
                MessageBox.Show("CPF Deve ser preenchido obrigatóriamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCPF.Focus();
            }
            else
            {
                 groupBox1.Enabled = true;
                btnConfirm.Enabled = true;
                btnTotal.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por votar nas eleições de 2022!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Insira a senha de acesso:", "Total de Pontos por Candidato", "", 0, 0);

            if (input == "123")
            {
                MessageBox.Show($"O Total de Votos por Candidatos é: \n Bolsonaro = {jair} \n Lula = {lula} \n André = {andre} \n Simone = {simone} \n Ciro = {ciro} \n Nulos = {nulo}");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {




            if (rdbAndre.Checked == true)
            {
                MessageBox.Show("Você votou no André Janones", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                andre++;
                btnConfirm.Enabled = false;
            }
            else if (rdbCiro.Checked == true)
            {
                MessageBox.Show("Você votou no Ciro Gomes", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ciro++;
                btnConfirm.Enabled = false;
            }
            else if (rdbJair.Checked == true)
            {
                MessageBox.Show("Você votou no Jair Bolsonaro", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jair++;
                btnConfirm.Enabled = false;
            }
            else if (rdbLula.Checked == true)
            {
                MessageBox.Show("Você votou no Lula", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lula++;
                btnConfirm.Enabled = false;
            }
            else if (rdbSimone.Checked == true)
            {
                MessageBox.Show("Você votou na Simone Tebet", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                simone++;
                btnConfirm.Enabled = false;
            }
            else if (MessageBox.Show("Certeza que deseja votar nulo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nulo++;
                btnConfirm.Enabled = false;
            }

            rdbAndre.Checked = false;
            rdbCiro.Checked = false;
            rdbJair.Checked = false;
            rdbLula.Checked = false;
            rdbSimone.Checked = false;
            
        }
}
}
