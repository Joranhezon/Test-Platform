﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TestPlatform.Models;

namespace TestPlatform.Views.ExperimentPages
{
    public partial class ExperimentResultUserControl : UserControl
    {
        private string path = Global.experimentTestFilesPath + Global.resultsFolderName;
        public ExperimentResultUserControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            string[] filePaths = null;

            string[] headers = ExperimentTest.HeaderOutputFileText.Split('\t');
            foreach (var columnName in headers)
            {
                dataGridView1.Columns.Add(columnName, columnName); // Configura Cabeçalho na tabela
            }

            if (Directory.Exists(path)) // Preenche comboBox com arquivos do tipo .txt no diretório dado
            {
                filePaths = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
                for (int i = 0; i < filePaths.Length; i++)
                {
                    fileNameBox.Items.Add(Path.GetFileNameWithoutExtension(filePaths[i]));
                }
            }
            else
            {
                Console.WriteLine("{0} é um caminho inválido!.", path);
            }
        }

        private void csvExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string[] lines;

            saveFileDialog1.Filter = "Excel CSV (.csv)|*.csv"; // salva em .csvs
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = fileNameBox.Text;

            try
            {
                if (fileNameBox.SelectedIndex == -1)
                {
                    throw new Exception("Selecione um arquivo de dados!");
                }

                lines = Program.readDataFile(path + "/" + fileNameBox.SelectedItem.ToString() + ".txt");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) // abre caixa para salvar
                {
                    using (TextWriter tw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        tw.WriteLine(ExperimentTest.HeaderOutputFileText);
                        for (int i = 0; i < lines.Length; i++)
                        {
                            tw.WriteLine(lines[i]); // escreve linhas no novo arquivo
                        }
                        tw.Close();
                        MessageBox.Show("Arquivo exportado com sucesso!");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void fileNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            string[] line;
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                line = Program.readDataFile(path + "/" + fileNameBox.SelectedItem.ToString() + ".txt");
                if (line.Count() > 0)
                {
                    for (int i = 0; i < line.Count(); i++)
                    {
                        string[] cellArray = line[i].Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        if (cellArray.Length == dataGridView1.Columns.Count)
                        {
                            dataGridView1.Rows.Add(cellArray);                            
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
