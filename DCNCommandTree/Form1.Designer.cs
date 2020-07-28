namespace DCNCommandTree
{
    partial class IP
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.form_check = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.form_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.form_login = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.form_ip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.indexshow = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.control_telnet_test_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.control_telnet_progress = new System.Windows.Forms.ProgressBar();
            this.control_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.form_check);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.form_password);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.form_login);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.form_ip);
            this.panel2.Controls.Add(this.label10);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // form_check
            // 
            resources.ApplyResources(this.form_check, "form_check");
            this.form_check.Name = "form_check";
            this.form_check.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // form_password
            // 
            resources.ApplyResources(this.form_password, "form_password");
            this.form_password.Name = "form_password";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // form_login
            // 
            resources.ApplyResources(this.form_login, "form_login");
            this.form_login.Name = "form_login";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // form_ip
            // 
            resources.ApplyResources(this.form_ip, "form_ip");
            this.form_ip.Name = "form_ip";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // next
            // 
            resources.ApplyResources(this.next, "next");
            this.next.Name = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            resources.ApplyResources(this.previous, "previous");
            this.previous.Name = "previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // indexshow
            // 
            resources.ApplyResources(this.indexshow, "indexshow");
            this.indexshow.Name = "indexshow";
            // 
            // finish
            // 
            resources.ApplyResources(this.finish, "finish");
            this.finish.Name = "finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.control_telnet_test_label);
            this.ControlPanel.Controls.Add(this.label2);
            this.ControlPanel.Controls.Add(this.control_telnet_progress);
            this.ControlPanel.Controls.Add(this.control_ip);
            this.ControlPanel.Controls.Add(this.label1);
            resources.ApplyResources(this.ControlPanel, "ControlPanel");
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlPanel_Paint);
            // 
            // control_telnet_test_label
            // 
            resources.ApplyResources(this.control_telnet_test_label, "control_telnet_test_label");
            this.control_telnet_test_label.Name = "control_telnet_test_label";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // control_telnet_progress
            // 
            resources.ApplyResources(this.control_telnet_progress, "control_telnet_progress");
            this.control_telnet_progress.Name = "control_telnet_progress";
            this.control_telnet_progress.Step = 1;
            this.control_telnet_progress.Click += new System.EventHandler(this.control_telnet_progress_Click);
            // 
            // control_ip
            // 
            resources.ApplyResources(this.control_ip, "control_ip");
            this.control_ip.Name = "control_ip";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // IP
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.indexshow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Name = "IP";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox form_check;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox form_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox form_login;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox form_ip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label indexshow;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox control_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar control_telnet_progress;
        private System.Windows.Forms.Label control_telnet_test_label;
    }
}

