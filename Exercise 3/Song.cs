using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Song
    {
        private String typeList;
        private String name;
        private String time;

        public Song()
        {
        }

        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get => typeList; set => typeList = value; }
        public string Name { get => name; set => name = value; }
        public string Time { get => time; set => time = value; }
    }
}
