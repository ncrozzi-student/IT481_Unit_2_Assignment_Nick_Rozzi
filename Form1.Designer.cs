namespace IT481_Unit_3_Assignment_Nick_Rozzi
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.btnQuery3 = new System.Windows.Forms.Button();
            this.btnQuery4 = new System.Windows.Forms.Button();
            this.btnQuery5 = new System.Windows.Forms.Button();
            this.btnQuery6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(378, 158);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(176, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnQuery1
            // 
            this.btnQuery1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery1.Location = new System.Drawing.Point(76, 276);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(176, 23);
            this.btnQuery1.TabIndex = 4;
            this.btnQuery1.Text = "Get Customer Count";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // btnQuery2
            // 
            this.btnQuery2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery2.Location = new System.Drawing.Point(378, 276);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(176, 23);
            this.btnQuery2.TabIndex = 5;
            this.btnQuery2.Text = "Get Customer Names";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(551, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "SERVER:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(527, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "DATABASE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "USER:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "PASSWORD:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(212, 38);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(160, 20);
            this.tbUser.TabIndex = 14;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(212, 78);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(160, 20);
            this.tbPassword.TabIndex = 15;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(665, 38);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(166, 20);
            this.tbServer.TabIndex = 16;
            // 
            // tbDatabase
            // 
            this.tbDatabase.Location = new System.Drawing.Point(665, 78);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(166, 20);
            this.tbDatabase.TabIndex = 17;
            // 
            // btnQuery3
            // 
            this.btnQuery3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery3.Location = new System.Drawing.Point(665, 276);
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(176, 23);
            this.btnQuery3.TabIndex = 18;
            this.btnQuery3.Text = "Get Order Count";
            this.btnQuery3.UseVisualStyleBackColor = true;
            this.btnQuery3.Click += new System.EventHandler(this.btnQuery3_Click);
            // 
            // btnQuery4
            // 
            this.btnQuery4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery4.Location = new System.Drawing.Point(76, 443);
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Size = new System.Drawing.Size(176, 23);
            this.btnQuery4.TabIndex = 19;
            this.btnQuery4.Text = "Get Order Ship Names";
            this.btnQuery4.UseVisualStyleBackColor = true;
            this.btnQuery4.Click += new System.EventHandler(this.btnQuery4_Click);
            // 
            // btnQuery5
            // 
            this.btnQuery5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery5.Location = new System.Drawing.Point(378, 443);
            this.btnQuery5.Name = "btnQuery5";
            this.btnQuery5.Size = new System.Drawing.Size(176, 23);
            this.btnQuery5.TabIndex = 20;
            this.btnQuery5.Text = "Get Employee Count";
            this.btnQuery5.UseVisualStyleBackColor = true;
            this.btnQuery5.Click += new System.EventHandler(this.btnQuery5_Click);
            // 
            // btnQuery6
            // 
            this.btnQuery6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery6.Location = new System.Drawing.Point(665, 443);
            this.btnQuery6.Name = "btnQuery6";
            this.btnQuery6.Size = new System.Drawing.Size(176, 23);
            this.btnQuery6.TabIndex = 21;
            this.btnQuery6.Text = "Get Employee Names";
            this.btnQuery6.UseVisualStyleBackColor = true;
            this.btnQuery6.Click += new System.EventHandler(this.btnQuery6_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(992, 574);
            this.Controls.Add(this.btnQuery6);
            this.Controls.Add(this.btnQuery5);
            this.Controls.Add(this.btnQuery4);
            this.Controls.Add(this.btnQuery3);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnQuery2);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.Button btnQuery3;
        private System.Windows.Forms.Button btnQuery4;
        private System.Windows.Forms.Button btnQuery5;
        private System.Windows.Forms.Button btnQuery6;
    }
}

