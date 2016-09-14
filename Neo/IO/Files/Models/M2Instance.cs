﻿using Neo.Scene.Models.M2;

namespace Neo.IO.Files.Models
{
    class M2Instance
    {
        public int Hash { get; set; }
        public int Uuid { get; set; }
        public BoundingBox BoundingBox { get; set; }
        public M2RenderInstance RenderInstance { get; set; }
        public int MddfIndex { get; set; }
    }
}