using LenchikSite.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Blazored.LocalStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//DBservice.Init_db();

//DBservice.AddFurniture("2000 грн", "https://annihaus.ru/upload/iblock/561/56166c4717cd3ab25b0d15e598f82fb7.jpg", "Стул говна", 1);
//DBservice.AddFurniture("5 грн", "https://static.insales-cdn.com/images/products/1/7330/322198690/%D0%A1%D1%82%D0%BE%D0%BB.jpg", "Стол из шага", 3);
//DBservice.AddFurniture("10 грн", "https://static.insales-cdn.com/images/products/1/7330/322198690/%D0%A1%D1%82%D0%BE%D0%BB.jpg", "Стол денчика", 7);
//DBservice.AddFurniture("30 000 грн", "https://constanta.ua/5396-tm_large_default/divan-bombej.jpg", "Диван Толик", 4);
//DBservice.AddFurniture("30 000 грн", "https://oleksenko.com.ua/wp-content/uploads/2020/06/DSC1588.jpg", "Стул Еблан", 1);

//DBservice.AddUser("ebakasobaka", "ebakasobaka");

DBservice.GetDataFromDB();

builder.Services.AddSingleton<AppState>();

builder.Services.AddBlazoredLocalStorage();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
