namespace Sdl.PackagesOperations.Sample
{
    partial class PackagesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenPackage = new System.Windows.Forms.Button();
            this.labelPackagePath = new System.Windows.Forms.Label();
            this.textBoxPackagePath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBrowsePackagePath = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenPackage
            // 
            this.buttonOpenPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenPackage.Location = new System.Drawing.Point(361, 37);
            this.buttonOpenPackage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenPackage.Name = "buttonOpenPackage";
            this.buttonOpenPackage.Size = new System.Drawing.Size(191, 28);
            this.buttonOpenPackage.TabIndex = 0;
            this.buttonOpenPackage.Text = "Open Package";
            this.buttonOpenPackage.UseVisualStyleBackColor = true;
            this.buttonOpenPackage.Click += new System.EventHandler(this.openPackage);
            // 
            // labelPackagePath
            // 
            this.labelPackagePath.AutoSize = true;
            this.labelPackagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPackagePath.Location = new System.Drawing.Point(4, 0);
            this.labelPackagePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPackagePath.Name = "labelPackagePath";
            this.labelPackagePath.Size = new System.Drawing.Size(107, 33);
            this.labelPackagePath.TabIndex = 3;
            this.labelPackagePath.Text = "Package path";
            this.labelPackagePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPackagePath
            // 
            this.textBoxPackagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPackagePath.Location = new System.Drawing.Point(119, 4);
            this.textBoxPackagePath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPackagePath.Name = "textBoxPackagePath";
            this.textBoxPackagePath.Size = new System.Drawing.Size(433, 22);
            this.textBoxPackagePath.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(8, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(612, 257);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Package Flows";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPackagePath, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPackagePath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonOpenPackage, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonBrowsePackagePath, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 234);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(4, 37);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(107, 28);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonBrowsePackagePath
            // 
            this.buttonBrowsePackagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowsePackagePath.Location = new System.Drawing.Point(560, 4);
            this.buttonBrowsePackagePath.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowsePackagePath.Name = "buttonBrowsePackagePath";
            this.buttonBrowsePackagePath.Size = new System.Drawing.Size(40, 25);
            this.buttonBrowsePackagePath.TabIndex = 9;
            this.buttonBrowsePackagePath.Text = "...";
            this.buttonBrowsePackagePath.UseVisualStyleBackColor = true;
            this.buttonBrowsePackagePath.Click += new System.EventHandler(this.ButtonBrowsePackagePath_Click);
            // 
            // PackagesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PackagesControl";
            this.Size = new System.Drawing.Size(624, 266);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenPackage;
        private System.Windows.Forms.Label labelPackagePath;
        private System.Windows.Forms.TextBox textBoxPackagePath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonBrowsePackagePath;
        private System.Windows.Forms.Button buttonClear;
    }
}
