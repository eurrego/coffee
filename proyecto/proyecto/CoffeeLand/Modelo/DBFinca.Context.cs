﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBFincaEntities : DbContext
    {
        public DBFincaEntities()
            : base("name=DBFincaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AbonoCompra> AbonoCompra { get; set; }
        public virtual DbSet<AbonoDeuda> AbonoDeuda { get; set; }
        public virtual DbSet<AbonoEgreso> AbonoEgreso { get; set; }
        public virtual DbSet<Arboles> Arboles { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Compra_Insumo> Compra_Insumo { get; set; }
        public virtual DbSet<Concepto> Concepto { get; set; }
        public virtual DbSet<CostoBeneficio> CostoBeneficio { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<DeudaPersona> DeudaPersona { get; set; }
        public virtual DbSet<Egreso> Egreso { get; set; }
        public virtual DbSet<Finca> Finca { get; set; }
        public virtual DbSet<Insumo> Insumo { get; set; }
        public virtual DbSet<Labor> Labor { get; set; }
        public virtual DbSet<Labor_Lote> Labor_Lote { get; set; }
        public virtual DbSet<LaborLote_Insumo> LaborLote_Insumo { get; set; }
        public virtual DbSet<Lote> Lote { get; set; }
        public virtual DbSet<MovimientoProduccion> MovimientoProduccion { get; set; }
        public virtual DbSet<MovimientosArboles> MovimientosArboles { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Produccion> Produccion { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<RegistroPago> RegistroPago { get; set; }
        public virtual DbSet<RegistroPagoSalario> RegistroPagoSalario { get; set; }
        public virtual DbSet<SalarioPersonaPermanente> SalarioPersonaPermanente { get; set; }
        public virtual DbSet<SalarioPersonaTemporal> SalarioPersonaTemporal { get; set; }
        public virtual DbSet<TipoArbol> TipoArbol { get; set; }
        public virtual DbSet<TipoInsumo> TipoInsumo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
    
        public virtual ObjectResult<AbonoCompraProveedor_Result> AbonoCompraProveedor(Nullable<int> idCompra, Nullable<decimal> valor, Nullable<System.DateTime> fecha, Nullable<decimal> total)
        {
            var idCompraParameter = idCompra.HasValue ?
                new ObjectParameter("idCompra", idCompra) :
                new ObjectParameter("idCompra", typeof(int));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(decimal));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("Total", total) :
                new ObjectParameter("Total", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AbonoCompraProveedor_Result>("AbonoCompraProveedor", idCompraParameter, valorParameter, fechaParameter, totalParameter);
        }
    
        public virtual int ActializarCantidadArboles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActializarCantidadArboles");
        }
    
        public virtual ObjectResult<asociarLaborLote_Result> asociarLaborLote(Nullable<int> idLabor, Nullable<int> idLote, Nullable<System.DateTime> fecha)
        {
            var idLaborParameter = idLabor.HasValue ?
                new ObjectParameter("idLabor", idLabor) :
                new ObjectParameter("idLabor", typeof(int));
    
            var idLoteParameter = idLote.HasValue ?
                new ObjectParameter("idLote", idLote) :
                new ObjectParameter("idLote", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<asociarLaborLote_Result>("asociarLaborLote", idLaborParameter, idLoteParameter, fechaParameter);
        }
    
        public virtual ObjectResult<ComprasProveedor_Result1> ComprasProveedor(string nit)
        {
            var nitParameter = nit != null ?
                new ObjectParameter("nit", nit) :
                new ObjectParameter("nit", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ComprasProveedor_Result1>("ComprasProveedor", nitParameter);
        }
    
        public virtual ObjectResult<consultarMovimientosArboles_Result1> consultarMovimientosArboles(Nullable<int> idArbol)
        {
            var idArbolParameter = idArbol.HasValue ?
                new ObjectParameter("idArbol", idArbol) :
                new ObjectParameter("idArbol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultarMovimientosArboles_Result1>("consultarMovimientosArboles", idArbolParameter);
        }
    
        public virtual ObjectResult<Consultasproduccion_Result> Consultasproduccion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Consultasproduccion_Result>("Consultasproduccion");
        }
    
        public virtual ObjectResult<gestionArboles_Result> gestionArboles(Nullable<short> idLote, Nullable<byte> idTipoArbol, Nullable<int> cantidad, Nullable<System.DateTime> fecha, Nullable<int> idMovimiento, Nullable<int> opcion)
        {
            var idLoteParameter = idLote.HasValue ?
                new ObjectParameter("idLote", idLote) :
                new ObjectParameter("idLote", typeof(short));
    
            var idTipoArbolParameter = idTipoArbol.HasValue ?
                new ObjectParameter("idTipoArbol", idTipoArbol) :
                new ObjectParameter("idTipoArbol", typeof(byte));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var idMovimientoParameter = idMovimiento.HasValue ?
                new ObjectParameter("idMovimiento", idMovimiento) :
                new ObjectParameter("idMovimiento", typeof(int));
    
            var opcionParameter = opcion.HasValue ?
                new ObjectParameter("opcion", opcion) :
                new ObjectParameter("opcion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gestionArboles_Result>("gestionArboles", idLoteParameter, idTipoArbolParameter, cantidadParameter, fechaParameter, idMovimientoParameter, opcionParameter);
        }
    
        public virtual ObjectResult<string> gestionArboles2(Nullable<short> idLote, Nullable<byte> idTipoArbol, Nullable<int> cantidad, Nullable<System.DateTime> fecha)
        {
            var idLoteParameter = idLote.HasValue ?
                new ObjectParameter("idLote", idLote) :
                new ObjectParameter("idLote", typeof(short));
    
            var idTipoArbolParameter = idTipoArbol.HasValue ?
                new ObjectParameter("idTipoArbol", idTipoArbol) :
                new ObjectParameter("idTipoArbol", typeof(byte));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("gestionArboles2", idLoteParameter, idTipoArbolParameter, cantidadParameter, fechaParameter);
        }
    
        public virtual ObjectResult<gestionConcepto_Result> gestionConcepto(string nombreConcepto, string descripcion, Nullable<int> idConcepto, Nullable<int> opc)
        {
            var nombreConceptoParameter = nombreConcepto != null ?
                new ObjectParameter("NombreConcepto", nombreConcepto) :
                new ObjectParameter("NombreConcepto", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var idConceptoParameter = idConcepto.HasValue ?
                new ObjectParameter("idConcepto", idConcepto) :
                new ObjectParameter("idConcepto", typeof(int));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gestionConcepto_Result>("gestionConcepto", nombreConceptoParameter, descripcionParameter, idConceptoParameter, opcParameter);
        }
    
        public virtual ObjectResult<gestionInsumo_Result> gestionInsumo(Nullable<byte> idTipoInsumo, string nombreInsumo, string descripcion, string marca, string unidadMedida, Nullable<int> idInsumo, Nullable<int> opc)
        {
            var idTipoInsumoParameter = idTipoInsumo.HasValue ?
                new ObjectParameter("idTipoInsumo", idTipoInsumo) :
                new ObjectParameter("idTipoInsumo", typeof(byte));
    
            var nombreInsumoParameter = nombreInsumo != null ?
                new ObjectParameter("nombreInsumo", nombreInsumo) :
                new ObjectParameter("nombreInsumo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("marca", marca) :
                new ObjectParameter("marca", typeof(string));
    
            var unidadMedidaParameter = unidadMedida != null ?
                new ObjectParameter("unidadMedida", unidadMedida) :
                new ObjectParameter("unidadMedida", typeof(string));
    
            var idInsumoParameter = idInsumo.HasValue ?
                new ObjectParameter("idInsumo", idInsumo) :
                new ObjectParameter("idInsumo", typeof(int));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gestionInsumo_Result>("gestionInsumo", idTipoInsumoParameter, nombreInsumoParameter, descripcionParameter, marcaParameter, unidadMedidaParameter, idInsumoParameter, opcParameter);
        }
    
        public virtual ObjectResult<gestionLabor_Result> gestionLabor(string nombreLabor, Nullable<bool> modificaArbol, Nullable<bool> requiereInsumo, string descripcion, Nullable<int> idLabor, Nullable<int> opc)
        {
            var nombreLaborParameter = nombreLabor != null ?
                new ObjectParameter("nombreLabor", nombreLabor) :
                new ObjectParameter("nombreLabor", typeof(string));
    
            var modificaArbolParameter = modificaArbol.HasValue ?
                new ObjectParameter("modificaArbol", modificaArbol) :
                new ObjectParameter("modificaArbol", typeof(bool));
    
            var requiereInsumoParameter = requiereInsumo.HasValue ?
                new ObjectParameter("requiereInsumo", requiereInsumo) :
                new ObjectParameter("requiereInsumo", typeof(bool));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var idLaborParameter = idLabor.HasValue ?
                new ObjectParameter("idLabor", idLabor) :
                new ObjectParameter("idLabor", typeof(int));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gestionLabor_Result>("gestionLabor", nombreLaborParameter, modificaArbolParameter, requiereInsumoParameter, descripcionParameter, idLaborParameter, opcParameter);
        }
    
        public virtual ObjectResult<gestionLotes_Result> gestionLotes(string nombreLote, string observaciones, string cuadras, Nullable<int> idLote, Nullable<int> opc)
        {
            var nombreLoteParameter = nombreLote != null ?
                new ObjectParameter("nombreLote", nombreLote) :
                new ObjectParameter("nombreLote", typeof(string));
    
            var observacionesParameter = observaciones != null ?
                new ObjectParameter("observaciones", observaciones) :
                new ObjectParameter("observaciones", typeof(string));
    
            var cuadrasParameter = cuadras != null ?
                new ObjectParameter("cuadras", cuadras) :
                new ObjectParameter("cuadras", typeof(string));
    
            var idLoteParameter = idLote.HasValue ?
                new ObjectParameter("idLote", idLote) :
                new ObjectParameter("idLote", typeof(int));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gestionLotes_Result>("gestionLotes", nombreLoteParameter, observacionesParameter, cuadrasParameter, idLoteParameter, opcParameter);
        }
    
        public virtual ObjectResult<gestionPersona_Result> gestionPersona(string nombrePersona, string genero, string telefono, Nullable<System.DateTime> fechaNacimiento, Nullable<int> documentoPerosna, Nullable<int> opc, string tipoDocumento, string tipoContrato)
        {
            var nombrePersonaParameter = nombrePersona != null ?
                new ObjectParameter("nombrePersona", nombrePersona) :
                new ObjectParameter("nombrePersona", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("fechaNacimiento", fechaNacimiento) :
                new ObjectParameter("fechaNacimiento", typeof(System.DateTime));
    
            var documentoPerosnaParameter = documentoPerosna.HasValue ?
                new ObjectParameter("documentoPerosna", documentoPerosna) :
                new ObjectParameter("documentoPerosna", typeof(int));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            var tipoDocumentoParameter = tipoDocumento != null ?
                new ObjectParameter("TipoDocumento", tipoDocumento) :
                new ObjectParameter("TipoDocumento", typeof(string));
    
            var tipoContratoParameter = tipoContrato != null ?
                new ObjectParameter("TipoContrato", tipoContrato) :
                new ObjectParameter("TipoContrato", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gestionPersona_Result>("gestionPersona", nombrePersonaParameter, generoParameter, telefonoParameter, fechaNacimientoParameter, documentoPerosnaParameter, opcParameter, tipoDocumentoParameter, tipoContratoParameter);
        }
    
        public virtual ObjectResult<gestionProducto_Result> gestionProducto(string nombreProducto, string descripcion, Nullable<int> idProducto, Nullable<int> opc)
        {
            var nombreProductoParameter = nombreProducto != null ?
                new ObjectParameter("NombreProducto", nombreProducto) :
                new ObjectParameter("NombreProducto", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gestionProducto_Result>("gestionProducto", nombreProductoParameter, descripcionParameter, idProductoParameter, opcParameter);
        }
    
        public virtual ObjectResult<gestionProveedor_Result> gestionProveedor(string nit, string nombreProveedor, string telefono, string direccion, string tipoDocumento, Nullable<int> opc)
        {
            var nitParameter = nit != null ?
                new ObjectParameter("nit", nit) :
                new ObjectParameter("nit", typeof(string));
    
            var nombreProveedorParameter = nombreProveedor != null ?
                new ObjectParameter("nombreProveedor", nombreProveedor) :
                new ObjectParameter("nombreProveedor", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var tipoDocumentoParameter = tipoDocumento != null ?
                new ObjectParameter("TipoDocumento", tipoDocumento) :
                new ObjectParameter("TipoDocumento", typeof(string));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gestionProveedor_Result>("gestionProveedor", nitParameter, nombreProveedorParameter, telefonoParameter, direccionParameter, tipoDocumentoParameter, opcParameter);
        }
    
        public virtual ObjectResult<gestionTipoArboles_Result> gestionTipoArboles(string nombreArbol, string descripcion, Nullable<int> idTipoArbol, Nullable<int> tiempoProduccion, Nullable<int> opc)
        {
            var nombreArbolParameter = nombreArbol != null ?
                new ObjectParameter("NombreArbol", nombreArbol) :
                new ObjectParameter("NombreArbol", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var idTipoArbolParameter = idTipoArbol.HasValue ?
                new ObjectParameter("idTipoArbol", idTipoArbol) :
                new ObjectParameter("idTipoArbol", typeof(int));
    
            var tiempoProduccionParameter = tiempoProduccion.HasValue ?
                new ObjectParameter("tiempoProduccion", tiempoProduccion) :
                new ObjectParameter("tiempoProduccion", typeof(int));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gestionTipoArboles_Result>("gestionTipoArboles", nombreArbolParameter, descripcionParameter, idTipoArbolParameter, tiempoProduccionParameter, opcParameter);
        }
    
        public virtual ObjectResult<gestionTipoInsumo_Result> gestionTipoInsumo(string nombreTipoInsumo, string descripcion, Nullable<int> idTipoInsumo, Nullable<int> opc)
        {
            var nombreTipoInsumoParameter = nombreTipoInsumo != null ?
                new ObjectParameter("NombreTipoInsumo", nombreTipoInsumo) :
                new ObjectParameter("NombreTipoInsumo", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var idTipoInsumoParameter = idTipoInsumo.HasValue ?
                new ObjectParameter("idTipoInsumo", idTipoInsumo) :
                new ObjectParameter("idTipoInsumo", typeof(int));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gestionTipoInsumo_Result>("gestionTipoInsumo", nombreTipoInsumoParameter, descripcionParameter, idTipoInsumoParameter, opcParameter);
        }
    
        public virtual ObjectResult<GestionUsuario_Result> GestionUsuario(Nullable<int> idUsuario, string nickName, string rol, string contrasena, string preguntaSeguridad, string respuesta, Nullable<int> opc)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            var nickNameParameter = nickName != null ?
                new ObjectParameter("nickName", nickName) :
                new ObjectParameter("nickName", typeof(string));
    
            var rolParameter = rol != null ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(string));
    
            var contrasenaParameter = contrasena != null ?
                new ObjectParameter("contrasena", contrasena) :
                new ObjectParameter("contrasena", typeof(string));
    
            var preguntaSeguridadParameter = preguntaSeguridad != null ?
                new ObjectParameter("preguntaSeguridad", preguntaSeguridad) :
                new ObjectParameter("preguntaSeguridad", typeof(string));
    
            var respuestaParameter = respuesta != null ?
                new ObjectParameter("respuesta", respuesta) :
                new ObjectParameter("respuesta", typeof(string));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GestionUsuario_Result>("GestionUsuario", idUsuarioParameter, nickNameParameter, rolParameter, contrasenaParameter, preguntaSeguridadParameter, respuestaParameter, opcParameter);
        }
    
        public virtual int GestionVenta(Nullable<int> nit, Nullable<System.DateTime> fecha, Nullable<int> numeroFactura, Nullable<int> idProducto, Nullable<decimal> precioCarga, Nullable<decimal> cantidadCargas, Nullable<decimal> precioBeneficio)
        {
            var nitParameter = nit.HasValue ?
                new ObjectParameter("nit", nit) :
                new ObjectParameter("nit", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var numeroFacturaParameter = numeroFactura.HasValue ?
                new ObjectParameter("numeroFactura", numeroFactura) :
                new ObjectParameter("numeroFactura", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            var precioCargaParameter = precioCarga.HasValue ?
                new ObjectParameter("PrecioCarga", precioCarga) :
                new ObjectParameter("PrecioCarga", typeof(decimal));
    
            var cantidadCargasParameter = cantidadCargas.HasValue ?
                new ObjectParameter("CantidadCargas", cantidadCargas) :
                new ObjectParameter("CantidadCargas", typeof(decimal));
    
            var precioBeneficioParameter = precioBeneficio.HasValue ?
                new ObjectParameter("PrecioBeneficio", precioBeneficio) :
                new ObjectParameter("PrecioBeneficio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GestionVenta", nitParameter, fechaParameter, numeroFacturaParameter, idProductoParameter, precioCargaParameter, cantidadCargasParameter, precioBeneficioParameter);
        }
    
        public virtual ObjectResult<insercionAbonoDeuda_Result> insercionAbonoDeuda(Nullable<decimal> valor, Nullable<System.DateTime> fecha, Nullable<int> idDeuda, Nullable<int> opc)
        {
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(decimal));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var idDeudaParameter = idDeuda.HasValue ?
                new ObjectParameter("idDeuda", idDeuda) :
                new ObjectParameter("idDeuda", typeof(int));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<insercionAbonoDeuda_Result>("insercionAbonoDeuda", valorParameter, fechaParameter, idDeudaParameter, opcParameter);
        }
    
        public virtual ObjectResult<insercionDeudaEmpleado_Result> insercionDeudaEmpleado(string documentoPersona, Nullable<decimal> valor, Nullable<System.DateTime> fecha, string descripcion)
        {
            var documentoPersonaParameter = documentoPersona != null ?
                new ObjectParameter("DocumentoPersona", documentoPersona) :
                new ObjectParameter("DocumentoPersona", typeof(string));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(decimal));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<insercionDeudaEmpleado_Result>("insercionDeudaEmpleado", documentoPersonaParameter, valorParameter, fechaParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<string> ModificarFinca(string nombreFinca, string propietario, Nullable<int> idMunicipio, string vereda, string telefono, string hectareas)
        {
            var nombreFincaParameter = nombreFinca != null ?
                new ObjectParameter("nombreFinca", nombreFinca) :
                new ObjectParameter("nombreFinca", typeof(string));
    
            var propietarioParameter = propietario != null ?
                new ObjectParameter("Propietario", propietario) :
                new ObjectParameter("Propietario", typeof(string));
    
            var idMunicipioParameter = idMunicipio.HasValue ?
                new ObjectParameter("idMunicipio", idMunicipio) :
                new ObjectParameter("idMunicipio", typeof(int));
    
            var veredaParameter = vereda != null ?
                new ObjectParameter("Vereda", vereda) :
                new ObjectParameter("Vereda", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var hectareasParameter = hectareas != null ?
                new ObjectParameter("hectareas", hectareas) :
                new ObjectParameter("hectareas", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ModificarFinca", nombreFincaParameter, propietarioParameter, idMunicipioParameter, veredaParameter, telefonoParameter, hectareasParameter);
        }
    
        public virtual ObjectResult<PagosPersona_Result> PagosPersona(Nullable<int> opcionPago)
        {
            var opcionPagoParameter = opcionPago.HasValue ?
                new ObjectParameter("opcionPago", opcionPago) :
                new ObjectParameter("opcionPago", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PagosPersona_Result>("PagosPersona", opcionPagoParameter);
        }
    
        public virtual ObjectResult<RegistrarCompra_Result> RegistrarCompra(string nit, Nullable<System.DateTime> fecha, Nullable<int> numeroFactura)
        {
            var nitParameter = nit != null ?
                new ObjectParameter("nit", nit) :
                new ObjectParameter("nit", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var numeroFacturaParameter = numeroFactura.HasValue ?
                new ObjectParameter("numeroFactura", numeroFactura) :
                new ObjectParameter("numeroFactura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RegistrarCompra_Result>("RegistrarCompra", nitParameter, fechaParameter, numeroFacturaParameter);
        }
    
        public virtual int registroProduccion(Nullable<int> idLote, Nullable<System.DateTime> fecha, Nullable<int> cantidad)
        {
            var idLoteParameter = idLote.HasValue ?
                new ObjectParameter("idLote", idLote) :
                new ObjectParameter("idLote", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("registroProduccion", idLoteParameter, fechaParameter, cantidadParameter);
        }
    
        public virtual ObjectResult<VentaProduccion_Result> VentaProduccion(Nullable<decimal> cantidad)
        {
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VentaProduccion_Result>("VentaProduccion", cantidadParameter);
        }
    
        public virtual ObjectResult<DetalleSalario_Result> DetalleSalario(Nullable<int> cedula)
        {
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DetalleSalario_Result>("DetalleSalario", cedulaParameter);
        }
    
        public virtual int Insercion_RegistroPago_SalarioPersonaTemporal()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insercion_RegistroPago_SalarioPersonaTemporal");
        }
    }
}
