using System;
using TesteUnitario.Model;

namespace TesteUnitario.ViewModel
{
    public class CadastroClienteViewModel
    {

        private Cliente cliente;

        public CadastroClienteViewModel()
        {
            cliente = new Cliente();
        }


        public Cliente RetornaNomeSobrenome()
        {

            cliente.Nome = "Renan";
            cliente.SobreNome = "Toniolo Rocha";

            return cliente;
        }

    }
}
