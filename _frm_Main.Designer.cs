namespace WindowsFormsApplication1
{
    partial class frm_Main
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
            this.bpMain = new System.Windows.Forms.PictureBox();
            this.bOpen = new System.Windows.Forms.Button();
            this.pFaces = new System.Windows.Forms.FlowLayoutPanel();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bpMain)).BeginInit();
            this.pFaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // bpMain
            // 
            this.bpMain.Location = new System.Drawing.Point(12, 12);
            this.bpMain.Name = "bpMain";
            this.bpMain.Size = new System.Drawing.Size(586, 320);
            this.bpMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bpMain.TabIndex = 4;
            this.bpMain.TabStop = false;
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(12, 338);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 5;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bStart_MouseClick);
            // 
            // pFaces
            // 
            this.pFaces.AutoScroll = true;
            this.pFaces.Controls.Add(this.pb1);
            this.pFaces.Location = new System.Drawing.Point(602, 12);
            this.pFaces.Name = "pFaces";
            this.pFaces.Size = new System.Drawing.Size(198, 320);
            this.pFaces.TabIndex = 6;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(3, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(183, 110);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 377);
            this.Controls.Add(this.pFaces);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.bpMain);
            this.Name = "frm_Main";
            this.Text = "Face detection";
            ((System.ComponentModel.ISupportInitialize)(this.bpMain)).EndInit();
            this.pFaces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bpMain;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.FlowLayoutPanel pFaces;
        private System.Windows.Forms.PictureBox pb1;
    }
}

