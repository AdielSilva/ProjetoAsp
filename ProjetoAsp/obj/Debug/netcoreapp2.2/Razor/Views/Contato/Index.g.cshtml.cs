#pragma checksum "C:\Users\Hamilton\Desktop\Adiel\Asp_Udemy\ProjetoAsp\ProjetoAsp\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d839a23d199a6f19f5077f5c5e544cb8ea3c3055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contato/Index.cshtml", typeof(AspNetCore.Views_Contato_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d839a23d199a6f19f5077f5c5e544cb8ea3c3055", @"/Views/Contato/Index.cshtml")]
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!Doctype html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 382, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d839a23d199a6f19f5077f5c5e544cb8ea3c30552918", async() => {
                BeginContext(31, 369, true);
                WriteLiteral(@"

    <title>
        Contato
    </title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css"" 
          integrity=""sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS"" crossorigin=""anonymous"">
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width =device-width"" />

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(407, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(411, 1294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d839a23d199a6f19f5077f5c5e544cb8ea3c30554485", async() => {
                BeginContext(417, 347, true);
                WriteLiteral(@"

    <h1>Contato</h1>

    <div id=""container"">

        <form method=""post"" action=""/contato/receberContato"">
            <div class=""form-group"">
                <label for=""nome"">Nome</label>
                <input type=""text"" name=""nome"" class=""form-control"" id=""nome"" placeholder=""Digite seu nome"">
            </div>
            ");
                EndContext();
                BeginContext(765, 30, false);
#line 26 "C:\Users\Hamilton\Desktop\Adiel\Asp_Udemy\ProjetoAsp\ProjetoAsp\Views\Contato\Index.cshtml"
       Write(Html.ValidationMessage("nome"));

#line default
#line hidden
                EndContext();
                BeginContext(795, 239, true);
                WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"email\">E-mail</label>\r\n                <input type=\"text\" name=\"email\" class=\"form-control\" id=\"email\" placeholder=\"Digite seu e-mail\">\r\n            </div>\r\n            ");
                EndContext();
                BeginContext(1035, 31, false);
#line 32 "C:\Users\Hamilton\Desktop\Adiel\Asp_Udemy\ProjetoAsp\ProjetoAsp\Views\Contato\Index.cshtml"
       Write(Html.ValidationMessage("email"));

#line default
#line hidden
                EndContext();
                BeginContext(1066, 503, true);
                WriteLiteral(@"

            <div class=""form-group"">
                <label for=""assunto"">Assunto</label>
                <input type=""text"" name=""assunto"" class=""form-control"" id=""assunto"" placeholder=""Digite o seu assunto"">
            </div>
           

            <div class=""form-group"">
                <label for=""mensagem"">Mensagem</label>
                <textarea name=""mensagem"" class=""form-control"" id=""mensagem"" placeholder=""Digite sua mensagem""> </textarea>
            </div>
            ");
                EndContext();
                BeginContext(1570, 16, false);
#line 44 "C:\Users\Hamilton\Desktop\Adiel\Asp_Udemy\ProjetoAsp\ProjetoAsp\Views\Contato\Index.cshtml"
       Write(ViewBag.Mensagem);

#line default
#line hidden
                EndContext();
                BeginContext(1586, 112, true);
                WriteLiteral("\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n        </form>\r\n\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1705, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
