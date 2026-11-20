using System.Security.Cryptography.X509Certificates;

namespace electro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cabels[] cabels = new Cabels[3];
            Cabels al = new Cabels("Алюминиевый", 100, 10);
            Cabels me = new Cabels("Медный", 200, 5);
            Cabels si = new Cabels("Силовой", 500, 2);
            Cabels vo = new Cabels("Водостойкий", 300, 3);
            cabels[0] = al;
            cabels[1] = me;
            cabels[2] = si;
            cabels[3] = vo;
            for (int i = 0; i < 3; i++)
            {
                left.Items.Add($"{cabels[i].name} | {cabels[i].price}р | {cabels[i].length}м");
            }
        }

        private void left_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void right_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
