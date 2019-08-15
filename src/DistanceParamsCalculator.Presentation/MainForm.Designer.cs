namespace DistanceParamsCalculator
{
    partial class MainForm
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
            this.tbxPixelSize = new System.Windows.Forms.TextBox();
            this.lblPixelSize = new System.Windows.Forms.Label();
            this.lblLinearSize = new System.Windows.Forms.Label();
            this.tbxLinearSize = new System.Windows.Forms.TextBox();
            this.lblHorisontalSizeInPixels = new System.Windows.Forms.Label();
            this.tbxHorisontalSizeInPixels = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.lblHorisontalFieldOfView = new System.Windows.Forms.Label();
            this.tbxHorisontalFieldOfView = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPixelSize
            // 
            this.tbxPixelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPixelSize.Location = new System.Drawing.Point(12, 65);
            this.tbxPixelSize.Name = "tbxPixelSize";
            this.tbxPixelSize.Size = new System.Drawing.Size(325, 30);
            this.tbxPixelSize.TabIndex = 0;
            // 
            // lblPixelSize
            // 
            this.lblPixelSize.AutoSize = true;
            this.lblPixelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPixelSize.Location = new System.Drawing.Point(7, 28);
            this.lblPixelSize.Name = "lblPixelSize";
            this.lblPixelSize.Size = new System.Drawing.Size(330, 25);
            this.lblPixelSize.TabIndex = 1;
            this.lblPixelSize.Text = "Пиксельный размер БпЛА (пикс.):";
            // 
            // lblLinearSize
            // 
            this.lblLinearSize.AutoSize = true;
            this.lblLinearSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLinearSize.Location = new System.Drawing.Point(7, 111);
            this.lblLinearSize.Name = "lblLinearSize";
            this.lblLinearSize.Size = new System.Drawing.Size(281, 25);
            this.lblLinearSize.TabIndex = 3;
            this.lblLinearSize.Text = "Линейный размер БпЛА (м):";
            // 
            // tbxLinearSize
            // 
            this.tbxLinearSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLinearSize.Location = new System.Drawing.Point(12, 148);
            this.tbxLinearSize.Name = "tbxLinearSize";
            this.tbxLinearSize.Size = new System.Drawing.Size(325, 30);
            this.tbxLinearSize.TabIndex = 2;
            // 
            // lblHorisontalSizeInPixels
            // 
            this.lblHorisontalSizeInPixels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHorisontalSizeInPixels.Location = new System.Drawing.Point(7, 199);
            this.lblHorisontalSizeInPixels.Name = "lblHorisontalSizeInPixels";
            this.lblHorisontalSizeInPixels.Size = new System.Drawing.Size(294, 67);
            this.lblHorisontalSizeInPixels.TabIndex = 5;
            this.lblHorisontalSizeInPixels.Text = "Горизонтальный размер изображения (пикс.):";
            // 
            // tbxHorisontalSizeInPixels
            // 
            this.tbxHorisontalSizeInPixels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxHorisontalSizeInPixels.Location = new System.Drawing.Point(12, 266);
            this.tbxHorisontalSizeInPixels.Name = "tbxHorisontalSizeInPixels";
            this.tbxHorisontalSizeInPixels.Size = new System.Drawing.Size(325, 30);
            this.tbxHorisontalSizeInPixels.TabIndex = 4;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDistance.Location = new System.Drawing.Point(7, 316);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(247, 25);
            this.lblDistance.TabIndex = 7;
            this.lblDistance.Text = "Расстояние до БпЛА (м):";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxDistance.Location = new System.Drawing.Point(12, 353);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(325, 30);
            this.tbxDistance.TabIndex = 6;
            // 
            // lblHorisontalFieldOfView
            // 
            this.lblHorisontalFieldOfView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHorisontalFieldOfView.Location = new System.Drawing.Point(7, 402);
            this.lblHorisontalFieldOfView.Name = "lblHorisontalFieldOfView";
            this.lblHorisontalFieldOfView.Size = new System.Drawing.Size(229, 53);
            this.lblHorisontalFieldOfView.TabIndex = 9;
            this.lblHorisontalFieldOfView.Text = "Горизонтальное поле зрения (градусы):";
            // 
            // tbxHorisontalFieldOfView
            // 
            this.tbxHorisontalFieldOfView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxHorisontalFieldOfView.Location = new System.Drawing.Point(12, 461);
            this.tbxHorisontalFieldOfView.Name = "tbxHorisontalFieldOfView";
            this.tbxHorisontalFieldOfView.Size = new System.Drawing.Size(325, 30);
            this.tbxHorisontalFieldOfView.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(394, 439);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(138, 52);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // lblErrorText
            // 
            this.lblErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblErrorText.Location = new System.Drawing.Point(367, 31);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(371, 155);
            this.lblErrorText.TabIndex = 11;
            this.lblErrorText.Text = "label1";
            this.lblErrorText.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblErrorText);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblHorisontalFieldOfView);
            this.Controls.Add(this.tbxHorisontalFieldOfView);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.lblHorisontalSizeInPixels);
            this.Controls.Add(this.tbxHorisontalSizeInPixels);
            this.Controls.Add(this.lblLinearSize);
            this.Controls.Add(this.tbxLinearSize);
            this.Controls.Add(this.lblPixelSize);
            this.Controls.Add(this.tbxPixelSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор параметров видимости БпЛА";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPixelSize;
        private System.Windows.Forms.Label lblPixelSize;
        private System.Windows.Forms.Label lblLinearSize;
        private System.Windows.Forms.TextBox tbxLinearSize;
        private System.Windows.Forms.Label lblHorisontalSizeInPixels;
        private System.Windows.Forms.TextBox tbxHorisontalSizeInPixels;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Label lblHorisontalFieldOfView;
        private System.Windows.Forms.TextBox tbxHorisontalFieldOfView;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblErrorText;
        private System.Windows.Forms.Button button1;
    }
}

