#pragma once
#include"Autores.h"
namespace biblioteca {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de frmAutores
	/// </summary>
	public ref class frmAutores : public System::Windows::Forms::Form
	{
	public:
		frmAutores(void)
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
		~frmAutores()
		{
			if (components)
			{
				delete components;
			}
		}

	protected:


	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Button^ btnaceptar;
	private: System::Windows::Forms::ComboBox^ cbxautor;
	private: System::Windows::Forms::Label^ label1;

	private: System::Windows::Forms::Button^ btnBuscar;
	private: System::Windows::Forms::Button^ btnEliminar;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::TextBox^ txtid;
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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(frmAutores::typeid));
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->btnaceptar = (gcnew System::Windows::Forms::Button());
			this->cbxautor = (gcnew System::Windows::Forms::ComboBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->btnBuscar = (gcnew System::Windows::Forms::Button());
			this->btnEliminar = (gcnew System::Windows::Forms::Button());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->txtid = (gcnew System::Windows::Forms::TextBox());
			this->btnsalir = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label2->Font = (gcnew System::Drawing::Font(L"Arial", 9.75F, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Italic)),
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label2->Location = System::Drawing::Point(237, 44);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(57, 16);
			this->label2->TabIndex = 11;
			this->label2->Text = L"Nombre";
			// 
			// btnaceptar
			// 
			this->btnaceptar->Location = System::Drawing::Point(96, 143);
			this->btnaceptar->Name = L"btnaceptar";
			this->btnaceptar->Size = System::Drawing::Size(105, 23);
			this->btnaceptar->TabIndex = 16;
			this->btnaceptar->Text = L"Guardar/Actualizar";
			this->btnaceptar->UseVisualStyleBackColor = true;
			this->btnaceptar->Click += gcnew System::EventHandler(this, &frmAutores::btnaceptar_Click);
			// 
			// cbxautor
			// 
			this->cbxautor->FormattingEnabled = true;
			this->cbxautor->Location = System::Drawing::Point(175, 72);
			this->cbxautor->Name = L"cbxautor";
			this->cbxautor->Size = System::Drawing::Size(209, 21);
			this->cbxautor->TabIndex = 18;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label1->Font = (gcnew System::Drawing::Font(L"Arial", 9.75F, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Italic)),
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(12, 77);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(19, 16);
			this->label1->TabIndex = 9;
			this->label1->Text = L"Id";
			// 
			// btnBuscar
			// 
			this->btnBuscar->Location = System::Drawing::Point(93, 73);
			this->btnBuscar->Name = L"btnBuscar";
			this->btnBuscar->Size = System::Drawing::Size(76, 23);
			this->btnBuscar->TabIndex = 19;
			this->btnBuscar->Text = L"Buscar";
			this->btnBuscar->UseVisualStyleBackColor = true;
			this->btnBuscar->Click += gcnew System::EventHandler(this, &frmAutores::btnBuscar_Click);
			// 
			// btnEliminar
			// 
			this->btnEliminar->BackColor = System::Drawing::SystemColors::Control;
			this->btnEliminar->Location = System::Drawing::Point(220, 143);
			this->btnEliminar->Name = L"btnEliminar";
			this->btnEliminar->Size = System::Drawing::Size(90, 23);
			this->btnEliminar->TabIndex = 20;
			this->btnEliminar->Text = L"Eliminar";
			this->btnEliminar->UseVisualStyleBackColor = false;
			this->btnEliminar->Click += gcnew System::EventHandler(this, &frmAutores::btnEliminar_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label3->Font = (gcnew System::Drawing::Font(L"Arial", 14.25F, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Underline)),
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label3->Location = System::Drawing::Point(187, -1);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(83, 22);
			this->label3->TabIndex = 21;
			this->label3->Text = L"Autores";
			// 
			// txtid
			// 
			this->txtid->Location = System::Drawing::Point(35, 75);
			this->txtid->Name = L"txtid";
			this->txtid->Size = System::Drawing::Size(52, 20);
			this->txtid->TabIndex = 22;
			this->txtid->Text = L"0";
			// 
			// btnsalir
			// 
			this->btnsalir->Location = System::Drawing::Point(327, 143);
			this->btnsalir->Name = L"btnsalir";
			this->btnsalir->Size = System::Drawing::Size(75, 23);
			this->btnsalir->TabIndex = 23;
			this->btnsalir->Text = L"Salir";
			this->btnsalir->UseVisualStyleBackColor = true;
			this->btnsalir->Click += gcnew System::EventHandler(this, &frmAutores::btnsalir_Click);
			// 
			// frmAutores
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->ClientSize = System::Drawing::Size(508, 193);
			this->Controls->Add(this->btnsalir);
			this->Controls->Add(this->txtid);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->btnEliminar);
			this->Controls->Add(this->btnBuscar);
			this->Controls->Add(this->cbxautor);
			this->Controls->Add(this->btnaceptar);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"frmAutores";
			this->Text = L"frmAutores";
			this->Load += gcnew System::EventHandler(this, &frmAutores::frmAutores_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void frmAutores_Load(System::Object^ sender, System::EventArgs^ e) {
		llenarcbox();
		Consecutivo();
	}
	private:void Consecutivo()
	{
		SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
		SqlCommand^ command = gcnew SqlCommand("select max(id) +1 from Autores", con);
		con->Open();
		txtid->Text = command->ExecuteScalar()->ToString();
	}
		  
	private:void llenarcbox()
	{
		SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
		SqlConnectionStringBuilder^ st;
		SqlCommand^ comando = gcnew SqlCommand();
		SqlDataAdapter^ da = gcnew SqlDataAdapter("Select * from Autores", con);
		DataSet^ ds = gcnew DataSet("Autores");
		da->FillSchema(ds, SchemaType::Source, "Autores");
		da->Fill(ds, "Autores");
		cbxautor->DataSource = ds->Tables["Autores"];
		cbxautor->DisplayMember = ds->Tables["Autores"]->Columns["Nombre"]->ToString();
		cbxautor->ValueMember = "id";
		cbxautor->SelectedIndex = -1;
	}
    private: void LimpiarCampos()
	 {
			  
			   txtid->Text = "0";
			   cbxautor->SelectedIndex = -1;
	}
	
private: System::Void btnaceptar_Click(System::Object^ sender, System::EventArgs^ e) {
	Autores  x;
	x.id = Int32::Parse(txtid->Text); 
	x.Nombre = cbxautor->Text;
	x.Guardar();
	LimpiarCampos();

}
private: System::Void btnEliminar_Click(System::Object^ sender, System::EventArgs^ e) {
	Autores x;
	x.id = Convert::ToInt32(txtid->Text);
	x.Eliminar();
	LimpiarCampos();

}
private: System::Void btnBuscar_Click(System::Object^ sender, System::EventArgs^ e) {
	Autores x;
	x.id = Convert::ToInt32(txtid->Text);

	x.Buscar();

	if (x.encontro == true)
	{

		cbxautor->Text = x.Nombre;
	}
}
private: System::Void btnsalir_Click(System::Object^ sender, System::EventArgs^ e) {
	this->Close();
}
};
}

