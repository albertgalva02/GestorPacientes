﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Database.Modelo;

namespace LogicLayer
{
    public class ServicioCita
    {
        CitaRepositorio cita;
        public ServicioCita(SqlConnection connection)
        {
            cita = new CitaRepositorio(connection);
        }

        public void Agregar(Cita item) 
        {
            cita.Agregar(item);
        }

        public void Eliminar(int id) 
        {
            cita.Eliminar(id);
        }

        public DataTable LoadData() 
        {
            return cita.GetAll();
        }

        public string GetCedulaByCita(int id) 
        {
            return cita.GetCedulaByCita(id);
        }

        public string GetEstadoCita(int id) 
        {
            return cita.GetEstadoCita(id);
        }

        public void ActualizaEstado(string estado, int id) 
        { 
            cita.ActualizaEstado(estado,id);
        }
    }
}
