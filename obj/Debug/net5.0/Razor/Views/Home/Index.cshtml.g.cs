#pragma checksum "D:\source\repos\MyFirstProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11f7af52c76a348fc059d6a0aab8f10f16db68c7"
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
#line 1 "D:\source\repos\MyFirstProject\Views\_ViewImports.cshtml"
using MyFirstProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\repos\MyFirstProject\Views\_ViewImports.cshtml"
using MyFirstProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\source\repos\MyFirstProject\Views\_ViewImports.cshtml"
using MyFirstProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11f7af52c76a348fc059d6a0aab8f10f16db68c7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ccf596526e6f34f86772ea3a15863ccffb49cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\source\repos\MyFirstProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Все пользователи";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f7af52c76a348fc059d6a0aab8f10f16db68c74020", async() => {
                WriteLiteral("Добавить пользователя");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Имя</td>\r\n            <td>Возраст</td>\r\n        </tr>\r\n");
#nullable restore
#line 15 "D:\source\repos\MyFirstProject\Views\Home\Index.cshtml"
         foreach (var item in Model.Users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "D:\source\repos\MyFirstProject\Views\Home\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "D:\source\repos\MyFirstProject\Views\Home\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "D:\source\repos\MyFirstProject\Views\Home\Index.cshtml"
               Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "D:\source\repos\MyFirstProject\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>


    Мой дед родился в Кронштадте, моя жена — ленинградка, так что в Петербурге я чувствую себя не совсем чужим. Впрочем, в России трудно найти человека, в чьей жизни этот город ничего бы не значил. Все мы так или иначе связаны с ним, а через него друг с другом.

    В Петербурге мало зелени, зато много воды и неба. Город раскинулся на равнине, и небо над ним необъятно. Можно подолгу наслаждаться спектаклями, которые на этой сцене разыгрывают облака и закаты. Актёрами управляет лучший на свете режиссер — ветер. Декорации из крыш, куполов и шпилей остаются неизменными, но никогда не надоедают. В 1941 году Гитлер решил выморить ленинградцев голодом и стереть город с лица земли. «Фюрер не понимал, что распоряжение взорвать Ленинград равносильно приказу взорвать Альпы», – заметил писатель Даниил Гранин. Петербург – каменная громада, по своей слитности и мощи не имеющая равных среди европейских столиц. В нём сохранилось свыше восемнадцати тысяч зданий, построенных до 1917 года. Это больше, чем в");
            WriteLiteral(@" Лондоне и Париже, не говоря уж о Москве.

    Через несокрушимый, высеченный из камня лабиринт течет Нева с её притоками, протоками и каналами. В отличие от неба, вода здесь не свободна, она говорит о могуществе империи, сумевшей заковать ее в гранит. Летом у парапетов на набережных стоят рыбаки с удочками. Под ногами у них лежат полиэтиленовые кульки, в которых трепещут пойманные рыбешки. Такие же ловцы плотвы и кóрюшки стояли здесь и при Пушкине. Так же серели тогда бастионы Петропавловской крепости и дыбил коня Медный всадник. Разве что Зимний дворец был тёмно-красным, а не зелёным, как сейчас.

    Кажется, ничто вокруг не напоминает о том, что в двадцатом столетии трещина русской истории прошла через Петербург. Его красота позволяет нам забыть о перенесённых им немыслимых испытаниях.

    Разбор текста диктанта вместе с подробными комментариями
    Подробные комментарии к тексту
    Расскажите друзьям:
    Часть 2. Пермь. Кама
    Когда с левого берега Камы, на котором лежит моя родная Пермь, ");
            WriteLiteral(@"смотришь на правый с его синеющими до горизонта лесами, чувствуешь зыбкость границы между цивилизацией и первозданной лесной стихией. Их разделяет только полоса воды, и она же их объединяет. Если ребенком вы жили в городе на большой реке, вам повезло: суть жизни вы понимаете лучше, чем те, кто был лишен этого счастья.

    В моем детстве в Каме еще водилась стерлядь. В старину ее отправляли в Петербург к царскому столу, а чтобы не испортилась в пути, под жабры клали смоченную в коньяке вату. Мальчиком я видел на песке маленького осетра с испятнанной мазутом зубчáтой спиной: вся Кама была тогда в мазуте от буксиров. Эти грязные трудяги тащили за собой плоты и баржи. На палубах бегали дети и сушилось на солнце бельё. Нескончаемые вереницы сбитых скобами осклизлых брёвен исчезли вместе с буксирами и баржами. Кама стала чище, но стерлядь в нее так и не вернулась.

    Говорили, что Пермь, подобно Москве и Риму, лежит на семи холмах. Этого было достаточно, чтобы ощутить, как над моим деревянным, утыканным заво");
            WriteLiteral(@"дскими трубами городом веет дыхание истории. Его улицы идут или параллельно Каме, или перпендикулярно ей. Первые до революции назывались по стоявшим на них храмам, как, например, Вознесенская или Покровская. Вторые носили имена тех мест, куда вели вытекающие из них дороги: Сибирская, Соликамская, Верхотурская. Там, где они пересекались, небесное встречалось с земным. Здесь я понял, что дольнее рано или поздно сходится с горним, нужно лишь набраться терпения и подождать.

    Пермяки утверждают, что не Кама впадает в Волгу, а, наоборот, Волга в Каму. Мне не важно, какая из двух этих великих рек является притоком другой. В любом случае Кама — та река, которая течёт через мое сердце.

    Разбор текста диктанта вместе с подробными комментариями
    Подробные комментарии к тексту
    Расскажите друзьям:
    Часть 3. Улан-Удэ. Селенга
    Названия рек древнее всех других имён, нанесённых на карты. Нам не всегда понятен их смысл, вот и Селенга хранит тайну своего имени. Оно произошло не то от бурятского сло");
            WriteLiteral(@"ва «сэл», что значит «разлив», не то от эвенкийского «сэлэ», то есть «железо», но мне слышалось в нём имя греческой богини луны, Селены. Стиснутая поросшими лесом сопками, часто окутанная туманом Селенга была для меня загадочной «лунной рекой». В шуме её течения мне, юному лейтенанту, чудилось обещание любви и счастья. Казалось, они ожидают меня впереди так же непреложно, как Селенгу ждет Байкал.

    Может быть, то же обещала она двадцатилетнему поручику Анатолию Пепеляеву, будущему белому генералу и поэту. Незадолго до Первой мировой войны он тайно обвенчался со своей избранницей в бедной сельской церкви на берегу Селенги. Отец-дворянин не дал сыну благословения на неравный брак. Невеста была внучкой ссыльных и дочерью простого железнодорожника из Верхнеудинска — так прежде назывался Улан-Удэ.

    Я застал этот город почти таким, каким его видел Пепеляев. На рынке торговали бараниной приехавшие из глубинки буряты в традиционных синих халатах и прохаживались женщины в музейных сарафанах. Они продавали н");
            WriteLiteral(@"анизанные на руки, как калачи, круги мороженого молока. Это были «семейские», как в Забайкалье именуют старообрядцев, раньше живших большими семьями. Правда, появилось и то, чего при Пепеляеве не было. Помню, как на главной площади поставили самый оригинальный из всех виденных мною памятников Ленину: на невысоком пьедестале круглилась громадная, без шеи и туловища, гранитная голова вождя, похожая на голову богатыря-исполина из «Руслана и Людмилы». Она до сих пор стоит в столице Бурятии и стала одним из её символов. Здесь история и современность, православие и буддизм не отторгают и не подавляют друг друга. Улан-Удэ подарил мне надежду, что и в других местах это возможно.
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
