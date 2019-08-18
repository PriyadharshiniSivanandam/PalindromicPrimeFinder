namespace PalindromicPrimeFinderUI
{
  partial class FormFinder
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
      this.lbl_NumberSystem = new System.Windows.Forms.Label();
      this.cb_NumberSystem = new System.Windows.Forms.ComboBox();
      this.lb_From = new System.Windows.Forms.Label();
      this.tb_FromValue = new System.Windows.Forms.TextBox();
      this.lb_To = new System.Windows.Forms.Label();
      this.tb_ToValue = new System.Windows.Forms.TextBox();
      this.bt_Find = new System.Windows.Forms.Button();
      this.rtb_Output = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // lbl_NumberSystem
      // 
      this.lbl_NumberSystem.AutoSize = true;
      this.lbl_NumberSystem.Location = new System.Drawing.Point(26, 25);
      this.lbl_NumberSystem.Name = "lbl_NumberSystem";
      this.lbl_NumberSystem.Size = new System.Drawing.Size(104, 17);
      this.lbl_NumberSystem.TabIndex = 0;
      this.lbl_NumberSystem.Text = "NumberSystem";
      // 
      // cb_NumberSystem
      // 
      this.cb_NumberSystem.FormattingEnabled = true;
      this.cb_NumberSystem.Location = new System.Drawing.Point(136, 22);
      this.cb_NumberSystem.Name = "cb_NumberSystem";
      this.cb_NumberSystem.Size = new System.Drawing.Size(121, 24);
      this.cb_NumberSystem.TabIndex = 2;
      this.cb_NumberSystem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // lb_From
      // 
      this.lb_From.AutoSize = true;
      this.lb_From.Location = new System.Drawing.Point(26, 75);
      this.lb_From.Name = "lb_From";
      this.lb_From.Size = new System.Drawing.Size(40, 17);
      this.lb_From.TabIndex = 3;
      this.lb_From.Text = "From";
      // 
      // tb_FromValue
      // 
      this.tb_FromValue.Location = new System.Drawing.Point(72, 70);
      this.tb_FromValue.Name = "tb_FromValue";
      this.tb_FromValue.Size = new System.Drawing.Size(100, 22);
      this.tb_FromValue.TabIndex = 4;
      this.tb_FromValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // lb_To
      // 
      this.lb_To.AutoSize = true;
      this.lb_To.Location = new System.Drawing.Point(201, 70);
      this.lb_To.Name = "lb_To";
      this.lb_To.Size = new System.Drawing.Size(25, 17);
      this.lb_To.TabIndex = 5;
      this.lb_To.Text = "To";
      // 
      // tb_ToValue
      // 
      this.tb_ToValue.Location = new System.Drawing.Point(232, 70);
      this.tb_ToValue.Name = "tb_ToValue";
      this.tb_ToValue.Size = new System.Drawing.Size(100, 22);
      this.tb_ToValue.TabIndex = 6;
      this.tb_ToValue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // bt_Find
      // 
      this.bt_Find.Location = new System.Drawing.Point(82, 141);
      this.bt_Find.Name = "bt_Find";
      this.bt_Find.Size = new System.Drawing.Size(75, 23);
      this.bt_Find.TabIndex = 7;
      this.bt_Find.Text = "Find";
      this.bt_Find.UseVisualStyleBackColor = true;
      this.bt_Find.Click += new System.EventHandler(this.bt_Find_Click);
      // 
      // rtb_Output
      // 
      this.rtb_Output.Location = new System.Drawing.Point(12, 228);
      this.rtb_Output.Name = "rtb_Output";
      this.rtb_Output.Size = new System.Drawing.Size(333, 242);
      this.rtb_Output.TabIndex = 8;
      this.rtb_Output.Text = "";
      // 
      // FormFinder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(357, 493);
      this.Controls.Add(this.rtb_Output);
      this.Controls.Add(this.bt_Find);
      this.Controls.Add(this.tb_ToValue);
      this.Controls.Add(this.lb_To);
      this.Controls.Add(this.tb_FromValue);
      this.Controls.Add(this.lb_From);
      this.Controls.Add(this.cb_NumberSystem);
      this.Controls.Add(this.lbl_NumberSystem);
      this.Name = "FormFinder";
      this.Text = "PalindromicPrimeFinder";
      this.Load += new System.EventHandler(this.form_Finder_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_NumberSystem;
    private System.Windows.Forms.ComboBox cb_NumberSystem;
    private System.Windows.Forms.Label lb_From;
    private System.Windows.Forms.TextBox tb_FromValue;
    private System.Windows.Forms.Label lb_To;
    private System.Windows.Forms.TextBox tb_ToValue;
    private System.Windows.Forms.Button bt_Find;
    private System.Windows.Forms.RichTextBox rtb_Output;
  }
}

