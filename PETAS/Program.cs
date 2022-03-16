using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Blazored.LocalStorage;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PETAS;
using PETAS.Services;
using Microsoft.Extensions.Http;
using Plk.Blazor.DragDrop;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

#region edited code

builder.Services
      .AddBlazorise(options =>
      {
          options.ChangeTextOnKeyPress = true;
      })
      .AddBootstrapProviders()
      .AddFontAwesomeIcons();

builder.Services.AddSingleton(new HttpClient
{
    BaseAddress = new Uri("https://localhost:7286/")
});

//builder.Services.AddSingleton(new HttpClient
//{
//    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
//});



#endregion

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//setting up URI for API calls
string baseAPIAddress = builder.Configuration["BaseApiUrl"].ToString();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAPIAddress) });

//adding HRMS API Service
builder.Services.AddHttpClient<HRMSClient>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["HRMSApiUrl"].ToString());
    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
});

//adding a mail notification API Service
builder.Services.AddHttpClient<MailClient>(mclient =>
{
    mclient.BaseAddress = new Uri(builder.Configuration["MailClientApiUrl"].ToString());
    mclient.DefaultRequestHeaders.Add("access-control-allow-methods", "[POST]");
    mclient.DefaultRequestHeaders.Add("access-control-allow-methods", "[GET]");
    mclient.DefaultRequestHeaders.Add("access-control-allow-methods", "[PUT]");
    mclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
});

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IUserAccountService, UserAccountService>();
builder.Services.AddScoped<ITrainingDomainService, TrainingDomainService>();
builder.Services.AddScoped<ICertificationAwardService, CertificationAwardService>();
builder.Services.AddScoped<ITrainingCertificationService, TrainingCertificationService>();
builder.Services.AddScoped<ITrainingResourceTypeService, TrainingResourceTypeService>();
builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddScoped<IAssessmentSubjectService, AssessmentSubjectService>();
builder.Services.AddScoped<IQuestionTypeService, QuestionTypeService>();

builder.Services.AddScoped<ITestService, TestService>();
builder.Services.AddScoped<IFileUploadService, FileUploadService>();
builder.Services.AddScoped<IAssessmentQuestionPoolService, AssessmentQuestionPoolService>();
builder.Services.AddScoped<IObjectiveService, ObjectiveService>();
builder.Services.AddScoped<ITrainingResourceService, TrainingResourceService>();
builder.Services.AddScoped<ITrainingTypeService, TrainingTypeService>();
builder.Services.AddScoped<ITrainingService, TrainingService>();

builder.Services.AddScoped<IHRMSService, HRMSService>();
builder.Services.AddScoped<IDragService, DragService>();
builder.Services.AddScoped<IMailService, MailService>();

builder.Services.AddBlazorDragDrop();

builder.Services.AddBlazoredLocalStorage();

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

var host = builder.Build();
var accountService =  host.Services.GetRequiredService<IUserAccountService>();
await accountService.Initialize();

await builder.Build().RunAsync();
