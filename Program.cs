using System;
using System.Collections.Generic;



namespace TheBank
{
    class Program
    {
        static void Main(string[] args)
        {   


            List<User> initList = new List<User>();

            initList.Add(new User());

            TheBank MyBank = new TheBank() {UserList = initList};
            
        }
    }
}
