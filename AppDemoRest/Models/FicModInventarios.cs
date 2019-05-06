﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDemoRest.Models {

    public class zt_cat_cedis {   
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int16 IdCEDI { get; set; }
        [StringLength(50)]
        public string DesCEDI { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }

    public class zt_cat_almacenes {
        [StringLength(20)]
        public string IdAlmacen { get; set; } 
        public Int16 IdCEDI { get; set; }
        public zt_cat_cedis zt_cat_cedis { get; set; }
        [StringLength(50)]
        public string DesAlmacen { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }

    public class zt_cat_grupos_sku {
        [StringLength(20)]
        public string IdGrupoSKU { get; set; } 
        [StringLength(50)]
        public string DesGrupoSKU { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    } 

    public class zt_cat_unidad_medidas {
        [StringLength(10)]
        public string IdUnidadMedida { get; set; }
        [StringLength(20)]
        public string DesUMedida { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }

    public class zt_cat_productos {
        [StringLength(20)]
        public string IdSKU { get; set; }
        [StringLength(20)]
        public string CodigoBarras { get; set; }
        [StringLength(50)]
        public string DesSKU { get; set; }
        [StringLength(20)]
        public string IdGrupoSKU { get; set; }
        public zt_cat_grupos_sku zt_cat_grupos_sku { get; set; }
        [StringLength(10)]
        public string IdUMedidaBase { get; set; }
        public zt_cat_unidad_medidas zt_cat_unidad_medidas { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }

    public class zt_cat_productos_medidas {
        [StringLength(20)]
        public string IdSKU { get; set; }
        public zt_cat_productos zt_cat_productos { get; set; }
        [StringLength(10)]
        public string IdUMedidaBase { get; set; }
        public zt_cat_unidad_medidas zt_cat_unidad_medidas { get; set; }
        public float CantidadPZA { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }

    public class zt_cat_ubicaciones {
        [StringLength(20)]
        public string IdUbicacion { get; set; }
        [StringLength(50)]
        public string DesUbicacion { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    } 

    public class zt_almacenes_ubicaciones {
        [StringLength(20)]
        public string IdAlmacen { get; set; }
        public zt_cat_almacenes zt_cat_almacenes { get; set; }
        [StringLength(20)]
        public string IdUbicacion { get; set; }
        public zt_cat_ubicaciones zt_cat_ubicaciones { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
    } 

    public class zt_cat_estatus {
        [StringLength(20)]
        public string IdEstatus { get; set; }
        [StringLength(50)]
        public string DesEstatus { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
    } 

    public class zt_inventarios {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdInventario { get; set; }
        public Int16 IdCEDI { get; set; }
        public zt_cat_cedis zt_cat_cedis { get; set; }
        [StringLength(20)]
        public string IdAlmacen { get; set; }
        public zt_cat_almacenes zt_cat_almacenes { get; set; }
        [StringLength(20)]
        public string IdEstatus { get; set; }
        public zt_cat_estatus zt_cat_estatus { get; set; }
        [StringLength(20)]
        public string IdInventarioSAP { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    } 

    public class zt_inventarios_acumulados {
        public int IdInventario { get; set; }
        public zt_inventarios zt_inventarios { get; set; }
        [StringLength(20)]
        public string IdSKU { get; set; }
        public zt_cat_productos zt_cat_productos { get; set; }
        [StringLength(10)]
        public string IdUnidadMedida { get; set; }
        public zt_cat_unidad_medidas zt_cat_unidad_medidas { get; set; }
        public float CantadadTeorica { get; set; }
        public float CantidadTeoricaCJA { get; set; }
        public float CantidadFisica { get; set; }
        public float Diferencia { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }

    public class zt_inventarios_conteos {
        public int IdInventario { get; set; }
        public zt_inventarios zt_inventarios { get; set; }
        [StringLength(20)]
        public string IdSKU { get; set; }
        public zt_cat_productos zt_cat_productos { get; set; }
        [StringLength(10)]
        public string IdUnidadMedida { get; set; }
        public zt_cat_unidad_medidas zt_cat_unidad_medidas { get; set; }
        [StringLength(20)]
        public string IdAlmacen { get; set; }
        public zt_cat_almacenes zt_cat_almacenes { get; set; }
        [StringLength(20)]
        public string IdUbicacion { get; set; }
        public zt_cat_ubicaciones zt_cat_ubicaciones { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumConteo { get; set; } 
        [StringLength(20)]
        public string CodigoBarras { get; set; }
        public float CantidadFisica { get; set; }
        public float CantidadPZA { get; set; }
        [StringLength(30)]
        public string Lote { get; set; }
        public DateTime FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }

}
