using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeTarefas2._0.ConsoleApp.Version1
{
    public class InsertTask
    {
        internal string id;

        public string NameOfTask { get; set; }
        public DateTime ConclusionDate { get; set; }
        public string ImportanceLevel { get; set; }
        public int ConclusionPercent { get; set; }
    }
}
