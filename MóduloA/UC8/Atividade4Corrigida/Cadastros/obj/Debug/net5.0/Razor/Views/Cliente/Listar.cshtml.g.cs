#pragma checksum "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93df6d66cff71712efd0141dfa9f13cc6ed5c4c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Listar), @"mvc.1.0.view", @"/Views/Cliente/Listar.cshtml")]
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
#nullable restore
#line 1 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\_ViewImports.cshtml"
using Cadastros;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\_ViewImports.cshtml"
using Cadastros.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93df6d66cff71712efd0141dfa9f13cc6ed5c4c5", @"/Views/Cliente/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bdb0dc22cfe52403a06683669d4e27c1c452006", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
  
    Layout = "_Layout2";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
      
        ViewData["Title"] = "Listagem de Contato";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2>Mensagens Recebidas</h2>
    <table>
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Email</th>
                <th>Telefone</th>
                <th>Selecao</th>
                <th>Descricao</th>
                <th>Opções</th>                
            </tr>
        </thead>        
");
#nullable restore
#line 21 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
             foreach ( Cliente c in Model)
            {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
                   Write(c.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
                   Write(c.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
                   Write(c.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
                   Write(c.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
                   Write(c.Selecao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
                   Write(c.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a href=\"mailto:?to=&subject=Formulário de contato.&body=Olá! Sou Kelly da Kawase Soluções Digitais. Obrigada por entrar em contato conosco! (Resposta)\">Enviar email</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1073, "\"", 1105, 2);
            WriteAttributeValue("", 1080, "/Cliente/Remover?Id=", 1080, 20, true);
#nullable restore
#line 32 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
WriteAttributeValue("", 1100, c.Id, 1100, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\kelly\Desktop\Contato\ContatoV7 - Copia\Cadastros\Views\Cliente\Listar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
