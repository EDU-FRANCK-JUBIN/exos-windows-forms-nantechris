namespace WindowsForm
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Label");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Button");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("CheckBox");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.grpBoxUserDetails = new System.Windows.Forms.GroupBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.listCity = new System.Windows.Forms.ListBox();
            this.radBtnMale = new System.Windows.Forms.RadioButton();
            this.radBtnFemale = new System.Windows.Forms.RadioButton();
            this.chkBoxCS = new System.Windows.Forms.CheckBox();
            this.chkBoxASP = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxUserDetails
            // 
            this.grpBoxUserDetails.Controls.Add(this.txtBoxAddress);
            this.grpBoxUserDetails.Controls.Add(this.txtBoxName);
            this.grpBoxUserDetails.Controls.Add(this.labelAddress);
            this.grpBoxUserDetails.Controls.Add(this.labelName);
            this.grpBoxUserDetails.Location = new System.Drawing.Point(22, 25);
            this.grpBoxUserDetails.Name = "grpBoxUserDetails";
            this.grpBoxUserDetails.Size = new System.Drawing.Size(249, 129);
            this.grpBoxUserDetails.TabIndex = 0;
            this.grpBoxUserDetails.TabStop = false;
            this.grpBoxUserDetails.Text = "User Details";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(118, 89);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(100, 22);
            this.txtBoxAddress.TabIndex = 3;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(118, 43);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxName.TabIndex = 2;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(35, 94);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 17);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(35, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // listCity
            // 
            this.listCity.FormattingEnabled = true;
            this.listCity.ItemHeight = 16;
            this.listCity.Items.AddRange(new object[] {
            "Mumbai",
            "Bangalore",
            "Hydrebad"});
            this.listCity.Location = new System.Drawing.Point(22, 169);
            this.listCity.Name = "listCity";
            this.listCity.Size = new System.Drawing.Size(249, 100);
            this.listCity.TabIndex = 4;
            this.listCity.SelectedIndexChanged += new System.EventHandler(this.listCity_SelectedIndexChanged);
            // 
            // radBtnMale
            // 
            this.radBtnMale.AutoSize = true;
            this.radBtnMale.Location = new System.Drawing.Point(327, 70);
            this.radBtnMale.Name = "radBtnMale";
            this.radBtnMale.Size = new System.Drawing.Size(59, 21);
            this.radBtnMale.TabIndex = 5;
            this.radBtnMale.TabStop = true;
            this.radBtnMale.Text = "Male";
            this.radBtnMale.UseVisualStyleBackColor = true;
            // 
            // radBtnFemale
            // 
            this.radBtnFemale.AutoSize = true;
            this.radBtnFemale.Location = new System.Drawing.Point(327, 120);
            this.radBtnFemale.Name = "radBtnFemale";
            this.radBtnFemale.Size = new System.Drawing.Size(75, 21);
            this.radBtnFemale.TabIndex = 6;
            this.radBtnFemale.TabStop = true;
            this.radBtnFemale.Text = "Female";
            this.radBtnFemale.UseVisualStyleBackColor = true;
            // 
            // chkBoxCS
            // 
            this.chkBoxCS.AutoSize = true;
            this.chkBoxCS.Location = new System.Drawing.Point(327, 189);
            this.chkBoxCS.Name = "chkBoxCS";
            this.chkBoxCS.Size = new System.Drawing.Size(47, 21);
            this.chkBoxCS.TabIndex = 7;
            this.chkBoxCS.Text = "C#";
            this.chkBoxCS.UseVisualStyleBackColor = true;
            // 
            // chkBoxASP
            // 
            this.chkBoxASP.AutoSize = true;
            this.chkBoxASP.Location = new System.Drawing.Point(327, 232);
            this.chkBoxASP.Name = "chkBoxASP";
            this.chkBoxASP.Size = new System.Drawing.Size(57, 21);
            this.chkBoxASP.TabIndex = 8;
            this.chkBoxASP.Text = "ASP";
            this.chkBoxASP.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(318, 303);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(475, 31);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nœud2";
            treeNode1.Text = "Label";
            treeNode2.Name = "Nœud3";
            treeNode2.Text = "Button";
            treeNode3.Name = "Nœud1";
            treeNode3.Text = "CheckBox";
            treeNode4.Name = "Nœud0";
            treeNode4.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(196, 123);
            this.treeView1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 344);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkBoxASP);
            this.Controls.Add(this.chkBoxCS);
            this.Controls.Add(this.radBtnFemale);
            this.Controls.Add(this.radBtnMale);
            this.Controls.Add(this.listCity);
            this.Controls.Add(this.grpBoxUserDetails);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grpBoxUserDetails.ResumeLayout(false);
            this.grpBoxUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxUserDetails;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.ListBox listCity;
        private System.Windows.Forms.RadioButton radBtnMale;
        private System.Windows.Forms.RadioButton radBtnFemale;
        private System.Windows.Forms.CheckBox chkBoxCS;
        private System.Windows.Forms.CheckBox chkBoxASP;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}