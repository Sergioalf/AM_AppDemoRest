using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppDemoRest.Data;
using AppDemoRest.Models;

namespace AppDemoRest.Controllers
{
    [Produces("application/json")]
    public class FicApiInventariosController : Controller
    {

        private readonly FicDBContext FicLoDBContext;

        public FicApiInventariosController(FicDBContext ficPaDBContext) {
            FicLoDBContext = ficPaDBContext;
        }
        // GET: api/FicApiInventarios
        [HttpGet]
        [Route("api/inventarios/invacucon")]
        public async Task<IActionResult> FicApiGetListInventarios([FromQuery]int cedi)
        {
            var zt_inventarios = (from data_inv in FicLoDBContext.zt_inventarios where data_inv.IdCEDI == cedi select data_inv).ToList();
            if (zt_inventarios.Count() > 0)
            {
                zt_inventarios = zt_inventarios.ToList();
                return Ok(zt_inventarios);
            }
            else
            {
                zt_inventarios = zt_inventarios.ToList();
                return Ok(zt_inventarios);
            }
        }

        //GET: api/FicApiInventarios/5
        [HttpGet]
        [Route("api/inventarios/todos")]
        public async Task<IActionResult> FicApiGetListInventarios()
        {
            var zt_inventarios = (from data_inv in FicLoDBContext.zt_inventarios select data_inv).ToList();
            if (zt_inventarios.Count() > 0)
            {
                zt_inventarios = zt_inventarios.ToList();
                return Ok(zt_inventarios);
            }
            else
            {
                zt_inventarios = zt_inventarios.ToList();
                return Ok(zt_inventarios);
            }
        }
        
        // POST: api/FicApiInventarios
        [HttpPost]
        [Route("api/inventarios/insertar")]
        public async Task<IActionResult> FicApiPostInventario([FromForm] int id, [FromForm]short cedi, [FromForm]String almacen, [FromForm]String estatus, [FromForm]string sap, [FromForm] DateTime fecha, [FromForm] string user)
        {
            zt_inventarios inventario = new zt_inventarios();
            inventario.IdInventario = id;
            inventario.IdCEDI = cedi;
            inventario.IdAlmacen = almacen;
            inventario.IdEstatus = estatus;
            inventario.IdInventarioSAP = sap;
            inventario.FechaReg = fecha;
            inventario.UsuarioReg = user;
            inventario.Activo = "S";
            inventario.Borrado = "N";
            FicLoDBContext.zt_inventarios.Add(inventario);
            FicLoDBContext.SaveChanges();
            return Ok(inventario);

        }

        // PUT: api/FicApiInventarios/5
        [HttpPut]
        [Route("/api/inventarios/actualizar")]
        public async Task<IActionResult> FicApiUpdateInventario([FromForm] int id, [FromForm]short cedi, [FromForm]String almacen, [FromForm]String estatus, [FromForm]string sap, [FromForm]string act, [FromForm]string bor,[FromForm] DateTime fecha, [FromForm] string user)
        {
            try
            {
                var inventario = FicLoDBContext.zt_inventarios.First(a => a.IdInventario == id);
                inventario.IdInventario = id;
                inventario.IdCEDI = cedi;
                inventario.IdAlmacen = almacen;
                inventario.IdEstatus = estatus;
                inventario.IdInventarioSAP = sap;
                inventario.Activo = act;
                inventario.Borrado = bor;
                inventario.FechaUltMod = fecha;
                inventario.UsuarioMod = user;
                FicLoDBContext.SaveChanges();
                return Ok(inventario);
            }
            catch (Exception e)
            {
                Dictionary<String, String> err = new Dictionary<string, string>();
                err.Add("err", "No se encontraron registros");
                return Ok(err);
            }

        }
        [HttpDelete]
        [Route("/api/inventarios/eliminar")]
        public async Task<IActionResult> FicApiDeleteInventario([FromQuery] int id)
        {
            zt_inventarios inventario = new zt_inventarios();
            inventario.IdInventario = id;
            try
            {
                FicLoDBContext.zt_inventarios.Remove(inventario);
                FicLoDBContext.SaveChanges();
                return Ok(inventario);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException e)
            {
                Dictionary<String, String> err = new Dictionary<string, string>();
                err.Add("err", "No se encontraron registros");
                return Ok(err);
            }
        }
    }
}
