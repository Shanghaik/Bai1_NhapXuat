using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4_Tinhchat
{
    // Kế thừa lớp trừu tượng cũng tương tự như các lớp bình thường
    // nhưng phải thực hiện implement (làm rõ cho các phương thức
    // trừu tượng)
    internal class CaMap : Ca
    {
        public override void Boi()
        {
            Console.WriteLine("Cá mập bơi ở biển");
        }
    }
}
