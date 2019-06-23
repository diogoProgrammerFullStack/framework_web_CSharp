#language: pt

Funcionalidade: Criar Tarefas
	Para que eu possa gerenciar minhas atividades do dia a dia
	Sendo um usuário cadastrado
	Posso criar novas tarefas
	
	Contexto: Login
		Dado que estou logado com 'diogooliveirati4@gmail.com' e '41679152'

	Cenário: Nova Tarefa
		
		E que 'Revisar as aulas' é a minha nova tarefa
		E esta tarefa deve ser concluida até '04/04/2020'
		E quero taguear esta tarefa com:
		| tags        |
		| csharp      |
		| programacao |
		| specflow    |
		Quando eu faço o cadastro desta tarefa 
		Entao um novo registro deve ser inserido na lista de tarefas

	#Teste negativo
	Cenário: Tarefa duplicada
		
		E que 'Estudar MongoDB' é a minha nova tarefa
		E esta tarefa deve ser concluida até '04/04/2020'
		Mas eu ja cadastrei esta tarefa e não tinha percebido
		Quando eu faço o cadastro desta tarefa
		Entao devo ver a mensagem de alerta 'Tarefa duplicada.'
		E devo ver somente 1 registro com o nome desta tarefa
