using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class GameState
{
    public static State state = new State();

    public static State export()
    {
        return state;
    }

    public static void import(State _state)
    {
        state = _state;

    }

    public class State
    {
        public int supply { get; set; }
        public int demand { get; set; }

        public int supplyDelta { get; set; }
        public int demandDelta { get; set; }

		public int _cena;
		public float cena {
			get {return (float)_cena / 100.0f;}
			set{ _cena = (int)value * 100; }
		}

		public int _premozenje;
		public float premozenje {
	
			get { return (float)_premozenje / 100.0f;}
			set{ _premozenje = (int)value * 100; }
		}

		public int daysLeft;
        public State()
        {
            demand = 1500;
            supply = 1500;
			_cena = 100;
			_premozenje = 10000;
			daysLeft = 100;
        }

    }
}
