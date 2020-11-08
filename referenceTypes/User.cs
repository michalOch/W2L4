using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace referenceTypes
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Addres { get; set; }
        public long PhoneNumber { get; set; }
        public string Email  { get; set; }
        public decimal MonthlyEarnings { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            return $"\r\n{FirstName} {LastName} \r\nurodzony: {BirthDay.ToShortDateString()} \r\nAdres zamieszkania: {Addres} \r\nTel: {PhoneNumber} \r\nEmail: {Email} \r\nWzrost: {Height}, Waga:  {Weight} \r\nŚrednie miesięczne zarobki: {MonthlyEarnings} zł(brutto)";
        }
    }
}
