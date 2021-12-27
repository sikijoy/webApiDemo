using webApiDemo.BLL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//解决跨域问题  添加策略  3任何 允许任何的头部请求  允许任何的域名  允许任何的方法 
builder.Services.AddCors(c => c.AddPolicy("any", p => p.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()));

//保持全局单例  注入单例
builder.Services.AddSingleton<UserBLL>();
//再单次请求中保持单例  不会被重复创建
//builder.Services.AddScoped<IApplicationBuilder, ApplicationBuilder>();

// 瞬时的  使用完这个实例后立马被注销掉  下次使用时再new
//builder.Services.AddTransient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 这里使用策略  并在相应的 控制器中 需要加入 [EnableCors("政策名称")]
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
