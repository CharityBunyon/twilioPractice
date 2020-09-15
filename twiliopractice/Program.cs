using System;
using System.Linq;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace twiliopractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            // DANGER! This is insecure. See http://twil.io/secure
            const string accountSid = "AC6072ff9abad24ebeece0827cc00664f5";
            const string authToken = "";

            TwilioClient.Init(accountSid, authToken);
            var mediaUrl = new[] {
                new Uri("https://pbs.twimg.com/profile_images/679818776670371840/h4PrZuJd.png")
            }.ToList(); // using Linq to convert it to a linq object

            var message = MessageResource.Create(
                body: "Sending an image.",
                from: new Twilio.Types.PhoneNumber("+12095800301"),
                mediaUrl: mediaUrl,
                to: new Twilio.Types.PhoneNumber("+16159676153")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
