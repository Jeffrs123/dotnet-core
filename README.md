# INICIADO

## Template WEB

Projeto WEB:
- vazio
- simples
- É o templete mais cru, que podemos criar.
- Printa na tela um Hello World

        dotnet new web -n ProAgil.Web

---


## Template API

Apresenta Service:

- AddMVC()
- Qtd de referências são diferentes, maior em relação ao template WEB
- Preza na tela o que estiver dentro do controler, ou seja, arquitertura **`MVC`**.
- Dentro do controler as configurações de quais são as rotas, as persistências.
- GET, POST e 

dotnet new api -n ProAgil.API


---

## Template MVC

- Também tem controlers
- Tem MODELS
- Tem View
- Pasta root com referência de Bootstrap, Jquery, arquivo JavaScript, CSS
- Controler não esta retornando um json/string, ela retornará um **"View()"**

        dotnet new mvc -n ProAgil.MVC


---

## Por qual começar

Como objetivo do curso é usar .NET + Angular.
**WEB** -> Por ser cru demais, não é recomendado.
**MVC** -> Completo, trabalha com views e razor.
**WEBAPI** -> Como usaremos o Angular como Front, este será o mais recomendado para o curso.

## COMANDOS

dotnet watch run -> Rodar, e assistir as alterações. Porém, no browser ainda precisamos sempre dar o refresh da página.

Adicionar campo imageURL

Model > Evento.cs Adicionar

        public string ImagemURL { get; set; }

no terminal: 

        dotnet ef migrations add 'qualquer coisa'

        dotnet ef database update


ou, como no caso era pequeno. Deletei:

        "ProAgil.db"

E então rodei novamente:

        dotnet ef migrations add init


---


