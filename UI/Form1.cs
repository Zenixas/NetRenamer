using System;
using System.Windows.Forms;
using NetRenamer.Selection;
using AsmResolver.DotNet;

namespace NetRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static ModuleDefinition module { get; set; }

        private void LoadModuleButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    ModulePathTextBox.Text = filePath;
                    module = ModuleDefinition.FromFile(filePath);
                }
            }

            loadlist();
        }

        private void loadlist()
        {
            foreach (var m in module.GetAllTypes())
            {
                foreach (var x in m.Methods)
                    MethodCheckedListBox.Items.Add(x);
                foreach (var x in m.Fields)
                    FieldCheckedListBox.Items.Add(x);
                foreach (var x in m.Properties)
                    PropertyCheckedListBox.Items.Add(x);
                foreach (var x in m.Events)
                    EventCheckedListBox.Items.Add(x);
            }

            List.tcb.Add(MethodCheckedListBox);
            List.tcb.Add(FieldCheckedListBox);
            List.tcb.Add(PropertyCheckedListBox);
            List.tcb.Add(EventCheckedListBox);

            ModuleNameTextBox.Text = module.Name;
            ModuleANameTextBox.Text = module.Assembly.Name;
            ModuleVersionTextBox.Text = module.Assembly.Version.ToString();
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            module = ModuleDefinition.FromFile(ModulePathTextBox.Text);

            Rename.rename(module);

            obfuscate();
        }

        private void RenameClassesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            List.renameClasses = RenameClassesCheckBox.Checked;
        }

        private void obfuscate()
        {
            module.Name = ModuleNameTextBox.Text;
            module.Assembly.Name = ModuleANameTextBox.Text;
            module.Assembly.Version = Version.Parse(ModuleVersionTextBox.Text);

            module.Write(ModulePathTextBox.Text.Replace(".exe", "-Renamed.exe"));
        }

        #region selection

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            @select.all();
        }

        private void SelectCurrentButton_Click(object sender, EventArgs e)
        {
            @select.current(Types.SelectedIndex);
        }

        #endregion

        #region deselection

        private void DeSelectCurrentButton_Click(object sender, EventArgs e)
        {
            deselect.current(Types.SelectedIndex);
        }

        private void DeSelectAllButton_Click(object sender, EventArgs e)
        {
            deselect.all();
        }

        #endregion

        #region watermark

        private void WaterMarkTextBox_TextChanged(object sender, EventArgs e)
        {
            List.WaterMark = WaterMarkTextBox.Text;
        }

        private void WatermarkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            List.watermark = WatermarkCheckBox.Checked;
        }

        #endregion

        private void Types_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Types.SelectedIndex != 0)
            {
                SelectCurrentButton.Enabled = true;
                DeSelectCurrentButton.Enabled = true;
                SelectCurrentButton.Text = $"Select All {Types.SelectedTab.Text}";
                DeSelectCurrentButton.Text = $"Select All {Types.SelectedTab.Text}";
            }
            else
            {
                SelectCurrentButton.Enabled = false;
                DeSelectCurrentButton.Enabled = false;
            }
        }
    }
}