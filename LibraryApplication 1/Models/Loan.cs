using MongoDB.Bson;

namespace LibraryApplication_1.Models
{
    public class Loan
    {
        public ObjectId Id { get; set; }
        public string BookId { get; set; }
        public string UserId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
