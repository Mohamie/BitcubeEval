#pragma checksum "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93884407e03cca92f16bfb20b64943baa05c472b"
// <auto-generated/>
#pragma warning disable 1591
namespace BitCube.Section3.Pages.Student
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
    public partial class _Student : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary my-2");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                               (() => AddStudent())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Add Student");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card shadow mb-3");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<div class=\"card-header py-3\">\r\n        <p class=\"text-primary m-0 font-weight-bold\">Students</p>\r\n    </div>\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "table-responsive table mt-2");
            __builder.AddAttribute(14, "id", "dataTable");
            __builder.AddAttribute(15, "role", "grid");
            __builder.AddAttribute(16, "aria-describedby", "dataTable_info");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table my-0");
            __builder.AddAttribute(20, "id", "dataTable");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, @"<thead>
                    <tr>
                        <th>Full Name</th>
                        <th>Surname</th>
                        <th>Date Of Birth</th>
                        <th>Enrolled Degree</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(23, "tbody");
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 25 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                     foreach(var student in students)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 28 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                 student.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 29 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                 student.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 30 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                 student.DateOfBirth.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "td");
            __builder.AddMarkupContent(38, "\r\n                                \r\n");
#nullable restore
#line 33 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                 if(student.EnrolledDegree != null)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                                    ");
            __builder.OpenElement(40, "span");
            __builder.AddAttribute(41, "class", "text-success");
            __builder.AddContent(42, 
#nullable restore
#line 35 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                                                student.EnrolledDegree.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(43, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, " \r\n");
#nullable restore
#line 36 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                                    ");
            __builder.AddMarkupContent(46, "<span class=\"text-danger\">Not Enrolled</span>\r\n");
#nullable restore
#line 40 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.OpenElement(49, "td");
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 43 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                 if (student.EnrolledDegree != null)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(52);
            __builder.AddAttribute(53, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 45 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                                               ButtonStyle.Danger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "Icon", "remove_circle_outline");
            __builder.AddAttribute(55, "Text", "Remove Degree");
            __builder.AddAttribute(56, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                                                                                                                            () => RemoveDegree(student.Id)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 46 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(59);
            __builder.AddAttribute(60, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 49 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                                               ButtonStyle.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "Icon", "add_circle_outline");
            __builder.AddAttribute(62, "Text", "Enroll Now");
            __builder.AddAttribute(63, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                                                                                                                    () => EnrollDegree(student.Id)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 50 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 53 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\user-pc\Desktop\BitCube\BitcubeEval\BitCube\BitCube.Section3\Pages\Student\_Student.razor"
 
    private Student student;
    private List<Student> students = new List<Student>();

    //Notification Toast to be used to indicate outcome of operations
    NotificationMessage notification = new NotificationMessage { Duration = 4000};

    protected override void OnInitialized()
    {
        students = SampleDataService.GetAllStudents();
    }

    //Method to add new Student to in-memory db(SampleDataService)
    async Task AddStudent()
    {
        student = await DialogService.OpenAsync<AddStudentForm>("Add Student");

        if(student != null)
        {
            students.Add(student);


            notification = new NotificationMessage
            {
                Severity = NotificationSeverity.Success,
                Summary = "Student Added Succesfully",
            };

            NotificationService.Notify(notification);
        }
    }

    //Method to Remove a linked Degree from a student 
    async Task RemoveDegree(int studentId)
    {
        var deleteStudent = SampleDataService.GetStudentById(studentId);
        if (deleteStudent != null)
        {
            //Confirm Dialog
            bool? confirmDelete = await DialogService.Confirm($"Are You Sure You Want to Remove {deleteStudent.FullName} from {deleteStudent.EnrolledDegree.Name} ?",
            "Confirm Deregistration",
            new ConfirmOptions() { OkButtonText = "Yes", CancelButtonText = "Cancel"});

            if(confirmDelete == true)
            {
                SampleDataService.RemoveDegreeFromStudent(studentId);

                students = SampleDataService.GetAllStudents();
                notification = new NotificationMessage
                {
                    Severity = NotificationSeverity.Info,
                    Summary = "Student Removed From Degree",
                };

                NotificationService.Notify(notification);
            }

        }

    }

    //Method to Show a Dialog Form and Select/Set a Degree from dropdown list to a student
    async Task EnrollDegree(int studentId)
    {
        Student editStudent = students.Where(s => s.Id == studentId).FirstOrDefault();
        List<Degree> degrees = SampleDataService.GetAllDegrees();

        //A dialog form to link a Degree to a Student
        editStudent = await DialogService.OpenAsync<EnrollStudent>("Enroll Student To Degree", new Dictionary<string, object> { { "Student", editStudent }, { "Degrees", degrees } });

        if(editStudent != null)
        {
            if(editStudent.EnrolledDegree != null)
            {
                //Update a Student Degree Enrollment to in-memory database
                var enrollStudent = SampleDataService.EnrollStudent(editStudent.Id, editStudent.EnrolledDegree);

                //if update was successfull(will be null if something went wrong)
                if (enrollStudent != null)
                {
                    students = SampleDataService.GetAllStudents();

                    notification = new NotificationMessage
                    {
                        Severity = NotificationSeverity.Info,
                        Summary = "Student Enrolled To a Degree",
                    };

                    NotificationService.Notify(notification);
                }
                else
                {
                    notification = new NotificationMessage
                    {
                        Severity = NotificationSeverity.Error,
                        Summary = "Something went wrong while Updating a Student Degree",
                    };

                    NotificationService.Notify(notification);
                }
            }

        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SampleDataService sampledata { get; set; }
    }
}
#pragma warning restore 1591
