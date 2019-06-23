#language: pt

Funcionalidade: Login
	Sendo um usuário cadastrado
	Posso fazer login
	Para ter acesso ao meu painel de atividades

	Cenário: Usuário autenticado
		
		Quando eu faço login com 'diogooliveirati4@gmail.com' e '41679152'
		Então devo ver a mensagem de boas vindas 'Olá, Diogo de OliveiraJulião'

		Esquema do Cenário: Tentar logar

		Quando eu faço login com <email> e <senha>
		Então devo ver a mensagem de notificação <alerta>

		Exemplos:
		| email                        | senha      | alerta                        |
		| 'diogooliveirati4@gmail.com' | '@abcde'   | 'Senha inválida.'             |
		| 'diogooliveirati3@gmail.com' | '41679152' | 'Usuário não cadastrado.'     |
		| 'diogooliveirati4@gmail.com' | ''         | 'Senha ausente.'              |
		| ''                           | '41679152' | 'Email incorreto ou ausente.' |
		| 'diogooliveirati*gmail.com'  | '41679152' | 'Email incorreto ou ausente.' |
