namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "") { num = float.Parse(txtstore.Text); }
            txtr.Text = txtstore.Text + 'X';
            txtstore.Clear();
            cnt = 3;
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "") { num = float.Parse(txtstore.Text); }
            txtr.Text = txtstore.Text + '%';
            txtstore.Clear();
            cnt = 5;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + ".";
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "0";

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "1";

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "2";

        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "3";

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "4";

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "5";

        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "6";

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "7";

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "8";

        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "9";

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            txtr.Clear();
            txtstore.Clear();
        }
        float num;
        int cnt;

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "") { num = float.Parse(txtstore.Text); }
            txtr.Text = txtstore.Text + '-';
            txtstore.Clear();
            cnt = 1;

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "") { num = float.Parse(txtstore.Text); }
            txtr.Text = txtstore.Text + '+';
            txtstore.Clear();
            cnt = 2;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "") { num = float.Parse(txtstore.Text); }
            txtr.Text = txtstore.Text + '/';
            txtstore.Clear();
            cnt =4;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            float ans;
            switch (cnt)
            {
                case  1:
                    ans = num - float.Parse(txtstore.Text);
                    txtr.Text = txtr.Text + txtstore.Text +"=" +ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(txtstore.Text);
                    txtr.Text = txtr.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(txtstore.Text);
                    txtr.Text = txtr.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(txtstore.Text);
                    txtr.Text = txtr.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 5:
                    ans = num % float.Parse(txtstore.Text);
                    txtr.Text = txtr.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;






            }
        }
    }
}