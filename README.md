# Procedimentos
<h4>Este projeto tem como objetivo o gerenciamento de procedimentos. Nem sempre conseguimos nos lembrar como fazemos as coisas, e este projeto tenta auxiliar neste processo, além de manter o conhecimento centralizado em um local, evitando que o conhecimento se dissipe com o tempo.

<h2>Tecnologias utilizadas</h2>
<ul>
  <li>Visual Studio 2017.</li>
  <li>Linguagem C# - Windows Forms.</li>
  <li>Padrão Layered.</li>  
  <li>Arquivos txt como "Banco de Dados".</li>
  <li> Hash MD5 para guardar as senhas.</li>
</ul>

<h2>Requisitos mínimos</h2>
<ul>
  <li>Caso queira editar o projeto, é recomendado seguir as especificações mínimas do próprio Visual Studio.</li>
  <li>Para utilizar apenas o executavel, um dispositivo para atividades básicas já é o suficiente, pois o programa é bem leve.</li>
  <li>Funciona apenas no Sistema Operacional Windows.</li>
</ul>

<h2>Caso queira utilizar direto o executável</h2>
<p>Ele se encontra no seguinte caminho: Procedimentos -> bin -> debug. Copie todos os arquivos da pasta e use o executável.</p>

<h2>Esquema de arquivos do projeto</h2>
<p>Os usuários são gravados na pasta Usuarios, e os procedimentos na pasta Procedimentos. Somente uma pessoa pode criar usuários por vez, assim como os procedimentos, sendo que o mesmo vale para o modo de edição de ambos. Todos podem consultar os procedimentos ao
mesmo tempo. Em cada procedimento são gravados os passos, o usuário que criou e o último a editar, com suas respectivas datas.</p>
<p>A forma de controle dos usuários que criam e editam os arquivos se dão por meio de arquivos com extensão ".emuso", que são criados 
e excluídos automaticamente. É possível forçar a exclusão destes arquivos pelo programa, em caso de falta de energia.</pp>

<h2>Observações</h2>
<ul>
  <li>Apenas administradores podem criar novos usuários.</li>
  <li>Os administradores são setados via código, no form Consultar. Há um vetor de strings, onde pode-se colocar os códigos desejados.  </li>
<li>Em cada Form, no canto inferior direito há um panel (panelLogo) com um label escrito "Logo", serve para colocar o ícone que desejar, como por exemplo de uma empresa. Caso tenha interesse em colocar com a sua marca basta excluir o label e colocar um backgroundImage no panel.</li>
</ul>
