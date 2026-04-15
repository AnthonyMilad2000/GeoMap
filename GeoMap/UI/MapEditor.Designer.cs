namespace GeoMap.UI
{
    partial class MapEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapEditor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTypeBox = new System.Windows.Forms.ComboBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PolygonBtn = new System.Windows.Forms.Button();
            this.LineBtn = new System.Windows.Forms.Button();
            this.PointBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GeometryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.OpenHumanitarian = new System.Windows.Forms.Button();
            this.OpenStreetMap = new System.Windows.Forms.Button();
            this.Cursor = new System.Windows.Forms.Button();
            this.TwoPoints = new System.Windows.Forms.Button();
            this.PolygonPoints = new System.Windows.Forms.Button();
            this.OnePoint = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboTypeBox);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.PolygonBtn);
            this.panel1.Controls.Add(this.LineBtn);
            this.panel1.Controls.Add(this.PointBtn);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DescriptionBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ColorBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GeometryBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.OpenHumanitarian);
            this.panel1.Controls.Add(this.OpenStreetMap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 846);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 657);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Type";
            // 
            // comboTypeBox
            // 
            this.comboTypeBox.FormattingEnabled = true;
            this.comboTypeBox.Location = new System.Drawing.Point(65, 655);
            this.comboTypeBox.Name = "comboTypeBox";
            this.comboTypeBox.Size = new System.Drawing.Size(192, 24);
            this.comboTypeBox.TabIndex = 25;
            this.comboTypeBox.SelectedIndexChanged += new System.EventHandler(this.comboTypeBox_SelectedIndexChanged);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(290, 789);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(134, 46);
            this.Deletebtn.TabIndex = 24;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(150, 789);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(134, 46);
            this.UpdateBtn.TabIndex = 23;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 326);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PolygonBtn
            // 
            this.PolygonBtn.Location = new System.Drawing.Point(398, 697);
            this.PolygonBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PolygonBtn.Name = "PolygonBtn";
            this.PolygonBtn.Size = new System.Drawing.Size(164, 73);
            this.PolygonBtn.TabIndex = 21;
            this.PolygonBtn.Text = "Polygon";
            this.PolygonBtn.UseVisualStyleBackColor = true;
            this.PolygonBtn.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // LineBtn
            // 
            this.LineBtn.Location = new System.Drawing.Point(216, 697);
            this.LineBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(176, 73);
            this.LineBtn.TabIndex = 20;
            this.LineBtn.Text = "Line";
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // PointBtn
            // 
            this.PointBtn.Location = new System.Drawing.Point(17, 697);
            this.PointBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PointBtn.Name = "PointBtn";
            this.PointBtn.Size = new System.Drawing.Size(193, 73);
            this.PointBtn.TabIndex = 19;
            this.PointBtn.Text = "Point";
            this.PointBtn.UseVisualStyleBackColor = true;
            this.PointBtn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(430, 789);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(134, 46);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 789);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Description";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(370, 615);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(192, 22);
            this.DescriptionBox.TabIndex = 13;
            this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(65, 615);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(192, 22);
            this.ColorBox.TabIndex = 9;
            this.ColorBox.TextChanged += new System.EventHandler(this.ColorBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Geometry";
            // 
            // GeometryBox
            // 
            this.GeometryBox.Location = new System.Drawing.Point(370, 575);
            this.GeometryBox.Name = "GeometryBox";
            this.GeometryBox.Size = new System.Drawing.Size(192, 22);
            this.GeometryBox.TabIndex = 7;
            this.GeometryBox.TextChanged += new System.EventHandler(this.GeometryBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Feature";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(65, 575);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(192, 22);
            this.NameBox.TabIndex = 4;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // OpenHumanitarian
            // 
            this.OpenHumanitarian.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenHumanitarian.Location = new System.Drawing.Point(290, 59);
            this.OpenHumanitarian.Name = "OpenHumanitarian";
            this.OpenHumanitarian.Size = new System.Drawing.Size(272, 93);
            this.OpenHumanitarian.TabIndex = 3;
            this.OpenHumanitarian.Text = "Open Humanitarian";
            this.OpenHumanitarian.UseVisualStyleBackColor = false;
            this.OpenHumanitarian.Click += new System.EventHandler(this.OpenHumanitarian_Click);
            // 
            // OpenStreetMap
            // 
            this.OpenStreetMap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenStreetMap.Location = new System.Drawing.Point(7, 59);
            this.OpenStreetMap.Name = "OpenStreetMap";
            this.OpenStreetMap.Size = new System.Drawing.Size(274, 93);
            this.OpenStreetMap.TabIndex = 2;
            this.OpenStreetMap.Text = "Open Street Map";
            this.OpenStreetMap.UseVisualStyleBackColor = false;
            this.OpenStreetMap.Click += new System.EventHandler(this.OpenStreetMap_Click);
            // 
            // Cursor
            // 
            this.Cursor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cursor.BackgroundImage")));
            this.Cursor.Location = new System.Drawing.Point(872, 785);
            this.Cursor.Name = "Cursor";
            this.Cursor.Size = new System.Drawing.Size(51, 49);
            this.Cursor.TabIndex = 2;
            this.Cursor.UseVisualStyleBackColor = true;
            this.Cursor.Click += new System.EventHandler(this.button2_Click);
            // 
            // TwoPoints
            // 
            this.TwoPoints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TwoPoints.BackgroundImage")));
            this.TwoPoints.Location = new System.Drawing.Point(949, 785);
            this.TwoPoints.Name = "TwoPoints";
            this.TwoPoints.Size = new System.Drawing.Size(51, 49);
            this.TwoPoints.TabIndex = 3;
            this.TwoPoints.UseVisualStyleBackColor = true;
            this.TwoPoints.Click += new System.EventHandler(this.button3_Click);
            // 
            // PolygonPoints
            // 
            this.PolygonPoints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PolygonPoints.BackgroundImage")));
            this.PolygonPoints.Location = new System.Drawing.Point(1021, 785);
            this.PolygonPoints.Name = "PolygonPoints";
            this.PolygonPoints.Size = new System.Drawing.Size(51, 49);
            this.PolygonPoints.TabIndex = 4;
            this.PolygonPoints.UseVisualStyleBackColor = true;
            this.PolygonPoints.Click += new System.EventHandler(this.button4_Click);
            // 
            // OnePoint
            // 
            this.OnePoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OnePoint.BackgroundImage")));
            this.OnePoint.Location = new System.Drawing.Point(1096, 785);
            this.OnePoint.Name = "OnePoint";
            this.OnePoint.Size = new System.Drawing.Size(40, 49);
            this.OnePoint.TabIndex = 5;
            this.OnePoint.UseVisualStyleBackColor = true;
            this.OnePoint.Click += new System.EventHandler(this.button5_Click);
            // 
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(581, 0);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(847, 846);
            this.axMap1.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(80, 22);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(192, 22);
            this.searchBox.TabIndex = 27;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Search";
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 846);
            this.Controls.Add(this.OnePoint);
            this.Controls.Add(this.PolygonPoints);
            this.Controls.Add(this.TwoPoints);
            this.Controls.Add(this.Cursor);
            this.Controls.Add(this.axMap1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapEditor";
            this.Text = "Map Editor";
            this.Load += new System.EventHandler(this.MapEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxMapWinGIS.AxMap axMap1;
        private System.Windows.Forms.Button Cursor;
        private System.Windows.Forms.Button TwoPoints;
        private System.Windows.Forms.Button PolygonPoints;
        private System.Windows.Forms.Button OnePoint;
        private System.Windows.Forms.Button OpenHumanitarian;
        private System.Windows.Forms.Button OpenStreetMap;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GeometryBox;
        private System.Windows.Forms.Button PointBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PolygonBtn;
        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTypeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchBox;
    }
}