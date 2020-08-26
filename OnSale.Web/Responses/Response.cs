using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Responses
{
   

        public class Response
        {
            public bool IsSuccess { get; set; }

            public string Message { get; set; }

            public object Result { get; set; }
        }
    
}
