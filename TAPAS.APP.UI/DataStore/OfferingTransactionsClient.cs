using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAPAS.APP.UI.DataStore
{
    //public abstract class OfferOrder
    //{

    //    public string OfferName { get; set; }
    //    public bool IsRecurring { get; set; }
    //    public int RecurringInstance { get; set; }
    //    public string RecurringInstruction { get; set; }
    //}

    //public class BasicOfferOrder: OfferOrder
    //{
    //    public string Name { get; set; }
    //    public string Star { get; set; }
    //}
    public class StandardOfferOrder 
    {
        public string Name { get; set; }
        public string Star { get; set; }
        public int Rate { get; set; }
        public int Quantity { get; set; }
        public DateTime BillDate { get; set; }
        public int TotalAmount { get; set; }
        public int PaidAmount { get; set; }
        public int PendingAmount { get; set; }
        public int Advance { get; set; }
        public string OfferName { get; set; }
        public bool IsRecurring { get; set; }
        public int RecurringInstance { get; set; }
        public string RecurringInstruction { get; set; }
    }
    public class OfferingTransactionDetail
    {
        public string TransactionId { get; set; }

        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public List<StandardOfferOrder> OrderDetail { get; set; }

    }
    public class OfferingTransactionsClient
    {
    }
}
