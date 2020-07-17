namespace FileSearchForm
{
	partial class SearchForm
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
			this.fileTree = new System.Windows.Forms.TreeView();
			this.editStartDirectory = new System.Windows.Forms.TextBox();
			this.startDirectoryText = new System.Windows.Forms.TextBox();
			this.editDirectoryButton = new System.Windows.Forms.Button();
			this.fileTemplateText = new System.Windows.Forms.TextBox();
			this.editFileTemplate = new System.Windows.Forms.TextBox();
			this.editSymbolSet = new System.Windows.Forms.TextBox();
			this.symbolSetText = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.defaultButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fileTree
			// 
			this.fileTree.Location = new System.Drawing.Point(12, 12);
			this.fileTree.Name = "fileTree";
			this.fileTree.Size = new System.Drawing.Size(383, 512);
			this.fileTree.TabIndex = 0;
			this.fileTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.fileTree_AfterSelect);
			// 
			// editStartDirectory
			// 
			this.editStartDirectory.Location = new System.Drawing.Point(401, 37);
			this.editStartDirectory.Name = "editStartDirectory";
			this.editStartDirectory.Size = new System.Drawing.Size(491, 26);
			this.editStartDirectory.TabIndex = 1;
			// 
			// startDirectoryText
			// 
			this.startDirectoryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.startDirectoryText.Location = new System.Drawing.Point(401, 12);
			this.startDirectoryText.Name = "startDirectoryText";
			this.startDirectoryText.ReadOnly = true;
			this.startDirectoryText.Size = new System.Drawing.Size(392, 19);
			this.startDirectoryText.TabIndex = 2;
			this.startDirectoryText.Text = "Стартовая директория";
			// 
			// editDirectoryButton
			// 
			this.editDirectoryButton.AutoSize = true;
			this.editDirectoryButton.Location = new System.Drawing.Point(898, 37);
			this.editDirectoryButton.Name = "editDirectoryButton";
			this.editDirectoryButton.Size = new System.Drawing.Size(37, 30);
			this.editDirectoryButton.TabIndex = 3;
			this.editDirectoryButton.Text = "...";
			this.editDirectoryButton.UseVisualStyleBackColor = true;
			this.editDirectoryButton.Click += new System.EventHandler(this.editDirectoryButton_Click);
			// 
			// fileTemplateText
			// 
			this.fileTemplateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fileTemplateText.Location = new System.Drawing.Point(401, 69);
			this.fileTemplateText.Name = "fileTemplateText";
			this.fileTemplateText.ReadOnly = true;
			this.fileTemplateText.Size = new System.Drawing.Size(392, 19);
			this.fileTemplateText.TabIndex = 5;
			this.fileTemplateText.Text = "Шаблон файла";
			// 
			// editFileTemplate
			// 
			this.editFileTemplate.Location = new System.Drawing.Point(401, 94);
			this.editFileTemplate.Name = "editFileTemplate";
			this.editFileTemplate.Size = new System.Drawing.Size(491, 26);
			this.editFileTemplate.TabIndex = 4;
			// 
			// editSymbolSet
			// 
			this.editSymbolSet.Location = new System.Drawing.Point(401, 151);
			this.editSymbolSet.Name = "editSymbolSet";
			this.editSymbolSet.Size = new System.Drawing.Size(491, 26);
			this.editSymbolSet.TabIndex = 6;
			// 
			// symbolSetText
			// 
			this.symbolSetText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.symbolSetText.Location = new System.Drawing.Point(401, 126);
			this.symbolSetText.Name = "symbolSetText";
			this.symbolSetText.ReadOnly = true;
			this.symbolSetText.Size = new System.Drawing.Size(392, 19);
			this.symbolSetText.TabIndex = 7;
			this.symbolSetText.Text = "Набор символов";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(744, 197);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(148, 51);
			this.searchButton.TabIndex = 8;
			this.searchButton.Text = "Поиск";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.AutoSize = true;
			this.saveButton.Location = new System.Drawing.Point(982, 94);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(186, 51);
			this.saveButton.TabIndex = 9;
			this.saveButton.Text = "Сохранить изменения";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// defaultButton
			// 
			this.defaultButton.AutoSize = true;
			this.defaultButton.Location = new System.Drawing.Point(982, 37);
			this.defaultButton.Name = "defaultButton";
			this.defaultButton.Size = new System.Drawing.Size(186, 51);
			this.defaultButton.TabIndex = 10;
			this.defaultButton.Text = "По умолчанию";
			this.defaultButton.UseVisualStyleBackColor = true;
			this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1171, 536);
			this.Controls.Add(this.defaultButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.symbolSetText);
			this.Controls.Add(this.editSymbolSet);
			this.Controls.Add(this.fileTemplateText);
			this.Controls.Add(this.editFileTemplate);
			this.Controls.Add(this.editDirectoryButton);
			this.Controls.Add(this.startDirectoryText);
			this.Controls.Add(this.editStartDirectory);
			this.Controls.Add(this.fileTree);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "SearchForm";
			this.Text = "Поиск файлов";
			this.Load += new System.EventHandler(this.SearchForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView fileTree;
		private System.Windows.Forms.TextBox editStartDirectory;
		private System.Windows.Forms.TextBox startDirectoryText;
		private System.Windows.Forms.Button editDirectoryButton;
		private System.Windows.Forms.TextBox fileTemplateText;
		private System.Windows.Forms.TextBox editFileTemplate;
		private System.Windows.Forms.TextBox editSymbolSet;
		private System.Windows.Forms.TextBox symbolSetText;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button defaultButton;
	}
}

