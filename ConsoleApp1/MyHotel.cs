using System;

namespace ConsoleApp1
{
    class MyHotel
    {
        public MyHotel(int count)
        {
            rooms = new Room[count];
            CreateRooms();
            ShowRooms();
        }
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string PhoneNumber { get; set; }
        public string Stars { get; set; }
        public string Location { get; set; }
        public int RoomCount { get; set; }
        public Room[] rooms { get; set; }

        public void CreateRooms()
        {
            int roomId = 1;

            for (int i = 0; i < rooms.Length; i++)
            {
                Room room = null;
                if (i <= 1)
                {
                    room = new Room
                    {
                        Status = false,
                        RoomType = "VIP",
                        Id = roomId
                    };
                }
                else
                {
                    room = new Room
                    {
                        Status = false,
                        RoomType = "standart",
                        Id = roomId
                    };
                }

                rooms[i] = room;
                roomId++;
            }
        }

        public void ShowRooms()
        {
            foreach (var item in rooms)
            {
                string res = item.Status == false ? "Bos" : "Dolu";
                Console.WriteLine($"Otaq Nomresi: {item.Id}; Otaq Statusu: {res}; Otaq Tipi: {item.RoomType}");
            }
        }

        public void SetUser(int roomId, Customer customer, string roomType)
        {
            Room room = null;
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i].Id == roomId)
                {
                    room = rooms[i];
                    room.Customer = customer;
                    if (room.RoomType.ToLower() == roomType.ToLower())
                    {
                        room.Status = true;
                        break;
                    }
                    
                }
            }

            ShowRooms();
        }
    }
}
