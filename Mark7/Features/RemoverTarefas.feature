#language: pt

Funcionalidade: Remover Tarefas
	Para que eu possa gerenciar minhas atividades do dia a dia
	Sendo um usuário cadastrado
	Posso remover tarefas

	Contexto: Login
		Dado que estou logado com 'diogooliveirati4@gmail.com' e '41679152'

	Cenário: Remover Tarefa
		
		E que 'Revisar as aulas' é a minha nova tarefa
		E esta tarefa deve ser concluida até '04/04/2020'
		E quero taguear esta tarefa com:
		| tags        |
		| csharp      |
		| programacao |
		| specflow    |
		Quando eu faço o cadastro desta tarefa 
		E eu remover está tarefa 'Revisar as aulas'
		Entao deve exibir a mensagem 'Hmm... nenhuma tarefa encontrada :('

		