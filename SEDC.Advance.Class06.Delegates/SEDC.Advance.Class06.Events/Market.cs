
namespace SEDC.Advance.Class06.Events
{
    public class Market
    {
        public delegate void PromotionSender(ProductType productType, string name);

        event PromotionSender PromotionSenderEvent;

        public ProductType CurrentProductType { get; set; }

        public List<string> Emails { get; set; }
        public string Name { get; set; }


       public Market()
        {
            Emails = new List<string>();    
        }
        
        
        public void SubscribeToPromotion(PromotionSender eventHendler, string email)
        {
            PromotionSenderEvent += eventHendler;
           //int i = 0;
            //i = i + 1;
            //i += 2;
        }
        public void Send()
        {
            PromotionSenderEvent(CurrentProductType, Name);
        }

        public void Unsubscribe (PromotionSender eventHandler, string email)
        {
            PromotionSenderEvent -= eventHandler;
            string emailToDelete = Emails.FirstOrDefault(x => x == email);
            Emails.Remove(emailToDelete);
        }

    }
    public enum ProductType
    {
        Food,
        Cosmetics,
        Electronics,
        Other
    }


}
