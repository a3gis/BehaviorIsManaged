

// Generated on 09/23/2012 21:40:24
using System;
using System.Collections.Generic;
using BiM.Protocol.Tools;

namespace BiM.Protocol.Data
{
    [D2OClass("Title")]
    public class Title : IDataObject
    {
        private const String MODULE = "Titles";
        public int id;
        public uint nameId;
        public String color;
    }
}