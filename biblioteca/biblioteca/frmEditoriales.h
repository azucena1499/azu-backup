#pragma once
#include"Editoriales.h"

namespace biblioteca {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de frmEditoriales
	/// </summary>
	public ref class frmEditoriales : public System::Windows::Forms::Form
	{
	public:
		frmEditoriales(void)
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
		~frmEditoriales()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ComboBox^ cboxeditorial;
	protected:

	protected:
	private: System::Windows::Forms::Button^ btnaceptar;
	private: System::Windows::Forms::Label^ label3;

	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Button^ btnBuscar;
	private: System::Windows::Forms::TextBox^ txtid;
	private: System::Windows::Forms::Button^ btnEliminar;
	private: System::Windows::Forms::Label^ label2;
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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(frmEditoriales::typeid));
			this->cboxeditorial = (gcnew System::Windows::Forms::ComboBox());
			this->btnaceptar = (gcnew System::Windows::Forms::Button());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->btnBuscar = (gcnew System::Windows::Forms::Button());
			this->txtid = (gcnew System::Windows::Forms::TextBox());
			this->btnEliminar = (gcnew System::Windows::Forms::Button());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->btnsalir = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// cboxeditorial
			// 
			this->cboxeditorial->FormattingEnabled = true;
			this->cboxeditorial->Location = System::Drawing::Point(127, 84);
			this->cboxeditorial->Name = L"cboxeditorial";
			this->cboxeditorial->Size = System::Drawing::Size(230, 21);
			this->cboxeditorial->TabIndex = 20;
			// 
			// btnaceptar
			// 
			this->btnaceptar->Location = System::Drawing::Point(48, 145);
			this->btnaceptar->Name = L"btnaceptar";
			this->btnaceptar->Size = System::Drawing::Size(112, 23);
			this->btnaceptar->TabIndex = 19;
			this->btnaceptar->Text = L"Guardar/Actualizar";
			this->btnaceptar->UseVisualStyleBackColor = true;
			this->btnaceptar->Click += gcnew System::EventHandler(this, &frmEditoriales::btnaceptar_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label3->Font = (gcnew System::Drawing::Font(L"Arial", 9.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label3->Location = System::Drawing::Point(176, 65);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(61, 16);
			this->label3->TabIndex = 18;
			this->label3->Text = L"Editorial";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label1->Font = (gcnew System::Drawing::Font(L"Arial", 9.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(6, 87);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(20, 16);
			this->label1->TabIndex = 16;
			this->label1->Text = L"Id";
			// 
			// btnBuscar
			// 
			this->btnBuscar->Location = System::Drawing::Point(72, 83);
			this->btnBuscar->Name = L"btnBuscar";
			this->btnBuscar->Size = System::Drawing::Size(49, 21);
			this->btnBuscar->TabIndex = 21;
			this->btnBuscar->Text = L"buscar";
			this->btnBuscar->UseVisualStyleBackColor = true;
			this->btnBuscar->Click += gcnew System::EventHandler(this, &frmEditoriales::btnBuscar_Click);
			// 
			// txtid
			// 
			this->txtid->Location = System::Drawing::Point(32, 83);
			this->txtid->Name = L"txtid";
			this->txtid->Size = System::Drawing::Size(34, 20);
			this->txtid->TabIndex = 22;
			this->txtid->Text = L"0";
			// 
			// btnEliminar
			// 
			this->btnEliminar->Location = System::Drawing::Point(194, 145);
			this->btnEliminar->Name = L"btnEliminar";
			this->btnEliminar->Size = System::Drawing::Size(75, 23);
			this->btnEliminar->TabIndex = 23;
			this->btnEliminar->Text = L"Eliminar";
			this->btnEliminar->UseVisualStyleBackColor = true;
			this->btnEliminar->Click += gcnew System::EventHandler(this, &frmEditoriales::btnEliminar_Click);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label2->Font = (gcnew System::Drawing::Font(L"Arial", 14.25F, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Underline)),
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label2->Location = System::Drawing::Point(151, 9);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(109, 22);
			this->label2->TabIndex = 24;
			this->label2->Text = L"Editoriales";
			// 
			// btnsalir
			// 
			this->btnsalir->Location = System::Drawing::Point(282, 145);
			this->btnsalir->Name = L"btnsalir";
			this->btnsalir->Size = System::Drawing::Size(75, 23);
			this->btnsalir->TabIndex = 25;
			this->btnsalir->Text = L"Salir";
			this->btnsalir->UseVisualStyleBackColor = true;
			this->btnsalir->Click += gcnew System::EventHandler(this, &frmEditoriales::btnsalir_Click);
			// 
			// frmEditoriales
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->ClientSize = System::Drawing::Size(497, 198);
			this->Controls->Add(this->btnsalir);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->btnEliminar);
			this->Controls->Add(this->txtid);
			this->Controls->Add(this->btnBuscar);
			this->Controls->Add(this->cboxeditorial);
			this->Controls->Add(this->btnaceptar);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label1);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"frmEditoriales";
			this->Text = L"frmEditoriales";
			this->Load += gcnew System::EventHandler(this, &frmEditoriales::frmEditoriales_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void frmEditoriales_Load(System::Object^ sender, System::EventArgs^ e){
		llenarcbox();
		consecutivo();	
	}
	  
	private: void consecutivo()
	{
		SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
		SqlCommand^ command = gcnew SqlCommand("select max(id) +1 from Editoriales", con);
		con->Open();
		txtid->Text = command->ExecuteScalar()->ToString();
		txtid->Focus();

	}
    
	private: void LimpiarCampos()
	{
		txtid->Text = "0";
		cboxeditorial->SelectedIndex = -1;
	}
	private:void llenarcbox()
	{
		SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
		SqlConnectionStringBuilder^ st;
		SqlCommand^ comando = gcnew SqlCommand();
		SqlDataAdapter^ da = gcnew SqlDataAdapter("Select * from Editoriales", con);
		DataSet^ ds = gcnew DataSet("Editoriales");
		da->FillSchema(ds, SchemaType::Source, "Editoriales");
		da->Fill(ds, "Editoriales");
		cboxeditorial->DataSource = ds->Tables["Editoriales"];
		cboxeditorial->DisplayMember = ds->Tables["Editoriales"]->Columns["Nombre"]->ToString();
		cboxeditorial->ValueMember = "id";
		cboxeditorial->SelectedIndex = -1;
	}
			
private: System::Void btnaceptar_Click(System::Object^ sender, System::EventArgs^ e) {
	Editoriales x;
	x.id=Int32::Parse(txtid->Text);
	x.Nombre=cboxeditorial->Text;
	x.Guardar();
	LimpiarCampos();
}
private: System::Void btnBuscar_Click(System::Object^ sender, System::EventArgs^ e) {
	Editoriales x;
	x.id = Convert::ToInt32(txtid->Text);
	x.Buscar();
	if (x.encontro == true)
	{
		cboxeditorial->Text = x.Nombre;
	}
	else
	{
		LimpiarCampos();
	}
}
private: System::Void btnEliminar_Click(System::Object^ sender, System::EventArgs^ e) {
	Editoriales x;
	x.id = Convert::ToInt32(txtid->Text);
	x.Eliminar();
	LimpiarCampos();

}
private: System::Void btnsalir_Click(System::Object^ sender, System::EventArgs^ e) {
	this->Close();
}
};
}
