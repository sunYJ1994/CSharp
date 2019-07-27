namespace GraphIndex
{
    partial class GraphIndex
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.source_pic_box = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select_pic_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.index_pic_box = new System.Windows.Forms.PictureBox();
            this.index_result_path_lab = new System.Windows.Forms.Label();
            this.pre_pic_btn = new System.Windows.Forms.Button();
            this.pre_next_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.open_dir_btn = new System.Windows.Forms.Button();
            this.last_image_btn = new System.Windows.Forms.Button();
            this.first_image_btn = new System.Windows.Forms.Button();
            this.copy_path_btn = new System.Windows.Forms.Button();
            this.copy_name_btn = new System.Windows.Forms.Button();
            this.searching_bar = new System.Windows.Forms.ProgressBar();
            this.start_index_btn = new System.Windows.Forms.Button();
            this.index_path_lab = new System.Windows.Forms.Label();
            this.select_dir_btn = new System.Windows.Forms.Button();
            this.pixel_count_lab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.source_pic_box)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.index_pic_box)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // source_pic_box
            // 
            this.source_pic_box.Location = new System.Drawing.Point(6, 12);
            this.source_pic_box.Name = "source_pic_box";
            this.source_pic_box.Size = new System.Drawing.Size(500, 481);
            this.source_pic_box.TabIndex = 2;
            this.source_pic_box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(184, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "图片源";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F);
            this.label2.Location = new System.Drawing.Point(839, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "索引结果";
            // 
            // select_pic_btn
            // 
            this.select_pic_btn.Location = new System.Drawing.Point(6, 33);
            this.select_pic_btn.Name = "select_pic_btn";
            this.select_pic_btn.Size = new System.Drawing.Size(82, 40);
            this.select_pic_btn.TabIndex = 5;
            this.select_pic_btn.Text = "选择图片";
            this.select_pic_btn.UseMnemonic = false;
            this.select_pic_btn.UseVisualStyleBackColor = true;
            this.select_pic_btn.Click += new System.EventHandler(this.select_pic_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.source_pic_box);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 500);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.index_pic_box);
            this.groupBox2.Location = new System.Drawing.Point(540, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 500);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // index_pic_box
            // 
            this.index_pic_box.Location = new System.Drawing.Point(6, 12);
            this.index_pic_box.Name = "index_pic_box";
            this.index_pic_box.Size = new System.Drawing.Size(580, 481);
            this.index_pic_box.TabIndex = 2;
            this.index_pic_box.TabStop = false;
            this.index_pic_box.DoubleClick += new System.EventHandler(this.open_index_result_btn_Click);
            // 
            // index_result_path_lab
            // 
            this.index_result_path_lab.AutoSize = true;
            this.index_result_path_lab.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.index_result_path_lab.ForeColor = System.Drawing.Color.Black;
            this.index_result_path_lab.Location = new System.Drawing.Point(526, 558);
            this.index_result_path_lab.Name = "index_result_path_lab";
            this.index_result_path_lab.Size = new System.Drawing.Size(0, 12);
            this.index_result_path_lab.TabIndex = 9;
            this.index_result_path_lab.Click += new System.EventHandler(this.copy_index_result_path);
            // 
            // pre_pic_btn
            // 
            this.pre_pic_btn.Location = new System.Drawing.Point(113, 114);
            this.pre_pic_btn.Name = "pre_pic_btn";
            this.pre_pic_btn.Size = new System.Drawing.Size(82, 26);
            this.pre_pic_btn.TabIndex = 9;
            this.pre_pic_btn.Text = "上一张";
            this.pre_pic_btn.UseMnemonic = false;
            this.pre_pic_btn.UseVisualStyleBackColor = true;
            this.pre_pic_btn.Click += new System.EventHandler(this.pre_pic_btn_Click);
            // 
            // pre_next_btn
            // 
            this.pre_next_btn.Location = new System.Drawing.Point(201, 114);
            this.pre_next_btn.Name = "pre_next_btn";
            this.pre_next_btn.Size = new System.Drawing.Size(82, 26);
            this.pre_next_btn.TabIndex = 10;
            this.pre_next_btn.Text = "下一张";
            this.pre_next_btn.UseMnemonic = false;
            this.pre_next_btn.UseVisualStyleBackColor = true;
            this.pre_next_btn.Click += new System.EventHandler(this.pre_next_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.open_dir_btn);
            this.groupBox3.Controls.Add(this.last_image_btn);
            this.groupBox3.Controls.Add(this.first_image_btn);
            this.groupBox3.Controls.Add(this.copy_path_btn);
            this.groupBox3.Controls.Add(this.copy_name_btn);
            this.groupBox3.Controls.Add(this.pre_next_btn);
            this.groupBox3.Controls.Add(this.pre_pic_btn);
            this.groupBox3.Controls.Add(this.searching_bar);
            this.groupBox3.Controls.Add(this.start_index_btn);
            this.groupBox3.Controls.Add(this.index_path_lab);
            this.groupBox3.Controls.Add(this.select_dir_btn);
            this.groupBox3.Controls.Add(this.select_pic_btn);
            this.groupBox3.Location = new System.Drawing.Point(12, 569);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1121, 175);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // open_dir_btn
            // 
            this.open_dir_btn.Location = new System.Drawing.Point(291, 82);
            this.open_dir_btn.Name = "open_dir_btn";
            this.open_dir_btn.Size = new System.Drawing.Size(82, 26);
            this.open_dir_btn.TabIndex = 15;
            this.open_dir_btn.Text = "打开目录";
            this.open_dir_btn.UseMnemonic = false;
            this.open_dir_btn.UseVisualStyleBackColor = true;
            this.open_dir_btn.Click += new System.EventHandler(this.open_dir_btn_Click);
            // 
            // last_image_btn
            // 
            this.last_image_btn.Location = new System.Drawing.Point(203, 82);
            this.last_image_btn.Name = "last_image_btn";
            this.last_image_btn.Size = new System.Drawing.Size(82, 26);
            this.last_image_btn.TabIndex = 14;
            this.last_image_btn.Text = "最后";
            this.last_image_btn.UseMnemonic = false;
            this.last_image_btn.UseVisualStyleBackColor = true;
            this.last_image_btn.Click += new System.EventHandler(this.last_image_btn_Click);
            // 
            // first_image_btn
            // 
            this.first_image_btn.Location = new System.Drawing.Point(113, 82);
            this.first_image_btn.Name = "first_image_btn";
            this.first_image_btn.Size = new System.Drawing.Size(82, 26);
            this.first_image_btn.TabIndex = 13;
            this.first_image_btn.Text = "最前";
            this.first_image_btn.UseMnemonic = false;
            this.first_image_btn.UseVisualStyleBackColor = true;
            this.first_image_btn.Click += new System.EventHandler(this.first_image_btn_Click);
            // 
            // copy_path_btn
            // 
            this.copy_path_btn.Location = new System.Drawing.Point(377, 114);
            this.copy_path_btn.Name = "copy_path_btn";
            this.copy_path_btn.Size = new System.Drawing.Size(82, 26);
            this.copy_path_btn.TabIndex = 12;
            this.copy_path_btn.Text = "复制路径";
            this.copy_path_btn.UseMnemonic = false;
            this.copy_path_btn.UseVisualStyleBackColor = true;
            this.copy_path_btn.Click += new System.EventHandler(this.copy_path_btn_Click);
            // 
            // copy_name_btn
            // 
            this.copy_name_btn.Location = new System.Drawing.Point(289, 114);
            this.copy_name_btn.Name = "copy_name_btn";
            this.copy_name_btn.Size = new System.Drawing.Size(82, 26);
            this.copy_name_btn.TabIndex = 11;
            this.copy_name_btn.Text = "复制名字";
            this.copy_name_btn.UseMnemonic = false;
            this.copy_name_btn.UseVisualStyleBackColor = true;
            this.copy_name_btn.Click += new System.EventHandler(this.copy_name_btn_Click);
            // 
            // searching_bar
            // 
            this.searching_bar.Location = new System.Drawing.Point(6, 146);
            this.searching_bar.Name = "searching_bar";
            this.searching_bar.Size = new System.Drawing.Size(1108, 23);
            this.searching_bar.TabIndex = 9;
            // 
            // start_index_btn
            // 
            this.start_index_btn.Location = new System.Drawing.Point(6, 100);
            this.start_index_btn.Name = "start_index_btn";
            this.start_index_btn.Size = new System.Drawing.Size(82, 40);
            this.start_index_btn.TabIndex = 8;
            this.start_index_btn.Text = "开始索引";
            this.start_index_btn.UseMnemonic = false;
            this.start_index_btn.UseVisualStyleBackColor = true;
            this.start_index_btn.Click += new System.EventHandler(this.start_index_btn_Click);
            // 
            // index_path_lab
            // 
            this.index_path_lab.AutoSize = true;
            this.index_path_lab.Font = new System.Drawing.Font("宋体", 9F);
            this.index_path_lab.Location = new System.Drawing.Point(201, 49);
            this.index_path_lab.Name = "index_path_lab";
            this.index_path_lab.Size = new System.Drawing.Size(0, 12);
            this.index_path_lab.TabIndex = 7;
            // 
            // select_dir_btn
            // 
            this.select_dir_btn.Location = new System.Drawing.Point(113, 33);
            this.select_dir_btn.Name = "select_dir_btn";
            this.select_dir_btn.Size = new System.Drawing.Size(82, 40);
            this.select_dir_btn.TabIndex = 6;
            this.select_dir_btn.Text = "设置目录";
            this.select_dir_btn.UseVisualStyleBackColor = true;
            this.select_dir_btn.Click += new System.EventHandler(this.select_dir_btn_Click);
            // 
            // pixel_count_lab
            // 
            this.pixel_count_lab.AutoSize = true;
            this.pixel_count_lab.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pixel_count_lab.ForeColor = System.Drawing.Color.Black;
            this.pixel_count_lab.Location = new System.Drawing.Point(626, 29);
            this.pixel_count_lab.Name = "pixel_count_lab";
            this.pixel_count_lab.Size = new System.Drawing.Size(0, 19);
            this.pixel_count_lab.TabIndex = 3;
            // 
            // GraphIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 756);
            this.Controls.Add(this.index_result_path_lab);
            this.Controls.Add(this.pixel_count_lab);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1161, 794);
            this.MinimumSize = new System.Drawing.Size(1161, 794);
            this.Name = "GraphIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphIndex";
            ((System.ComponentModel.ISupportInitialize)(this.source_pic_box)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.index_pic_box)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox source_pic_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button select_pic_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label index_path_lab;
        private System.Windows.Forms.Button select_dir_btn;
        private System.Windows.Forms.Button start_index_btn;
        private System.Windows.Forms.Button pre_next_btn;
        private System.Windows.Forms.Button pre_pic_btn;
        private System.Windows.Forms.Label pixel_count_lab;
        private System.Windows.Forms.Label index_result_path_lab;
        private System.Windows.Forms.PictureBox index_pic_box;
        private System.Windows.Forms.ProgressBar searching_bar;
        private System.Windows.Forms.Button copy_path_btn;
        private System.Windows.Forms.Button copy_name_btn;
        private System.Windows.Forms.Button open_dir_btn;
        private System.Windows.Forms.Button last_image_btn;
        private System.Windows.Forms.Button first_image_btn;
    }
}

