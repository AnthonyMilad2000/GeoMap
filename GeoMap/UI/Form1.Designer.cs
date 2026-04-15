namespace GeoMap
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.GeometryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DesciptionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(992, 629);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.MaximumSize = new System.Drawing.Size(60, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(30, 428);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(155, 52);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(117, 34);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(175, 25);
            this.NameBox.TabIndex = 3;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // GeometryBox
            // 
            this.GeometryBox.Location = new System.Drawing.Point(117, 78);
            this.GeometryBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GeometryBox.Name = "GeometryBox";
            this.GeometryBox.Size = new System.Drawing.Size(174, 25);
            this.GeometryBox.TabIndex = 5;
            this.GeometryBox.TextChanged += new System.EventHandler(this.GeometryBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.MaximumSize = new System.Drawing.Size(70, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geometry";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(117, 124);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(175, 25);
            this.ColorBox.TabIndex = 7;
            this.ColorBox.TextChanged += new System.EventHandler(this.ColorBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.MaximumSize = new System.Drawing.Size(60, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 170);
            this.label4.MaximumSize = new System.Drawing.Size(60, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DesciptionBox
            // 
            this.DesciptionBox.Location = new System.Drawing.Point(117, 221);
            this.DesciptionBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DesciptionBox.Name = "DesciptionBox";
            this.DesciptionBox.Size = new System.Drawing.Size(175, 25);
            this.DesciptionBox.TabIndex = 11;
            this.DesciptionBox.TextChanged += new System.EventHandler(this.DesciptionBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 221);
            this.label5.MaximumSize = new System.Drawing.Size(100, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(30, 512);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(155, 52);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(206, 512);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(155, 52);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(117, 170);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(175, 27);
            this.TypeBox.TabIndex = 14;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(206, 428);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(155, 52);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1436, 702);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.DesciptionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GeometryBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "GEO Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox GeometryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DesciptionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Button Update;
    }
}

