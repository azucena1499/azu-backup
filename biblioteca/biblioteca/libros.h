#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;
using namespace Data;
using namespace Data::SqlClient;
using namespace System::Configuration;

ref class libros
{
	SqlConnection^ con = gcnew SqlConnection("Data Source=DESKTOP-U4S9UO5;Initial Catalog=BIBLIOTECA;Persist Security Info = True;User Id=sa; Password=papasfritas");
	SqlConnectionStringBuilder^ st;
	SqlCommand^ comando = gcnew SqlCommand();
	SqlDataReader^ lector;

public:Byte id;
	  String^ ISBN;
	  String^ Titulo;
	  int idAutor;
	  int idGenero;
	  DateTime FechaPublicacion;
	  String^ Editorial;
	  Boolean encontro = false;
public:
	libros();
	void Guardar()
	{
		comando->Connection = con;
		comando->CommandType = CommandType::StoredProcedure;
		comando->CommandText = "spLibros";
		comando->Parameters->Clear();
		comando->Parameters->AddWithValue("@op", 2);
		comando->Parameters->AddWithValue("@id", id);
		comando->Parameters->AddWithValue("@ISBN", ISBN);
		comando->Parameters->AddWithValue("@Titulo", Titulo);
		comando->Parameters->AddWithValue("@idAutor", idAutor);
		comando->Parameters->AddWithValue("@idGenero", idGenero);
		comando->Parameters->AddWithValue("@FchaPublicacion", FechaPublicacion);
		comando->Parameters->AddWithValue("@Editorial", Editorial);

		try
		{
			con->Open();
			comando->ExecuteNonQuery();
			MessageBox::Show("Se guardo con exito!");

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
		comando->CommandText = "spLibros";
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
			MessageBox::Show("su proceso de eliminar ha fallado");
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
		comando->CommandText = "spLibros";
		comando->Parameters->Clear();
		comando->Parameters->AddWithValue("@op", 1);
		comando->Parameters->AddWithValue("@id", id);
		try
		{
			con->Open();
			lector = comando->ExecuteReader();
			if (lector->Read())
			{
				//Aqui obtenemos el valor de los campos y se los asignamos a las variables
				//Los nombres denntro de [] deben de ser igual al nombre de los campos de su tabla
				ISBN = lector["ISBN"]->ToString();
				Titulo = lector["Titulo"]->ToString();
				idAutor = Int32::Parse(lector["idAutor"]->ToString());
				idGenero = Int32::Parse(lector["idGenero"]->ToString());
				FechaPublicacion = DateTime::Parse(lector["FechaPublicacion"]->ToString());
				Editorial = lector["Editorial"]->ToString();
				encontro = true;
			}
			else
			{
				MessageBox::Show("No hay datos con ese id.");
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
};



