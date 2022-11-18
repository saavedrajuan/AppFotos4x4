using System.Windows.Forms;

namespace AppFotos4x4
{
    public partial class Form1 : Form
    {  App app1 = new App();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile("" + openFileDialog1.FileName + "");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text != "") { 
                app1.crearImagen(openFileDialog1.FileName, Int32.Parse(textBox1.Text));

            }
            else
            {
                MessageBox.Show("Ingrese una cantidad");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}