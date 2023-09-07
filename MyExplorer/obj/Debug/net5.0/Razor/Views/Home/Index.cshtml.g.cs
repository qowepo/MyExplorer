#pragma checksum "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ed5e80effbe9325ac2c7fbd442c88ca9c69ee47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\_ViewImports.cshtml"
using MyExplorer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\_ViewImports.cshtml"
using MyExplorer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ed5e80effbe9325ac2c7fbd442c88ca9c69ee47", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3f7985e048215cc370ce37adc32fd73bf0a8708", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyExplorer.Controllers.FileViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"" style=""margin: 20px;"">
    <div class=""row"">
        <div class=""col-4"">
            <label class=""h5 text-center"" for=""inputPath"">Path to the selected folder</label>
        </div>
        <!-- Ввод нового пути -->
        <div class=""col-6"">
            <input type=""text"" class=""form-control"" id=""inputPath"" style=""width: 100%;"" placeholder=""C:\ProgramData\Atom"" aria-describedby=""inputGroup-sizing-default""");
            BeginWriteAttribute("value", " value=\"", 487, "\"", 514, 1);
#nullable restore
#line 10 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
WriteAttributeValue("", 495, ViewData["MyPath"], 495, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <!-- Открыть новый путь -->
        <div class=""col-1"">
            <button type=""button"" onclick=""SetNewPath()"" class=""btn btn-outline-primary"">Apply</button>
        </div>
        <!-- Вернуться назад -->
        <div class=""col-1"">
            <button type=""button"" onclick=""ToBack()"" class=""btn btn-outline-dark"" >Back</button>
        </div>
        
    </div>

    <div class=""row pt-4"" style=""overflow: auto;"">
        <div class=""col-6"" style=""overflow: auto;"">
            <!-- Рекурсивно строиться дерево -->
             <div id=""myUL"" class=""tree"">
                ");
#nullable restore
#line 27 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
           Write(Html.Raw(RenderTree(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-6\" style=\"overflow: auto;\">\r\n            <!-- Отображение дочерних файлов -->\r\n");
#nullable restore
#line 32 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
             foreach(var item in Model.Children.OrderByDescending(x => x.Size))
            {
                if(item.IsDirectory) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- Если элемент папка -->\r\n                    <img src=\"/img/folder.png\" width=\"20\" height=\"20\">\r\n");
#nullable restore
#line 37 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
                    if(item.Children.Count() > 0) 
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
                   Write(Html.ActionLink(item.Name, "Index", "Home", new{ path = item.Path}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
                                                                                            
                    else
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
                   Write(Html.Raw(item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- Размер папки -->\r\n");
#nullable restore
#line 42 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
               Write(Html.Raw(" (" + Math.Round(item.Size, 2) + " Кб)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
                                                                       
                }
                else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- Если это файл -->\r\n                    <img src=\"/img/files.png\" width=\"20\" height=\"20\">\r\n                    <!-- Размер файла -->\r\n");
#nullable restore
#line 48 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
               Write(Html.Raw(item.Name + " (" + Math.Round(item.Size, 2) + " Кб)"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
                                                                                   
                }     

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br>\r\n");
#nullable restore
#line 51 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n \r\n\r\n");
            WriteLiteral(@"<script>
    var toggler = document.getElementsByClassName(""box"");
    var i;

    for (i = 0; i < toggler.length; i++) {
      toggler[i].addEventListener(""click"", function() {
        this.parentElement.querySelector("".nested"").classList.toggle(""active"");
        this.classList.toggle(""check-box"");
      });
    }
 
    document.querySelector('.nested').classList.add('active');
    document.querySelector('.box').classList.add('check-box');
 
    // Открытие нового пути
    function SetNewPath() {
        
        if (document.getElementById(""inputPath"").value !== """") {
            window.location.href = ""/Home/Index/?path="" + document.getElementById(""inputPath"").value;
        }        
    };  
    // Переместиться на уровень назад
    function ToBack() { history.back(); }; 
    
</script>");
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\nikul\source\repos\MyExplorer\MyExplorer\Views\Home\Index.cshtml"
            
    string RenderTree(MyExplorer.Controllers.FileViewModel file)
    {
        var result = "";
        result += "<ul>";

        // Render the current file
        result += "<li>";
        result += RenderFile(file);

        // Render children recursively
        if (file.Children.Any())
        {
            result += "<ul class=\"nested\">";

            foreach (var child in file.Children)
            {
                result += "<li>";
                result += RenderTree(child);
                result += "</li>";
            }

            result += "</ul>";
        }

        result += "</li>";
        result += "</ul>";

        return result;
    }

    string RenderFile(MyExplorer.Controllers.FileViewModel file)
    {
        var result = "";
        if (file.Path != null)
        {            
            var img = file.IsDirectory ? "<img src=\"/img/folder.png\" width=\"20\" height=\"20\">" : "<img src=\"/img/files.png\" width=\"20\" height=\"20\">";

            if (file.Children.Any())
            {
                result += $"<span class=\"box\"><a href='/Home/Index?path={ file.Path }'>{ img + " " + file.Name }</a></span>";
            }
            else
            {
                result += img + " " + file.Name;
            }
        }
        return result;
    }

#line default
#line hidden
#nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyExplorer.Controllers.FileViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
