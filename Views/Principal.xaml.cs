using aperezs5b.Models;

namespace aperezs5b.Views;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
	}

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        App.personRepo.AddnewPerson(txtName.Text);
        lblStatus.Text = App.personRepo.status;
    }

    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
        List<Persona> people = App.personRepo.GetAllPeople();   
        listapersonas.ItemsSource = people;
    }
}