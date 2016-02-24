﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MTerrenos
    {
        #region Singleton

        private static MTerrenos instance;

        public static MTerrenos GetInstance()
        {
            if (instance == null)
            {
                instance = new MTerrenos();
            }

            return instance;
        }

        #endregion

        #region Propertys

        private string nombreLote;

        public string NombreLote
        {
            get { return nombreLote; }
            set { nombreLote = value; }
        }

        private int cuadras;

        public int Cuadras
        {
            get { return cuadras; }
            set { cuadras = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        #endregion


        public List<MTerrenos> ConsultarLote()
        {
            List<MTerrenos> lista = new List<MTerrenos>();

            using (var entity = new DBFincaEntities())
            {
                var lotes = from c in entity.Lote
                            where c.EstadoLote == "A"
                            select c;

                foreach (var item in lotes)
                {
                    int total = 0;

                    var cantidad = from c in entity.Arboles
                                   where c.idLote == item.idLote
                                   select new { c.Cantidad };

                    if (cantidad.Count() == 0)
                    {
                        total = 0;
                    }
                    else
                    {
                        total = cantidad.Sum(c => c.Cantidad);
                    }

                    lista.Add(new MTerrenos { NombreLote = item.NombreLote, Cuadras = int.Parse(item.Cuadras), Cantidad = total });
                }

                return lista;
            }
        }

        public List<Labor> ConsultarLabor()
        {
            using (var entity = new DBFincaEntities())
            {



                var query = from c in entity.Labor
                            where c.EstadoLabor == "A"
                            select c;
                return query.ToList();
            }

        }

        public List<Insumo> ConsultarInsumo()
        {
            using (var entity = new DBFincaEntities())
            {

                List<Insumo> lista = new List<Insumo>()
                {
                    new Insumo
                    {
                        idInsumo = 0,
                        NombreInsumo = "Seleccione un Insumo",
                    }
                };

                var query = lista.Union(from c in entity.Insumo
                                        where c.EstadoInsumo == "A"
                                        select c);
                return query.ToList();
            }

        }

        public List<Persona> ConsultarEmpleado()
        {
            using (var entity = new DBFincaEntities())
            {

                List<Persona> lista = new List<Persona>()
                {
                    new Persona
                    {
                        DocumentoPersona = 0.ToString(),
                        NombrePersona = "Seleccione un Empleado",
                    }
                };

                var query = lista.Union(from c in entity.Persona
                                        where c.TipoContratoPersona == "Temporal" && c.EstadoPersona == "A"
                                        select c);
                return query.ToList();
            }

        }

        public string asociarLaborLote(int labor, int lote, DateTime fecha)
        {
            using (var entity = new DBFincaEntities())
            {

                var rpta = entity.asociarLaborLote(labor, lote, fecha).First();
                return rpta.mensaje;
            }

        }

        public object asociarInsumoLaborLote(DataTable tabla)
        {
            using (var entity = new DBFincaEntities())
            {

                var rpta = entity.SP_InsumoLaborLote(tabla);

                return rpta;
            }

        }

        public object salarioEmpleado(DataTable tabla)
        {
            using (var entity = new DBFincaEntities())
            {

                var rpta = entity.SP_SalariosEmpleados(tabla);

                return rpta;
            }

        }
        public object registrarProduccion(int idLote, DateTime fecha, int cantidad)
        {
            using (var entity = new DBFincaEntities())
            {

                var query = entity.registroProduccion(idLote, fecha, cantidad);

                return query;
            }

        }

        public int cantidadArbolesLote(int idTipoArbol, int idLote)
        {
            using (var entity = new DBFincaEntities())
            {

                var query = (from a in entity.Arboles
                             where a.idLote == idLote && a.idTIpoArbol == idTipoArbol
                             select a.Cantidad).First();

                return query;
            }

        }

        public string MovimientoArboles(short idLote, byte idTipoArbol, int cantidad, DateTime fecha, int idMovimiento, string tipoMovimiento, int opcion)
        {
            using (var entity = new DBFincaEntities())
            {

                var rpta = entity.gestionArboles2(idLote, idTipoArbol, cantidad, fecha, idMovimiento, tipoMovimiento, opcion);
                return rpta.ToString();
            }
        }
        public object LaborModificaArbol(int idLote)
        {
            using (var entity = new DBFincaEntities())
            {
                List<object> lista = new List<object>()
                {
                    new TipoArbol
                    {
                        idTipoArbol=0,
                        NombreTipoArbol = "Seleccione árbol",
                    }
                };

                var query = lista.Union(from a in entity.Arboles
                                        join t in entity.TipoArbol on a.idTIpoArbol equals t.idTipoArbol
                                        where a.idLote == idLote
                                        select new { a.idArboles, a.idLote, a.idTIpoArbol, a.Cantidad, t.NombreTipoArbol });

                return query.ToList();
            }
        }

        public List<TipoArbol> ConsultarTipoArboles()
        {
            using (var entity = new DBFincaEntities())
            {
                List<TipoArbol> lista = new List<TipoArbol>()
                {
                    new TipoArbol
                    {
                        idTipoArbol = 0,
                        NombreTipoArbol = "Tipos Arboles",
                    }
                };

                var query = lista.Union((from c in entity.TipoArbol

                                         select c));
                return query.ToList();
            }

        }

    }
}