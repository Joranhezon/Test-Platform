﻿namespace TestPlatform
{
    partial class FormAudioConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.audioListNameLabel = new System.Windows.Forms.Label();
            this.audioListNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteItemlabel = new System.Windows.Forms.Label();
            this.audioLabel = new System.Windows.Forms.Label();
            this.moveRowLabel = new System.Windows.Forms.Label();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.audioPathDataGridView = new System.Windows.Forms.DataGridView();
            this.fileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.playAudioButton = new System.Windows.Forms.Button();
            this.numberFilesLabel = new System.Windows.Forms.Label();
            this.numberFiles = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelEmpty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.audioPathDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // audioListNameLabel
            // 
            this.audioListNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.audioListNameLabel.AutoSize = true;
            this.audioListNameLabel.Location = new System.Drawing.Point(159, 37);
            this.audioListNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.audioListNameLabel.Name = "audioListNameLabel";
            this.audioListNameLabel.Size = new System.Drawing.Size(103, 17);
            this.audioListNameLabel.TabIndex = 55;
            this.audioListNameLabel.Text = "Nome da Lista:";
            // 
            // audioListNameTextBox
            // 
            this.audioListNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.audioListNameTextBox.Location = new System.Drawing.Point(159, 58);
            this.audioListNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.audioListNameTextBox.Name = "audioListNameTextBox";
            this.audioListNameTextBox.Size = new System.Drawing.Size(554, 22);
            this.audioListNameTextBox.TabIndex = 45;
            this.audioListNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.audioListNameTextBox_Validating);
            this.audioListNameTextBox.Validated += new System.EventHandler(this.audioListNameTextBox_Validated);
            // 
            // deleteItemlabel
            // 
            this.deleteItemlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteItemlabel.AutoSize = true;
            this.deleteItemlabel.Location = new System.Drawing.Point(13, 143);
            this.deleteItemlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deleteItemlabel.Name = "deleteItemlabel";
            this.deleteItemlabel.Size = new System.Drawing.Size(88, 17);
            this.deleteItemlabel.TabIndex = 54;
            this.deleteItemlabel.Text = "Apagar Item:";
            // 
            // audioLabel
            // 
            this.audioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.audioLabel.AutoSize = true;
            this.audioLabel.Location = new System.Drawing.Point(13, 91);
            this.audioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.audioLabel.Name = "audioLabel";
            this.audioLabel.Size = new System.Drawing.Size(55, 17);
            this.audioLabel.TabIndex = 53;
            this.audioLabel.Text = "Áudios:";
            // 
            // moveRowLabel
            // 
            this.moveRowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moveRowLabel.AutoSize = true;
            this.moveRowLabel.Location = new System.Drawing.Point(13, 194);
            this.moveRowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moveRowLabel.Name = "moveRowLabel";
            this.moveRowLabel.Size = new System.Drawing.Size(81, 17);
            this.moveRowLabel.TabIndex = 52;
            this.moveRowLabel.Text = "Mover item:";
            // 
            // moveDownButton
            // 
            this.moveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moveDownButton.AutoSize = true;
            this.moveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moveDownButton.Location = new System.Drawing.Point(13, 250);
            this.moveDownButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(137, 28);
            this.moveDownButton.TabIndex = 49;
            this.moveDownButton.Text = "Abaixo";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moveUpButton.AutoSize = true;
            this.moveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moveUpButton.Location = new System.Drawing.Point(13, 214);
            this.moveUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(137, 28);
            this.moveUpButton.TabIndex = 48;
            this.moveUpButton.Text = "Acima";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // audioPathDataGridView
            // 
            this.audioPathDataGridView.AllowUserToAddRows = false;
            this.audioPathDataGridView.AllowUserToOrderColumns = true;
            this.audioPathDataGridView.AllowUserToResizeRows = false;
            this.audioPathDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.audioPathDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.audioPathDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.audioPathDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameColumn,
            this.filePathColumn});
            this.audioPathDataGridView.Location = new System.Drawing.Point(162, 91);
            this.audioPathDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.audioPathDataGridView.MultiSelect = false;
            this.audioPathDataGridView.Name = "audioPathDataGridView";
            this.audioPathDataGridView.ReadOnly = true;
            this.audioPathDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.audioPathDataGridView.RowHeadersVisible = false;
            this.audioPathDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.audioPathDataGridView.Size = new System.Drawing.Size(551, 582);
            this.audioPathDataGridView.TabIndex = 44;
            this.audioPathDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.audioPathDataGridView_CellContentDoubleClick);
            this.audioPathDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.audioPathDataGridView_KeyDown);
            this.audioPathDataGridView.Validating += new System.ComponentModel.CancelEventHandler(this.listLength_Validating);
            this.audioPathDataGridView.Validated += new System.EventHandler(this.listLength_Validated);
            // 
            // fileNameColumn
            // 
            this.fileNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fileNameColumn.FillWeight = 187.013F;
            this.fileNameColumn.HeaderText = "Nome do Arquivo";
            this.fileNameColumn.Name = "fileNameColumn";
            this.fileNameColumn.ReadOnly = true;
            this.fileNameColumn.Width = 120;
            // 
            // filePathColumn
            // 
            this.filePathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filePathColumn.FillWeight = 12.98701F;
            this.filePathColumn.HeaderText = "Localização";
            this.filePathColumn.Name = "filePathColumn";
            this.filePathColumn.ReadOnly = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.AutoSize = true;
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Location = new System.Drawing.Point(13, 716);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 51;
            this.cancelButton.Text = "cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.AutoSize = true;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Location = new System.Drawing.Point(613, 716);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 50;
            this.saveButton.Text = "salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.AutoSize = true;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Location = new System.Drawing.Point(13, 162);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(137, 28);
            this.deleteButton.TabIndex = 47;
            this.deleteButton.Text = "Apagar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.openButton.AutoSize = true;
            this.openButton.CausesValidation = false;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openButton.Location = new System.Drawing.Point(13, 111);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(137, 28);
            this.openButton.TabIndex = 46;
            this.openButton.Text = "Abrir";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // playAudioButton
            // 
            this.playAudioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playAudioButton.AutoSize = true;
            this.playAudioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAudioButton.Location = new System.Drawing.Point(13, 301);
            this.playAudioButton.Margin = new System.Windows.Forms.Padding(4);
            this.playAudioButton.Name = "playAudioButton";
            this.playAudioButton.Size = new System.Drawing.Size(137, 28);
            this.playAudioButton.TabIndex = 56;
            this.playAudioButton.Text = "Reproduzir Áudio";
            this.playAudioButton.UseVisualStyleBackColor = true;
            this.playAudioButton.Click += new System.EventHandler(this.playAudioButton_Click);
            // 
            // numberFilesLabel
            // 
            this.numberFilesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numberFilesLabel.AutoSize = true;
            this.numberFilesLabel.Location = new System.Drawing.Point(506, 677);
            this.numberFilesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberFilesLabel.Name = "numberFilesLabel";
            this.numberFilesLabel.Size = new System.Drawing.Size(121, 17);
            this.numberFilesLabel.TabIndex = 58;
            this.numberFilesLabel.Text = "Arquivos na Lista:";
            // 
            // numberFiles
            // 
            this.numberFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numberFiles.AutoSize = true;
            this.numberFiles.Location = new System.Drawing.Point(635, 675);
            this.numberFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberFiles.Name = "numberFiles";
            this.numberFiles.Size = new System.Drawing.Size(16, 17);
            this.numberFiles.TabIndex = 59;
            this.numberFiles.Text = "0";
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.helpButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.helpButton.BackgroundImage = global::TestPlatform.Properties.Resources.helpButton;
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.helpButton.Location = new System.Drawing.Point(678, 2);
            this.helpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(35, 32);
            this.helpButton.TabIndex = 82;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // labelEmpty
            // 
            this.labelEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEmpty.AutoSize = true;
            this.labelEmpty.ForeColor = System.Drawing.Color.Red;
            this.labelEmpty.Location = new System.Drawing.Point(17, 356);
            this.labelEmpty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Size = new System.Drawing.Size(77, 17);
            this.labelEmpty.TabIndex = 83;
            this.labelEmpty.Text = "labelEmpty";
            // 
            // FormAudioConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.labelEmpty);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.numberFiles);
            this.Controls.Add(this.numberFilesLabel);
            this.Controls.Add(this.playAudioButton);
            this.Controls.Add(this.audioListNameLabel);
            this.Controls.Add(this.audioListNameTextBox);
            this.Controls.Add(this.deleteItemlabel);
            this.Controls.Add(this.audioLabel);
            this.Controls.Add(this.moveRowLabel);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.audioPathDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAudioConfig";
            this.Size = new System.Drawing.Size(717, 785);
            ((System.ComponentModel.ISupportInitialize)(this.audioPathDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label audioListNameLabel;
        private System.Windows.Forms.TextBox audioListNameTextBox;
        private System.Windows.Forms.Label deleteItemlabel;
        private System.Windows.Forms.Label audioLabel;
        private System.Windows.Forms.Label moveRowLabel;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.DataGridView audioPathDataGridView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button playAudioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathColumn;
        private System.Windows.Forms.Label numberFilesLabel;
        private System.Windows.Forms.Label numberFiles;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelEmpty;
    }
}