using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearit.Dto.Request;

public class DtoPlayList
{
    public int UsuarioId { get; set; }

    public int CancionId { get; set; }

    public string Titulo { get; set; }

    public string Descripcion { get; set; }
}

