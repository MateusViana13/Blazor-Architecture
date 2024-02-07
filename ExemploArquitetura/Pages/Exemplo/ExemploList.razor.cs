using Microsoft.AspNetCore.Components;

namespace ExemploArquitetura.Pages.Exemplo
{
    public partial class ExemploList
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; } = default!;

        private string Teste { get; set; } = "Teste";

        protected override void OnInitialized()
        {
            Teste = "Teste 2";
        }
    }
}
