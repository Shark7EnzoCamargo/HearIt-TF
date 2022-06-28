using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearit.Dto.Request;

public class DtoCalificacion
{
    public int UsuarioId { get; set; }

    public int ArtistaId { get; set; }

    public int Puntuacion { get; set; }

    public string Comentario { get; set; }
}

