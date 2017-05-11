using System;
using System.Collections.Generic;
using System.Linq;

namespace WcfServiceLibrary5
{
    public class BetService : IBetService
    {
        public List<double> CalculateSin(double[] x)
        {
            return x.Select(p => Math.Sin(p)).ToList();
        }

        public string GetValue(int i)
        {
            return $"You have sent {i}.";
        }

        public List<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person
                {
                    Name = "John Smith",
                    Age = 45
                },

                new Person
                {
                    Name = "Jane Doe",
                    Age = 29
                }
            };
        }
    }
}