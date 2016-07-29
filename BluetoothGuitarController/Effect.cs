using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluetoothGuitarController
{
    class Effect
    {
        // Constructors
        public Effect()
        {
            name = "default";
            controls = new List<EffectControl>();
            volume = new string[] { "0", "0", "0" };
        }
        public Effect(string nm)
        {
            name = nm;
            controls = new List<EffectControl>();
            volume = new string[] { "0", "0", "0" };
        }
        // Methods

        // Variables
        public string name;
        public List<EffectControl> controls;
        public string[] volume;
    }
}
