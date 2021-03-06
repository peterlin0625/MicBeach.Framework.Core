#pragma checksum "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6b3655b385630b8a4153c3b34ebdc66d3877dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sys_EditAuthorityOperation), @"mvc.1.0.view", @"/Views/Sys/EditAuthorityOperation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sys/EditAuthorityOperation.cshtml", typeof(AspNetCore.Views_Sys_EditAuthorityOperation))]
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
#line 1 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\_ViewImports.cshtml"
using Site.Cms;

#line default
#line hidden
#line 2 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\_ViewImports.cshtml"
using MicBeach.Web.Mvc;

#line default
#line hidden
#line 5 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
using MicBeach.Util.Extension;

#line default
#line hidden
#line 6 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
using MicBeach.ViewModel.Sys;

#line default
#line hidden
#line 7 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
using MicBeach.Application.Identity.Auth;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6b3655b385630b8a4153c3b34ebdc66d3877dcd", @"/Views/Sys/EditAuthorityOperation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e5000250b2a0bb9c30615591362c9282acaa0ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Sys_EditAuthorityOperation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorityOperationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
  
    ViewBag.Title = "编辑授权操作";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 9 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
  
    bool isAdd = Model.SysNo <= 0;

#line default
#line hidden
            BeginContext(270, 92, true);
            WriteLiteral("<div id=\"pc-body\">\r\n    <div id=\"pc-body-inner\">\r\n        <div class=\"form-con\" id=\"home\">\r\n");
            EndContext();
