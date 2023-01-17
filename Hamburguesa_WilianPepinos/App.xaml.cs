using Hamburguesa_WilianPepinos.Data;

namespace Hamburguesa_WilianPepinos;

public partial class App : Application
{

    public static BurgerDatabase BurgerRepo { get; private set; }

    public App(BurgerDatabase repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        BurgerRepo = repo;
    }
}