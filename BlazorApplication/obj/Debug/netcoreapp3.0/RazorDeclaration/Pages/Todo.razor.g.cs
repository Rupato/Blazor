#pragma checksum "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5c595a259423dc55a5d53ac36791f2160ab9b1c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\_Imports.razor"
using BlazorApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\_Imports.razor"
using BlazorApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\Pages\Todo.razor"
using BlazorApplication.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Rupato\Blazor\BlazorApplication\BlazorApplication\Pages\Todo.razor"
 
    //creatiom of a list here 
    private IList<TodoItem> todos = new List<TodoItem>();
    private string newTodo;


   private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo });
            newTodo = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
