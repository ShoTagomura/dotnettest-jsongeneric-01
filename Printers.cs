using System;
using System.Collections.Generic;

namespace iotest02
{
    public class Printers
    {
        public string Id { get; set; }
        public string Branch { get; set; }
        public List<PList> Plist { get; set; }
    }

    public class PList
    {
        public string Num { get; set; }
        public string Name { get; set; }
    }
}