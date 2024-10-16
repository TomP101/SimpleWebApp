var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.UseStaticFiles();

// Main endpoint that displays a welcome message and a link to the CV
app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/html"; 
    await context.Response.WriteAsync(@"
        <html>gg
        <head>
            <title>Welcome to Tomasz's Site</title>
            <style>
                body {
                    font-family: Arial, sans-serif;
                    text-align: center;
                    margin-top: 50px;
                }
                h1 {
                    color: #333;
                }
                a {
                    color: #0066cc;
                    text-decoration: none;
                    font-weight: bold;
                }
                a:hover {
                    text-decoration: underline;
                }
            </style>
        </head>
        <body>
            <h1>Hello, my name is Tomasz, welcome to my site!</h1>
            <p>Click <a href='/Tomasz_CV.pdf' target='_blank'>here</a> to view my CV.</p>
        </body>
        </html>
    ");
});

app.Run();
