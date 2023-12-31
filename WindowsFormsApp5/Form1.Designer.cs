
namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.loginbtn = new MaterialSkin.Controls.MaterialButton();
            this.cancelarbtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(256, 160);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(308, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(256, 238);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Password = true;
            this.materialTextBox2.Size = new System.Drawing.Size(308, 50);
            this.materialTextBox2.TabIndex = 1;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            this.materialTextBox2.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(297, 68);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(152, 58);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Login\r\n";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(176, 171);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 29);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "user";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(134, 248);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 29);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "password";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginbtn
            // 
            this.loginbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginbtn.Depth = 0;
            this.loginbtn.HighEmphasis = true;
            this.loginbtn.Icon = null;
            this.loginbtn.Location = new System.Drawing.Point(312, 318);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginbtn.Size = new System.Drawing.Size(64, 36);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "login";
            this.loginbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginbtn.UseAccentColor = false;
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelarbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelarbtn.Depth = 0;
            this.cancelarbtn.HighEmphasis = true;
            this.cancelarbtn.Icon = null;
            this.cancelarbtn.Location = new System.Drawing.Point(402, 318);
            this.cancelarbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelarbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelarbtn.Size = new System.Drawing.Size(96, 36);
            this.cancelarbtn.TabIndex = 6;
            this.cancelarbtn.Text = "cancelar";
            this.cancelarbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelarbtn.UseAccentColor = false;
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 471);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton loginbtn;
        private MaterialSkin.Controls.MaterialButton cancelarbtn;
    }
}

