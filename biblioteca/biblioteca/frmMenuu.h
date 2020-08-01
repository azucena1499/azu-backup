#pragma once
#include "frmLibros.h"
#include "frmGeneros.h"
#include "frmClientes.h"
#include "frmAutores.h"
#include"frmEditoriales.h"
#include"frmbusquedaLib.h"
#include "frmbusquedaCliente.h"

namespace biblioteca {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de frmMenuu
	/// </summary>
	public ref class frmMenuu : public System::Windows::Forms::Form
	{
	public:
		frmMenuu(void)
		{
			InitializeComponent();
			//
			//TODO: agregar código de constructor aquí
			//
		}

	protected:
		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		~frmMenuu()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::MenuStrip^ menuStrip1;
	protected:
	private: System::Windows::Forms::ToolStripMenuItem^ librosToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ autoresToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ clientesToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ generosToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ editorialesToolStripMenuItem;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::ToolStripMenuItem^ salirToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ busquedaToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ librosToolStripMenuItem1;
	private: System::Windows::Forms::ToolStripMenuItem^ clientesToolStripMenuItem1;

	private:
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(frmMenuu::typeid));
			this->menuStrip1 = (gcnew System::Windows::Forms::MenuStrip());
			this->librosToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->autoresToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->clientesToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->generosToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->editorialesToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->salirToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->busquedaToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->librosToolStripMenuItem1 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->clientesToolStripMenuItem1 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->menuStrip1->SuspendLayout();
			this->SuspendLayout();
			// 
			// menuStrip1
			// 
			this->menuStrip1->BackColor = System::Drawing::SystemColors::InactiveCaption;
			this->menuStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(7) {
				this->librosToolStripMenuItem,
					this->autoresToolStripMenuItem, this->clientesToolStripMenuItem, this->generosToolStripMenuItem, this->editorialesToolStripMenuItem,
					this->busquedaToolStripMenuItem, this->salirToolStripMenuItem
			});
			this->menuStrip1->Location = System::Drawing::Point(0, 0);
			this->menuStrip1->Name = L"menuStrip1";
			this->menuStrip1->Size = System::Drawing::Size(616, 24);
			this->menuStrip1->TabIndex = 2;
			this->menuStrip1->Text = L"menuStrip1";
			// 
			// librosToolStripMenuItem
			// 
			this->librosToolStripMenuItem->Name = L"librosToolStripMenuItem";
			this->librosToolStripMenuItem->Size = System::Drawing::Size(51, 20);
			this->librosToolStripMenuItem->Text = L"Libros";
			this->librosToolStripMenuItem->Click += gcnew System::EventHandler(this, &frmMenuu::librosToolStripMenuItem_Click);
			// 
			// autoresToolStripMenuItem
			// 
			this->autoresToolStripMenuItem->Name = L"autoresToolStripMenuItem";
			this->autoresToolStripMenuItem->Size = System::Drawing::Size(60, 20);
			this->autoresToolStripMenuItem->Text = L"Autores";
			this->autoresToolStripMenuItem->Click += gcnew System::EventHandler(this, &frmMenuu::autoresToolStripMenuItem_Click);
			// 
			// clientesToolStripMenuItem
			// 
			this->clientesToolStripMenuItem->Name = L"clientesToolStripMenuItem";
			this->clientesToolStripMenuItem->Size = System::Drawing::Size(61, 20);
			this->clientesToolStripMenuItem->Text = L"Clientes";
			this->clientesToolStripMenuItem->Click += gcnew System::EventHandler(this, &frmMenuu::clientesToolStripMenuItem_Click);
			// 
			// generosToolStripMenuItem
			// 
			this->generosToolStripMenuItem->Name = L"generosToolStripMenuItem";
			this->generosToolStripMenuItem->Size = System::Drawing::Size(62, 20);
			this->generosToolStripMenuItem->Text = L"Generos";
			this->generosToolStripMenuItem->Click += gcnew System::EventHandler(this, &frmMenuu::generosToolStripMenuItem_Click);
			// 
			// editorialesToolStripMenuItem
			// 
			this->editorialesToolStripMenuItem->Name = L"editorialesToolStripMenuItem";
			this->editorialesToolStripMenuItem->Size = System::Drawing::Size(73, 20);
			this->editorialesToolStripMenuItem->Text = L"Editoriales";
			this->editorialesToolStripMenuItem->Click += gcnew System::EventHandler(this, &frmMenuu::editorialesToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this->salirToolStripMenuItem->Name = L"salirToolStripMenuItem";
			this->salirToolStripMenuItem->Size = System::Drawing::Size(41, 20);
			this->salirToolStripMenuItem->Text = L"Salir";
			this->salirToolStripMenuItem->Click += gcnew System::EventHandler(this, &frmMenuu::salirToolStripMenuItem_Click);
			// 
			// busquedaToolStripMenuItem
			// 
			this->busquedaToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) {
				this->librosToolStripMenuItem1,
					this->clientesToolStripMenuItem1
			});
			this->busquedaToolStripMenuItem->Name = L"busquedaToolStripMenuItem";
			this->busquedaToolStripMenuItem->Size = System::Drawing::Size(71, 20);
			this->busquedaToolStripMenuItem->Text = L"Busqueda";
			this->busquedaToolStripMenuItem->Click += gcnew System::EventHandler(this, &frmMenuu::busquedaToolStripMenuItem_Click);
			// 
			// librosToolStripMenuItem1
			// 
			this->librosToolStripMenuItem1->Name = L"librosToolStripMenuItem1";
			this->librosToolStripMenuItem1->Size = System::Drawing::Size(180, 22);
			this->librosToolStripMenuItem1->Text = L"Libros";
			this->librosToolStripMenuItem1->Click += gcnew System::EventHandler(this, &frmMenuu::librosToolStripMenuItem1_Click);
			// 
			// clientesToolStripMenuItem1
			// 
			this->clientesToolStripMenuItem1->Name = L"clientesToolStripMenuItem1";
			this->clientesToolStripMenuItem1->Size = System::Drawing::Size(180, 22);
			this->clientesToolStripMenuItem1->Text = L"Clientes";
			this->clientesToolStripMenuItem1->Click += gcnew System::EventHandler(this, &frmMenuu::clientesToolStripMenuItem1_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Arial", 36, static_cast<System::Drawing::FontStyle>(((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Italic)
				| System::Drawing::FontStyle::Underline)), System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(-10, 200);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(266, 55);
			this->label1->TabIndex = 3;
			this->label1->Text = L"Biblioteca ";
			// 
			// frmMenuu
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->ClientSize = System::Drawing::Size(616, 248);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->menuStrip1);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"frmMenuu";
			this->Text = L"frmMenuu";
			this->Load += gcnew System::EventHandler(this, &frmMenuu::frmMenuu_Load);
			this->menuStrip1->ResumeLayout(false);
			this->menuStrip1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void frmMenuu_Load(System::Object^ sender, System::EventArgs^ e) {
	}
private: System::Void librosToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	frmbiblioteca x;
	x.IsMdiChild.ToString();
	x.ShowDialog();
}
private: System::Void autoresToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	frmAutores x;
	x.IsMdiChild.ToString();
	x.ShowDialog();
}
private: System::Void clientesToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	frmClientes x;
	x.IsMdiChild.ToString();
	x.ShowDialog();
}
private: System::Void generosToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	frmGeneros x;
	x.IsMdiChild.ToString();
	x.ShowDialog();
}
private: System::Void editorialesToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	frmEditoriales x;
	x.IsMdiChild.ToString();
	x.ShowDialog();
}
private: System::Void salirToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	this->Close();
}
private: System::Void busquedaToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	

}
private: System::Void clientesToolStripMenuItem1_Click(System::Object^ sender, System::EventArgs^ e) {
	frmbusquedaCliente x;
	x.IsMdiChild.ToString();
	x.ShowDialog();
}
private: System::Void librosToolStripMenuItem1_Click(System::Object^ sender, System::EventArgs^ e) {
	frmbusquedaLib x;
	x.IsMdiChild.ToString();
	x.ShowDialog();
}
};
}
