﻿using System;
using System.Collections.Generic;
using System.Text;

namespace exceptionsProject
{

    class Person
    {
        private int age;
        public int Age
        {
            get
            {

                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("An age can't be negative", "Age");
                }
                if (value == 2 || value > 80)
                {
                    throw new DressCodeException();
                }

                age = value;

            }
        }

        public Person(int age)
        {
            this.Age = age;
        }
    }
}
