using System;
using System.Collections.Generic;
using System.Text;

namespace CesJarvis.Models.Response
{
    public class ResponseBody
    {
        public string speech { get; set; }
        public string displayText { get; set; }
        public Payload data { get; set; }
        public object[] contextOut { get; set; }
        public string source { get; set; }
    }

    public class Payload
    {
    }
}
