Documentando meu site:

1- Adicionei suporte ao Razor Pages com o builder.Services.AddRazorPages(); no Program.cs.

2- Adicionei redirecionamente para Https usando o app.UseHttpsRedirection(); no Program.cs.

3- Adicionei app.UseStaticFiles(); no Program.cs e criamos uma pasta wwwroot para podermos usar arquivos estaticos, como imagens, css, etc;

4- Adicionei app.UseRouting(); no Program.cs para configurar a aplicação para processar o roteamento das requisições, ele determina qual controlador ou endpoint será responsável para processar a requisição com base na URL e nos métodos HTTP (GET, POST, etc.).

5- Adicionei app.MapRazorPages(); no Program.cs para habilitar o roteamento para páginas Razor na aplicação.

6- Criei uma pasta Pages para armazenar nossas Razor Pages;

7- Criei a Razor Page Index para ser a página principal do meu site;

8- Criei a pasta Shared para colocar os itens que podem ser usados multiplas vezes.

9- Criei a classe _ViewImports para conter as configurações das páginas, como using..., @AddTagHelpers, etc.

10- Criei a classe _Layout para conter o Header e o Footer das minhas páginas.

11- Conectei todas as minhas Razor Pages com o _Layout, crindo a página _ViewStart.

12- Criei a ViewData no title da minha página _Layout.

13- Criei minha classe css dentro do wwwroot/css e linkei na classe _Layout.

14- Criei os Models.

15- Criei o DataContext e os Mappings.