#pragma once
using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;
using namespace Data;
using namespace Data::SqlClient;
ref class Editoriales
{
	SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
	SqlConnectionStringBuilder^ st;
	SqlCommand^ comando = gcnew SqlCommand();
	SqlDataReader^ lector;

public:Byte id;
	  String^ Nombre;
	  Boolean encontro = false;
public:
	Editoriales();
	void Guardar()
	{
		comando->Connection = con;
		comando->CommandType = CommandType::StoredProcedure;
		comando->CommandText = "spEditoriales";
		comando->Parameters->Clear();
		comando->Parameters->AddWithValue("@op", 2);
		comando->Parameters->AddWithValue("@id", id);
		comando->Parameters->AddWithValue("@Nombre", Nombre);
		try
		{
			con->Open();
			comando->ExecuteNonQuery();
			MessageBox::Show("Proceso realizado exitosamente.");

		}
		catch (SqlException ^ e)
		{

		}
		finally
		{
			con->Close();
		}
	}
	void Buscar()
	{
		comando->Connection = con;
		comando->CommandType = CommandType::StoredProcedure;
		comando->CommandText = "spEditoriales";
		comando->Parameters->Clear();
		comando->Parameters->AddWithValue("@op", 1);
		comando->Parameters->AddWithValue("@id", id);
		try
		{
			con->Open();
			lector = comando->ExecuteReader();
			if (lector->Read())
			{
				Nombre = lector["Nombre"]->ToString(); //es un cbox
				encontro = true;
			}
			else
			{
				MessageBox::Show("No se encuentran datos con ese id.");
			}
		}
		catch (SqlException ^ e)
		{
		}
		finally
		{
			con->Close();
		}
	}
	void Eliminar()
	{
		comando->Connection = con;
		comando->CommandType = CommandType::StoredProcedure;
		comando->CommandText = "spEditoriales";
		comando->Parameters->Clear();
		comando->Parameters->AddWithValue("@op", 3);
		comando->Parameters->AddWithValue("@id", id);
		try
		{
			con->Open();
			comando->ExecuteNonQuery();
			MessageBox::Show("se elimino correctamente.");
			
		}
		catch (SqlException ^ e)
		{
			MessageBox::Show("No se pudo eliminar.");
		}
		finally
		{
			con->Close();
		}
	}
};




