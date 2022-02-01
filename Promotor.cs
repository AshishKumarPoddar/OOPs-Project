using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Promotor
    {
        private string _firstName;
        private string _lastName;
        public string BusinessCard
        {
            get
            {
                return String.Format("{0} {1} {3}.", this._firstName, this._lastName,this._phone);
            }
        }

        private long _phone;
        public Promotor(string firstName, string lastName,long phone)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._phone = phone;

        }
        public  void promote()
        {
            this.ShareWithInnerCircle();
            this.PaidAds();

        }

        protected abstract void ShareWithInnerCircle();
        protected abstract void PaidAds();


    }


}
