using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Database.Modelo
{
    public class CitaRepositorio
    {
        private SqlConnection _connection;

        public CitaRepositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public void Agregar(Cita item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO citas (id_paciente, id_medico, fecha, hora, causa, estado) VALUES (@idpaciente, @iddoctor, @fecha, @hora, @causa, @estado)", _connection);
            command.Parameters.AddWithValue("@idpaciente", item.IdPaciente);
            command.Parameters.AddWithValue("@iddoctor", item.IdMedico);
            command.Parameters.AddWithValue("@fecha", item.Fecha);
            command.Parameters.AddWithValue("@hora", item.Hora);
            command.Parameters.AddWithValue("@causa", item.Causa);
            command.Parameters.AddWithValue("@estado", item.Estado);

            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();

        }

        public void Eliminar(int id)
        {
            _connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM citas where id_cita = @id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();


            SqlCommand command1 = new SqlCommand("DELETE FROM resultados where id_cita = @id", _connection);
            command1.Parameters.AddWithValue("@id", id);
            command1.ExecuteNonQuery();

            _connection.Close();

        }

        public void ActualizaEstado(string estado, int id)
        {
            SqlCommand command = new SqlCommand("UPDATE citas SET estado = @estado where id_cita = @id", _connection);
            command.Parameters.AddWithValue("@estado", estado);
            command.Parameters.AddWithValue("@id", id);

            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();

        }

        public string GetEstadoCita(int id)
        {
            _connection.Open();

            SqlCommand command = new SqlCommand("select estado from citas where id_cita = @id", _connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();

            string Estado;

            if (reader.Read())
            {
                Estado = reader.GetString(0);
            }
            else
            {
                Estado = "";
            }

            _connection.Close();
            reader.Close();
            reader.Dispose();

            return Estado;
        }

        public string GetCedulaByCita(int id) 
        {
            _connection.Open();

            SqlCommand command = new SqlCommand("select p.cedula from citas c join pacientes p on c.id_paciente = p.id_paciente where c.id_cita = @id", _connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();

            string CedulaPaciente;

            if (reader.Read())
            {
                CedulaPaciente = reader.GetString(0);
            }
            else
            {
                CedulaPaciente = "";
            }

            _connection.Close();
            reader.Close();
            reader.Dispose();

            return CedulaPaciente;
        }

        public DataTable GetAll()
        {
            SqlDataAdapter command = new SqlDataAdapter("SELECT c.id_cita, p.nombre, m.nombre, c.fecha, c.hora, c.causa, " +
                "case when c.estado = 'PC' then 'Pendiente de Consulta' when c.estado = 'PR' " +
                "then 'Pendiente de Resultados' when c.estado = 'C' then 'Completado' end as 'estado' " +
                "FROM citas c INNER JOIN pacientes p on(c.id_paciente = p.id_paciente) " +
                "INNER JOIN medicos m on (c.id_medico = m.id_medico)", _connection);

            return LoadData(command);
        }

        public DataTable LoadData(SqlDataAdapter command)
        {
            try
            {
                DataTable data = new DataTable();

                _connection.Open();
                command.Fill(data);
                _connection.Close();

                return data;
            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
