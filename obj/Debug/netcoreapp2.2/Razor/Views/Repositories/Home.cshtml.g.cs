#pragma checksum "R:\Programas\C#\Résmony_Silva_Muniz\GithubAPI\Views\Repositories\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf25f3a41222e8859a23727ce5beec565d919789"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Repositories_Home), @"mvc.1.0.view", @"/Views/Repositories/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Repositories/Home.cshtml", typeof(AspNetCore.Views_Repositories_Home))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "R:\Programas\C#\Résmony_Silva_Muniz\GithubAPI\Views\_ViewImports.cshtml"
using GithubAPI;

#line default
#line hidden
#line 2 "R:\Programas\C#\Résmony_Silva_Muniz\GithubAPI\Views\_ViewImports.cshtml"
using GithubAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf25f3a41222e8859a23727ce5beec565d919789", @"/Views/Repositories/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"345bf42da3367081ac91579c7aff3cebce0d3f51", @"/Views/_ViewImports.cshtml")]
    public class Views_Repositories_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "R:\Programas\C#\Résmony_Silva_Muniz\GithubAPI\Views\Repositories\Home.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(89, 1325, true);
            WriteLiteral(@"
<h1>Descrição</h1>
<br />
<div class=""text-body container"">
    <p>
        1.	Deve existir uma seção ""Meus repositórios"", onde é listado todos os repositórios do candidato (você, que está lendo isso agora).
    </p>
    <p>
        2.	Deve existir uma seção onde o usuário pode procurar por repositórios do github utilizando como filtro nome ou parte do nome do repositório.
    </p>
    <p>
        3.	Deve existir uma seção listando repositórios favoritos (não são os seus favoritos e sim os marcados como favoritos por quem usar seu sistema, ver 5.1)
    </p>
    <p>
       4.	Ao clicar no nome de um repositório em qualquer lugar, devemos ir para uma tela de detalhes com nome, descrição, linguagem, última data de atualização e o dono do repositório. Abaixo disso, liste todos os contribuidores do projeto.
    </p>
    <p>
        5.	Na tela de detalhes do repositório, deve ser possível marcá-lo como repositório favorito (ver 5.1).
    </p>
    <p>
        5.1 O que significa marcar como favo");
            WriteLiteral(@"rito?
        Você deve salvar esta informação no servidor onde roda sua aplicação ASP.NET, não no Github e não no navegador do usuário. Para isso, use qualquer forma de armazenamento (arquivo de texto, banco embedded, qualquer coisa que não precise ser instalada. Seja criativo).
    </p>
</div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591