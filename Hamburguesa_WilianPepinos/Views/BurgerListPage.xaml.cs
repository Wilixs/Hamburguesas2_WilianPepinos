using Hamburguesa_WilianPepinos.Models;

namespace Hamburguesa_WilianPepinos.Views;

public partial class BurgerListPage : ContentPage
{
    public BurgerListPage()
    {
        InitializeComponent();
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPage));
    }

    private void RefreshData(object sender, EventArgs e)
    {
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
    private async void SelectedItem(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            var burgers = (Models.Burger)e.CurrentSelection[0];
            await Shell.Current.GoToAsync($"{nameof(BurgerItemPage)}?{nameof(BurgerItemPage.ItemId)}={burgers.Id}");
            burgerList.SelectedItem = null;
        }
    }
}