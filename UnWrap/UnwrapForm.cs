using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnWrap
{
    public partial class frmUnwrap : Form
    {
        public frmUnwrap()
        {
            InitializeComponent();
        }                      

        private void btnUnWrap_Click(object sender, EventArgs e)
        {
            //запуск процедуры разврапа
            rtbResult.Clear();
            rtbResult.AppendText(Utl.text_source(rtbSource.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //очистка исходного (заврапленного) текста
            rtbSource.Clear();
            rtbSource.Focus();
        }

        private void btnFromFile_Click(object sender, EventArgs e)
        {
            //загрузка заврапленного файла из файла
            fdSource.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fdSource.FilterIndex = 2;
            fdSource.RestoreDirectory = true;

            if (fdSource.ShowDialog() == DialogResult.OK && fdSource.FileName.Length > 0)
            {
                rtbSource.Clear();
                string filePath = fdSource.FileName;
                rtbSource.LoadFile(filePath, RichTextBoxStreamType.PlainText);
            }

        }

        private void btnClipBoard_Click(object sender, EventArgs e)
        {
            //сохранение в буфер
            Clipboard.SetText(rtbResult.Text);
        }

        private void btnToFile_Click(object sender, EventArgs e)
        {
            //сохранение разврапленного текста в файл
            fdResult.OverwritePrompt = true;

            fdResult.DefaultExt = "txt";
            fdResult.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fdResult.RestoreDirectory = true;

            if (fdResult.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = fdResult.OpenFile();
                rtbResult.SaveFile(fileStream, RichTextBoxStreamType.PlainText);
                fileStream.Close();
            }
        }
    }
}
