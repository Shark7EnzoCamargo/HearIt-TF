﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearit.Dto.Request;

public class DtoVideo
{
    public int ArtistaId { get; set; }

    public string Titulo { get; set; }

    public string Descripcion { get; set; }

    public string? VideoURL { get; set; }
}

