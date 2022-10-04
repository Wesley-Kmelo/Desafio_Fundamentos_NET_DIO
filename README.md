# Desafio_Fundamentos_NET_DIO

Projeto de aplicativo console desenvolvido em C#, baseado em desafio proposto pelo mestre [Leonardo Buta](https://github.com/leonardo-buta).

Nesse desafio foi proposto a criação de um aplicativo console que gerencie um estacionamento. O aplicativo deve conter três métodos :
> * Adicionar Placa
> * Remover Placa
> * Listar todas as Placas

Foi disponibilizado um projeto incompleto para que possamos completar o restante do [código](https://github.com/leonardo-buta/trilha-net-fundamentos-desafio) seguindo os ensinamentos já adquiridos.

Resolvi fazer o aplicativo do zero, aplicando apenas os conhecimentos adquiridos. Nesse aplicativo tem os métodos solicitados , mas também algumas melhorias com finalidade de tornar mais amigável a experiência de quem está usando.

Dessa forma, o aplicativo inicia solicitando o nome de quem está utilizando. Caso o usuário deseje, o nome pode ser alterado antes de começar a utilizar o sistema.

Em seguida é mostrado um MENU onde estão as opçoes para utilizar o Sistema.

>O método ADICIONAR adiciona a placa(*string*) e um valor Inicial(*decimal*) em uma lista, além de formatar a placa como XXX-XXXX.
>
>O método REMOVER , verifica se existe alguma placa cadastrada no sistema. Senão houver, exibe uma mensagem de erro e retorna ao MENU. Em caso de haver, solicita a placa e se existir, solicita qual o tempo de estacionamento e em seguida o valor da hora e depois calcula o produto desses dois valores mais o valor inicial. Depois ainda pergunta se realmente quer remover a placa.  E se não existir a placa retorna uma mensagem de erro personalizada , afirmando que a placa não existe e solicitando que seja conferida através da opção LISTAR.
>
>O método LISTAR como o nome diz lista todos os veículos. Configurado uma mensagem estilizada também.

Esse projeto prático faz parte do bootcamp de .NET Developer oferecido pela [Digital Innovation One](https://www.dio.me/) em parceria com a [Pottencial](https://pottencial.com.br/). 

Para esse projeto, foram utilizados a .NET 6.0 , Ubuntu 20.04LTS e Visual Studio Code, configurado com plugins [C# Microsoft](https://github.com/OmniSharp/omnisharp-vscode) e [C# Extensions by JosKreativ](https://github.com/kreativjos/csharpextensions).



