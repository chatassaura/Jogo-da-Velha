using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class frm_jogo_velha : Form
    {
        int score_X = 0;
        int score_O = 0;
        bool ganhou = false;
        int count_player = 0;
        string[,] matriz = new string[3, 3];
        string simbolo = "";

        public frm_jogo_velha()
        {
            InitializeComponent();
            img_grid.Parent = img_resultado;
            btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_reset.FlatAppearance.BorderSize = 0;
            btn_reset.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_reset.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_reset.BackColor = Color.Transparent;
        }

        private void VerificarGanhou(string xo)
        {
            // verificar se ganhou nas linhas 
            for (int i = 0; i < 3; i++)
            {
                if (matriz[i, 0] == xo && matriz[i, 1] == xo && matriz[i, 2] == xo)
                {
                    ganhou = true;
                    img_resultado.Image = Image.FromFile("l"+(i+1)+".png");
                    mensagem_final(xo);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (matriz[0, i] == xo && matriz[1, i] == xo && matriz[2, i] == xo)
                {
                    ganhou = true;
                    img_resultado.Image = Image.FromFile("c" + (i + 1) + ".png");
                    mensagem_final(xo);
                }
            }

            if (matriz[0, 0] == xo && matriz[1, 1] == xo && matriz[2, 2] == xo)
            {
                ganhou = true;
                img_resultado.Image = Image.FromFile("v2.png");
                mensagem_final(xo);
            }
            if (matriz[0, 2] == xo && matriz[1, 1] == xo && matriz[2, 0] == xo)
            {
                ganhou = true;
                img_resultado.Image = Image.FromFile("v1.png"); 
                mensagem_final(xo);
            }
            if(count_player == 9 && !ganhou )
            {
                mensagem_final(xo);
            }
        }

        private void jogar_click(object sender, EventArgs e)
        {
            PictureBox px = (PictureBox)sender;
            px.Parent = img_resultado;
            px.BringToFront();

            if (px.Image == null) {
                if (count_player % 2 == 0)
                {  
                    px.Image = Image.FromFile("bola.png");
                    simbolo = "O";
                }
                else
                {
                    px.Image = Image.FromFile("xis.png");
                    simbolo = "X";
                }

                count_player++;
                registrarNaMatriz(px, simbolo);
                VerificarGanhou(simbolo);
            }
        }


        public void registrarNaMatriz(PictureBox px, string simbolo)
        {

            if (px.Name.Equals("img_a1"))
            {
                matriz[0, 0] = simbolo;
            } 
            else if (px.Name.Equals("img_a2")){
                matriz[0, 1] = simbolo;
            }
            else if (px.Name.Equals("img_a3")){
                matriz[0, 2] = simbolo;
            }
            else if (px.Name.Equals("img_b1")){
                matriz[1, 0] = simbolo;
            }
            else if(px.Name.Equals("img_b2")){
                matriz[1, 1] = simbolo;
            }
            else if (px.Name.Equals("img_b3")){
                matriz[1, 2] = simbolo;
            }
            else if (px.Name.Equals("img_c1")){
                matriz[2, 0] = simbolo;
            }
            else if (px.Name.Equals("img_c2")){
                matriz[2, 1] = simbolo;
            }
            else {
                matriz[2, 2] = simbolo;
            }
        }

        public void resetar_jogo()
        {
            img_a1.Image = null;
            img_a2.Image = null;
            img_a3.Image = null;
            img_b1.Image = null;
            img_b2.Image = null;
            img_b3.Image = null;
            img_c1.Image = null;
            img_c2.Image = null;
            img_c3.Image = null;
            img_resultado.Image = null;
            ganhou = false;
            count_player = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = "";
                }
            }   
        }
        public void mensagem_final(string simbolo)
        {
            var final = DialogResult.No;
            if (ganhou == true)
            {
                if (simbolo == "X")
                {
                    score_X++;
                    lbl_x.Text = "X - " + score_X.ToString();
                }
                else
                {
                    score_O++;
                    lbl_o.Text = "O - " + score_O.ToString();

                }
                final = MessageBox.Show("O Jogador " + simbolo + " Ganhou! ", "fim de jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                final = MessageBox.Show("Deu Velha!", "fim de jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
                if (final == DialogResult.Yes)
            {
                resetar_jogo();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetar_jogo();
            score_X = 0;
            score_O = 0;
            lbl_x.Text = "X - " + score_X.ToString();
            lbl_o.Text = "O - " + score_O.ToString();
        }
    }
}
