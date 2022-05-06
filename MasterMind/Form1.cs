namespace MasterMind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreaSoluzione();
        }
        int[] soluzione = new int[4];
        int[] codice = { 0, 0, 0, 0 };
        int vite = 10, pos = 0, col = 0;

        Color[] colori = { Color.White, Color.Black, Color.Red, Color.Green, Color.Blue };
        int a = 1, b = 1, c = 1, d = 1;
        Random rand = new Random();
        private void CreaSoluzione()
        {
            for (int i = 0; i < soluzione.Length; i++)
            {
                soluzione[i] = rand.Next(1, 5);
            }
            vite_r.Text = "" + vite;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (a == 5)
            {
                a = 1;
            }
            btn1.BackColor = colori[a];
            codice[0] = a;
            a++;
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (b == 5)
            {
                b = 1;
            }
            btn2.BackColor = colori[b];
            codice[1] = b;
            b++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (c == 5)
            {
                c = 1;
            }
            btn3.BackColor = colori[c];
            codice[2] = c;
            c++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (d == 5)
            {
                d = 1;
            }
            btn4.BackColor = colori[d];
            codice[3] = d;
            d++;
        }

        private void btnverifica_Click(object sender, EventArgs e)
        {
            int esito = 0;
            pos = 0;
            col = 0;
            int[] tmp_soluzione = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (codice[i] == 0)
                {
                    lb_error.Visible = true;
                    return;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (codice[i] == soluzione[i])
                {
                    pos++;
                }
                tmp_soluzione[i] = soluzione[i];
            }
            pos_cor.Text = "" + pos;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tmp_soluzione[j] == codice[i])
                    {
                        col++;
                        tmp_soluzione[j] = 100;
                        break;
                    }
                }
            }
            col_cor.Text = "" + col;
            vite--;
            vite_r.Text = "" + vite;
            lb_error.Visible = false;
            if (pos == 4)
            {
                lb_ris.Text = "HAI VINTO!";
                lb_ris.Visible = true;
                lb_pos.Visible = false;
                lb_col.Visible = false;
                pos_cor.Visible = false;
                col_cor.Visible = false;
                lb_vite.Visible = false;
                vite_r.Visible = false;
                btn_reset.Visible = true;
                btnverifica.Visible = false;
                esito = 1;
                Comandi.SalvaPartite(esito);
            }
            else if (vite == 0)
            {
                lb_ris.Text = "HAI PERSO!";
                lb_ris.Visible = true;
                lb_pos.Visible = false;
                lb_col.Visible = false;
                pos_cor.Visible = false;
                lb_vite.Visible = false;
                vite_r.Visible = false;
                col_cor.Visible = false;
                btn_reset.Visible = true;
                btnverifica.Visible = false;
                esito = 0;
                Comandi.SalvaPartite(esito);
            }
            Storico(vite, codice, pos, col);
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            lb_ris.Visible = false;
            lb_pos.Visible = true;
            lb_col.Visible = true;
            pos_cor.Visible = true;
            lb_vite.Visible = true;
            vite_r.Visible = true;
            col_cor.Visible = true;
            btn_reset.Visible = false;
            btnverifica.Visible = true;
            vite = 10;
            pos = 0;
            col = 0;
            a = 1;
            b = 1;
            c = 1;
            d = 1;
            pos_cor.Text = "" + pos;
            col_cor.Text = "" + col;
            vite_r.Text = "" + vite;
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            CreaSoluzione();
            hideBtn();
            HideBtnHelp();
            Comandi.ClearStorico();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Comandi.ClearStorico();
        }

        public void hideBtn()
        {
            bntst01.Visible = false;
            bntst02.Visible = false;
            bntst03.Visible = false;
            bntst04.Visible = false;
            bntst05.Visible = false;
            bntst06.Visible = false;
            bntst07.Visible = false;
            bntst08.Visible = false;
            bntst09.Visible = false;
            bntst10.Visible = false;
            bntst11.Visible = false;
            bntst12.Visible = false;
            bntst13.Visible = false;
            bntst14.Visible = false;
            bntst15.Visible = false;
            bntst16.Visible = false;
            bntst17.Visible = false;
            bntst18.Visible = false;
            bntst19.Visible = false;
            bntst20.Visible = false;
            bntst21.Visible = false;
            bntst22.Visible = false;
            bntst23.Visible = false;
            bntst24.Visible = false;
            bntst25.Visible = false;
            bntst26.Visible = false;
            bntst27.Visible = false;
            bntst28.Visible = false;
            bntst29.Visible = false;
            bntst30.Visible = false;
            bntst31.Visible = false;
            bntst32.Visible = false;
            bntst33.Visible = false;
            bntst34.Visible = false;
            bntst35.Visible = false;
            bntst36.Visible = false;
        }
        public void Storico(int vite, int[] codice, int pos, int col)
        {
            switch (vite)
            {
                case 9:
                    bntst01.Visible = true;
                    bntst01.BackColor = colori[codice[0]];
                    bntst02.Visible = true;
                    bntst02.BackColor = colori[codice[1]];
                    bntst03.Visible = true;
                    bntst03.BackColor = colori[codice[2]];
                    bntst04.Visible = true;
                    bntst04.BackColor = colori[codice[3]];
                    Comandi.SalvaStorico(codice, 1);
                    ColorBtnHelp(BtnHelp(vite), pos, col);
                    break;
                case 8:
                    bntst05.Visible = true;
                    bntst05.BackColor = colori[codice[0]];
                    bntst06.Visible = true;
                    bntst06.BackColor = colori[codice[1]];
                    bntst07.Visible = true;
                    bntst07.BackColor = colori[codice[2]];
                    bntst08.Visible = true;
                    bntst08.BackColor = colori[codice[3]];
                    Comandi.SalvaStorico(codice, 2);
                    ColorBtnHelp(BtnHelp(vite), pos, col);
                    break;
                case 7:
                    bntst09.Visible = true;
                    bntst09.BackColor = colori[codice[0]];
                    bntst10.Visible = true;
                    bntst10.BackColor = colori[codice[1]];
                    bntst11.Visible = true;
                    bntst11.BackColor = colori[codice[2]];
                    bntst12.Visible = true;
                    bntst12.BackColor = colori[codice[3]];
                    Comandi.SalvaStorico(codice, 3);
                    ColorBtnHelp(BtnHelp(vite), pos, col);
                    break;
                case 6:
                    bntst13.Visible = true;
                    bntst13.BackColor = colori[codice[0]];
                    bntst14.Visible = true;
                    bntst14.BackColor = colori[codice[1]];
                    bntst15.Visible = true;
                    bntst15.BackColor = colori[codice[2]];
                    bntst16.Visible = true;
                    bntst16.BackColor = colori[codice[3]];
                    Comandi.SalvaStorico(codice, 4);
                    ColorBtnHelp(BtnHelp(vite), pos, col);
                    break;
                case 5:
                    bntst17.Visible = true;
                    bntst17.BackColor = colori[codice[0]];
                    bntst18.Visible = true;
                    bntst18.BackColor = colori[codice[1]];
                    bntst19.Visible = true;
                    bntst19.BackColor = colori[codice[2]];
                    bntst20.Visible = true;
                    bntst20.BackColor = colori[codice[3]];
                    Comandi.SalvaStorico(codice, 5);
                    ColorBtnHelp(BtnHelp(vite), pos, col);
                    break;
                case 4:
                    bntst21.Visible = true;
                    bntst21.BackColor = colori[codice[0]];
                    bntst22.Visible = true;
                    bntst22.BackColor = colori[codice[1]];
                    bntst23.Visible = true;
                    bntst23.BackColor = colori[codice[2]];
                    bntst24.Visible = true;
                    bntst24.BackColor = colori[codice[3]];
                    Comandi.SalvaStorico(codice, 6);
                    ColorBtnHelp(BtnHelp(vite), pos, col);
                    break;
                case 3:
                    bntst25.Visible = true;
                    bntst25.BackColor = colori[codice[0]];
                    bntst26.Visible = true;
                    bntst26.BackColor = colori[codice[1]];
                    bntst27.Visible = true;
                    bntst27.BackColor = colori[codice[2]];
                    bntst28.Visible = true;
                    bntst28.BackColor = colori[codice[3]];
                    Comandi.SalvaStorico(codice, 7);
                    ColorBtnHelp(BtnHelp(vite), pos, col);
                    break;
                case 2:
                    bntst29.Visible = true;
                    bntst29.BackColor = colori[codice[0]];
                    bntst30.Visible = true;
                    bntst30.BackColor = colori[codice[1]];
                    bntst31.Visible = true;
                    bntst31.BackColor = colori[codice[2]];
                    bntst32.Visible = true;
                    bntst32.BackColor = colori[codice[3]];
                    Comandi.SalvaStorico(codice, 8);
                    ColorBtnHelp(BtnHelp(vite), pos, col);
                    break;
                case 1:
                    bntst33.Visible = true;
                    bntst33.BackColor = colori[codice[0]];
                    bntst34.Visible = true;
                    bntst34.BackColor = colori[codice[1]];
                    bntst35.Visible = true;
                    bntst35.BackColor = colori[codice[2]];
                    bntst36.Visible = true;
                    bntst36.BackColor = colori[codice[3]];
                    Comandi.SalvaStorico(codice, 9);
                    ColorBtnHelp(BtnHelp(vite), pos, col);
                    break;
            }
        }
        private void ColorBtnHelp(Button[] btnhelp, int pos, int col)
        {
            
            int x = col - pos;
            for (int i = pos; i < pos + x; i++)
            {
                btnhelp[i].BackColor = Color.Pink;
            }
            for (int i = 0; i < pos; i++)
            {
                btnhelp[i].BackColor = Color.Black;
            }
        }
        private Button[] BtnHelp(int vite)
        {
            Button[] btnhelp = new Button[4];
            if (vite == 9)
            {
                btnhelp[0] = btns01;
                btnhelp[1] = btns02;
                btnhelp[2] = btns03;
                btnhelp[3] = btns04;
                btns01.Visible = true;
                btns02.Visible = true;
                btns03.Visible = true;
                btns04.Visible = true;
            }
            else if (vite == 8)
            {
                btnhelp[0] = btns05;
                btnhelp[1] = btns06;
                btnhelp[2] = btns07;
                btnhelp[3] = btns08;
                btns05.Visible = true;
                btns06.Visible = true;
                btns07.Visible = true;
                btns08.Visible = true;
            }
            else if (vite == 7)
            {
                btnhelp[0] = btns09;
                btnhelp[1] = btns10;
                btnhelp[2] = btns11;
                btnhelp[3] = btns12;
                btns09.Visible = true;
                btns10.Visible = true;
                btns11.Visible = true;
                btns12.Visible = true;
            }
            else if (vite == 6)
            {
                btnhelp[0] = btns13;
                btnhelp[1] = btns14;
                btnhelp[2] = btns15;
                btnhelp[3] = btns16;
                btns13.Visible = true;
                btns14.Visible = true;
                btns15.Visible = true;
                btns16.Visible = true;
            }
            else if (vite == 5)
            {
                btnhelp[0] = btns17;
                btnhelp[1] = btns18;
                btnhelp[2] = btns19;
                btnhelp[3] = btns20;
                btns17.Visible = true;
                btns18.Visible = true;
                btns19.Visible = true;
                btns20.Visible = true;
            }
            else if (vite == 4)
            {
                btnhelp[0] = btns21;
                btnhelp[1] = btns22;
                btnhelp[2] = btns23;
                btnhelp[3] = btns24;
                btns21.Visible = true;
                btns22.Visible = true;
                btns23.Visible = true;
                btns24.Visible = true;
            }
            else if (vite == 3)
            {
                btnhelp[0] = btns25;
                btnhelp[1] = btns26;
                btnhelp[2] = btns27;
                btnhelp[3] = btns28;
                btns25.Visible = true;
                btns26.Visible = true;
                btns27.Visible = true;
                btns28.Visible = true;
            }
            else if (vite == 2)
            {
                btnhelp[0] = btns29;
                btnhelp[1] = btns30;
                btnhelp[2] = btns31;
                btnhelp[3] = btns32;
                btns29.Visible = true;
                btns30.Visible = true;
                btns31.Visible = true;
                btns32.Visible = true;
            }
            else if (vite == 1)
            {
                btnhelp[0] = btns33;
                btnhelp[1] = btns34;
                btnhelp[2] = btns35;
                btnhelp[3] = btns36;
                btns33.Visible = true;
                btns34.Visible = true;
                btns35.Visible = true;
                btns36.Visible = true;
            }
            return btnhelp;
        }

        private void HideBtnHelp()
        {
            btns01.Visible = false;
            btns02.Visible = false;
            btns03.Visible = false;
            btns04.Visible = false;
            btns05.Visible = false;
            btns06.Visible = false;
            btns07.Visible = false;
            btns08.Visible = false;
            btns09.Visible = false;
            btns10.Visible = false;
            btns11.Visible = false;
            btns12.Visible = false;
            btns13.Visible = false;
            btns14.Visible = false;
            btns15.Visible = false;
            btns16.Visible = false;
            btns17.Visible = false;
            btns18.Visible = false;
            btns19.Visible = false;
            btns20.Visible = false;
            btns21.Visible = false;
            btns22.Visible = false;
            btns23.Visible = false;
            btns24.Visible = false;
            btns25.Visible = false;
            btns26.Visible = false;
            btns27.Visible = false;
            btns28.Visible = false;
            btns29.Visible = false;
            btns30.Visible = false;
            btns31.Visible = false;
            btns32.Visible = false;
            btns33.Visible = false;
            btns34.Visible = false;
            btns35.Visible = false;
            btns36.Visible = false;
        }
    }
}