#line 15 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
             using (Html.AjaxBeginForm("EditAuthorityOperation", "Sys", new AjaxFormOptions() { HttpMethod = "Post", OnSuccess = "SuccessCallback", OnFailure = "FailedCallback" }, new { id = "formvalide" }))
            {
                

#line default
#line hidden
            BeginContext(603, 48, false);
#line 17 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
           Write(Html.Hidden("SysNo", null, new { id = "SysNo" }));

#line default
#line hidden
            EndContext();
            BeginContext(670, 34, false);
#line 18 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
           Write(Html.HiddenFor(r => r.Group.SysNo));

#line default
#line hidden
            EndContext();
            BeginContext(706, 363, true);
            WriteLiteral(@"                <table cellpadding=""0"" cellspacing=""0"" class=""form_table"">
                    <tr>
                        <td class=""txt-right tit""><button type=""button"" class=""btn btn-xs btn-success"" id=""btn_selectgroup""><i class=""glyphicon glyphicon-check""></i> 选择</button></td>
                        <td id=""groupname_td"">
                            【");
            EndContext();
            BeginContext(1070, 17, false);
#line 23 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                        Write(ViewBag.GroupName);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 139, true);
            WriteLiteral("】\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"txt-right tit\">* ");
            EndContext();
            BeginContext(1227, 26, false);
#line 27 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                                               Write(Html.LabelFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1319, 67, false);
#line 29 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.TextBoxFor(a => a.Name, new { @class = "form-control w-200" }));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1417, 80, false);
#line 30 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.DefaultValidationMessageFor(a => a.Name, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 138, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"txt-right tit\">* ");
            EndContext();
            BeginContext(1636, 36, false);
#line 34 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                                               Write(Html.LabelFor(c => c.ControllerCode));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1738, 77, false);
#line 36 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.TextBoxFor(a => a.ControllerCode, new { @class = "form-control w-200" }));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1846, 90, false);
#line 37 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.DefaultValidationMessageFor(a => a.ControllerCode, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(1936, 138, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"txt-right tit\">* ");
            EndContext();
            BeginContext(2075, 32, false);
#line 41 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                                               Write(Html.LabelFor(c => c.ActionCode));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2173, 73, false);
#line 43 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.TextBoxFor(a => a.ActionCode, new { @class = "form-control w-200" }));

#line default
#line hidden
            EndContext();
            BeginContext(2246, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2277, 86, false);
#line 44 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.DefaultValidationMessageFor(a => a.ActionCode, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(2363, 136, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"txt-right tit\">");
            EndContext();
            BeginContext(2500, 28, false);
#line 48 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                                             Write(Html.LabelFor(c => c.Method));

#line default
#line hidden
            EndContext();
            BeginContext(2528, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2594, 170, false);
#line 50 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.EnumToSelect(a => a.Method, AuthorityOperationMethod.全部, new { @class = "form-control w-200" }, selectedValue: (Model == null ? "" : ((int)Model.Method).ToString())));

#line default
#line hidden
            EndContext();
            BeginContext(2764, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2795, 82, false);
#line 51 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.DefaultValidationMessageFor(a => a.Method, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(2877, 136, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"txt-right tit\">");
            EndContext();
            BeginContext(3014, 35, false);
#line 55 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                                             Write(Html.LabelFor(c => c.AuthorizeType));

#line default
#line hidden
            EndContext();
            BeginContext(3049, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3115, 192, false);
#line 57 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.EnumToSelect(a => a.AuthorizeType, AuthorityOperationAuthorizeType.无限制, new { @class = "form-control w-200" }, selectedValue: (Model == null ? "" : ((int)Model.AuthorizeType).ToString())));

#line default
#line hidden
            EndContext();
            BeginContext(3307, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3338, 89, false);
#line 58 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.DefaultValidationMessageFor(a => a.AuthorizeType, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(3427, 138, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"txt-right tit\">* ");
            EndContext();
            BeginContext(3566, 28, false);
#line 62 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                                               Write(Html.LabelFor(c => c.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3594, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3660, 144, false);
#line 64 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.EnumToSelect(a => a.Status, AuthorityOperationStatus.启用, new { @class = "form-control w-200" }, "", "选择状态", ((int)Model.Status).ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(3804, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3835, 82, false);
#line 65 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                       Write(Html.DefaultValidationMessageFor(a => a.Status, "", new { @class = "tip prompt" }));

#line default
#line hidden
            EndContext();
            BeginContext(3917, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
            BeginContext(4418, 26, true);
            WriteLiteral("                </table>\r\n");
            EndContext();
#line 76 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
            }

#line default
#line hidden
            BeginContext(4459, 252, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div id=\"pc-foot\">\r\n    <div class=\"txt-right form-submitbtn-con pdr-10\"><button type=\"button\" onclick=\"SubmitForm()\" class=\"btn btn-blue\"><i class=\"glyphicon glyphicon-floppy-save\"></i> 提交</button></div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4730, 252, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        HasDivPageCon = true;\r\n        $(function () {\r\n            //选择分组\r\n            $(\"#btn_selectgroup\").click(function () {\r\n                SelectGroup();\r\n            });\r\n        })\r\n        var isAdd = \'");
                EndContext();
                BeginContext(4983, 26, false);
#line 94 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                Write(isAdd.ToString().ToLower());

#line default
#line hidden
                EndContext();
                BeginContext(5009, 644, true);
                WriteLiteral(@"' == 'true';

        //提交表单
        function SubmitForm() {
            $(""#formvalide"").submit();
        }

        //成功回调
        function SuccessCallback(res) {
            if (!res) {
                return;
            }
            if (res.Success) {
                art.dialog.opener.LoadActions();
                art.dialog.close(true);
            } else {
                ResultMsg(res);
            }
        }

        //失败回调
        function FailedCallback(res) {
            ErrorMsg('提交失败');
        }

        //选择分组
        function SelectGroup() {
            DialogPage({
                url: '");
                EndContext();
                BeginContext(5654, 55, false);
#line 122 "F:\GitHubProject\MicBeach.Framework.Core\src\Application\Site\Site.Cms\Views\Sys\EditAuthorityOperation.cshtml"
                 Write(Url.Action("AuthorityOperationGroupSingleSelect","Sys"));

#line default
#line hidden
                EndContext();
                BeginContext(5709, 486, true);
                WriteLiteral(@"',
                width: ""300px"",
                height: ""400px"",
                title: '选择操作分组',
                ok: false,
                cancel: null
            });
        }

        //分组选择回调
        function AuthorityOperationGroupSingleSelectCallback(group, parentsNames) {
            if (group) {
                $(""#groupname_td"").html('【' + parentsNames + '】');
                $(""#Group_SysNo"").val(group.SysNo);
            }
        }

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorityOperationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
