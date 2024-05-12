namespace giaiptbac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {
            double a, b, c;

            // Lấy giá trị từ các ô textbox
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            // Sử dụng textBox3 thay vì lấy giá trị từ textBox3.Text
            c = double.Parse(textBox3.Text);

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                MessageBox.Show($"Phương trình có 2 nghiệm phân biệt:\nx1 = {x1}\nx2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                MessageBox.Show($"Phương trình có nghiệm kép:\nx = {x}");
            }
            else
            {
                MessageBox.Show("Phương trình vô nghiệm");
            }
        }

        
    }
}
