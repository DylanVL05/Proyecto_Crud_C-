
namespace WindowsFormsApp5
{
    partial class Cliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre_textbox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.correo_textbox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1_Agregar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2_Eliminar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3_editar = new MaterialSkin.Controls.MaterialButton();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(383, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.AllowPromptAsInput = true;
            this.nombre_textbox.AnimateReadOnly = false;
            this.nombre_textbox.AsciiOnly = false;
            this.nombre_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nombre_textbox.BeepOnError = false;
            this.nombre_textbox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.nombre_textbox.Depth = 0;
            this.nombre_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nombre_textbox.HidePromptOnLeave = false;
            this.nombre_textbox.HideSelection = true;
            this.nombre_textbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.nombre_textbox.LeadingIcon = null;
            this.nombre_textbox.Location = new System.Drawing.Point(103, 57);
            this.nombre_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombre_textbox.Mask = "";
            this.nombre_textbox.MaxLength = 32767;
            this.nombre_textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.PasswordChar = '\0';
            this.nombre_textbox.PrefixSuffixText = null;
            this.nombre_textbox.PromptChar = '_';
            this.nombre_textbox.ReadOnly = false;
            this.nombre_textbox.RejectInputOnFirstFailure = false;
            this.nombre_textbox.ResetOnPrompt = true;
            this.nombre_textbox.ResetOnSpace = true;
            this.nombre_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nombre_textbox.SelectedText = "";
            this.nombre_textbox.SelectionLength = 0;
            this.nombre_textbox.SelectionStart = 0;
            this.nombre_textbox.ShortcutsEnabled = true;
            this.nombre_textbox.Size = new System.Drawing.Size(162, 48);
            this.nombre_textbox.SkipLiterals = true;
            this.nombre_textbox.TabIndex = 1;
            this.nombre_textbox.TabStop = false;
            this.nombre_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nombre_textbox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.nombre_textbox.TrailingIcon = null;
            this.nombre_textbox.UseSystemPasswordChar = false;
            this.nombre_textbox.ValidatingType = null;
            this.nombre_textbox.Click += new System.EventHandler(this.materialMaskedTextBox1_Click);
            // 
            // correo_textbox
            // 
            this.correo_textbox.AllowPromptAsInput = true;
            this.correo_textbox.AnimateReadOnly = false;
            this.correo_textbox.AsciiOnly = false;
            this.correo_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.correo_textbox.BeepOnError = false;
            this.correo_textbox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.correo_textbox.Depth = 0;
            this.correo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.correo_textbox.HidePromptOnLeave = false;
            this.correo_textbox.HideSelection = true;
            this.correo_textbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.correo_textbox.LeadingIcon = null;
            this.correo_textbox.Location = new System.Drawing.Point(103, 109);
            this.correo_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.correo_textbox.Mask = "";
            this.correo_textbox.MaxLength = 32767;
            this.correo_textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.correo_textbox.Name = "correo_textbox";
            this.correo_textbox.PasswordChar = '\0';
            this.correo_textbox.PrefixSuffixText = null;
            this.correo_textbox.PromptChar = '_';
            this.correo_textbox.ReadOnly = false;
            this.correo_textbox.RejectInputOnFirstFailure = false;
            this.correo_textbox.ResetOnPrompt = true;
            this.correo_textbox.ResetOnSpace = true;
            this.correo_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.correo_textbox.SelectedText = "";
            this.correo_textbox.SelectionLength = 0;
            this.correo_textbox.SelectionStart = 0;
            this.correo_textbox.ShortcutsEnabled = true;
            this.correo_textbox.Size = new System.Drawing.Size(167, 48);
            this.correo_textbox.SkipLiterals = true;
            this.correo_textbox.TabIndex = 2;
            this.correo_textbox.TabStop = false;
            this.correo_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.correo_textbox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.correo_textbox.TrailingIcon = null;
            this.correo_textbox.UseSystemPasswordChar = false;
            this.correo_textbox.ValidatingType = null;
            this.correo_textbox.Click += new System.EventHandler(this.materialMaskedTextBox2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(425, 9);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 41);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Clientes";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(10, 128);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 29);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "correo";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(8, 66);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(83, 29);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "nombre";
            // 
            // materialButton1_Agregar
            // 
            this.materialButton1_Agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1_Agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1_Agregar.Depth = 0;
            this.materialButton1_Agregar.HighEmphasis = true;
            this.materialButton1_Agregar.Icon = null;
            this.materialButton1_Agregar.Location = new System.Drawing.Point(3, 255);
            this.materialButton1_Agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButton1_Agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1_Agregar.Name = "materialButton1_Agregar";
            this.materialButton1_Agregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1_Agregar.Size = new System.Drawing.Size(88, 36);
            this.materialButton1_Agregar.TabIndex = 6;
            this.materialButton1_Agregar.Text = "Agregar";
            this.materialButton1_Agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1_Agregar.UseAccentColor = false;
            this.materialButton1_Agregar.UseVisualStyleBackColor = true;
            this.materialButton1_Agregar.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2_Eliminar
            // 
            this.materialButton2_Eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2_Eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2_Eliminar.Depth = 0;
            this.materialButton2_Eliminar.HighEmphasis = true;
            this.materialButton2_Eliminar.Icon = null;
            this.materialButton2_Eliminar.Location = new System.Drawing.Point(108, 255);
            this.materialButton2_Eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButton2_Eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2_Eliminar.Name = "materialButton2_Eliminar";
            this.materialButton2_Eliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2_Eliminar.Size = new System.Drawing.Size(88, 36);
            this.materialButton2_Eliminar.TabIndex = 7;
            this.materialButton2_Eliminar.Text = "Eliminar";
            this.materialButton2_Eliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2_Eliminar.UseAccentColor = false;
            this.materialButton2_Eliminar.UseVisualStyleBackColor = true;
            this.materialButton2_Eliminar.Click += new System.EventHandler(this.materialButton2_Eliminar_Click);
            // 
            // materialButton3_editar
            // 
            this.materialButton3_editar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3_editar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3_editar.Depth = 0;
            this.materialButton3_editar.HighEmphasis = true;
            this.materialButton3_editar.Icon = null;
            this.materialButton3_editar.Location = new System.Drawing.Point(211, 255);
            this.materialButton3_editar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButton3_editar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3_editar.Name = "materialButton3_editar";
            this.materialButton3_editar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3_editar.Size = new System.Drawing.Size(71, 36);
            this.materialButton3_editar.TabIndex = 8;
            this.materialButton3_editar.Text = "editar";
            this.materialButton3_editar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3_editar.UseAccentColor = false;
            this.materialButton3_editar.UseVisualStyleBackColor = true;
            this.materialButton3_editar.Click += new System.EventHandler(this.materialButton3_editar_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(664, 57);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 287);
            this.vScrollBar1.TabIndex = 9;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 380);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.materialButton3_editar);
            this.Controls.Add(this.materialButton2_Eliminar);
            this.Controls.Add(this.materialButton1_Agregar);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.correo_textbox);
            this.Controls.Add(this.nombre_textbox);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialMaskedTextBox nombre_textbox;
        private MaterialSkin.Controls.MaterialMaskedTextBox correo_textbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton1_Agregar;
        private MaterialSkin.Controls.MaterialButton materialButton2_Eliminar;
        private MaterialSkin.Controls.MaterialButton materialButton3_editar;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}