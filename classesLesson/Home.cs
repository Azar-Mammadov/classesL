using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace classesLesson
{
    class Home
    {
        public int otaq_say ;
        byte mertebe_say ;
        public string unvan ;
        public string telefon ;
        public string sheher;
        public string method()
        {
            return $"{unvan}{telefon}{sheher}";
        }
    }
   
}
