using NUnit.Framework;
using System;
using System.Diagnostics;
using TesteUnitario.Model;
using TesteUnitario.ViewModel;

namespace TesteUnitarioProjeto
{
    [TestFixture()]
    public class CadastroClienteViewModelTest
    {
        [Test()]
        public void Test_Retorno_Nome_nao_Vazio_ou_nulo()
        {
            CadastroClienteViewModel cadastro;

            cadastro = new CadastroClienteViewModel();

            Cliente cliente = cadastro.RetornaNomeSobrenome();

            Assert.IsNotNullOrEmpty(cliente.Nome);
        }

        [Test()]
        public void Test_Retorno_Nome_igual_Renan()
        {
            CadastroClienteViewModel cadastro;
            Cliente cliente = new Cliente();

            cliente.Nome = "Renan";

            cadastro = new CadastroClienteViewModel();
            Cliente nomeSobrenome = cadastro.RetornaNomeSobrenome();

            Assert.AreSame(nomeSobrenome.Nome,cliente.Nome);
        }

    }

}
