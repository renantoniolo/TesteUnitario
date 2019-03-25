using System;
using System.Collections.Generic;
using TesteUnitario.ViewModel;
using Xamarin.Forms;

namespace TesteUnitario.View
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();

            this.BindingContext = new CadastroClienteViewModel(); 
        }
    }
}
