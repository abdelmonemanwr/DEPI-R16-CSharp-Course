using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIII.USES_A
{
    internal class OrderService
    {
        public void CreateOrder(EmailService emailService)
        {
            // create order
            // store in db
            // fetch user details (email, name)
            // Body, subject
            
            string emailDetails = $@"
                Subject: Order complete! Start learning now.
                Body: Dear Men3m,
                        Your order’s been processed
                        You’re all set to start learning. Ready to jump in?
                Best Regards
                DEPI Team
            ";

            emailService.Send(emailDetails);
        }
    }
}
