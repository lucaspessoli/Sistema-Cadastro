<h1 align="center"> Tela de Login e Cadastro integrado com MySql</h2>
<p align = "center"> <img src="https://user-images.githubusercontent.com/115120374/226198203-08c3e84e-6df6-465f-af38-68763062a42c.png" alt="Tela de Login"> <img src="https://user-images.githubusercontent.com/115120374/226198513-05e5ad98-3202-44ca-afbc-f3fe61008379.png" alt="Tela de Cadastro"> </p>
<p align="center"> UI inspirado em: @CodeCreaks </p>


<h1 align="center"> Informações do Projeto:</h2>

<p align="center"> Projeto com fins de liberar uma template para telas de cadastro e login utilizando C# e MySql, tendo em mente facilitar futuros usos da prática </p>

<h1 align="center"> Ferramentas utilizadas para o desenvolvimento:</h2>


```bash
  Visual Studio (2022)
  Visual Studio Pacotes NuGet: MySqlConnector, MySql.Data
  MySql Workbench 9.0
  MySql Connector/Net
```

<h1 align="center"> Instruções de uso para o Desenvolvedor:</h2>

## Linha 10: em "frmLogin.cs", Altere para o seu servidor, o nome do seu banco de dados, e o usuario e senha para login no banco.

```C#
        string conexaoString = "server=localhost;database=;uid=;pwd=;";
```

## Linha 46: em "frmLogin.cs", Altere para o seu servidor, o nome do seu banco de dados, e o usuario e senha para login no banco.

```C#
        string conexaoString = "server=localhost;database=;uid=;pwd=;";
```

## Linha 51: em "frmLogin.cs" Altere para selecionar a Tabela, e em seguida as colunas, no caso da linha abaixo, registro é a tabela, username e password são as colunas.

```C#
         String seleciona = ("SELECT COUNT(*) FROM registro WHERE username=@user AND password=@senha");
```
<br>
<br>

## Linha 12: em "frmRegistro.cs", Altere para o seu servidor, o nome do seu banco de dados, e o usuario e senha para login no banco.

```C#
         MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=;Uid=;Pwd=");
```

## Linha 29: em "frmRegistro.cs", Criará uma Table caso ainda não exista, substitua "registro" para o nome que você queira dar á sua tabela.

```C#
          MySqlCommand tabela = new MySqlCommand("CREATE TABLE IF NOT EXISTS registro(userid INT AUTO_INCREMENT PRIMARY KEY, username varchar(40) UNIQUE, password varchar(440), email varchar(704) UNIQUE);", conexao);
```

## Linha 33: em "frmRegistro.cs", Substitua o nome da tabela "registro" para a anterior, caso você tenha substituído, esse trecho do código está inserindo os dados passados pelo usuário nas respectivas colunas.

```C#
           MySqlCommand inserir = new MySqlCommand("INSERT INTO registro (username, password, email) VALUES (" + "'" + txtusuario.Text + "', " + "'" + txtSenhaa.Text + "', " + "'" + txtEmaill.Text + "');", conexao);

```
<br>

<h1 align="center"> FAQ:</h2>

## FAQ

#### Funciona com PostgresSQL?

Não, o projeto só tem compatibilidade com o MySQL

#### Problemas com Conexão com o banco de Dados

Certifique-se de estar usando o MySQL 8.0 e ter instalando as extensões do mesmo: "MySQL CONNECTOR / NET"
<br>

Também certifique-se de ter instalado as referencias NuGet em seu projeto: "MySqlConnector", "MySql.Data", Para fazer isso clique com o botão direito no projeto, na aba Gerenciador de Soluções do Visual Studio > Gerenciar pacotes NuGet > Procurar > E procure pelos dois pacotes e os instale.


## Autor

- [@lucaspessoli](https://www.github.com/lucaspessoli)



