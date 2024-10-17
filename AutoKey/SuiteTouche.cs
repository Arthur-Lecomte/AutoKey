using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKey {
    public class SuiteTouche {
        public string Nom { get; set; }
        public DateTime DateModification { get; set; }
        public List<Action> ListeAction { get; set; }
    }
}
