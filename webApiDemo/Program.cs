using webApiDemo.BLL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//�����������  ��Ӳ���  3�κ� �����κε�ͷ������  �����κε�����  �����κεķ��� 
builder.Services.AddCors(c => c.AddPolicy("any", p => p.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()));

//����ȫ�ֵ���  ע�뵥��
builder.Services.AddSingleton<UserBLL>();
//�ٵ��������б��ֵ���  ���ᱻ�ظ�����
//builder.Services.AddScoped<IApplicationBuilder, ApplicationBuilder>();

// ˲ʱ��  ʹ�������ʵ��������ע����  �´�ʹ��ʱ��new
//builder.Services.AddTransient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ����ʹ�ò���  ������Ӧ�� �������� ��Ҫ���� [EnableCors("��������")]
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
