namespace InstaladorProtheus
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void btnSelecionaOrigem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOrigem.Text = fileDialog.FileName;
            }
        }
        public void btnSelecionaDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDestino.Text = folderBrowserDialog.SelectedPath;
            }
        }
        public async void btnInstalar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtOrigem.Text))
            {
                MessageBox.Show("Arquivo de origem não encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var blockSize = 4096;

            try
            {
                btnInstalar.Enabled = false;
                long totalSize = new FileInfo(txtOrigem.Text).Length;
                long copiedSize = 0;

                var filePath = Path.Combine(txtDestino.Text, Path.GetFileName(txtOrigem.Text));

                progressBar.Value = 0;
                progressBar.Maximum = 100;

                await Task.Run(() =>
                {
                    using (FileStream fsrc = new FileStream(txtOrigem.Text, FileMode.Open, FileAccess.Read))
                    using (FileStream fdst = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        byte[] buffer = new byte[blockSize];
                        int bytesRead;

                        while ((bytesRead = fsrc.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fdst.Write(buffer, 0, bytesRead);

                            copiedSize += bytesRead;

                            // Atualize a barra de progresso na thread de UI
                            int progress = (int)((double)copiedSize / totalSize * 100);
                            Invoke(new Action(() =>
                            {
                                progressBar.Value = progress;
                                lblStatus.Text = $"{progress}% concluído";
                            }));
                        }
                    }
                });

                MessageBox.Show("Cópia concluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnInstalar.Enabled = true;
            }
        }
    }
}
