using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// leggo i parametri da appsetting
string iusser = builder.Configuration.GetSection("issuer").ToString();
string audience = builder.Configuration.GetSection("audience").ToString();
string key = builder.Configuration.GetSection("key").ToString();

builder.Services.AddAuthentication().AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true, //significa che se issuer == la stringa che definisco allora puo passare
        ValidateAudience = true,
        ValidateLifetime = true,//metto una scadenza al token
        ValidateIssuerSigningKey = true,//
        ValidIssuer = iusser,// è il sito che genera il token jwt
        ValidAudience = audience,//chi consuma, quindi le nostre api
        IssuerSigningKey = new SymmetricSecurityKey(
    Encoding.UTF8.GetBytes(key))//dobbiamo superare i 256 bit.OGNI 8 BIT SONO 1 BYTE QUINDI 1 CARATTERE!!!!!
    };
});
var app = builder.Build();