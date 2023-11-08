using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.Services
{
    public class CalculadoraImp
    {
        private List<string> _historic;
        private string _data;
        public CalculadoraImp()
        {
            _historic = new List<string>();
            _data = DateTime.Now.ToShortDateString();
        }

        public void HistoricoM(int resultado)
        {
            _historic.Insert(0,"Res "+ resultado +" "+ _data);
        }
        public int Somar(int val1, int val2)
        {
            var res = val1 + val2;
            HistoricoM(res);
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
          var res = val1 - val2;
          HistoricoM(res);
            return res;
        }
        public int Multiplicar(int val1, int val2)
        {
            var res = val1 * val2;
            HistoricoM(res);
            return res;;
        }
        public int Dividir(int val1, int val2)
        {
             var res = val1 / val2;
             HistoricoM(res);
            return res;
        }

        public List<string> HistoricoCalc()
        {
            _historic.RemoveRange(3, _historic.Count - 3);
            return _historic;
        }
    }
}