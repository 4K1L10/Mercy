using System;
using System.Collections.Generic;

namespace Mercy.Models;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string? Nombre { get; set; }

    public int? Precio { get; set; }

    public string? Sku { get; set; }

    public int? IdUsuario { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
