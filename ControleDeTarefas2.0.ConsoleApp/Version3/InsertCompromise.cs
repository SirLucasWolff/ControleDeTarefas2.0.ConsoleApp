using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version3
{
    public class InsertCompromise
    {
        public string id;

        public string Subject { get; set; }
        public string Spot { get; set; }
        public DateTime CompromiseDate { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
        public string KindCompromise { get; set; }
        public List<String> GetId = new List<string>();
    }
}
