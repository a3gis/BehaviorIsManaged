

// Generated on 09/23/2012 21:40:19
using System;
using System.Collections.Generic;
using BiM.Protocol.Tools;

namespace BiM.Protocol.Data
{
    [D2OClass("AlmanaxCalendar")]
    public class AlmanaxCalendar : IDataObject
    {
        private const String MODULE = "AlmanaxCalendars";
        public int id;
        public uint nameId;
        public uint descId;
        public int npcId;
    }
}