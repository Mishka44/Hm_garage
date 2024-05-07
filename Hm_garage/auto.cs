using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Hm_garage
{
    public class auto
    {
        protected static int counter = 1000;
        
        public static int Counter { get { return counter; } }
        private int id;
        private string name;
        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public auto(string name_)
        {
            name = name_;
            id = ++counter;
        }

    }
    public class Porshe : auto
    {
        public Porshe(string name_ = "Porsche") : base(name_)
        {
            
        }
        

    }

    public class bmw : auto
    {
        public bmw(string name_ = "bmw") : base(name_)
        {

        }


    }

    public class Mercedes : auto
    {
        public Mercedes(string name_ = "mercedes") : base(name_)
        {

        }


    }

    public class turbo_911 : Porshe
    {
        public string model = "911 Turbo";
        protected int hp = 650;
        public string Model { get { return model; } }
        public int Hp { get { return hp; } private set { hp = value; }}
        
    }


    public class C_63 : Mercedes
    {
        public string model = "C class 63 AMG";
        protected int hp = 620;
        public string Model { get { return model; } }
        public int Hp { get { return hp; }  set { hp = value; } }

        public void Tune (int boost)
        {
            Hp = Hp+boost;
        }
    }
    public class m_5 : bmw
    {
        public string model = "M-5 F90";
        protected int hp = 625;
        public string Model { get { return model; } }
        public int Hp { get { return hp; } set { hp = value; } }

        public void Tune(int boost)
        {
            Hp = Hp + boost;
        }
    }




}
