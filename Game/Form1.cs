using Game.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        //adiciona o nome do player
        Player player;//cria uma variavel player



        //funçao retorna player
        public void RetornaPlayer(string p)
        {
            player = new Player();
            player.Nome = p;
        }

        List<Circulo> lista = new List<Circulo>();//criando uma lista circulo
        Jogador jogador = new Jogador();//iniciando um jogadro
        int pontos = 0;//pontos

        Timer t = new Timer();//criando um timer muda de tempo em tempo
        //passando in intervalo de tempo na dlecaraçao  -----Timer t = new Timer(1000);---- tempo em milesegundo

        Timer dece = new Timer();//criando um timer muda de tempo em tempo

        Timer seg = new Timer();//segundos
        //variaveis de começaor com teclado
        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;

        //variafev da sencibilidade
        int sensibilidade = 5;
        int segundos = 0;

        

        Image newImage = Image.FromFile("C:/Users/fla.9902005766/Desktop/aula_2b_(game-04-11-2015)/aula 2b (game-21-10-2015)/Game/Game/img/teste2.png");
        Image newImage2 = Image.FromFile("C:/Users/fla.9902005766/Desktop/aula_2b_(game-04-11-2015)/aula 2b (game-21-10-2015)/Game/Game/img/1446696893_Captain_America.ico");
        Image newImage3 = Image.FromFile("C:/Users/fla.9902005766/Desktop/aula_2b_(game-04-11-2015)/aula 2b (game-21-10-2015)/Game/Game/img/teste.png");
        Image newImage4 = Image.FromFile("C:/Users/fla.9902005766/Desktop/aula_2b_(game-04-11-2015)/aula 2b (game-21-10-2015)/Game/Game/img/teste3.png");

        public Form1()
        {
            InitializeComponent();

            //jogador


            //posicionado o jogador
            jogador.PosY = 450;
            jogador.PosX = 350;
            jogador.Cor = Color.DarkRed;//colocando a cor do jogador



            //----------------------circulo--------------------------------------------------------

            //tempo de criacao do objeto em x
            t.Interval = 300;//intervalo de tempo do t
            t.Tick += new EventHandler(Passando_tempo);//chama o evendo qundo tempo acabar
            //t.Start();//inicia o timer ----t.Start();---
            //t.Enabled = true;//iniciando o timer ----- t.Enabled = true;-----


            //contador de tempo
            seg.Interval = 1000;
            seg.Tick += new EventHandler(cont);
            //seg.Enabled = true;



            //decendo o objeto
            //tempo de criacao do objeto em x
            dece.Interval = 10;//intervalo de tempo do t
            dece.Tick += new EventHandler(decendo);//chama o evendo qundo tempo acabar
            //t.Start();//inicia o timer ----t.Start();---
            //dece.Enabled = true;//iniciando o timer ----- t.Enabled = true;-----

            //Initiates double buffering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            //ativar leitura do teclado
            this.KeyPreview = true;//ativa a leitura do teclado se true se falce desativa

        }
        private void gameOver()
        {
            t.Stop();
            dece.Stop();
            seg.Stop();
            segundos = 0;
            Pontuacao p = new Pontuacao();
            p.Data = DateTime.Now;
            player.pontuacoes.Add(p);
            pontos = 0;
            ldlGameOver.Visible = true;
            restartBT.Visible = true;
        }

        //funçao para fazer o movimento do jogador
        protected override void OnKeyDown(KeyEventArgs e)//sobrescrevendo a funçao de precionar no teclado
        {
            switch (e.KeyCode)//e.keyCode pega o valor do teclado
            {
                case Keys.Up:
                    up = true;
                    break;
                case Keys.Down:
                    down = true;
                    break;
                case Keys.Left:
                    left = true;
                    break;
                case Keys.Right:
                    right = true;
                    break;
            }
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)//sobrescrevendo a funçao de soltara tecla no teclado
        {
            switch (e.KeyCode)//e.keyCode pega o valor do teclado
            {
                case Keys.Up:
                    up = false;
                    break;
                case Keys.Down:
                    down = false;
                    break;
                case Keys.Left:
                    left = false;
                    break;
                case Keys.Right:
                    right = false;
                    break;
            }
            base.OnKeyUp(e);
        }

        void Passando_tempo(object o, EventArgs e)
        {
            
            Random r = new Random();//criar um ojeto radomico


            //deixando mais aleatorio nao funcionou 
            /*if (r.Next(0, 1) != 0)
            {
                return;
            }*/
            //--------


            Circulo circulo = new Circulo();//criar um circulo
            circulo.PosX = r.Next(0, 700);//sorteio do numero dentro do interalo --r.Next(0, 700)---- e coloca na posicao X
           // circulo.PosY = r.Next(0, 700);//sorteio do numero dentro do interalo --r.Next(0, 700)---- e coloca na posicao X
            circulo.Cor = Color.Azure;//colocando a cor
            circulo.Tipo = 1;

            Circulo circulo2 = new Circulo();//criar um circuloC:\Users\fla.9902005766\Desktop\aula_2b_(game-28-10-2015)\aula 2b (game-21-10-2015)\Game\Game\Objetos\Circulo.cs
            circulo2.PosX = r.Next(0, 700);//sorteio do numero dentro do interalo --r.Next(0, 700)---- e coloca na posicao X
                                          // circulo.PosY = r.Next(0, 700);//sorteio do numero dentro do interalo --r.Next(0, 700)---- e coloca na posicao X
            circulo2.Cor = Color.Azure;//colocando a cor
            circulo2.Tipo = 2;

            Circulo circulo3 = new Circulo();//criar um circuloC:\Users\fla.9902005766\Desktop\aula_2b_(game-28-10-2015)\aula 2b (game-21-10-2015)\Game\Game\Objetos\Circulo.cs
            circulo3.PosX = r.Next(0, 700);//sorteio do numero dentro do interalo --r.Next(0, 700)---- e coloca na posicao X
                                           // circulo.PosY = r.Next(0, 700);//sorteio do numero dentro do interalo --r.Next(0, 700)---- e coloca na posicao X
            circulo3.Cor = Color.Azure;//colocando a cor
            circulo3.Tipo = 3;

            lista.Add(circulo);//adicionando um circulo na lista
            lista.Add(circulo2);
            lista.Add(circulo3);
            Invalidate();//redesenhando a tela
        }

        void cont(object o, EventArgs e) { time.Text = "TIME : " + segundos++ +"s"; }//conta segundo

        

        void decendo(object o, EventArgs e)
        {

            lplVida.Text = "nome : "+ player.Nome + " vida" + Convert.ToString(jogador.Vida);
            ldlPontos.Text = "Pontos : " + Convert.ToString(pontos);
            
            if (lista.Count != 0)
            {

                /*  for (int i =0; i < lista.Count; i++)
                  {
                      lista[i].PosX++;
                      if (jogador.verificaColisao(lista[i].PosX, lista[i].PosY, lista[i].Raio))
                          {
                          lista.RemoveAt(i);
                          i = 0;
                      }
                  }*/

                  //finaliza jogo
                if (jogador.Vida <= 0)
                {
                    gameOver();
                    return;
                }


                for (int i = 0; i < lista.Count; i++)
                {
                    //verifica colisao
                    if (jogador.verificaColisao(lista[i].PosX, lista[i].PosY, lista[i].Raio))
                    {
                        lista.RemoveAt(i);
                        i = 0;
                    }
                    if (lista[i].PosY > 500)
                    {
                        lista.RemoveAt(i);
                        pontos += 10;
                        i = 0;
                    }
                    lista[i].PosY++;
                }

                for (int i = 0; i < lista.Count; i++)
                {
                    lista[i].PosY++;
                }
            }

            //movimenta o player
            if (up && jogador.PosY >0)
            {
                jogador.PosY -= sensibilidade;
            }
            if (down && jogador.PosY < this.Height-55)
            {
                jogador.PosY += sensibilidade;
            }
            if (left && jogador.PosX > 0)
            {
                jogador.PosX -= sensibilidade;
             
            }
            if (right && jogador.PosX < this.Width - 35)
            {
                jogador.PosX += sensibilidade;
            }

            Invalidate();
        }

        //desenhando na tela
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            //--------------------------------jogador------------------------


            Pen Contorno = new Pen(Color.Black);//definindo cor do contorno
            SolidBrush prenchimento = new SolidBrush(jogador.Cor);//definindo cor do prenchimento
            Contorno.Width = 2;//definindo tamanho da caneta
            //g.DrawEllipse(Contorno, jogador.PosX, jogador.PosY, 20, 20);//contorno da tela
           // g.FillEllipse(prenchimento, jogador.PosX, jogador.PosY, jogador.Raio, jogador.Raio);//prenchimento da tela
            g.DrawImage(newImage2, jogador.PosX, jogador.PosY, jogador.Raio, jogador.Raio);


            //-------------------------------circulo-----------------------

            //criando o circulo na tela
            int i = 0;
            if(lista.Count != 0)//verifica se a lista e vazia
            {
                for (i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Tipo == 1)
                    {
                        Contorno = new Pen(Color.Black);//definindo cor do contorno
                        prenchimento = new SolidBrush(lista[i].Cor);//definindo cor do prenchimento
                        Contorno.Width = 2;//definindo tamanho da caneta
                                           // g.DrawEllipse(Contorno, lista[i].PosX, lista[i].PosY, 20, 20);//contorno da tela
                                           // g.FillEllipse(prenchimento, lista[i].PosX, lista[i].PosY, lista[i].Raio, lista[i].Raio);//prenchimento da tela
                        g.DrawImage(newImage, lista[i].PosX, lista[i].PosY, lista[i].Raio, lista[i].Raio);
                    }
                    else if (lista[i].Tipo == 2)
                    {
                        g.DrawImage(newImage3, lista[i].PosX, lista[i].PosY, lista[i].Raio, lista[i].Raio);
                    }
                    else if (lista[i].Tipo == 3)
                    {
                        g.DrawImage(newImage4, lista[i].PosX, lista[i].PosY, lista[i].Raio, lista[i].Raio);
                    }
                    }

                /*
                while (i < lista.Count)//conta a quantidade de elemeto da tela (lista.Count) //------exemplo de codigo while em c#---------
                {

                    Pen Contorno = new Pen(Color.Black);//definindo cor do contorno
                    SolidBrush prenchimento = new SolidBrush(lista[i].Cor);//definindo cor do prenchimento
                    Contorno.Width = 2;//definindo tamanho da caneta
                    g.DrawEllipse(Contorno, lista[i].PosX, lista[i].PosY, 20, 20);//contorno da tela
                    g.FillEllipse(prenchimento, lista[i].PosX, lista[i].PosY, 20, 20);//prenchimento da tela

                    i++;
                }
                */
            }
        }
        //mostrando a caixa de cores e colocando ela no dialogo
        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //pCor.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = 0;
            Circulo circulo = new Circulo();
            Circulo circulo2 = new Circulo();
            /* if(!int.TryParse(txtPosX.Text,out d))//retorna int.TryParse verdadeiro se for int ! nao enta vai retornar verdadeiro se nao for numero
             {
                 MessageBox.Show("X invalido");//escreve uma menssagen na tela
                 return;
             }


             if (!int.TryParse(txtPosY.Text, out d))//retorna int.TryParse verdadeiro se for int ! nao enta vai retornar verdadeiro se nao for numero
             {
                 MessageBox.Show("Y invalido");//escreve uma menssagen na tela
                 return;
             }*/

            //pegando a posicao Y do circulo
            circulo.PosY = d;
            //pegando a cor na caixa de dialago
            //circulo.Cor = pCor.BackColor;
            //adicionando um objeto circulo na lista
            lista.Add(circulo);
            lista.Add(circulo2);

            Invalidate();//vai invalidar e redesenhar a tela


            /*switch (d)     //------exemplo de codigo switch em c#---------
            {
                case 1:
                    MessageBox.Show("condicao 1");
                    break;
                case 2:
                    MessageBox.Show("condicao 3");
                    break;
                default:
                    break;

            }*/

        }


        //menu de sencibilidade
        private void baixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediaToolStripMenuItem.Checked = false;
            baixaToolStripMenuItem.Checked = true;
            altaToolStripMenuItem.Checked = false;
            sensibilidade = 2;
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediaToolStripMenuItem.Checked = true;
            baixaToolStripMenuItem.Checked = false;
            altaToolStripMenuItem.Checked = false;
            sensibilidade = 5;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediaToolStripMenuItem.Checked = false;
            baixaToolStripMenuItem.Checked = false;
            altaToolStripMenuItem.Checked = true;
            sensibilidade = 8;
        }
        private void restartFucao()
        {
            ldlGameOver.Visible = false;
            restartBT.Visible = false;
            lista = new List<Circulo>();
            jogador.PosX = 250;
            jogador.PosY = 400;
            jogador.Vida = 5;
            Invalidate();
            t.Start();
            dece.Start();
            seg.Start();
        }
        //novo jogador
        private void novoJogador()
        {
            Form2 f = new Form2();
            f.ShowDialog(); //bloquea a tela anterior ate finalizar a nova

            player = new Player();
            player.Nome = f.nome;

            if (player.Carregar())
            {
                MessageBox.Show("Dados Carregado !");

            }
            else
            {
                MessageBox.Show("erro !");
            }
        }

        private void restartBT_Click(object sender, EventArgs e)
        {
            novoJogador();
            restartFucao();
            
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novoJogador();
            restartFucao();
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novoJogador();
            restartFucao();

        }
    }
}
