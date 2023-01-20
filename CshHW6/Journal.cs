using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW6
{
    internal class Journal
    {
        private string _name;
        private int _year;
        private string _discription;
        private long _phoneNumber;
        private string _email;
        private int _numberOfWorkers;



        public Journal(string name)
        {
            _name = name;
        }

        public void ChangeName(string name)
        {
            _name = name;
        }
        public void SetYear(int year)
        {
            _year = year;
        }
        public void SetDiscripion(string discription)
        {
            _discription = discription;
        }
        public void SetPhoneNumber(long phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }

        public void ShowJournalInfo()
        {
            Console.WriteLine($"The information about Journal {_name}");
            Console.WriteLine($"The Journal {_name} was founded in {_year}, if you want " +
                $"to contact us, please use this phone number {_phoneNumber} or e-mail: {_email}");
            Console.WriteLine($"Discription: {_discription}");
        }

        //task 1

        public void SetCountOfWorkers(int num)
        {
            _numberOfWorkers = num;
        }

        public void ShowCountOfWorkers()
        {
            Console.WriteLine($"number of workers in Journal {_name} is {_numberOfWorkers}");
        }

        public static bool operator ==(Journal j1, Journal j2)
        {
            if (j1._numberOfWorkers == j2._numberOfWorkers)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Journal j1, Journal j2)
        {
            if (j1._numberOfWorkers != j2._numberOfWorkers)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Journal j1, Journal j2)
        {
            return j1._numberOfWorkers > j2._numberOfWorkers;
        }

        public static bool operator <(Journal j1, Journal j2)
        {
            return j1._numberOfWorkers < j2._numberOfWorkers;
        }

        public override bool Equals(object otherJournal)
        {
            if (!(otherJournal is Journal)) return false;
            return this == (Journal)otherJournal;
        }

        public static Journal operator +(Journal j, int num)
        {
            j._numberOfWorkers += num;
            return j;
        }

        public override string ToString()
        {
            return _name;
        }

    }
}
