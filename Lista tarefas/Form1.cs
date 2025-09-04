namespace Lista_tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        string tarefa;
        private void button1_Click(object sender, EventArgs e)
        {
            tarefa =
                tb_tarefas.Text;
            if (tarefa.Length == 0)
            {
                MessageBox.Show("Digite alguma coisa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                lb_tarefas.Items.Add(tarefa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lb_tarefas.SelectedIndex >= 0)
            {
                lb_tarefas.Items.RemoveAt(lb_tarefas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}