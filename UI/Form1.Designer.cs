namespace NetRenamer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadModuleButton = new System.Windows.Forms.Button();
            this.ModulePathTextBox = new System.Windows.Forms.TextBox();
            this.RenameButton = new System.Windows.Forms.Button();
            this.Types = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.WatermarkCheckBox = new System.Windows.Forms.CheckBox();
            this.RenameClassesCheckBox = new System.Windows.Forms.CheckBox();
            this.WaterMarkTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModuleVersionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModuleANameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ModuleNameTextBox = new System.Windows.Forms.TextBox();
            this.Methods = new System.Windows.Forms.TabPage();
            this.MethodCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Fields = new System.Windows.Forms.TabPage();
            this.FieldCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Properties = new System.Windows.Forms.TabPage();
            this.PropertyCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Events = new System.Windows.Forms.TabPage();
            this.EventCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.SelectCurrentButton = new System.Windows.Forms.Button();
            this.DeSelectCurrentButton = new System.Windows.Forms.Button();
            this.DeSelectAllButton = new System.Windows.Forms.Button();
            this.Types.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.Methods.SuspendLayout();
            this.Fields.SuspendLayout();
            this.Properties.SuspendLayout();
            this.Events.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadModuleButton
            // 
            this.LoadModuleButton.Location = new System.Drawing.Point(597, 25);
            this.LoadModuleButton.Name = "LoadModuleButton";
            this.LoadModuleButton.Size = new System.Drawing.Size(113, 23);
            this.LoadModuleButton.TabIndex = 0;
            this.LoadModuleButton.Text = "Load Module";
            this.LoadModuleButton.UseVisualStyleBackColor = true;
            this.LoadModuleButton.Click += new System.EventHandler(this.LoadModuleButton_Click);
            // 
            // ModulePathTextBox
            // 
            this.ModulePathTextBox.Location = new System.Drawing.Point(12, 25);
            this.ModulePathTextBox.Name = "ModulePathTextBox";
            this.ModulePathTextBox.Size = new System.Drawing.Size(581, 23);
            this.ModulePathTextBox.TabIndex = 1;
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(494, 373);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(212, 40);
            this.RenameButton.TabIndex = 6;
            this.RenameButton.Text = "Build";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // Types
            // 
            this.Types.Controls.Add(this.MainPage);
            this.Types.Controls.Add(this.Methods);
            this.Types.Controls.Add(this.Fields);
            this.Types.Controls.Add(this.Properties);
            this.Types.Controls.Add(this.Events);
            this.Types.Location = new System.Drawing.Point(12, 54);
            this.Types.Name = "Types";
            this.Types.SelectedIndex = 0;
            this.Types.Size = new System.Drawing.Size(698, 271);
            this.Types.TabIndex = 7;
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.WatermarkCheckBox);
            this.MainPage.Controls.Add(this.RenameClassesCheckBox);
            this.MainPage.Controls.Add(this.WaterMarkTextBox);
            this.MainPage.Controls.Add(this.label3);
            this.MainPage.Controls.Add(this.ModuleVersionTextBox);
            this.MainPage.Controls.Add(this.label2);
            this.MainPage.Controls.Add(this.ModuleANameTextBox);
            this.MainPage.Controls.Add(this.label1);
            this.MainPage.Controls.Add(this.ModuleNameTextBox);
            this.MainPage.Location = new System.Drawing.Point(4, 24);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(690, 243);
            this.MainPage.TabIndex = 4;
            this.MainPage.Text = "Main";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // WatermarkCheckBox
            // 
            this.WatermarkCheckBox.AutoSize = true;
            this.WatermarkCheckBox.Location = new System.Drawing.Point(349, 59);
            this.WatermarkCheckBox.Name = "WatermarkCheckBox";
            this.WatermarkCheckBox.Size = new System.Drawing.Size(170, 19);
            this.WatermarkCheckBox.TabIndex = 10;
            this.WatermarkCheckBox.Text = "Enable Custom Watermark:";
            this.WatermarkCheckBox.UseVisualStyleBackColor = true;
            this.WatermarkCheckBox.CheckedChanged += new System.EventHandler(this.WatermarkCheckBox_CheckedChanged);
            // 
            // RenameClassesCheckBox
            // 
            this.RenameClassesCheckBox.AutoSize = true;
            this.RenameClassesCheckBox.Location = new System.Drawing.Point(349, 128);
            this.RenameClassesCheckBox.Name = "RenameClassesCheckBox";
            this.RenameClassesCheckBox.Size = new System.Drawing.Size(110, 19);
            this.RenameClassesCheckBox.TabIndex = 9;
            this.RenameClassesCheckBox.Text = "Rename Classes";
            this.RenameClassesCheckBox.UseVisualStyleBackColor = true;
            this.RenameClassesCheckBox.CheckedChanged += new System.EventHandler(this.RenameClassesCheckBox_CheckedChanged);
            // 
            // WaterMarkTextBox
            // 
            this.WaterMarkTextBox.Location = new System.Drawing.Point(333, 84);
            this.WaterMarkTextBox.Name = "WaterMarkTextBox";
            this.WaterMarkTextBox.Size = new System.Drawing.Size(321, 23);
            this.WaterMarkTextBox.TabIndex = 8;
            this.WaterMarkTextBox.Text = "NetRenamer";
            this.WaterMarkTextBox.TextChanged += new System.EventHandler(this.WaterMarkTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Module Version:";
            // 
            // ModuleVersionTextBox
            // 
            this.ModuleVersionTextBox.Location = new System.Drawing.Point(6, 84);
            this.ModuleVersionTextBox.Name = "ModuleVersionTextBox";
            this.ModuleVersionTextBox.Size = new System.Drawing.Size(321, 23);
            this.ModuleVersionTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Module Assembly Name:";
            // 
            // ModuleANameTextBox
            // 
            this.ModuleANameTextBox.Location = new System.Drawing.Point(333, 28);
            this.ModuleANameTextBox.Name = "ModuleANameTextBox";
            this.ModuleANameTextBox.Size = new System.Drawing.Size(321, 23);
            this.ModuleANameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Module Name:";
            // 
            // ModuleNameTextBox
            // 
            this.ModuleNameTextBox.Location = new System.Drawing.Point(6, 28);
            this.ModuleNameTextBox.Name = "ModuleNameTextBox";
            this.ModuleNameTextBox.Size = new System.Drawing.Size(321, 23);
            this.ModuleNameTextBox.TabIndex = 0;
            // 
            // Methods
            // 
            this.Methods.Controls.Add(this.MethodCheckedListBox);
            this.Methods.Location = new System.Drawing.Point(4, 24);
            this.Methods.Name = "Methods";
            this.Methods.Padding = new System.Windows.Forms.Padding(3);
            this.Methods.Size = new System.Drawing.Size(690, 243);
            this.Methods.TabIndex = 0;
            this.Methods.Text = "Methods";
            this.Methods.UseVisualStyleBackColor = true;
            // 
            // MethodCheckedListBox
            // 
            this.MethodCheckedListBox.FormattingEnabled = true;
            this.MethodCheckedListBox.Location = new System.Drawing.Point(3, 3);
            this.MethodCheckedListBox.Name = "MethodCheckedListBox";
            this.MethodCheckedListBox.Size = new System.Drawing.Size(681, 238);
            this.MethodCheckedListBox.TabIndex = 0;
            // 
            // Fields
            // 
            this.Fields.Controls.Add(this.FieldCheckedListBox);
            this.Fields.Location = new System.Drawing.Point(4, 24);
            this.Fields.Name = "Fields";
            this.Fields.Padding = new System.Windows.Forms.Padding(3);
            this.Fields.Size = new System.Drawing.Size(690, 243);
            this.Fields.TabIndex = 1;
            this.Fields.Text = "Fields";
            this.Fields.UseVisualStyleBackColor = true;
            // 
            // FieldCheckedListBox
            // 
            this.FieldCheckedListBox.FormattingEnabled = true;
            this.FieldCheckedListBox.Location = new System.Drawing.Point(3, 3);
            this.FieldCheckedListBox.Name = "FieldCheckedListBox";
            this.FieldCheckedListBox.Size = new System.Drawing.Size(681, 238);
            this.FieldCheckedListBox.TabIndex = 0;
            // 
            // Properties
            // 
            this.Properties.Controls.Add(this.PropertyCheckedListBox);
            this.Properties.Location = new System.Drawing.Point(4, 24);
            this.Properties.Name = "Properties";
            this.Properties.Padding = new System.Windows.Forms.Padding(3);
            this.Properties.Size = new System.Drawing.Size(690, 243);
            this.Properties.TabIndex = 2;
            this.Properties.Text = "Properties";
            this.Properties.UseVisualStyleBackColor = true;
            // 
            // PropertyCheckedListBox
            // 
            this.PropertyCheckedListBox.FormattingEnabled = true;
            this.PropertyCheckedListBox.Location = new System.Drawing.Point(3, 3);
            this.PropertyCheckedListBox.Name = "PropertyCheckedListBox";
            this.PropertyCheckedListBox.Size = new System.Drawing.Size(681, 238);
            this.PropertyCheckedListBox.TabIndex = 0;
            // 
            // Events
            // 
            this.Events.Controls.Add(this.EventCheckedListBox);
            this.Events.Location = new System.Drawing.Point(4, 24);
            this.Events.Name = "Events";
            this.Events.Padding = new System.Windows.Forms.Padding(3);
            this.Events.Size = new System.Drawing.Size(690, 243);
            this.Events.TabIndex = 3;
            this.Events.Text = "Events";
            this.Events.UseVisualStyleBackColor = true;
            // 
            // EventCheckedListBox
            // 
            this.EventCheckedListBox.FormattingEnabled = true;
            this.EventCheckedListBox.Location = new System.Drawing.Point(3, 3);
            this.EventCheckedListBox.Name = "EventCheckedListBox";
            this.EventCheckedListBox.Size = new System.Drawing.Size(681, 238);
            this.EventCheckedListBox.TabIndex = 0;
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Location = new System.Drawing.Point(12, 373);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(212, 40);
            this.SelectAllButton.TabIndex = 8;
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // SelectCurrentButton
            // 
            this.SelectCurrentButton.Location = new System.Drawing.Point(12, 327);
            this.SelectCurrentButton.Name = "SelectCurrentButton";
            this.SelectCurrentButton.Size = new System.Drawing.Size(212, 40);
            this.SelectCurrentButton.TabIndex = 9;
            this.SelectCurrentButton.Text = "Select All In Current Tab";
            this.SelectCurrentButton.UseVisualStyleBackColor = true;
            this.SelectCurrentButton.Click += new System.EventHandler(this.SelectCurrentButton_Click);
            // 
            // DeSelectCurrentButton
            // 
            this.DeSelectCurrentButton.Location = new System.Drawing.Point(230, 327);
            this.DeSelectCurrentButton.Name = "DeSelectCurrentButton";
            this.DeSelectCurrentButton.Size = new System.Drawing.Size(212, 40);
            this.DeSelectCurrentButton.TabIndex = 10;
            this.DeSelectCurrentButton.Text = "DeSelect All In Current Tab";
            this.DeSelectCurrentButton.UseVisualStyleBackColor = true;
            this.DeSelectCurrentButton.Click += new System.EventHandler(this.DeSelectCurrentButton_Click);
            // 
            // DeSelectAllButton
            // 
            this.DeSelectAllButton.Location = new System.Drawing.Point(230, 373);
            this.DeSelectAllButton.Name = "DeSelectAllButton";
            this.DeSelectAllButton.Size = new System.Drawing.Size(212, 40);
            this.DeSelectAllButton.TabIndex = 11;
            this.DeSelectAllButton.Text = "Deselect All";
            this.DeSelectAllButton.UseVisualStyleBackColor = true;
            this.DeSelectAllButton.Click += new System.EventHandler(this.DeSelectAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 438);
            this.Controls.Add(this.Types);
            this.Controls.Add(this.DeSelectAllButton);
            this.Controls.Add(this.DeSelectCurrentButton);
            this.Controls.Add(this.SelectCurrentButton);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.ModulePathTextBox);
            this.Controls.Add(this.LoadModuleButton);
            this.Name = "Form1";
            this.Text = "NetRenamer";
            this.Types.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.Methods.ResumeLayout(false);
            this.Fields.ResumeLayout(false);
            this.Properties.ResumeLayout(false);
            this.Events.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadModuleButton;
        private System.Windows.Forms.TextBox ModulePathTextBox;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.TabControl Types;
        private System.Windows.Forms.TabPage Methods;
        private System.Windows.Forms.CheckedListBox MethodCheckedListBox;
        private System.Windows.Forms.TabPage Fields;
        private System.Windows.Forms.CheckedListBox FieldCheckedListBox;
        private System.Windows.Forms.TabPage Properties;
        private System.Windows.Forms.CheckedListBox PropertyCheckedListBox;
        private System.Windows.Forms.TabPage Events;
        private System.Windows.Forms.CheckedListBox EventCheckedListBox;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button SelectCurrentButton;
        private System.Windows.Forms.Button DeSelectCurrentButton;
        private System.Windows.Forms.Button DeSelectAllButton;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TextBox ModuleNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModuleANameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModuleVersionTextBox;
        private System.Windows.Forms.TextBox WaterMarkTextBox;
        private System.Windows.Forms.CheckBox RenameClassesCheckBox;
        private System.Windows.Forms.CheckBox WatermarkCheckBox;
    }
}

