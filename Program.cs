using System;

namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Use Case #7: No Duplicate Entries in Address Book");
            Console.WriteLine("Use Case #8: Search Persons in City or State in Address Books");

            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 7:
                    MultipleAddressBooks multipleAddressBooks = new MultipleAddressBooks();
                    //adding first address book
                    multipleAddressBooks.AddAddressBook();
                    //adding two contacts in first address book
                    multipleAddressBooks.AddContact();
                    multipleAddressBooks.AddContact();  //if this second contact has the same name as first contact, we encounter runtime error
                    multipleAddressBooks.Display();
                    break;
                case 8:
                    MultipleAddressBooks multipleAddressBooksTwo = new MultipleAddressBooks();
                    //adding address books
                    multipleAddressBooksTwo.AddAddressBook();
                    multipleAddressBooksTwo.AddAddressBook();
                    //adding contacts to above addressbooks
                    multipleAddressBooksTwo.AddContact();
                    multipleAddressBooksTwo.AddContact();
                    multipleAddressBooksTwo.AddContact();
                    multipleAddressBooksTwo.AddContact();
                    multipleAddressBooksTwo.AddContact();
                    multipleAddressBooksTwo.Display();
                    //applying the search method
                    multipleAddressBooksTwo.SearchByCityOrState();
                    break;
                case 9:
                    MultipleAddressBooks multipleAddressBooks = new MultipleAddressBooks();
                    //adding multiple address books
                    multipleAddressBooks.AddAddressBook();
                    multipleAddressBooks.AddAddressBook();
                    //adding contacts to above address books
                    multipleAddressBooks.AddContact();
                    multipleAddressBooks.AddContact();
                    multipleAddressBooks.AddContact();
                    multipleAddressBooks.AddContact();
                    multipleAddressBooks.AddContact();
                    multipleAddressBooks.Display();
                    //maintaining city to person map
                    multipleAddressBooks.MaintainCityAndPersonMap();
                    multipleAddressBooks.DisplayByCity();
                    //maintaining state to person map
                    multipleAddressBooks.MaintainStateAndPersonMap();
                    multipleAddressBooks.DisplayByState();
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }


        }
    }
}