using ProyectoBitsBites.Models.TableViewModel;
using ProyectoBitsBites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBitsBites.Controllers
{
    public class CarritoController : Controller
    {
        private RestauranteBitsBitesEntities1 db = new RestauranteBitsBitesEntities1();

        public ActionResult Carrito()
        {
            // Obtener los datos de las tablas Pedidos y DetallesPedido
            List<Pedidos> pedidos = db.Pedidos.ToList();
            List<DetallesPedido> detalles = db.DetallesPedido.ToList();

            // Combinar los datos de las tablas Pedidos y DetallesPedido en objetos CarritoItem
            List<CarritoItem> carritoItems = new List<CarritoItem>();

            foreach (var pedido in pedidos)
            {
                var detalle = detalles.FirstOrDefault(d => d.id_pedido == pedido.id_pedido);

                if (detalle != null)
                {
                    var carritoItem = new CarritoItem
                    {
                        ID_Pedido = pedido.id_pedido,
                        ID_Cliente = pedido.id_cliente,
                        Fecha_Pedido = pedido.fecha_pedido,
                        Estado_Pedido = pedido.estado_pedido,
                        ID_Detalle = detalle.id_detalle,
                        ID_Producto = detalle.id_producto,
                        Cantidad = detalle.cantidad,
                        Precio = detalle.subtotal
                    };

                    carritoItems.Add(carritoItem);
                }
            }

            // Pasar la lista de objetos CarritoItem a la vista
            return View(carritoItems);
        }

        public ActionResult AgregarAlCarrito(int id)
        {
            // Lógica para agregar un producto al carrito

            // ... 


            // Actualizar el contador del carrito en el ViewBag
            ViewBag.CartCount = ObtenerContadorDelCarrito();

            // Redirigir al usuario a la página de productos
            return RedirectToAction("ProductHamburguesas", "Product");
        }

        public ActionResult EliminarDelCarrito(int id)
        {
            // Lógica para eliminar un producto del carrito
            // ...

            // Actualizar el contador del carrito en el ViewBag
            ViewBag.CartCount = ObtenerContadorDelCarrito();

            // Redirigir al usuario a la página del carrito
            return RedirectToAction("Carrito");
        }

        private int ObtenerContadorDelCarrito()
        {
            // Lógica para obtener el número de elementos en el carrito
            // ...

            // Aquí devolvemos un valor de ejemplo, reemplázalo con la lógica real
            return 0;
        }
    }
}
