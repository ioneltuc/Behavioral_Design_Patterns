namespace TMPS_lab3.Observer
{
    public class SmsMessage : ISubscriber
    {
        public string Update(Order order)
        {
            string message = "Aviz: In adresa DVS a parvenit o trimitere postala simpla.\n" +
                "Va invitam sa o ridicati din oficiul postal cu document de legitimare.";

            Console.WriteLine($"=== SMS message ===\n{message}");

            return message;
        }
    }
}