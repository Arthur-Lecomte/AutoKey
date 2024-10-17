using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKey {
    public class MainWindowVM : NotifyPropertyChanged {
        private List<DataGridSuiteTouche> listeSuiteTouche;
        public List<DataGridSuiteTouche> ListeSuiteTouche {
            get {
                //Argument de la fonction a modifié
                return listeSuiteTouche is null ? GetSuiteTouchesAsDG(new List<SuiteTouche>()) : listeSuiteTouche;
            }
            set {
                listeSuiteTouche = value;
                RaisePropertyChanged("ListeSuiteTouche");
            }
        }

        public List<DataGridSuiteTouche> GetSuiteTouchesAsDG(List<SuiteTouche> listeSuiteTouche) {
            List<DataGridSuiteTouche> listeSuiteToucheDG = new List<DataGridSuiteTouche>();
            foreach (SuiteTouche suiteTouche in listeSuiteTouche) {
                DataGridSuiteTouche dgSuiteTouche = new DataGridSuiteTouche();
                dgSuiteTouche.Nom = suiteTouche.Nom;
                dgSuiteTouche.DateModif = suiteTouche.DateModification.ToString();
                dgSuiteTouche.NombreTouche = suiteTouche.ListeAction is null ? 0 : suiteTouche.ListeAction.Count;
                listeSuiteToucheDG.Add(dgSuiteTouche);
            }
            return listeSuiteToucheDG;
        }
    }

    public class DataGridSuiteTouche {
        public string Nom { get; set; }
        public string DateModif { get; set; }
        public int NombreTouche { get; set; }
    }
}
