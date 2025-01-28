using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Gaming.Input; 

namespace gamepad1
{
    public partial class Form1 : Form
    {
        obj Rec = new obj(DefaultBackColor);
        Gamepad Controller;
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            Gamepad.GamepadAdded += Gamepad_GamepadAdded; //bu 
            Gamepad.GamepadRemoved += Gamepad_GamepadRemoved;//ve bu controllerin bağlanıp bağlanmadığıyla ilgili
            t.Tick += T_Tick;//tick = time
            t.Interval = 60;//interval = aralık. basma süresinde alınan action kontorlü
            t.Start();
        }

        //butona tıklandımı actionu
        private async void T_Tick(object sender, EventArgs e)
        {
            if (Gamepad.Gamepads.Count > 0)//What is controller doing
            {
                Controller = Gamepad.Gamepads.First();
                var Reading = Controller.GetCurrentReading();
                switch (Reading.Buttons)
                {
                    case GamepadButtons.B:
                        await Log("B has been pressed"); //await olması için metodun async olması gerekir. diğer butonlara basılsa bile sadece bunun çalışmasının bitmesi beklenir
                        Rec.moveObj(this.CreateGraphics(), Rec.x = Rec.x + 20,Rec.y) ;
                        break;
                    case GamepadButtons.X:
                        await Log("X has been pressed"); //await olması için metodun async olması gerekir
                        Rec.moveObj(this.CreateGraphics(), Rec.x = Rec.x - 20, Rec.y);
                        break;
                    case GamepadButtons.A:
                        await Log("A has been pressed"); //await olması için metodun async olması gerekir
                        Rec.moveObj(this.CreateGraphics(), Rec.x = Rec.x, Rec.y + 20);
                        break;
                    case GamepadButtons.Y:
                        await Log("Y has been pressed"); //await olması için metodun async olması gerekir
                        Rec.moveObj(this.CreateGraphics(), Rec.x = Rec.x, Rec.y - 20);
                        break;
                    case GamepadButtons.RightShoulder:
                        await Log("Right Shoulder has been pressed"); //await olması için metodun async olması gerekir
                        Rec.IncreaseSize(this.CreateGraphics(), Rec.size = Rec.size + 20);
                        break;
                    case GamepadButtons.LeftShoulder:
                        await Log("Left Shoulder has been pressed"); //await olması için metodun async olması gerekir
                        Rec.IncreaseSize(this.CreateGraphics(), Rec.size = Rec.size - 20);
                        break;
                }


            }
        }

        private async void Gamepad_GamepadRemoved(object sender, Gamepad e)
        {
            await Log("Controller Removed");

        }

        private async void Gamepad_GamepadAdded(object sender, Gamepad e)
        {
            await Log("Controller Added");
        }

        private async Task Log(string txt)
        {
            Task t = Task.Run(() => //() nun soluna async eklersek sinkli oluyor bu ne demek? we dont actually needed sink ?//asenkron çalışacak
            {
                Debug.WriteLine(DateTime.Now.ToShortTimeString() + ": " + txt);
            });
            await t;//t işlemi gerçekleşmeden program gerçekleşmez await 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Rec.createShape(this.CreateGraphics(),500,500,Brushes.Blue,25);
        }


    }
    class obj 
    {
        private Graphics g;
        private Color defaultFormColor;
        public int x;
        public int y;
        public int size;
        private Brush b;

        public obj(Color defaultFormColor) {
            this.defaultFormColor = defaultFormColor;
        }
        public void createShape(Graphics G,int X, int Y,Brush B, int Size) {
            G.FillRectangle(B,X,Y,Size,Size);
            this.x = X;
            this.y = Y;
            this.b = B;
            this.size = Size;
            this.g = G;
        }
        public void moveObj(Graphics G, int x, int y) {
            G.Clear(this.defaultFormColor);
            createShape(G,x,y,this.b,this.size);

        }

        public void IncreaseSize(Graphics G, int Size)
        {
            G.Clear(this.defaultFormColor);
            createShape(G,this.x,this.y,this.b,Size);
        }
    }
}
