namespace Lab5_V3
{
    partial class Form1
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
            this.peintboller1 = new Lab5_V3.Peintboller();
            this.SuspendLayout();
            // 
            // peintboller1
            // 
            this.peintboller1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.peintboller1.Location = new System.Drawing.Point(193, 511);
            this.peintboller1.Name = "peintboller1";
            this.peintboller1.Size = new System.Drawing.Size(100, 100);
            this.peintboller1.TabIndex = 0;
            this.peintboller1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.peintboller1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 629);
            this.Controls.Add(this.peintboller1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Peintboller peintboller1;
    }
}

