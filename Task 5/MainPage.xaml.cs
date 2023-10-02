using System.Collections.ObjectModel;

namespace Task_5
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Books> BooksList=new ObservableCollection<Books>();
        private ObservableCollection<Products> ProductsList = new ObservableCollection<Products>();
        private ObservableCollection<Product> ChosedList = new ObservableCollection<Product>();

        public MainPage()
        {
            InitializeComponent();

            BooksList.Add(new Books
            {
                Name = "Animal Farm",
                CountryOrigin = "England",
                Price = 100.50, 
                DateOfPackage = new DateTime(1945, 8, 17),
                Description = "A worldwide known book about an inequality between the government and the people and tyrant rulers.",
                PageAmount = 86,
                Edition = "BBC",
                Authors =  "George Orwell" 
            });
            BooksList.Add(new Books
            {
                Name = "Kobzar",
                CountryOrigin = "Ukraine",
                Price = 355,
                DateOfPackage = new DateTime(1840, 1, 1),
                Description = "Ukrainian classical book of famous author.",
                PageAmount = 115,
                Edition = "Knyzkovy Klub",
                Authors = "Taras Shevchenko"
            });
            BooksList.Add(new Books
            {
                Name = "The old man and the sea",
                CountryOrigin = "USA",
                Price = 247.89,
                DateOfPackage = new DateTime(1952, 1, 1),
                Description = " It tells the story of Santiago, an aging fisherman who catches a giant marlin after a lengthy struggle, but who then loses his bounty to sharks.",
                PageAmount = 112,
                Edition = "Knyzkovy Klub",
                Authors = "Ernest Hemingway" 
            });
            ProductsList.Add(new Products
            {
                Name = "Tomato juice",
                CountryOrigin = "Ukraine",
                Price = 45,
                DateOfPackage = new DateTime(2023, 10, 1),
                Description = "A fresh juice that is suitable for main dishes.",
                ExpirationDate=new DateTime(2023, 11, 5),
                Quantity= 23,
                Measurement = "1l"
            });
            ProductsList.Add(new Products
            {
                Name = "Jogurt",
                CountryOrigin = "Poland",
                Price = 24,
                DateOfPackage = new DateTime(2023, 9, 27),
                Description = "Sweet jogurt that everybody will probably like.",
                ExpirationDate = new DateTime(2023, 10, 5),
                Quantity = 111,
                Measurement = "1l"
            });
            ProductsList.Add(new Products
            {
                Name = "Crackers",
                CountryOrigin = "Ukraine",
                Price = 17,
                DateOfPackage = new DateTime(2023, 9, 3),
                Description = "Yummy crackers to eat while watching a film.",
                ExpirationDate = new DateTime(2024, 2, 11),
                Quantity = 54,
                Measurement = "250g"
            });
            BooksListView.ItemsSource = BooksList;
            ProductsListView.ItemsSource = ProductsList;
            ChosedListView.ItemsSource = ChosedList;

        }

        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Product product = (Product)button.BindingContext;
            ChosedList.Remove(product);
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Product product = (Product)button.BindingContext;
            if (!ChosedList.Contains(product))
            {
                ChosedList.Add(product);
                
            }
            else
            {
                DisplayAlert("Message", $"Product '{product.Name}' is already chosed.", "OK");
            }
        }
    }
}