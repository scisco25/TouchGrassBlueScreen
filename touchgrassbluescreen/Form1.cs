namespace touchgrassbluescreen
{
    public partial class Form1 : Form
    {
        public int completetime { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;



            var RNG = new Random();
            var textrandom = RNG.Next(1, 4);
            if(textrandom == 1)
            {
                stopcode.Text = "Stop code: NOLIFE";
            }
            else if(textrandom == 2)
            {
                stopcode.Text = "Stop code: GO_OUTSIDE";
            }
            else if(textrandom == 3)
            {
                stopcode.Text = "Stop code: TOUCH_GRASS";
            }
            else if(textrandom == 4)
            {
                stopcode.Text = "Stop code: MOMS_BASEMENT";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var RNG = new Random();
            var newcomplete = RNG.Next(1, 11);
            completetime = completetime + newcomplete;
            if(completetime > 100) { completetime = 100; }
            complete.Text = completetime + "% complete";
        }
    }
}