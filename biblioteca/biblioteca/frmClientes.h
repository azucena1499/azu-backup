#pragma once
#include"Clientes.h"
#include "frmbusquedaCliente.h"


namespace biblioteca {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de frmClientes
	/// </summary>
	public ref class frmClientes : public System::Windows::Forms::Form
	{
	public:
		frmClientes(void)
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
		~frmClientes()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^ label1;
	protected:
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::Label^ label5;
	private: System::Windows::Forms::Label^ label6;

	private: System::Windows::Forms::TextBox^ txtclave;
	private: System::Windows::Forms::TextBox^ txtnombre;
	private: System::Windows::Forms::TextBox^ txttelefono;
	private: System::Windows::Forms::TextBox^ txtdomicilio;
	private: System::Windows::Forms::TextBox^ txtlocalidad;

	private: System::Windows::Forms::TextBox^ txtemail;

	private: System::Windows::Forms::Label^ label8;
	private: System::Windows::Forms::Button^ btnaceptar;
	private: System::Windows::Forms::Button^ btnbuscar;
	private: System::Windows::Forms::Button^ btnEliminar;
	private: System::Windows::Forms::Button^ btnsalir;
	private: System::Windows::Forms::Button^ btnlimpiar;

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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(frmClientes::typeid));
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->txtclave = (gcnew System::Windows::Forms::TextBox());
			this->txtnombre = (gcnew System::Windows::Forms::TextBox());
			this->txttelefono = (gcnew System::Windows::Forms::TextBox());
			this->txtdomicilio = (gcnew System::Windows::Forms::TextBox());
			this->txtlocalidad = (gcnew System::Windows::Forms::TextBox());
			this->txtemail = (gcnew System::Windows::Forms::TextBox());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->btnaceptar = (gcnew System::Windows::Forms::Button());
			this->btnbuscar = (gcnew System::Windows::Forms::Button());
			this->btnEliminar = (gcnew System::Windows::Forms::Button());
			this->btnsalir = (gcnew System::Windows::Forms::Button());
			this->btnlimpiar = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(12, 89);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(42, 15);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Clave";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label2->Location = System::Drawing::Point(242, 60);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(62, 15);
			this->label2->TabIndex = 1;
			this->label2->Text = L"Nombre:";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label3->Location = System::Drawing::Point(448, 60);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(67, 15);
			this->label3->TabIndex = 2;
			this->label3->Text = L"Telefono:";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label4->Location = System::Drawing::Point(1, 152);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(72, 15);
			this->label4->TabIndex = 3;
			this->label4->Text = L"Domicilio:";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label5->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label5->Location = System::Drawing::Point(253, 151);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(74, 15);
			this->label5->TabIndex = 4;
			this->label5->Text = L"Localidad:";
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label6->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label6->Location = System::Drawing::Point(1, 215);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(48, 15);
			this->label6->TabIndex = 5;
			this->label6->Text = L"Email:";
			// 
			// txtclave
			// 
			this->txtclave->Location = System::Drawing::Point(60, 88);
			this->txtclave->Name = L"txtclave";
			this->txtclave->Size = System::Drawing::Size(43, 20);
			this->txtclave->TabIndex = 7;
			// 
			// txtnombre
			// 
			this->txtnombre->Location = System::Drawing::Point(182, 88);
			this->txtnombre->Name = L"txtnombre";
			this->txtnombre->Size = System::Drawing::Size(196, 20);
			this->txtnombre->TabIndex = 8;
			// 
			// txttelefono
			// 
			this->txttelefono->Location = System::Drawing::Point(415, 89);
			this->txttelefono->Name = L"txttelefono";
			this->txttelefono->Size = System::Drawing::Size(163, 20);
			this->txttelefono->TabIndex = 9;
			// 
			// txtdomicilio
			// 
			this->txtdomicilio->Location = System::Drawing::Point(80, 151);
			this->txtdomicilio->Name = L"txtdomicilio";
			this->txtdomicilio->Size = System::Drawing::Size(167, 20);
			this->txtdomicilio->TabIndex = 10;
			// 
			// txtlocalidad
			// 
			this->txtlocalidad->Location = System::Drawing::Point(334, 151);
			this->txtlocalidad->Name = L"txtlocalidad";
			this->txtlocalidad->Size = System::Drawing::Size(181, 20);
			this->txtlocalidad->TabIndex = 11;
			// 
			// txtemail
			// 
			this->txtemail->Location = System::Drawing::Point(60, 214);
			this->txtemail->Name = L"txtemail";
			this->txtemail->Size = System::Drawing::Size(234, 20);
			this->txtemail->TabIndex = 12;
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->label8->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Underline)),
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label8->Location = System::Drawing::Point(149, 13);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(195, 24);
			this->label8->TabIndex = 14;
			this->label8->Text = L"Registro de clientes";
			// 
			// btnaceptar
			// 
			this->btnaceptar->Location = System::Drawing::Point(107, 275);
			this->btnaceptar->Name = L"btnaceptar";
			this->btnaceptar->Size = System::Drawing::Size(112, 32);
			this->btnaceptar->TabIndex = 15;
			this->btnaceptar->Text = L"Guardar/Actualizar";
			this->btnaceptar->UseVisualStyleBackColor = true;
			this->btnaceptar->Click += gcnew System::EventHandler(this, &frmClientes::btnaceptar_Click);
			// 
			// btnbuscar
			// 
			this->btnbuscar->Location = System::Drawing::Point(107, 88);
			this->btnbuscar->Name = L"btnbuscar";
			this->btnbuscar->Size = System::Drawing::Size(56, 23);
			this->btnbuscar->TabIndex = 16;
			this->btnbuscar->Text = L"Buscar";
			this->btnbuscar->UseVisualStyleBackColor = true;
			this->btnbuscar->Click += gcnew System::EventHandler(this, &frmClientes::btnbuscar_Click);
			// 
			// btnEliminar
			// 
			this->btnEliminar->BackColor = System::Drawing::SystemColors::Control;
			this->btnEliminar->Location = System::Drawing::Point(334, 277);
			this->btnEliminar->Name = L"btnEliminar";
			this->btnEliminar->Size = System::Drawing::Size(87, 32);
			this->btnEliminar->TabIndex = 18;
			this->btnEliminar->Text = L"Eliminar";
			this->btnEliminar->UseVisualStyleBackColor = false;
			this->btnEliminar->Click += gcnew System::EventHandler(this, &frmClientes::btnEliminar_Click);
			// 
			// btnsalir
			// 
			this->btnsalir->Location = System::Drawing::Point(462, 275);
			this->btnsalir->Name = L"btnsalir";
			this->btnsalir->Size = System::Drawing::Size(75, 34);
			this->btnsalir->TabIndex = 23;
			this->btnsalir->Text = L"Salir";
			this->btnsalir->UseVisualStyleBackColor = true;
			this->btnsalir->Click += gcnew System::EventHandler(this, &frmClientes::btnsalir_Click);
			// 
			// btnlimpiar
			// 
			this->btnlimpiar->Location = System::Drawing::Point(237, 281);
			this->btnlimpiar->Name = L"btnlimpiar";
			this->btnlimpiar->Size = System::Drawing::Size(67, 24);
			this->btnlimpiar->TabIndex = 24;
			this->btnlimpiar->Text = L"Limpiar";
			this->btnlimpiar->UseVisualStyleBackColor = true;
			this->btnlimpiar->Click += gcnew System::EventHandler(this, &frmClientes::btnlimpiar_Click);
			// 
			// frmClientes
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->ClientSize = System::Drawing::Size(708, 335);
			this->Controls->Add(this->btnlimpiar);
			this->Controls->Add(this->btnsalir);
			this->Controls->Add(this->btnEliminar);
			this->Controls->Add(this->btnbuscar);
			this->Controls->Add(this->btnaceptar);
			this->Controls->Add(this->label8);
			this->Controls->Add(this->txtemail);
			this->Controls->Add(this->txtlocalidad);
			this->Controls->Add(this->txtdomicilio);
			this->Controls->Add(this->txttelefono);
			this->Controls->Add(this->txtnombre);
			this->Controls->Add(this->txtclave);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"frmClientes";
			this->Text = L"frmClientes";
			this->Load += gcnew System::EventHandler(this, &frmClientes::frmClientes_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
private: System::Void frmClientes_Load(System::Object^ sender, System::EventArgs^ e) {
	consecutivo();

	}
	   private: void consecutivo()
	   {

		   SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
		   SqlCommand^ command = gcnew SqlCommand("select max(Clave) +1 from Clientes", con);
		   con->Open();
		   txtclave->Text = command->ExecuteScalar()->ToString();
	   }
	private: void LimpiarCampos()
	{
		txtclave->Enabled = true;
		txtclave->Text = "0";
		txtdomicilio->Clear();
		txtemail->Clear();
		txtlocalidad->Clear();
		txtnombre-> Clear();
		txttelefono->Clear();
		txtclave->Focus();
	}
		   void obtener()
		   {
			   //Creamos este método para obtener los datos del formulario de búsqueda
			   frmbusquedaCliente x;
			   x.IsMdiChild.ToString();
			   x.ShowDialog();
			   txtclave->Text = x.Clave.ToString();
			   txtnombre->Text = x.Nombre;
			   txtdomicilio->Text = x.Domicilio;
			   txtlocalidad ->Text = x.Localidad;
               txttelefono->Text = x.Telefono;
			   txtemail->Text = x.Email;
			   txtclave->Enabled = false;
		   }
	  
private: System::Void btnaceptar_Click(System::Object^ sender, System::EventArgs^ e) {
	Clientes x;
	x.Clave = Int32::Parse(txtclave->Text);
	x.Nombre = txtnombre->Text;
	x.Domicilio = txtdomicilio->Text;
	x.Localidad = txtlocalidad->Text;
	x.Telefono = txttelefono->Text;
	x.Email = txtemail->Text;
	x.Guardar();
	LimpiarCampos();
}
	  
private: System::Void btnbuscar_Click(System::Object^ sender, System::EventArgs^ e) {
	obtener();
	/*Clientes x;
	x.Clave = Convert::ToInt32(txtclave->Text);
	x.Buscar();
	if (x.encontro == true)
	{
		txtnombre->Text = x.Nombre;
		txtdomicilio->Text = x.Domicilio;
		txtlocalidad->Text = x.Localidad;
		txttelefono->Text = x.Telefono;
		txtemail->Text = x.Email;
	}
	else
	{
		LimpiarCampos();
	}*/
}
private: System::Void btnEliminar_Click(System::Object^ sender, System::EventArgs^ e) {
	Clientes x;
	x.Clave = Int32::Parse(txtclave->Text);
	x.Eliminar();
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


