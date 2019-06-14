#language: pt

Funcionalidade: Login
	Sendo um usuário cadastrado
	Posso fazer login
	Para ter acesso ao meu painel de atividades

	Cenário: Usuário autenticado
		
		Quando eu faço login com 'diogooliveirati4@gmail.com' e '41679152'
		Então devo ver a mensagem de boas vindas 'Olá, Diogo de OliveiraJulião'

	Cenário: Senha Incorreta
		
		Quando eu faço login com 'diogooliveirati4@gmail.com' e '@abcde'
		Então devo ver a mensagem de notificação 'Senha inválida.'

	Cenario: Usuário não existe
		
		Quando eu faço login com 'diogooliveirati3@gmail.com' e '41679152'
		Então devo ver a mensagem de notificação 'Usuário não cadastrado.'

	Cenário: Senha Ausente

		Quando eu faço login com 'diogooliveirati4@gmail.com' e ''
		Então devo ver a mensagem de notificação 'Senha ausente.'

	Cenário: Email Ausente

		Quando eu faço login com '' e '41679152'
		Então devo ver a mensagem de notificação 'Email incorreto ou ausente.'

	Cenário: Email Incorreto

		Quando eu faço login com 'diogooliveirati*gmail.com' e '41679152'
		Então devo ver a mensagem de notificação 'Email incorreto ou ausente.'