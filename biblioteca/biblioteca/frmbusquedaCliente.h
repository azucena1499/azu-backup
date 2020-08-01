#pragma once
#include "Clientes.h"


namespace biblioteca {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Data::SqlClient;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de frmbusquedaCliente
	/// </summary>
	public ref class frmbusquedaCliente : public System::Windows::Forms::Form
	{
	public:
		frmbusquedaCliente(void)
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
		~frmbusquedaCliente()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::DataGridView^ dgClientes;
	protected:
	private: System::Windows::Forms::Button^ btnBuscar;
	private: System::Windows::Forms::TextBox^ txtClientes;

	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Button^ btnsalir;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(frmbusquedaCliente::typeid));
			this->dgClientes = (gcnew System::Windows::Forms::DataGridView());
			this->btnBuscar = (gcnew System::Windows::Forms::Button());
			this->txtClientes = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->btnsalir = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dgClientes))->BeginInit();
			this->SuspendLayout();
			// 
			// dgClientes
			// 
			this->dgClientes->AllowUserToAddRows = false;
			this->dgClientes->AllowUserToDeleteRows = false;
			this->dgClientes->BackgroundColor = System::Drawing::SystemColors::ControlLightLight;
			this->dgClientes->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dgClientes->Location = System::Drawing::Point(12, 113);
			this->dgClientes->Name = L"dgClientes";
			this->dgClientes->ReadOnly = true;
			this->dgClientes->Size = System::Drawing::Size(742, 175);
			this->dgClientes->TabIndex = 11;
			this->dgClientes->DoubleClick += gcnew System::EventHandler(this, &frmbusquedaCliente::dgClientes_DoubleClick);
			// 
			// btnBuscar
			// 
			this->btnBuscar->Location = System::Drawing::Point(479, 52);
			this->btnBuscar->Name = L"btnBuscar";
			this->btnBuscar->Size = System::Drawing::Size(76, 23);
			this->btnBuscar->TabIndex = 10;
			this->btnBuscar->Text = L"Buscar";
			this->btnBuscar->UseVisualStyleBackColor = true;
			this->btnBuscar->Click += gcnew System::EventHandler(this, &frmbusquedaCliente::btnBuscar_Click);
			// 
			// txtClientes
			// 
			this->txtClientes->Location = System::Drawing::Point(95, 52);
			this->txtClientes->Name = L"txtClientes";
			this->txtClientes->Size = System::Drawing::Size(367, 20);
			this->txtClientes->TabIndex = 9;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(31, 53);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(58, 15);
			this->label1->TabIndex = 8;
			this->label1->Text = L"Nombre";
			// 
			// btnsalir
			// 
			this->btnsalir->Location = System::Drawing::Point(588, 52);
			this->btnsalir->Name = L"btnsalir";
			this->btnsalir->Size = System::Drawing::Size(71, 23);
			this->btnsalir->TabIndex = 24;
			this->btnsalir->Text = L"Salir";
			this->btnsalir->UseVisualStyleBackColor = true;
			this->btnsalir->Click += gcnew System::EventHandler(this, &frmbusquedaCliente::btnsalir_Click);
			// 
			// frmbusquedaCliente
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->ClientSize = System::Drawing::Size(802, 461);
			this->Controls->Add(this->btnsalir);
			this->Controls->Add(this->dgClientes);
			this->Controls->Add(this->btnBuscar);
			this->Controls->Add(this->txtClientes);
			this->Controls->Add(this->label1);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"frmbusquedaCliente";
			this->Text = L"frmbusquedaCliente";
			this->Load += gcnew System::EventHandler(this, &frmbusquedaCliente::frmbusquedaCliente_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dgClientes))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
		SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
		public:Byte Clave;
			  String^ Nombre;
			  String^ Domicilio;
			  String^ Localidad;
			  String^ Telefono;
			  String^ Email;
		private: void llenargrid()
		{
			SqlCommand^ cmd = gcnew SqlCommand();
			cmd->Connection = con;
			cmd->CommandType = CommandType::Text;
			cmd->CommandText = "Select * from Vclientes";
			SqlDataAdapter^ da = gcnew SqlDataAdapter(cmd);
			DataTable^ dt = gcnew DataTable();
			da->Fill(dt);
			dgClientes->DataSource = dt;
			dgClientes->Columns[0]->Width = 40;
			dgClientes->Columns[1]->Width = 90;
			dgClientes->Columns[2]->Width = 150;
			dgClientes->Columns[3]->Width = 100;
			dgClientes->Columns[4]->Width = 100;
			dgClientes->Columns[5]->Width = 150;
		}
		private: void BusquedaClientes()
		{
			SqlCommand^ cmd = gcnew SqlCommand();
			cmd->Connection = con;
			cmd->CommandType = CommandType::Text;
			cmd->CommandText = "Select * from Vclientes where Nombre LIKE '%" + txtClientes->Text + "%'";
			SqlDataAdapter^ da = gcnew SqlDataAdapter(cmd);
			DataTable^ dt = gcnew DataTable();
			da->Fill(dt);
			dgClientes->DataSource = dt;
			dgClientes->Columns[0]->Width = 30;
			dgClientes->Columns[1]->Width = 90;
			dgClientes->Columns[2]->Width = 200;
			dgClientes->Columns[3]->Width = 150;
			dgClientes->Columns[4]->Width = 100;
			dgClientes->Columns[5]->Width = 100;
		}
		private: void obtenerdatos()
		{
			Clave = Byte::Parse(dgClientes->CurrentRow->Cells[0]->Value->ToString());
			Nombre = dgClientes->CurrentRow->Cells[1]->Value->ToString();
			Domicilio = dgClientes->CurrentRow->Cells[2]->Value->ToString();
			Localidad = dgClientes->CurrentRow->Cells[3]->Value->ToString();
			Telefono= dgClientes->CurrentRow->Cells[4]->Value->ToString();
			Email = dgClientes->CurrentRow->Cells[5]->Value->ToString();
			
		}
	private: System::Void btnBuscar_Click(System::Object^ sender, System::EventArgs^ e) {
		BusquedaClientes();
	}
	private: System::Void frmbusquedaCliente_Load(System::Object^ sender, System::EventArgs^ e) {
		llenargrid();
	}
private: System::Void btnsalir_Click(System::Object^ sender, System::EventArgs^ e) {
	this->Close();
}
	private: System::Void dgClientes_DoubleClick(System::Object^ sender, System::EventArgs^ e) {
		obtenerdatos();
		this->Close();
	}
};
}
