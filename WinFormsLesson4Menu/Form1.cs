namespace WinFormsLesson4Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mi_File_Open_Click(object sender, EventArgs e)
        {

        }

        private void mi_Theme_Light_Click(object sender, EventArgs e) // ���������� ������ ������� ����
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender; //������� ������, �������� ����������� ������ �������
            if (it.Checked == true)
            {
                this.BackColor = Color.White;
            }
            mi_Theme_Dark.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void mi_Theme_Dark_Click(object sender, EventArgs e) // ���������� ������ ������ ����
        {
            if (mi_Theme_Dark.Checked == true)
            {
                this.BackColor = Color.DarkGray;
            }
            mi_Theme_Light.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == true)
            {
                menuStrip2.Visible = true;
                menuStrip1.Visible = false;
            }
            else
            {
                menuStrip2.Visible = false;
                menuStrip1.Visible = true;
            }

        }

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Control ctl = this.GetChildAtPoint(e.Location);
            if (ctl != null && !ctl.Enabled && ctl.ContextMenuStrip != null)
                ctl.ContextMenuStrip.Show(this, e.Location);
        }
    }
}