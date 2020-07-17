using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLibrary
{
	public class FormPresenter
	{
		FormView view;

		public FormPresenter(FormView view)
		{
			this.view = view;
		}

		public void ReadValues()
		{
			string startDirectory = FileConstants.StartDirectory;
			string nameTemplate = FileConstants.NameTemplate;
			string symbolSet = FileConstants.SymbolSet;

			if (File.Exists(FileConstants.DefaultFilePath))
			{
				try
				{
					string[] values = File.ReadAllLines(FileConstants.DefaultFilePath);
					startDirectory = values[0];
					nameTemplate = values[1];
					symbolSet = values[2];
				}
				catch(IOException e)
				{
					view.ShowMessage($"Ошибка при чтении файла с значениями по умолчанию,{Environment.NewLine}{e.Message}");
				}
				catch(Exception e)
				{
					view.ShowMessage($"Ошибка при чтении файла с значениями по умолчанию,{Environment.NewLine}{e.Message}");
				}
			}
			else
			{
				try
				{
					string[] values = { startDirectory, nameTemplate, symbolSet };
					File.WriteAllLines(FileConstants.DefaultFilePath, values);
				}
				catch(IOException e)
				{
					view.ShowMessage($"Ошибка при создании файла с значениями по умолчанию,{Environment.NewLine}{e.Message}");
				}
				catch(Exception e)
				{
					view.ShowMessage($"Ошибка при создании файла с значениями по умолчанию,{Environment.NewLine}{e.Message}");
				}
			}

			view.SetupValues(startDirectory, nameTemplate, symbolSet);
		}

		public void GetDefaultValues()
		{
			view.SetupValues(
				FileConstants.StartDirectory,
				FileConstants.NameTemplate,
				FileConstants.SymbolSet
				);
		}

		public void SaveValues(string startDirectory, string nameTemplate, string symbolSet)
		{
			List<string> values = new List<string> { startDirectory, nameTemplate, symbolSet };
			if (values.TrueForAll(v => !string.IsNullOrEmpty(v)))
			{
				try
				{
					File.WriteAllLines(FileConstants.DefaultFilePath, values);
					view.ShowMessage("Значения успешно сохранены!");
				}
				catch (IOException e)
				{
					view.ShowMessage($"Ошибка при записи значений в файл,{Environment.NewLine}{e.Message}");
				}
				catch (Exception e)
				{
					view.ShowMessage($"Ошибка при записи значений в файл,{Environment.NewLine}{e.Message}");
				}
			}
			else
			{
				view.ShowMessage("Значения не должны быть пустыми!");
			}
		}
	}
}
