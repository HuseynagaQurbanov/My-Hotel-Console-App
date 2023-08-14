using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Room
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string RoomType { get; set; }
        public Customer Customer { get; set; }
    }
}
