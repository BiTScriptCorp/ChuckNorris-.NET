/**
 * INICIALIZA O WEB API BUILDER
 */
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/**
 * INSTANCIA O SISTEMA
 */
var system = new ChuckNorris.System.Core.System(builder, app);

/**
 * INICIA A CONFIGURAÇÃO DO SISTEMA
 */
system.Run();

/**
 * INICIA O SERVIDOR
 */
app.Run();
