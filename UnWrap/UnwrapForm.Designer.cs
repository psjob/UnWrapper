namespace UnWrap
{
    partial class frmUnwrap
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSource = new System.Windows.Forms.Panel();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFromFile = new System.Windows.Forms.Button();
            this.rtbSource = new System.Windows.Forms.RichTextBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.btnUnWrap = new System.Windows.Forms.Button();
            this.btnClipBoard = new System.Windows.Forms.Button();
            this.btnToFile = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.fdSource = new System.Windows.Forms.OpenFileDialog();
            this.fdResult = new System.Windows.Forms.SaveFileDialog();
            this.pnlSource.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSource
            // 
            this.pnlSource.Controls.Add(this.gbSource);
            this.pnlSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSource.Location = new System.Drawing.Point(0, 0);
            this.pnlSource.Name = "pnlSource";
            this.pnlSource.Size = new System.Drawing.Size(861, 203);
            this.pnlSource.TabIndex = 0;
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.btnClear);
            this.gbSource.Controls.Add(this.btnFromFile);
            this.gbSource.Controls.Add(this.rtbSource);
            this.gbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSource.Location = new System.Drawing.Point(0, 0);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(861, 203);
            this.gbSource.TabIndex = 0;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Исходный текст";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(682, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFromFile
            // 
            this.btnFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFromFile.Location = new System.Drawing.Point(773, 12);
            this.btnFromFile.Name = "btnFromFile";
            this.btnFromFile.Size = new System.Drawing.Size(85, 23);
            this.btnFromFile.TabIndex = 1;
            this.btnFromFile.Text = "Из файла";
            this.btnFromFile.UseVisualStyleBackColor = true;
            this.btnFromFile.Click += new System.EventHandler(this.btnFromFile_Click);
            // 
            // rtbSource
            // 
            this.rtbSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSource.Location = new System.Drawing.Point(3, 39);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.Size = new System.Drawing.Size(855, 161);
            this.rtbSource.TabIndex = 0;
            this.rtbSource.Text = "";
            // 
            // splitter
            // 
            this.splitter.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 203);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(861, 3);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.gbResult);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResult.Location = new System.Drawing.Point(0, 206);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(861, 195);
            this.pnlResult.TabIndex = 2;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.btnUnWrap);
            this.gbResult.Controls.Add(this.btnClipBoard);
            this.gbResult.Controls.Add(this.btnToFile);
            this.gbResult.Controls.Add(this.rtbResult);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResult.Location = new System.Drawing.Point(0, 0);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(861, 195);
            this.gbResult.TabIndex = 0;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат";
            // 
            // btnUnWrap
            // 
            this.btnUnWrap.Location = new System.Drawing.Point(3, 14);
            this.btnUnWrap.Name = "btnUnWrap";
            this.btnUnWrap.Size = new System.Drawing.Size(114, 23);
            this.btnUnWrap.TabIndex = 5;
            this.btnUnWrap.Text = "UnWrap";
            this.btnUnWrap.UseVisualStyleBackColor = true;
            this.btnUnWrap.Click += new System.EventHandler(this.btnUnWrap_Click);
            // 
            // btnClipBoard
            // 
            this.btnClipBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipBoard.Location = new System.Drawing.Point(682, 15);
            this.btnClipBoard.Name = "btnClipBoard";
            this.btnClipBoard.Size = new System.Drawing.Size(85, 23);
            this.btnClipBoard.TabIndex = 4;
            this.btnClipBoard.Text = "В буфер";
            this.btnClipBoard.UseVisualStyleBackColor = true;
            this.btnClipBoard.Click += new System.EventHandler(this.btnClipBoard_Click);
            // 
            // btnToFile
            // 
            this.btnToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToFile.Location = new System.Drawing.Point(773, 15);
            this.btnToFile.Name = "btnToFile";
            this.btnToFile.Size = new System.Drawing.Size(85, 23);
            this.btnToFile.TabIndex = 3;
            this.btnToFile.Text = "В файл";
            this.btnToFile.UseVisualStyleBackColor = true;
            this.btnToFile.Click += new System.EventHandler(this.btnToFile_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResult.Location = new System.Drawing.Point(3, 39);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(855, 153);
            this.rtbResult.TabIndex = 1;
            this.rtbResult.Text = "";
            // 
            // fdSource
            // 
            this.fdSource.FileName = "Открыть файл";
            // 
            // frmUnwrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 401);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.pnlSource);
            this.Name = "frmUnwrap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnWrapper";
            this.pnlSource.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.pnlResult.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSource;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFromFile;
        private System.Windows.Forms.RichTextBox rtbSource;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button btnUnWrap;
        private System.Windows.Forms.Button btnClipBoard;
        private System.Windows.Forms.Button btnToFile;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.OpenFileDialog fdSource;
        private System.Windows.Forms.SaveFileDialog fdResult;
    }
}

