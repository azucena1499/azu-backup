#pragma once
using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;
using namespace Data;
using namespace Data::SqlClient;
ref class Autores
{
	SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
	SqlConnectionStringBuilder^ st;
	SqlCommand^ comando = gcnew SqlCommand();
	SqlDataReader^ lector;

public:Byte id;
	  String^ Nombre;
	  Boolean encontro = false;
public:
	Autores();
	void Guardar()
	{
		comando->Connection = con;
		comando->CommandType = CommandType::StoredProcedure;
		comando->CommandText = "spautoress";
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
	void Eliminar()
	{
		comando->Connection = con;
		comando->CommandType = CommandType::StoredProcedure;
		comando->CommandText = "spautoress";
		comando->Parameters->Clear();
		comando->Parameters->AddWithValue("@op", 3);
		comando->Parameters->AddWithValue("@id", id);
		try
		{
			con->Open();
			comando->ExecuteNonQuery();
			MessageBox::Show("Proceso realizado exitosamente.");
		}
		catch (SqlException ^ e)
		{
			MessageBox::Show("Proceso fallido.");
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
		comando->CommandText = "spautoress";
		comando->Parameters->Clear();
		//Ponemos el @op el valor 1 por que es la opcion que le dimos en el procedimiento almacenado y solo necesitamos en @id por que con ese se hace la busqueda
		comando->Parameters->AddWithValue("@op", 1);
		comando->Parameters->AddWithValue("@id", id);
		try
		{
			con->Open();
			lector = comando->ExecuteReader();
			if (lector->Read())
			{
				Nombre = lector["Nombre"]->ToString();
				encontro = true;
			}
			else
			{
				MessageBox::Show("No se encuentran datos con ese id.");
			}
		}
		catch (SqlException ^ e)
		{
			MessageBox::Show(e->Message);
		}
		finally
		{
			con->Close();
		}
	}
};


