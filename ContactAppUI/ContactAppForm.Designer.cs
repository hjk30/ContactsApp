using ContactAppUI.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace ContactAppUI
{
    partial class ContactAppForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = (IContainer)new System.ComponentModel.Container();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.splitContainer1 = new SplitContainer();
            this.RemoveContactButton = new Button();
            this.EditContactButton = new Button();
            this.AddContactButton = new Button();
            this.SearchTextBox = new TextBox();
            this.SearchLabel = new Label();
            this.ContactsListBox = new ListBox();
            this.CurrentContactTableLayoutPanel = new TableLayoutPanel();
            this.birthTextBox = new TextBox();
            this.label7 = new Label();
            this.surnameTextBox = new TextBox();
            this.nameTextBox = new TextBox();
            this.phoneTextBox = new TextBox();
            this.emailTextBox = new TextBox();
            this.VKTextBox = new TextBox();
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.exitToolStripMenuItem = new ToolStripMenuItem();
            this.editToolStripMenuItem = new ToolStripMenuItem();
            this.addContactToolStripMenuItem = new ToolStripMenuItem();
            this.editContactToolStripMenuItem = new ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new ToolStripMenuItem();
            this.helpToolStripMenuItem = new ToolStripMenuItem();
            this.aboutToolStripMenuItem = new ToolStripMenuItem();
            this.birthdayPanel = new Panel();
            this.birthdayListLabel = new Label();
            this.timer1 = new Timer(this.components);
            this.splitContainer1.BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CurrentContactTableLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.birthdayPanel.SuspendLayout();
            this.SuspendLayout();
            this.label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new Size(64, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "VK:";
            this.label5.TextAlign = ContentAlignment.MiddleRight;
            this.label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail:";
            this.label4.TextAlign = ContentAlignment.MiddleRight;
            this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone:";
            this.label3.TextAlign = ContentAlignment.MiddleRight;
            this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            this.label2.TextAlign = ContentAlignment.MiddleRight;
            this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname:";
            this.label1.TextAlign = ContentAlignment.MiddleRight;
            this.splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.splitContainer1.Location = new Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add((Control)this.RemoveContactButton);
            this.splitContainer1.Panel1.Controls.Add((Control)this.EditContactButton);
            this.splitContainer1.Panel1.Controls.Add((Control)this.AddContactButton);
            this.splitContainer1.Panel1.Controls.Add((Control)this.SearchTextBox);
            this.splitContainer1.Panel1.Controls.Add((Control)this.SearchLabel);
            this.splitContainer1.Panel1.Controls.Add((Control)this.ContactsListBox);
            this.splitContainer1.Panel1MinSize = 200;
            this.splitContainer1.Panel2.Controls.Add((Control)this.birthdayPanel);
            this.splitContainer1.Panel2.Controls.Add((Control)this.CurrentContactTableLayoutPanel);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new Size(560, 411);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 13;
            this.RemoveContactButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.RemoveContactButton.BackgroundImage = (Image)Resources.RemoveContactIcon;
            this.RemoveContactButton.BackgroundImageLayout = ImageLayout.Stretch;
            this.RemoveContactButton.FlatStyle = FlatStyle.Flat;
            this.RemoveContactButton.Location = new Point(62, 385);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new Size(23, 23);
            this.RemoveContactButton.TabIndex = 17;
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            this.RemoveContactButton.Click += new EventHandler(this.RemoveContactButton_Click);
            this.EditContactButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.EditContactButton.BackgroundImage = (Image)Resources.EditContactIcon;
            this.EditContactButton.BackgroundImageLayout = ImageLayout.Stretch;
            this.EditContactButton.FlatStyle = FlatStyle.Flat;
            this.EditContactButton.Location = new Point(33, 385);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new Size(23, 23);
            this.EditContactButton.TabIndex = 16;
            this.EditContactButton.UseVisualStyleBackColor = true;
            this.EditContactButton.Click += new EventHandler(this.EditContactButton_Click);
            this.AddContactButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.AddContactButton.BackgroundImage = (Image)Resources.AddContactIcon;
            this.AddContactButton.BackgroundImageLayout = ImageLayout.Stretch;
            this.AddContactButton.FlatStyle = FlatStyle.Flat;
            this.AddContactButton.Location = new Point(4, 385);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new Size(23, 23);
            this.AddContactButton.TabIndex = 15;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new EventHandler(this.AddContactButton_Click);
            this.SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.SearchTextBox.Location = new Point(58, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new Size(146, 20);
            this.SearchTextBox.TabIndex = 13;
            this.SearchTextBox.TextChanged += new EventHandler(this.SearchTextBox_TextChanged);
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new Point(3, 8);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new Size(27, 13);
            this.SearchLabel.TabIndex = 14;
            this.SearchLabel.Text = "Find";
            this.ContactsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new Point(4, 27);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new Size(200, 355);
            this.ContactsListBox.TabIndex = 0;
            this.ContactsListBox.SelectedIndexChanged += new EventHandler(this.ContactsListBox_SelectedIndexChanged);
            this.CurrentContactTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.CurrentContactTableLayoutPanel.ColumnCount = 2;
            this.CurrentContactTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70f));
            this.CurrentContactTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.birthTextBox, 1, 2);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.label7, 0, 2);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.label3, 0, 3);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.label5, 0, 5);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.surnameTextBox, 1, 0);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.label2, 0, 1);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.nameTextBox, 1, 1);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.label1, 0, 0);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.phoneTextBox, 1, 3);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.emailTextBox, 1, 4);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.VKTextBox, 1, 5);
            this.CurrentContactTableLayoutPanel.Controls.Add((Control)this.label4, 0, 4);
            this.CurrentContactTableLayoutPanel.Location = new Point(3, 3);
            this.CurrentContactTableLayoutPanel.Name = "CurrentContactTableLayoutPanel";
            this.CurrentContactTableLayoutPanel.RowCount = 6;
            this.CurrentContactTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.CurrentContactTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.CurrentContactTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.CurrentContactTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.CurrentContactTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.CurrentContactTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.CurrentContactTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
            this.CurrentContactTableLayoutPanel.Size = new Size(337, 125);
            this.CurrentContactTableLayoutPanel.TabIndex = 13;
            this.birthTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.birthTextBox.Location = new Point(73, 43);
            this.birthTextBox.Name = "birthTextBox";
            this.birthTextBox.ReadOnly = true;
            this.birthTextBox.Size = new Size(261, 20);
            this.birthTextBox.TabIndex = 15;
            this.birthTextBox.Text = "30.09.2003";
            this.label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new Point(3, 40);
            this.label7.Name = "label7";
            this.label7.Size = new Size(64, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Birthday:";
            this.label7.TextAlign = ContentAlignment.MiddleRight;
            this.surnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.surnameTextBox.Location = new Point(73, 3);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new Size(261, 20);
            this.surnameTextBox.TabIndex = 1;
            this.surnameTextBox.Text = "Шифман";
            this.nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.nameTextBox.Location = new Point(73, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new Size(261, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.Text = "Демид";
            this.phoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.phoneTextBox.Location = new Point(73, 63);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new Size(261, 20);
            this.phoneTextBox.TabIndex = 6;
            this.phoneTextBox.Text = "77712525329";
            this.emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.emailTextBox.Location = new Point(73, 83);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new Size(261, 20);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.Text = "demid_postup@mail.ru";
            this.VKTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.VKTextBox.Location = new Point(73, 103);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.ReadOnly = true;
            this.VKTextBox.Size = new Size(261, 20);
            this.VKTextBox.TabIndex = 10;
            this.VKTextBox.Text = "312671324";
            this.menuStrip1.Items.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.fileToolStripMenuItem,
        (ToolStripItem) this.editToolStripMenuItem,
        (ToolStripItem) this.helpToolStripMenuItem
            });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(584, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
            {
        (ToolStripItem) this.exitToolStripMenuItem
            });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = Keys.F4 | Keys.Alt;
            this.exitToolStripMenuItem.Size = new Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.addContactToolStripMenuItem,
        (ToolStripItem) this.editContactToolStripMenuItem,
        (ToolStripItem) this.removeContactToolStripMenuItem
            });
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new Size(186, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new EventHandler(this.AddContactButton_Click);
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new Size(186, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new EventHandler(this.EditContactButton_Click);
            this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            this.removeContactToolStripMenuItem.ShortcutKeys = Keys.Delete;
            this.removeContactToolStripMenuItem.Size = new Size(186, 22);
            this.removeContactToolStripMenuItem.Text = "Remove Contact";
            this.removeContactToolStripMenuItem.Click += new EventHandler(this.RemoveContactButton_Click);
            this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
            {
        (ToolStripItem) this.aboutToolStripMenuItem
            });
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = Keys.F1;
            this.aboutToolStripMenuItem.Size = new Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
            this.birthdayPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.birthdayPanel.BackColor = SystemColors.ActiveCaption;
            this.birthdayPanel.Controls.Add((Control)this.birthdayListLabel);
            this.birthdayPanel.Location = new Point(3, 283);
            this.birthdayPanel.Name = "birthdayPanel";
            this.birthdayPanel.Size = new Size(343, 125);
            this.birthdayPanel.TabIndex = 14;
            this.birthdayListLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.birthdayListLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
            this.birthdayListLabel.Location = new Point(2, 0);
            this.birthdayListLabel.Name = "birthdayListLabel";
            this.birthdayListLabel.Size = new Size(341, 125);
            this.birthdayListLabel.TabIndex = 1;
            this.birthdayListLabel.Text = "вот у этихх";
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(584, 450);
            this.Controls.Add((Control)this.splitContainer1);
            this.Controls.Add((Control)this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new Size(600, 400);
            this.Name = nameof(ContactAppForm);
            this.Text = "ContactApp";
            this.FormClosed += new FormClosedEventHandler(this.ContactAppForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CurrentContactTableLayoutPanel.ResumeLayout(false);
            this.CurrentContactTableLayoutPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.birthdayPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ListBox ContactsListBox;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addContactToolStripMenuItem;
        private ToolStripMenuItem editContactToolStripMenuItem;
        private ToolStripMenuItem removeContactToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox SearchTextBox;
        private Label SearchLabel;
        private TableLayoutPanel CurrentContactTableLayoutPanel;
        private Label label7;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private TextBox phoneTextBox;
        private TextBox emailTextBox;
        private TextBox VKTextBox;
        private Button AddContactButton;
        private Button RemoveContactButton;
        private Button EditContactButton;
        private TextBox birthTextBox;
        private Panel birthdayPanel;
        private Label birthdayListLabel;
        private Timer timer1;
    }
}

