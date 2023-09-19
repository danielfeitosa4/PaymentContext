using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.Commands
{
    public class CreatePayPalSubscriptionCommand
    {
        public CreatePayPalSubscriptionCommand(string firstName, string lastName, string document, string email, string transactionCode, string paymentNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string payerDocument, EDocumentType payerDocumentType, string payerEmail, string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            TransactionCode = transactionCode;
            PaymentNumber = paymentNumber;
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            PayerDocument = payerDocument;
            PayerDocumentType = payerDocumentType;
            PayerEmail = payerEmail;
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string TransactionCode { get; set; }
        public string PaymentNumber { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public string PayerDocument { get; set; }
        public EDocumentType PayerDocumentType { get; set; }
        public string PayerEmail { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}