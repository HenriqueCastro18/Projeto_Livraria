Na disciplina de Design Patterns, desenvolvi um projeto sobre uma Livraria que permite adicionar, atualizar, remover e consultar dados sobre livros e alunos. 
Durante o desenvolvimento, apliquei alguns patterns, como:

1- Singleton: Garantiu que a classe responsável pela conexão com o banco de dados tivesse uma única instância, evitando problemas de múltiplas conexões simultâneas.
2- Template Method: Definiu o esqueleto das operações de manipulação de dados, permitindo que algumas etapas fossem implementadas nas subclasses.
3- Repository: Abstruiu a lógica de acesso ao banco de dados, tornando o código mais modular e fácil de manter.
4- Invoker: Facilitou a execução de comandos de forma desacoplada, permitindo maior flexibilidade nas operações.
5- Command: Permitiu o encapsulamento de ações como objetos, oferecendo uma maneira de tratar comandos de forma independente e flexível.

O banco de dados utilizado foi o MySQL, onde armazenamos as informações dos livros e alunos de maneira estruturada e eficiente.
