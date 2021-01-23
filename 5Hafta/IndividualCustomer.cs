using System;
using System.Collections.Generic;
using System.Text;

namespace _5Hafta
{
    //Customer nesnesinden miras alır ve müşteri sınıfının özelliklerini taşır. 
    class IndividualCustomer:Customer
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerIdentityNumber { get; set; }

    }
}
