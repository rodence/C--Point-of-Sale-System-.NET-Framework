namespace PointofSale_ITE_314
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.compute = new System.Windows.Forms.Button();
            this.item_num = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.no_stocks = new System.Windows.Forms.TextBox();
            this.item_price = new System.Windows.Forms.TextBox();
            this.no_order = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.vat = new System.Windows.Forms.TextBox();
            this.cash = new System.Windows.Forms.TextBox();
            this.total_change = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "POINT OF SALE\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 206);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Items";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ITEM NUMBER :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DESCRIPTION :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "NO. OF STOCKS :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ITEM PRICE :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "NUMBER ORDER :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(95, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "TOTAL :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(113, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "VAT :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(100, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "CASH :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(72, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "CHANGE :";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(372, 138);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(64, 26);
            this.search.TabIndex = 11;
            this.search.Text = "FIND";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(344, 314);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(92, 26);
            this.generate.TabIndex = 12;
            this.generate.Text = "GENERATE";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // compute
            // 
            this.compute.Location = new System.Drawing.Point(372, 461);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(64, 26);
            this.compute.TabIndex = 13;
            this.compute.Text = "CHANGE";
            this.compute.UseVisualStyleBackColor = true;
            this.compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // item_num
            // 
            this.item_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_num.Location = new System.Drawing.Point(190, 112);
            this.item_num.Name = "item_num";
            this.item_num.Size = new System.Drawing.Size(246, 20);
            this.item_num.TabIndex = 14;
            this.item_num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(190, 178);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(246, 20);
            this.description.TabIndex = 15;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // no_stocks
            // 
            this.no_stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_stocks.Location = new System.Drawing.Point(190, 209);
            this.no_stocks.Name = "no_stocks";
            this.no_stocks.Size = new System.Drawing.Size(246, 20);
            this.no_stocks.TabIndex = 16;
            // 
            // item_price
            // 
            this.item_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_price.Location = new System.Drawing.Point(190, 239);
            this.item_price.Name = "item_price";
            this.item_price.Size = new System.Drawing.Size(246, 20);
            this.item_price.TabIndex = 17;
            this.item_price.TextChanged += new System.EventHandler(this.item_price_TextChanged);
            // 
            // no_order
            // 
            this.no_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_order.Location = new System.Drawing.Point(190, 288);
            this.no_order.Name = "no_order";
            this.no_order.Size = new System.Drawing.Size(246, 20);
            this.no_order.TabIndex = 18;
            this.no_order.TextChanged += new System.EventHandler(this.no_order_TextChanged);
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(190, 358);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(246, 20);
            this.total.TabIndex = 19;
            // 
            // vat
            // 
            this.vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vat.Location = new System.Drawing.Point(190, 393);
            this.vat.Name = "vat";
            this.vat.Size = new System.Drawing.Size(246, 20);
            this.vat.TabIndex = 20;
            this.vat.TextChanged += new System.EventHandler(this.vat_TextChanged);
            // 
            // cash
            // 
            this.cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(190, 426);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(246, 20);
            this.cash.TabIndex = 21;
            // 
            // total_change
            // 
            this.total_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_change.Location = new System.Drawing.Point(190, 493);
            this.total_change.Name = "total_change";
            this.total_change.Size = new System.Drawing.Size(246, 20);
            this.total_change.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(473, 620);
            this.Controls.Add(this.total_change);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.vat);
            this.Controls.Add(this.total);
            this.Controls.Add(this.no_order);
            this.Controls.Add(this.item_price);
            this.Controls.Add(this.no_stocks);
            this.Controls.Add(this.description);
            this.Controls.Add(this.item_num);
            this.Controls.Add(this.compute);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.TextBox item_num;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox no_stocks;
        private System.Windows.Forms.TextBox item_price;
        private System.Windows.Forms.TextBox no_order;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox vat;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.TextBox total_change;
    }
}

