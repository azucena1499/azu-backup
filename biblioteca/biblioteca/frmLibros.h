#pragma once
#include"libros.h"


namespace biblioteca {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace Data;
	using namespace Data::SqlClient;
	
	/// <summary>
	/// Resumen de frmbiblioteca
	/// </summary>
	public ref class frmbiblioteca : public System::Windows::Forms::Form
	{
	public:
		frmbiblioteca(void)
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
		~frmbiblioteca()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::Label^ label5;
	private: System::Windows::Forms::Label^ label6;
	private: System::Windows::Forms::DateTimePicker^ dtmfecha;
	private: System::Windows::Forms::Label^ label7;

	private: System::Windows::Forms::TextBox^ txtISBN;
	private: System::Windows::Forms::TextBox^ txttitulo;


	private: System::Windows::Forms::Label^ label8;
	private: System::Windows::Forms::Button^ btnaceptar;
	private: System::Windows::Forms::ComboBox^ cbxautor;
	private: System::Windows::Forms::ComboBox^ cbxgenero;
	private: System::Windows::Forms::Button^ btnbuscar;
	private: System::Windows::Forms::TextBox^ txtid;
	private: System::Windows::Forms::Button^ btnEliminar;
	private: System::Windows::Forms::ComboBox^ cboxedit;
	private: System::Windows::Forms::Label^ Editorial;
	private: System::Windows::Forms::Button^ btnsalir;
	private: System::Windows::Forms::Button^ btnlimpiar;
	protected:

	private:
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		void InitializeComponent(void)
		{
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->dtmfecha = (gcnew System::Windows::Forms::DateTimePicker());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->txtISBN = (gcnew System::Windows::Forms::TextBox());
			this->txttitulo = (gcnew System::Windows::Forms::TextBox());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->btnaceptar = (gcnew System::Windows::Forms::Button());
			this->cbxautor = (gcnew System::Windows::Forms::ComboBox());
			this->cbxgenero = (gcnew System::Windows::Forms::ComboBox());
			this->btnbuscar = (gcnew System::Windows::Forms::Button());
			this->txtid = (gcnew System::Windows::Forms::TextBox());
			this->btnEliminar = (gcnew System::Windows::Forms::Button());
			this->cboxedit = (gcnew System::Windows::Forms::ComboBox());
			this->Editorial = (gcnew System::Windows::Forms::Label());
			this->btnsalir = (gcnew System::Windows::Forms::Button());
			this->btnlimpiar = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label1->Font = (gcnew System::Drawing::Font(L"Arial", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(5, 89);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(17, 15);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Id";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label2->Font = (gcnew System::Drawing::Font(L"Arial", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label2->Location = System::Drawing::Point(425, 69);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(34, 15);
			this->label2->TabIndex = 1;
			this->label2->Text = L"ISBN";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label3->Font = (gcnew System::Drawing::Font(L"Arial", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label3->Location = System::Drawing::Point(181, 67);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(38, 15);
			this->label3->TabIndex = 2;
			this->label3->Text = L"Titulo";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label4->Font = (gcnew System::Drawing::Font(L"Arial", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label4->Location = System::Drawing::Point(34, 150);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(38, 15);
			this->label4->TabIndex = 3;
			this->label4->Text = L"Autor";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(1, 152);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(0, 13);
			this->label5->TabIndex = 4;
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label6->Font = (gcnew System::Drawing::Font(L"Arial", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label6->Location = System::Drawing::Point(262, 154);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(48, 15);
			this->label6->TabIndex = 5;
			this->label6->Text = L"Genero";
			// 
			// dtmfecha
			// 
			this->dtmfecha->Location = System::Drawing::Point(640, 38);
			this->dtmfecha->Name = L"dtmfecha";
			this->dtmfecha->Size = System::Drawing::Size(200, 20);
			this->dtmfecha->TabIndex = 6;
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label7->Location = System::Drawing::Point(588, 45);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(37, 13);
			this->label7->TabIndex = 7;
			this->label7->Text = L"Fecha";
			// 
			// txtISBN
			// 
			this->txtISBN->Font = (gcnew System::Drawing::Font(L"Arial", 9, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->txtISBN->Location = System::Drawing::Point(363, 87);
			this->txtISBN->Name = L"txtISBN";
			this->txtISBN->Size = System::Drawing::Size(142, 21);
			this->txtISBN->TabIndex = 9;
			// 
			// txttitulo
			// 
			this->txttitulo->Font = (gcnew System::Drawing::Font(L"Arial", 9, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->txttitulo->Location = System::Drawing::Point(151, 86);
			this->txttitulo->Name = L"txttitulo";
			this->txttitulo->Size = System::Drawing::Size(190, 21);
			this->txttitulo->TabIndex = 10;
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label8->Font = (gcnew System::Drawing::Font(L"Arial Narrow", 18, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Underline)),
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label8->Location = System::Drawing::Point(248, 9);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(184, 29);
			this->label8->TabIndex = 13;
			this->label8->Text = L" Registro de libros";
			// 
			// btnaceptar
			// 
			this->btnaceptar->Location = System::Drawing::Point(184, 268);
			this->btnaceptar->Name = L"btnaceptar";
			this->btnaceptar->Size = System::Drawing::Size(110, 30);
			this->btnaceptar->TabIndex = 14;
			this->btnaceptar->Text = L"Guardar/Actualizar";
			this->btnaceptar->UseVisualStyleBackColor = true;
			this->btnaceptar->Click += gcnew System::EventHandler(this, &frmbiblioteca::btnaceptar_Click);
			// 
			// cbxautor
			// 
			this->cbxautor->FormattingEnabled = true;
			this->cbxautor->Location = System::Drawing::Point(92, 152);
			this->cbxautor->Name = L"cbxautor";
			this->cbxautor->Size = System::Drawing::Size(153, 21);
			this->cbxautor->TabIndex = 15;
			// 
			// cbxgenero
			// 
			this->cbxgenero->FormattingEnabled = true;
			this->cbxgenero->Location = System::Drawing::Point(320, 152);
			this->cbxgenero->Name = L"cbxgenero";
			this->cbxgenero->Size = System::Drawing::Size(147, 21);
			this->cbxgenero->TabIndex = 16;
			// 
			// btnbuscar
			// 
			this->btnbuscar->Location = System::Drawing::Point(92, 85);
			this->btnbuscar->Name = L"btnbuscar";
			this->btnbuscar->Size = System::Drawing::Size(53, 23);
			this->btnbuscar->TabIndex = 17;
			this->btnbuscar->Text = L"Buscar";
			this->btnbuscar->UseVisualStyleBackColor = true;
			this->btnbuscar->Click += gcnew System::EventHandler(this, &frmbiblioteca::btnbuscar_Click);
			// 
			// txtid
			// 
			this->txtid->Location = System::Drawing::Point(28, 87);
			this->txtid->Name = L"txtid";
			this->txtid->Size = System::Drawing::Size(58, 20);
			this->txtid->TabIndex = 18;
			this->txtid->Text = L"0";
			// 
			// btnEliminar
			// 
			this->btnEliminar->Location = System::Drawing::Point(320, 268);
			this->btnEliminar->Name = L"btnEliminar";
			this->btnEliminar->Size = System::Drawing::Size(75, 34);
			this->btnEliminar->TabIndex = 19;
			this->btnEliminar->Text = L"Eliminar";
			this->btnEliminar->UseVisualStyleBackColor = true;
			this->btnEliminar->Click += gcnew System::EventHandler(this, &frmbiblioteca::btnEliminar_Click);
			// 
			// cboxedit
			// 
			this->cboxedit->FormattingEnabled = true;
			this->cboxedit->Location = System::Drawing::Point(526, 152);
			this->cboxedit->Name = L"cboxedit";
			this->cboxedit->Size = System::Drawing::Size(121, 21);
			this->cboxedit->TabIndex = 21;
			// 
			// Editorial
			// 
			this->Editorial->AutoSize = true;
			this->Editorial->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->Editorial->Font = (gcnew System::Drawing::Font(L"Arial", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->Editorial->Location = System::Drawing::Point(558, 134);
			this->Editorial->Name = L"Editorial";
			this->Editorial->Size = System::Drawing::Size(53, 15);
			this->Editorial->TabIndex = 20;
			this->Editorial->Text = L"Editorial";
			// 
			// btnsalir
			// 
			this->btnsalir->Location = System::Drawing::Point(417, 268);
			this->btnsalir->Name = L"btnsalir";
			this->btnsalir->Size = System::Drawing::Size(75, 34);
			this->btnsalir->TabIndex = 22;
			this->btnsalir->Text = L"Salir";
			this->btnsalir->UseVisualStyleBackColor = true;
			this->btnsalir->Click += gcnew System::EventHandler(this, &frmbiblioteca::btnsalir_Click);
			// 
			// btnlimpiar
			// 
			this->btnlimpiar->Location = System::Drawing::Point(526, 269);
			this->btnlimpiar->Name = L"btnlimpiar";
			this->btnlimpiar->Size = System::Drawing::Size(63, 29);
			this->btnlimpiar->TabIndex = 23;
			this->btnlimpiar->Text = L"Limpiar";
			this->btnlimpiar->UseVisualStyleBackColor = true;
			this->btnlimpiar->Click += gcnew System::EventHandler(this, &frmbiblioteca::btnlimpiar_Click);
			// 
			// frmbiblioteca
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->ClientSize = System::Drawing::Size(904, 365);
			this->Controls->Add(this->btnlimpiar);
			this->Controls->Add(this->btnsalir);
			this->Controls->Add(this->cboxedit);
			this->Controls->Add(this->Editorial);
			this->Controls->Add(this->btnEliminar);
			this->Controls->Add(this->txtid);
			this->Controls->Add(this->btnbuscar);
			this->Controls->Add(this->cbxgenero);
			this->Controls->Add(this->cbxautor);
			this->Controls->Add(this->btnaceptar);
			this->Controls->Add(this->label8);
			this->Controls->Add(this->txttitulo);
			this->Controls->Add(this->txtISBN);
			this->Controls->Add(this->label7);
			this->Controls->Add(this->dtmfecha);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Name = L"frmbiblioteca";
			this->Text = L"Libros";
			this->Load += gcnew System::EventHandler(this, &frmbiblioteca::frmbiblioteca_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void frmbiblioteca_Load(System::Object^ sender, System::EventArgs^ e) {
		llenarcbox();
		consecutivo();

	}
	private: void consecutivo()
	{
		 
		 SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");	
		 SqlCommand ^ command = gcnew SqlCommand("select max(id) +1 from LIBROS", con);
		 con->Open();
		 txtid->Text = command->ExecuteScalar()->ToString();
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
		cbxgenero->DataSource = ds->Tables["GENERO"];
		cbxgenero->DisplayMember = ds->Tables["GENERO"]->Columns["Descrpcion"]->ToString();
		cbxgenero->ValueMember = "id";
		cbxgenero->SelectedIndex = -1;

		SqlCommand^ comando2 = gcnew SqlCommand();
		SqlDataAdapter^ da2 = gcnew SqlDataAdapter("Select * from Autores", con);
		DataSet^ ds2 = gcnew DataSet("Autores");
		da2->FillSchema(ds2, SchemaType::Source, "Autores");
		da2->Fill(ds2, "Autores");
		cbxautor->DataSource = ds2->Tables["Autores"];
		cbxautor->DisplayMember = ds2->Tables["Autores"]->Columns["Nombre"]->ToString();
		cbxautor->ValueMember = "id";
		cbxautor->SelectedIndex = -1;

		SqlCommand^ comando3 = gcnew SqlCommand();
		SqlDataAdapter^ da3 = gcnew SqlDataAdapter("Select * from Editoriales", con);
		DataSet^ ds3 = gcnew DataSet("Editoriales");
		da3->FillSchema(ds3, SchemaType::Source, "Editoriales");
		da3->Fill(ds3, "Editoriales");
		cboxedit->DataSource = ds3->Tables["Editoriales"];
		cboxedit->DisplayMember = ds3->Tables["Editoriales"]->Columns["Nombre"]->ToString();
		cboxedit->ValueMember = "id";
		cboxedit->SelectedIndex = -1;
	}
	private: void LimpiarCampos()
	{
		//Este metodo limpia los campos
		DateTime FechaActual;
		//Ponemos el id en 0 para que siga el consecutivo
		txtid->Enabled = true;
		txtid->Text = "0";
		txtISBN->Clear();
		txttitulo->Clear();
		cbxautor->SelectedIndex = -1;
		cbxgenero->SelectedIndex = -1;
		cboxedit->SelectedIndex = -1;
		//Se le asigna la fecha actual al datetimepicker
		dtmfecha->Text = FechaActual.Now.ToString();
	}

	private: System::Void btnaceptar_Click(System::Object^ sender, System::EventArgs^ e) {
		libros x;
		x.id = Int32::Parse(txtid->Text);
		x.ISBN = txtISBN->Text;
		x.Titulo = txttitulo->Text;
		x.idAutor = Int32::Parse(cbxautor->SelectedValue->ToString());
		x.idGenero = Int32::Parse(cbxgenero->SelectedValue->ToString());
		x.FechaPublicacion = dtmfecha->Value;
		x.Editorial = cboxedit->Text;
		x.Guardar();
		LimpiarCampos();

	}
	private: System::Void btnbuscar_Click(System::Object^ sender, System::EventArgs^ e) {
		

		libros x;
		x.id = Convert::ToInt32(txtid->Text);
		x.Buscar();
		if (x.encontro == true)
		{
			txtISBN->Text = x.ISBN;
			txttitulo->Text = x.Titulo;
			cbxautor->SelectedValue = x.idAutor.ToString();
			cbxgenero->SelectedValue = x.idGenero.ToString();
			dtmfecha->Text = x.FechaPublicacion.ToString();
			cboxedit->Text = x.Editorial;

		}
		else
		{
			LimpiarCampos();
		}
	}
	private: System::Void btnEliminar_Click(System::Object^ sender, System::EventArgs^ e) {
		libros x;
		x.id = Convert::ToInt32(txtid->Text);
		x.Eliminar();
		//Llamo el metodo al final de el evento click para que se limpien los campos
		LimpiarCampos();
	}
  
		  
private: System::Void btnsalir_Click(System::Object^ sender, System::EventArgs^ e) {
	this->Close();
}
private: System::Void btnlimpiar_Click(System::Object^ sender, System::EventArgs^ e) {
	LimpiarCampos();
}
};
}
