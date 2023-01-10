using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichEditControlMailMergeSample
{
    internal class DataHelper
    {
        public static List<DummyRecord> DummyRecords()
        {
            return new List<DummyRecord>()
            {
                new DummyRecord
                {
                    FirstName = "SomeFirstName",
                    LastName = "SomeLastName",
                    CreatedAt = new DateTime(2022, 12, 30, 23,59,59), //Some date time
                    Count = 10 // some int value
                }
            };
        }
    }
}