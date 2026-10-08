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

        public static List<BorrowRequest> GetAllRequests()
        {
            return requests;
        }
    }
}