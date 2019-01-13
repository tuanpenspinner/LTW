using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuanLyLapTop
{
    public class Laptop
    {
        public int IDLaptop { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Funtion { get; set; }
        public int Cost { get; set; }
        public string Hard { get; set; }
        public int Ram { get; set; }
        public int Memory { get; set; }
        public float Desktop { get; set; }
        public string Species { get; set; }
        public string Card { get; set; }
        public string CPU { get; set; }
        public string Resolution { get; set; }
        public double Weight { get; set; }
        public int Number { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return "CPU: " + CPU + "\n" + "Ram:" + Ram + "GB \n" + "Ổ cứng: " + Hard + "\n" + "Dung lượng ổ cứng: " + Memory + " GB\n"+"Khích thước màn hình: "+Desktop+" inch\n"+
                "Card đồ họa:"+Card+","+Species+"\n"+"Độ phân giải: "+Resolution+"\n"+"Trọng lượng: "+Weight+"KG";
        }

    }
}
