#include "frmMenuu.h"
using namespace System;
using namespace System::Windows::Forms;
[STAThread]
void main(array<String^>^ args)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	biblioteca::frmMenuu form;
	Application::Run(% form);
}

