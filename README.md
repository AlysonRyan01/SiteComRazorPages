Documentando meu site:

1- Adicionei suporte ao Razor Pages com o builder.Services.AddRazorPages(); no Program.cs.

2- Adicionei redirecionamente para Https usando o app.UseHttpsRedirection(); no Program.cs.

3- Adicionei app.UseStaticFiles(); no Program.cs e criamos uma pasta wwwroot para podermos usar arquivos estaticos, como imagens, css, etc;

4- Adicionei app.UseRouting(); no Program.cs para configurar a aplicação para processar o roteamento das requisições, ele determina qual controlador ou endpoint será responsável para processar a requisição com base na URL e nos métodos HTTP (GET, POST, etc.).

5- Adicionei app.MapRazorPages(); no Program.cs para habilitar o roteamento para páginas Razor na aplicação.

6- Criei uma pasta Pages para armazenar nossas Razor Pages;

7- Criei a Razor Page Index para ser a página principal do meu site;

8- 