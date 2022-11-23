namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Use Case #7: No Duplicate Entries in Address Book");

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
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }


        }
    }
}