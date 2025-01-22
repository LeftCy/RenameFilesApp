namespace RenameFilesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string folderPath = txtFolderPath.Text;
            string oldFileName = txtOldFileName.Text;
            string newFileName = txtNewFileName.Text;

            if (Directory.Exists(folderPath))
            {
                try
                {
                    var files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories)
                                         .Where(file => Path.GetFileName(file).Equals(oldFileName, StringComparison.OrdinalIgnoreCase));

                    foreach (var file in files)
                    {
                        string newFilePath = Path.Combine(Path.GetDirectoryName(file), newFileName);
                        File.Move(file, newFilePath);
                    }

                    MessageBox.Show("�t�@�C���̃��l�[�����������܂����B");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("�G���[���������܂���: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("�w�肳�ꂽ�t�H���_�����݂��܂���B");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
