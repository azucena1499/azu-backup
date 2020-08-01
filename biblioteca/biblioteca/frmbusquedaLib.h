#pragma once

namespace biblioteca {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Data::SqlClient;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de frmbusquedaLib
	/// </summary>
	public ref class frmbusquedaLib : public System::Windows::Forms::Form
	{
	public:
		frmbusquedaLib(void)
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
		~frmbusquedaLib()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::DataGridView^ dgLibros;
	protected:
	private: System::Windows::Forms::Button^ btnBuscar;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::TextBox^ txtTitulo;
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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(frmbusquedaLib::typeid));
			this->dgLibros = (gcnew System::Windows::Forms::DataGridView());
			this->btnBuscar = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->txtTitulo = (gcnew System::Windows::Forms::TextBox());
			this->btnsalir = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dgLibros))->BeginInit();
			this->SuspendLayout();
			// 
			// dgLibros
			// 
			this->dgLibros->AllowUserToAddRows = false;
			this->dgLibros->AllowUserToDeleteRows = false;
			this->dgLibros->BackgroundColor = System::Drawing::SystemColors::ControlLightLight;
			this->dgLibros->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dgLibros->Location = System::Drawing::Point(29, 92);
			this->dgLibros->Name = L"dgLibros";
			this->dgLibros->ReadOnly = true;
			this->dgLibros->Size = System::Drawing::Size(743, 207);
			this->dgLibros->TabIndex = 7;
			this->dgLibros->DoubleClick += gcnew System::EventHandler(this, &frmbusquedaLib::dgLibros_DoubleClick);
			// 
			// btnBuscar
			// 
			this->btnBuscar->Location = System::Drawing::Point(493, 24);
			this->btnBuscar->Name = L"btnBuscar";
			this->btnBuscar->Size = System::Drawing::Size(75, 23);
			this->btnBuscar->TabIndex = 6;
			this->btnBuscar->Text = L"Buscar";
			this->btnBuscar->UseVisualStyleBackColor = true;
			this->btnBuscar->Click += gcnew System::EventHandler(this, &frmbusquedaLib::btnBuscar_Click_1);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(26, 34);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(43, 15);
			this->label1->TabIndex = 4;
			this->label1->Text = L"Titulo";
			// 
			// txtTitulo
			// 
			this->txtTitulo->Location = System::Drawing::Point(75, 34);
			this->txtTitulo->Name = L"txtTitulo";
			this->txtTitulo->Size = System::Drawing::Size(367, 20);
			this->txtTitulo->TabIndex = 5;
			// 
			// btnsalir
			// 
			this->btnsalir->Location = System::Drawing::Point(602, 24);
			this->btnsalir->Name = L"btnsalir";
			this->btnsalir->Size = System::Drawing::Size(71, 23);
			this->btnsalir->TabIndex = 25;
			this->btnsalir->Text = L"Salir";
			this->btnsalir->UseVisualStyleBackColor = true;
			this->btnsalir->Click += gcnew System::EventHandler(this, &frmbusquedaLib::btnsalir_Click);
			// 
			// frmbusquedaLib
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->ClientSize = System::Drawing::Size(918, 351);
			this->Controls->Add(this->btnsalir);
			this->Controls->Add(this->dgLibros);
			this->Controls->Add(this->btnBuscar);
			this->Controls->Add(this->txtTitulo);
			this->Controls->Add(this->label1);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"frmbusquedaLib";
			this->Text = L"frmbusquedaLib";
			this->Load += gcnew System::EventHandler(this, &frmbusquedaLib::frmbusquedaLib_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dgLibros))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
		SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
		
		private: void llenargrid()
		{
			SqlCommand^ cmd = gcnew SqlCommand();
			cmd->Connection = con;
			cmd->CommandType = CommandType::Text;
			cmd->CommandText = "Select * from Vlibros";
			SqlDataAdapter^ da = gcnew SqlDataAdapter(cmd);
			DataTable^ dt = gcnew DataTable();
			da->Fill(dt);
			dgLibros->DataSource = dt;
			dgLibros->Columns[0]->Width = 30;
			dgLibros->Columns[1]->Width = 90;
			dgLibros->Columns[2]->Width = 200;
			dgLibros->Columns[3]->Width = 150;
			dgLibros->Columns[4]->Width = 100;
			dgLibros->Columns[5]->Width = 100;
		}
		private: void BusquedaLibros()
		{
			SqlCommand^ cmd = gcnew SqlCommand();
			cmd->Connection = con;
			cmd->CommandType = CommandType::Text;
			cmd->CommandText = "Select * from Vlibros where Titulo LIKE '%" + txtTitulo->Text + "%'";
			SqlDataAdapter^ da = gcnew SqlDataAdapter(cmd);
			DataTable^ dt = gcnew DataTable();
			da->Fill(dt);
			dgLibros->DataSource = dt;
			dgLibros->Columns[0]->Width = 30;
			dgLibros->Columns[1]->Width = 90;
			dgLibros->Columns[2]->Width = 200;
			dgLibros->Columns[3]->Width = 150;
			dgLibros->Columns[4]->Width = 100;
			dgLibros->Columns[5]->Width = 100;
		}
		
	
private: System::Void btnBuscar_Click_1(System::Object^ sender, System::EventArgs^ e) {
	BusquedaLibros();

}
private: System::Void frmbusquedaLib_Load(System::Object^ sender, System::EventArgs^ e) {
	llenargrid();
}
private: System::Void btnsalir_Click(System::Object^ sender, System::EventArgs^ e) {
	this->Close();
}

private: System::Void dgLibros_DoubleClick(System::Object^ sender, System::EventArgs^ e) {
	
}
};

}
