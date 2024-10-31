using aperezs5b.Utils;
using aperezs5b.Views;

namespace aperezs5b
{
    public partial class App : Application
    {
        public static PersonRepository personRepo;
        public App(PersonRepository personRepository)
        {
            InitializeComponent();

            MainPage = new Views.Principal();
            personRepo = personRepository;
        }
    }
}
