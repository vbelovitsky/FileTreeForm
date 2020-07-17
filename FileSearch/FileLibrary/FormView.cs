using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLibrary
{
	public interface FormView
	{
		void ShowMessage(string message);
		void SetupValues(string startDirectory, string fileTemplate, string symbolSet);
		void FillTree();
	}
}
