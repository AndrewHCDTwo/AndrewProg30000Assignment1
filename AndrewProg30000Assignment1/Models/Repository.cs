namespace AndrewProg30000Assignment1.Models
{
    public static class Repository
    {
        private static List<BorrowRequest> requests = new List<BorrowRequest>();
        private static int nextId = 1; // static counter for auto-incrementing Ids

        public static void AddRequest(BorrowRequest request)
        {
            request.Id = nextId;
            nextId++;
            requests.Add(request);
        }
        
        // have some as not avabile so i can visually see it already 
        public static List<Equipment> EquipmentList = new List<Equipment>()
        {
            new Equipment { Id = 1, Type = EquipmentType.Laptop, Description = "Macbook", IsAvailable = true },
            new Equipment { Id = 2, Type = EquipmentType.Laptop, Description = "Dell Laptop", IsAvailable = false },
            new Equipment { Id = 3, Type = EquipmentType.Phone, Description = "Samsung phone", IsAvailable = true },
            new Equipment { Id = 4, Type = EquipmentType.Phone, Description = "Iphone", IsAvailable = false },
            new Equipment { Id = 5, Type = EquipmentType.Tablet, Description = "ipad", IsAvailable = true },
            new Equipment { Id = 6, Type = EquipmentType.Tablet, Description = "samsung tablet", IsAvailable = true },
            new Equipment { Id = 7, Type = EquipmentType.Another, Description = "headphones", IsAvailable = false },
            new Equipment { Id = 8, Type = EquipmentType.Another, Description = "microphone", IsAvailable = true }
        };
        
        public static List<BorrowRequest> GetAllRequests()
        {
            return requests;
        }
    }
}