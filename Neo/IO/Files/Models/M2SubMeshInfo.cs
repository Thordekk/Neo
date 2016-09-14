﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;

namespace Neo.IO.Files.Models
{
    internal class M2SubMeshInfo
    {
        public int StartIndex { get; set; }
        public int NumIndices { get; set; }
        public BoundingSphere BoundingSphere;
    }
}
