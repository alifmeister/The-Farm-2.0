#pragma checksum "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff283c228bfe97c421fe2fb6bbe6c5f7eb7d8b79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(farm.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace farm.Pages
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
#line 1 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/_ViewImports.cshtml"
using farm;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff283c228bfe97c421fe2fb6bbe6c5f7eb7d8b79", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b977339cb2b29adf36c40151b9adbdf84c31e009", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/farm.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Farm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hidden md:h-screen md:block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cow.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("cow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-48 rounded-full mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Index.cshtml"
  
    ViewData["Title"] = "The Farm 2.0 | Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav class=""flex items-center bg-white p-3 flex-wrap shadow-xl"">
    <span class=""block font-bold text-lg text-black"">THE FARM 2.0</span>

    <button class=""text-black inline-flex p-3 hover:bg-gray-700 rounded ml-auto hover:text-white outline-none nav-toggler lg:hidden"" data-target=""#navigation"">
        <i class=""uil uil-bars pr-3""></i> MENU
    </button>

    <div class=""hidden top-navbar w-full lg:inline-flex lg:flex-grow lg:w-auto"" id=""navigation"">
        <div class=""lg:inline-flex lg:flex-row lg:ml-auto lg:w-auto w-full lg:items-center items-start flex flex-col lg:h-auto"">
            <a href=""#"" class=""lg:inline-flex lg:w-auto w-full px-7 py-2 rounded text-black items-center justify-center hover:bg-gray-100"">
                <span>Home</span>
            </a>

            <a href=""#"" class=""lg:inline-flex lg:w-auto w-full px-7 py-2 rounded text-black items-center justify-center hover:bg-gray-100"">
                <span>About us</span>
            </a>

            <a href=""#"" class=""lg:inline-flex lg");
            WriteLiteral(@":w-auto w-full px-7 py-2 rounded text-black items-center justify-center hover:bg-gray-100"">
                <span>Our cows</span>
            </a>

            <a href=""#"" class=""lg:inline-flex lg:w-auto w-full px-7 py-2 rounded text-black items-center justify-center hover:bg-gray-100"">
                <span>Contact us</span>
            </a>

            <a href=""#"" class=""lg:inline-flex lg:w-auto w-full px-7 py-2 text-black items-center justify-center lg:bg-green-500 lg:text-white hover:bg-green-700"">
                <span>Go to shopping</span>
            </a>
        </div>
    </div>
</nav>
<section class=""flex h-screen bg-cow-bg bg-cover bg-center p-4"">
    <div class=""m-auto"">
        <span class=""block text-center md:text-left sm:text-lg sm:leading-snug font-semibold tracking-wide uppercase text-gray-400 mb-3"">Random text</span>
        <h1 class=""text-4xl text-white md:text-left md:text-5xl md:w-6/12 font-semibold text-center"">Lorem ipsum dolor sit amet, consectetuer adipiscing elit.</h1>

        <b");
            WriteLiteral("utton class=\"p-3 rounded shadow-xl bg-white w-36 block mx-auto md:mx-0 mt-10 hover:bg-gray-200 duration-150\">Our cows</button>\n    </div>\n</section>\n<section class=\"md:h-screen\">\n    <div class=\"md:flex\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ff283c228bfe97c421fe2fb6bbe6c5f7eb7d8b798431", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""m-16 md:w-6/12"">
            <h2 class=""text-3xl text-black font-semibold"">About us</h2>

            <p class=""text-gray-500 leading-6 mt-5 text-justify"">
                Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Vestibulum fermentum tortor id mi. Nunc auctor. Vivamus luctus egestas leo. Sed convallis magna eu sem. Ut tempus purus at lorem. Fusce suscipit libero eget elit. Integer rutrum, orci vestibulum ullamcorper ultricies, lacus quam ultricies odio, vitae placerat pede sem sit amet enim. Fusce dui leo, imperdiet in, aliquam sit amet, feugiat eu, orci. Cras elementum. Phasellus rhoncus. In enim a arcu imperdiet malesuada. Nunc tincidunt ante vitae massa.
            </p>
            <p class=""text-gray-500 leading-6 mt-5 text-justify"">
                Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Pellentesque habitant morbi tristique senectus et netus et malesua");
            WriteLiteral(@"da fames ac turpis egestas. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Nam sed tellus id magna elementum tincidunt. Fusce wisi. Mauris elementum mauris vitae tortor. Mauris tincidunt sem sed arcu. Maecenas libero. Nulla turpis magna, cursus sit amet, suscipit a, interdum id, felis. Aliquam ornare wisi eu metus. Duis condimentum augue id magna semper rutrum. Sed convallis magna eu sem. Nullam dapibus fermentum ipsum. Nullam lectus justo, vulputate eget mollis sed, tempor sed magna. Proin in tellus sit amet nibh dignissim sagittis. Nam quis nulla. Aliquam erat volutpat. Fusce tellus. Nullam rhoncus aliquam metus.
            </p>

            <button class=""p-3 w-36 block mx-auto shadow-xl rounded mt-10 bg-indigo-500 text-white"">Visit us!</button>
        </div>
    </div>
</section>
<section class=""h-screen bg-gray-200 p-4"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ff283c228bfe97c421fe2fb6bbe6c5f7eb7d8b7911634", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <h2 class=""text-3xl text-black font-semibold text-center mt-4"">Our cows</h2>

    <p class=""text-gray-600 text-justify mt-8"">
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Vestibulum fermentum tortor id mi. Nunc auctor. Vivamus luctus egestas leo. Sed convallis magna eu sem. Ut tempus purus at lorem. Fusce suscipit libero eget elit. Integer rutrum, orci vestibulum ullamcorper ultricies, lacus quam ultricies odio, vitae placerat pede sem sit amet enim. Fusce dui leo, imperdiet in, aliquam sit amet, feugiat eu, orci. Cras elementum. Phasellus rhoncus. In enim a arcu imperdiet malesuada. Nunc tincidunt ante vitae massa.
    </p>
</section>
<section class=""p-4 md:mb-10"">
    <h2 class=""text-3xl text-black font-semibold md:text-center md:mt-10 md:mb-10"">Let's stay in touch!</h2>
    <div class=""md:flex"">
        <div class=""form md:flex-1 md:order-last md:mr-20"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff283c228bfe97c421fe2fb6bbe6c5f7eb7d8b7913733", async() => {
                WriteLiteral(@"
                <input type=""text"" name=""name"" placeholder=""Your name"" class=""bg-gray-100 rounded-t-lg border-b-2 border-indigo-600 w-auto outline-none p-3 block custom-input mb-10"">

                <input type=""text"" name=""email"" placeholder=""Your email"" class=""bg-gray-100 rounded-t-lg border-b-2 border-indigo-600 w-auto outline-none p-3 block custom-input mb-10"">

                <textarea type=""text"" name=""message"" placeholder=""Your message"" class=""bg-gray-100 rounded-t-lg border-b-2 border-indigo-600 w-auto outline-none p-3 block custom-input mb-10""></textarea>

                <button type=""submit"" class=""bg-purple-500 p-3 w-36 rounded shadow-xl text-white block mx-auto"">Send</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <div class=""mt-12 md:flex-1"">
            <ul class=""text-center"">
                <li class=""mb-5 text-xl""><i class=""uil uil-map-marker text-indigo-700 text-2xl pr-3""></i> Address 1234</li>
                <li class=""mb-5 text-xl""><i class=""uil uil-envelope-edit text-indigo-700 text-2xl pr-3""></i> info@thefarm.com</li>
                <li class=""mb-5 text-xl""><i class=""uil uil-phone text-indigo-700 text-2xl pr-3""></i> 123 456 789</li>
            </ul>
        </div>
    </div>
</section>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""
        integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=""
        crossorigin=""anonymous""></script>
<script src=""./js/script.js""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
