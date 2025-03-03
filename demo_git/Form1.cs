namespace demo_git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textboxusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên đăng nhập và mật khẩu
            if (textboxusername.Text == "admin" && textboxmatkhau.Text == "admin")
            {
                // Nếu đăng nhập thành công: mở Form2 và ẩn Form1
                Form2 formSuccess = new Form2();
                formSuccess.Show();
                this.Hide();
            }
            else
            {
                // Thông báo lỗi nếu thông tin không chính xác
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
