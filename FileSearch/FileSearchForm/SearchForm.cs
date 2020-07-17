using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileLibrary;

namespace FileSearchForm
{
	public partial class SearchForm : Form, FormView
	{

		FormPresenter presenter;

		public SearchForm()
		{
			InitializeComponent();

		}

		private void SearchForm_Load(object sender, EventArgs e)
		{
			presenter = new FormPresenter(this);
			presenter.ReadValues();
		}

		private void fileTree_AfterSelect(object sender, TreeViewEventArgs e)
		{

		}

		

		private void editDirectoryButton_Click(object sender, EventArgs e)
		{
			// Открывается панель выбора папки
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			// Запускается поиск файлов
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			presenter.SaveValues(
				editStartDirectory.Text,
				editFileTemplate.Text,
				editSymbolSet.Text
				);
		}

		private void defaultButton_Click(object sender, EventArgs e)
		{
			presenter.GetDefaultValues();
		}






		public void SetupValues(string startDirectory, string fileTemplate, string symbolSet)
		{
			editStartDirectory.Text = startDirectory;
			editFileTemplate.Text = fileTemplate;
			editSymbolSet.Text = symbolSet;
		}

		public void FillTree()
		{
			throw new NotImplementedException();
		}

		public void ShowMessage(string message)
		{
			MessageBox.Show(message);
		}

		
	}
}
