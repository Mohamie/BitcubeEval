#pragma checksum "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Degree\_Degree.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3af70fae0eca1803fc28aa5ce70886f4670c4847"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BitCube.Section3.Pages.Degree
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using BitCube.Section3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using BitCube.Section3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using BitCube.Section3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using BitCube.Section3.Pages.Student;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\_Imports.razor"
using BitCube.Section3.Pages.Degree;

#line default
#line hidden
#nullable disable
    public partial class _Degree : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Degree\_Degree.razor"
       

    List<Degree> degrees = new List<Degree>();
    List<Course> courses = new List<Course>();

    protected override void OnInitialized()
    {
        degrees = SampleDataService.GetAllDegrees();
        courses = SampleDataService.GetAllCourses();
    }

    //Method to show a Dialog which display all Courses linked to a single Degree
    async Task ViewCourses(Degree degree)
    {
        await DialogService.OpenAsync<DegreeCourses>($"Courses under {degree.Name}",
            new Dictionary<string, object> { { "Courses", courses.Where(c => c.LinkedDegree.Id == degree.Id).ToList() } },
            new DialogOptions() { Width = "750px", Height = "500px" });
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SampleDataService SampleDataService { get; set; }
    }
}
#pragma warning restore 1591
