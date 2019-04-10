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
            // Arrange
            CadastroClienteViewModel cadastro = new CadastroClienteViewModel();

            // Act
            Cliente cliente = cadastro.RetornaNomeSobrenome();

            // Assert
            Assert.IsNotNullOrEmpty(cliente.Nome);
        }

        [Test()]
        public void Test_Retorno_Nome_igual_Renan()
        {

            // Arrange
            CadastroClienteViewModel cadastro = new CadastroClienteViewModel();
            Cliente cliente = new Cliente();
            cliente.Nome = "Renan";

            // Act
            Cliente nomeSobrenome = cadastro.RetornaNomeSobrenome();

            // Assert
            Assert.AreSame(nomeSobrenome.Nome,cliente.Nome);
        }

    }

}
