#pragma once
#include"Generos.h"

namespace biblioteca {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de frmGeneros
	/// </summary>
	public ref class frmGeneros : public System::Windows::Forms::Form
	{
	public:
		frmGeneros(void)
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
		~frmGeneros()
		{
			if (components)
			{
				delete components;
			}
		}

	protected:
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label3;

	private: System::Windows::Forms::Button^ btnaceptar;
	private: System::Windows::Forms::ComboBox^ cboxGenero;
	private: System::Windows::Forms::Button^ btnEliminar;
	private: System::Windows::Forms::Button^ btnBuscar;
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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(frmGeneros::typeid));
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->btnaceptar = (gcnew System::Windows::Forms::Button());
			this->cboxGenero = (gcnew System::Windows::Forms::ComboBox());
			this->btnEliminar = (gcnew System::Windows::Forms::Button());
			this->btnBuscar = (gcnew System::Windows::Forms::Button());
			this->txtid = (gcnew System::Windows::Forms::TextBox());
			this->btnsalir = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(53, 109);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(21, 16);
			this->label1->TabIndex = 9;
			this->label1->Text = L"Id";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label2->Font = (gcnew System::Drawing::Font(L"Arial", 20.25F, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Underline)),
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label2->Location = System::Drawing::Point(232, 9);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(126, 32);
			this->label2->TabIndex = 11;
			this->label2->Text = L"Generos";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label3->Location = System::Drawing::Point(276, 83);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(91, 16);
			this->label3->TabIndex = 12;
			this->label3->Text = L"Descripción";
			// 
			// btnaceptar
			// 
			this->btnaceptar->BackColor = System::Drawing::SystemColors::Control;
			this->btnaceptar->Location = System::Drawing::Point(140, 209);
			this->btnaceptar->Name = L"btnaceptar";
			this->btnaceptar->Size = System::Drawing::Size(120, 27);
			this->btnaceptar->TabIndex = 14;
			this->btnaceptar->Text = L"Guardar/Actualizar";
			this->btnaceptar->UseVisualStyleBackColor = false;
			this->btnaceptar->Click += gcnew System::EventHandler(this, &frmGeneros::btnaceptar_Click);
			// 
			// cboxGenero
			// 
			this->cboxGenero->FormattingEnabled = true;
			this->cboxGenero->Location = System::Drawing::Point(223, 102);
			this->cboxGenero->Name = L"cboxGenero";
			this->cboxGenero->Size = System::Drawing::Size(241, 23);
			this->cboxGenero->TabIndex = 15;
			this->cboxGenero->SelectedIndexChanged += gcnew System::EventHandler(this, &frmGeneros::cboxGenero_SelectedIndexChanged);
			// 
			// btnEliminar
			// 
			this->btnEliminar->BackColor = System::Drawing::SystemColors::Control;
			this->btnEliminar->Location = System::Drawing::Point(292, 206);
			this->btnEliminar->Name = L"btnEliminar";
			this->btnEliminar->Size = System::Drawing::Size(87, 32);
			this->btnEliminar->TabIndex = 17;
			this->btnEliminar->Text = L"Eliminar";
			this->btnEliminar->UseVisualStyleBackColor = false;
			this->btnEliminar->Click += gcnew System::EventHandler(this, &frmGeneros::btnEliminar_Click);
			// 
			// btnBuscar
			// 
			this->btnBuscar->Location = System::Drawing::Point(140, 103);
			this->btnBuscar->Name = L"btnBuscar";
			this->btnBuscar->Size = System::Drawing::Size(76, 23);
			this->btnBuscar->TabIndex = 18;
			this->btnBuscar->Text = L"Buscar";
			this->btnBuscar->UseVisualStyleBackColor = true;
			this->btnBuscar->Click += gcnew System::EventHandler(this, &frmGeneros::btnBuscar_Click);
			// 
			// txtid
			// 
			this->txtid->Location = System::Drawing::Point(80, 103);
			this->txtid->Name = L"txtid";
			this->txtid->Size = System::Drawing::Size(52, 21);
			this->txtid->TabIndex = 19;
			this->txtid->Text = L"0";
			// 
			// btnsalir
			// 
			this->btnsalir->Location = System::Drawing::Point(408, 206);
			this->btnsalir->Name = L"btnsalir";
			this->btnsalir->Size = System::Drawing::Size(67, 30);
			this->btnsalir->TabIndex = 23;
			this->btnsalir->Text = L"Salir";
			this->btnsalir->UseVisualStyleBackColor = true;
			this->btnsalir->Click += gcnew System::EventHandler(this, &frmGeneros::btnsalir_Click);
			// 
			// frmGeneros
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(7, 15);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->ClientSize = System::Drawing::Size(666, 307);
			this->Controls->Add(this->btnsalir);
			this->Controls->Add(this->txtid);
			this->Controls->Add(this->btnBuscar);
			this->Controls->Add(this->btnEliminar);
			this->Controls->Add(this->cboxGenero);
			this->Controls->Add(this->btnaceptar);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"frmGeneros";
			this->Text = L"frmGeneros";
			this->Load += gcnew System::EventHandler(this, &frmGeneros::frmGeneros_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void frmGeneros_Load(System::Object^ sender, System::EventArgs^ e) {
		llenarcbox();
		consecutivo();
	}
	private: void consecutivo()
	{
	 SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
	 SqlCommand^ command = gcnew SqlCommand("select max(id) +1 from GENERO", con);
	 con->Open();
	 txtid->Text = command->ExecuteScalar()->ToString();
	}
    private: void LimpiarCampos()
    {

	 txtid->Text = "0";
	 cboxGenero->SelectedIndex = -1;

    }
	private:void llenarcbox()
	{
		SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
		SqlConnectionStringBuilder^ st;
		SqlCommand^ comando = gcnew SqlCommand();
		SqlDataAdapter^ da = gcnew SqlDataAdapter("Select * from GENERO", con);
		DataSet^ ds = gcnew DataSet("GENERO");
		da->FillSchema(ds, SchemaType::Source, "GENERO");
		da->Fill(ds, "GENERO");
		cboxGenero->DataSource = ds->Tables["GENERO"];
		cboxGenero->DisplayMember = ds->Tables["GENERO"]->Columns["Descrpcion"]->ToString();
		cboxGenero->ValueMember = "id";
		cboxGenero->SelectedIndex = -1;
	}
private: System::Void btnaceptar_Click(System::Object^ sender, System::EventArgs^ e) {
	Generos x;
	x.id = Int32::Parse(txtid->Text);
	x.Descrpcion = cboxGenero->Text;
	x.Guardar();
	LimpiarCampos();

}
private: System::Void cboxGenero_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void btnEliminar_Click(System::Object^ sender, System::EventArgs^ e) {
	Generos x;
	x.id = Convert::ToInt32(txtid->Text);
	x.Eliminar();
	LimpiarCampos();

}
private: System::Void btnBuscar_Click(System::Object^ sender, System::EventArgs^ e) {
	Generos x;
	x.id = Convert::ToInt32(txtid->Text);
	x.Buscar();

	if (x.encontro == true)
	{

		cboxGenero->Text = x.Descrpcion;
	}
	else
	{
		LimpiarCampos();
	}
}
private: System::Void btnsalir_Click(System::Object^ sender, System::EventArgs^ e) {
	this->Close();
}
};
}
