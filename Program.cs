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
                    MultipleAddressBooks multipleAddressBooksThree = new MultipleAddressBooks();
                    //adding multiple address books
                    multipleAddressBooksThree.AddAddressBook();
                    multipleAddressBooksThree.AddAddressBook();
                    //adding contacts to above address books
                    multipleAddressBooksThree.AddContact();
                    multipleAddressBooksThree.AddContact();
                    multipleAddressBooksThree.AddContact();
                    multipleAddressBooksThree.AddContact();
                    multipleAddressBooksThree.AddContact();
                    multipleAddressBooksThree.Display();
                    //maintaining city to person map
                    multipleAddressBooksThree.MaintainCityAndPersonMap();
                    multipleAddressBooksThree.DisplayByCity();
                    //maintaining state to person map
                    multipleAddressBooksThree.MaintainStateAndPersonMap();
                    multipleAddressBooksThree.DisplayByState();
                    break;
                case 10:
                    MultipleAddressBooks multipleAddressBooksFour = new MultipleAddressBooks();
                    //adding multiple address books
                    multipleAddressBooksFour.AddAddressBook();
                    multipleAddressBooksFour.AddAddressBook();
                    //adding contacts to above address books
                    multipleAddressBooksFour.AddContact();
                    multipleAddressBooksFour.AddContact();
                    multipleAddressBooksFour.AddContact();
                    multipleAddressBooksFour.AddContact();
                    multipleAddressBooksFour.AddContact();
                    multipleAddressBooksFour.Display();
                    //maintaining city to person map
                    multipleAddressBooksFour.MaintainCityAndPersonMap();
                    multipleAddressBooksFour.DisplayByCity();
                    //maintaining state to person map
                    multipleAddressBooksFour.MaintainStateAndPersonMap();
                    multipleAddressBooksFour.DisplayByState();
                    //counting by city and state
                    multipleAddressBooksFour.CountByCity();
                    multipleAddressBooksFour.CountByState();
                    break;
                case 11:
                    MultipleAddressBooks multipleAddressBooksFive = new MultipleAddressBooks();
                    //adding address books
                    multipleAddressBooksFive.AddAddressBook();
                    multipleAddressBooksFive.AddAddressBook();
                    //adding contacts
                    multipleAddressBooksFive.AddContact();
                    multipleAddressBooksFive.AddContact();
                    multipleAddressBooksFive.AddContact();
                    multipleAddressBooksFive.AddContact();
                    multipleAddressBooksFive.AddContact();
                    //sorting contacts in address books by comparing full name
                    multipleAddressBooksFive.SortContactsInAddressBookByComparingFullName();
                    break;
                case 12:
                    MultipleAddressBooks multipleAddressBooksSix = new MultipleAddressBooks();
                    //adding address books
                    multipleAddressBooksSix.addAddressBook();
                    multipleAddressBooksSix.addAddressBook();
                    //adding contacts to above address books
                    multipleAddressBooksSix.addContact();
                    multipleAddressBooksSix.addContact();
                    multipleAddressBooksSix.addContact();
                    multipleAddressBooksSix.addContact();
                    multipleAddressBooksSix.addContact();
                    multipleAddressBooksSix.Display();
                    //sorting by city
                    multipleAddressBooksSix.SortContactInAddressBooksByComparingCity();
                    Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                    //sorting by state
                    multipleAddressBooksSix.SortContactsInAddressBooksByComparingState();
                    Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                    //sorting by zip
                    multipleAddressBooksSix.SortContactsInAddressBooksByComparingZip();
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }


        }
    }
}