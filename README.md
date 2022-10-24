<h1 align="center"> Desafio Técnico SINQIA - Pontos Turísticos</h1>

<p align="center">
<img src="https://img.shields.io/static/v1?label=STATUS&message=CONCLUIDO&color=GREEN&style=for-the-badge"/>
</p>

### Tópicos 

- [Descrição do projeto](#descrição-do-projeto)

- [Compilar](#compilar)

- [Agradecimentos](#agradecimentos)

## Descrição do projeto 
<p align="justify">
 Projeto desenvolvido para resolver o desafio: 
 
Deve ser criado uma aplicação para o cadastro e listagem de pontos turísticos do país, cada ponto turístico deve ter o nome, descrição até 100 caracteres e localização (endereço ou referência de localização), cidade e estado. Deve ser possível na página inicial listar de forma paginada os cadastros ordenados de forma descrente pela data de inclusão e permitir buscar/filtrar digitando um termo de busca analisando tanto nome e descritivo quanto localização dos pontos turísticos cadastrados. A página deve listar os pontos com o nome e localização. Ao ser selecionado o ponto turístico deve ser demonstrada o nome, descrição e localização. No cadastro, os estados devem ser listados como combo/dropdown e a cidade ou pode ser texto livre, ou buscar de algum webservice online disponível na internet as cidades de acordo com o estado selecionado. Criar um menu de navegação para alternar entre o formulário de cadastro e a listagem. <br />
 
Para a solução optei por criar uma SPA com Angular 14, utilizando typescript, html, css, jquery, bootstrap. O qual consume uma API .NET core 6.0 distruibuido em camadas

## Compilar

<p align="justify"> 
  :heavy_check_mark: 1º: <a href="https://nodejs.org/en/download/" target="_blank"> Download do Node - versão utilizada v16.17.1 </a> finalizando o download execute node -v para certificar de que foi instalado corretamente, o comando retornará a versão do node instalada. <br /> <br />
  :heavy_check_mark: 2º:  <a href="https://angular.io/cli" target="_blank"> Angular CLI  </a>  - para executar a instalação abra um terminal como administrador e execute 'npm install -g @angular/cli'. <br />
</p>

Após concluído o download vá para o caminho
<ol>
  <li> Sistema </li>
  <li> Configuração avançadas do sistema </li>
  <li> Variáveis de Ambiente </li>
  <li> Path </li>
  <li> Editar </li>
</ol>  
  
Deverá encontrar algo semelhante a imagem abaixo:
<p align="center">
   <img src="https://i.stack.imgur.com/FUPTb.jpg"/>
</p> <br /><br />
 

Para compilar o BackEnd precisará ter instalado:
 <ol>
  <li> <a href="https://dotnet.microsoft.com/en-us/download/dotnet/6.0" target="_blank"> net core 6.0 </a> </li>
  <li> <a href="https://www.microsoft.com/pt-br/sql-server/sql-server-download" target="_blank"> Sql Server </a> </li>
  <li> <a href="https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16" target="_blank"> SQL Server Management Studio (SSMS)
 </a> </li>
   <li> <a href="https://visualstudio.microsoft.com/pt-br/downloads/" target="_blank"> Visual Studio 2022 </a> </li>
</ol>  
<br />

Ambiente devidamente configurado. <br />
 <ol>
  <li> Abra a solução no diretório 'Seucaminho...\DesafioPontosTuristicos\DesafioPontosTuristicos.sln' através do Visual Studio. </li>
  <li> Abra o Console Gerenciador de Pacotes pelo caminho <b>-> Exibir > Outras Janelas > Console Gerenciador de Pacotes </b>  </li>
  <li> Defina como como Padrão o Projeto Infra.Data </li>
  <li> Ajusta a string de conexão de acordo com a sua configuração local</li>
  <li> Execute o comando update-database para gerar o banco de dados local </li>
  <li> Clique com lado direito do mouse em cima do Projeto API depois vai em Definir com projeto de inicialização e executa </li>
</ol>  
<br />

Para compilar o FrontEnd, acesse seu editor de código preferido, navegue e acesse o diretório C:\Users\YouUser\DesafioPontosTuristicos\Presentation\DesafioAPP e dentro do Diretório execute os comandos abaixo:

 <ol>
  <li> 'npm install' -> realiza download das dependências do projeto</li>
  <li> 'ng serve -o' -> compila o projeto no seu navegador padrão</li>
</ol>  
<br />

### OBS: Qualquer problema ou duvidas na compilação, estou à disposição.

## Agradecimentos
 
Agradecer pela oportunidade de estar participando do processo e seletivo e agradecer em especial a Leticia e Rosângela, recruiters da Sinqia. Muito Obrigado ❤️


