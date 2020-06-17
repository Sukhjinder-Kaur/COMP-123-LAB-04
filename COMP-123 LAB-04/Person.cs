using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_LAB_04
{
    class Person
    {//PRIVATE INSTANCE VARIABLE
        private string m_name;
        private UInt16 m_age;

        //PUBLIC PROPERTIES
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        public UInt16 Age
        {
            get
            {
                return m_age;
            }
            set
            {
                m_age = value;
            }
        }
        //CONSTRUCTORS
        public Person(string name, UInt16 age)
        {
            m_name = name;
            m_age = age;
        }
        //PRIVATE METHODS
        //PUBLIC METHODS
        public void SayHello()
        {
            Console.WriteLine($"{Name} says hello!");
        }
    }
}