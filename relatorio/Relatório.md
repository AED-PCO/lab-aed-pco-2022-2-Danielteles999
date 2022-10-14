# Documentação da aula de laboratório

## Laboratório 1

### Atividade 1
Alguns números de quatro algarismos possuem uma característica particular. Se separamos 
esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado 
é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
 
Número = 3025 
Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025.
 
Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

A solução se encontra no arquivo Lab1 atv1.cs

Para a resolução deste exercício, utilizei do método substring.
Primeiro criei o looping passando pelo intervalo de 1000 a 9999, e em cada número converti o mesmo para string pelo Convert.ToString(). Após isto, dividi a strig em duas partes com o método substring.Transformei cada uma das partes em um número inteiro e fiz a operação.
somei as duas partes e mutipliquei pela mesma soma, colocando um if paa finalizar exibindo somente se o quadrado da soma for igual ao número passado pelo for.

Foi feito no Visual Studio Professional 2017, no formato .cs

![image](https://user-images.githubusercontent.com/107625244/190033178-a6e2583f-d02b-430f-9f86-333478697784.png)

------------------------------------------------------------------------

### Atividade 2

Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras 
palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é 
Primo.
Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por 
exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
Faça um programa que liste os números perfeitos de 1 a 1000.

A solução se encontra no arquivo Lab1 atv2.cs

Primeira parte do código foi traquila colocando um if para verificar se o número informado é divisível por um número gerado pelo for até o próprio número informado. E a cada resultado que o resto for zero, é incrementado um contador. Se o contador for menor ou igual a 2 o número informado é primo. Mas se o número do contador for maior, o número não é primo.

Segunda parte do código consistiu em verificar os número perfeitos. Então fiz um looping com  while para executar enquanto a variável for menor que 1000 e incrementando a mesma. dentro deste looping fiz um for incrementando i. dentro do for coloquei um if para verificar se o número gerado pelo while é divisível pelo número gerado pelo for, se true, o programa vai somando o valor com valor anterior da variavél soma. Se a soma for igual ao número inicial, fornecido pelo while, o console eibirá o número na tela.

Foi feito no Visual Studio Professional 2017, no formato .cs

![image](https://user-images.githubusercontent.com/107625244/190034446-34b0cc97-103a-43f4-87e9-1f4fa9771a9f.png)

------------------------------------------------------------------------

### Atividade 3

Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
Considere que nenhum dos vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.

[Não rodou 100%... ainda em construção]

------------------------------------------------------------------------

### Atividade 4

Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

A solução se encontra no arquivo Lab1 atv4.cs

Primeiramente criei um looping para criar a matriz lendo cada posição, para isso utilizei dois for, para linha e para coluna. Após a leitura e armazenamento, primeiro comecei a somar as linhas. Criei um while para executar quando uma das variaveis for verdadeira E quando a quantidade de linhas atingir o limite. 

(Utilizei uma variavel bool para controlar a repetição do while, pois o for não estava entrando em looping corretamente...)

Criei um for passando pela quantidade de colunas. No início já solicitei a soma do valor da posição + valor atual da soma. Lembrando que a soma das linhas consiste em um valor de linha que varia somente quando passar por todas as colunas. A incrementação da posição da linha foi controlada "manualmente".

Se a linha atingiu seu limite (length), dentro desta mesma condição, se o número gerado de colunas for igual a posição final, a varivel bool acusará false para interromper o looping e executar o código. Exibirá a soma da linha, e resetará a variavel somaLinha para receber a soma de uma nova linha. Coloquei outro controle de que o valor da linha só incrementará se o mesmo ser menor que o limite.

A mesma implementação ocorreu para a soma das colunas, porém neste caso o while incrementou a coluna e o for controlou o valor das linhas.

Foi feito no Visual Studio Professional 2017, no formato .cs

![image](https://user-images.githubusercontent.com/107625244/190036742-222fce45-5de2-44c5-ab34-62422b71ad22.png)


------------------------------------------------------------------------
### Atividade 5

Função capaz de calcular x elevado a y. Utilize a passagem por referencia

Muito bem, primeira coisa é pedir as entradas para o usuário. Peço o número e o expoente para a operação. E passo a uma função os valores lidos com o "ref".

Dentro da função, recendo com o ref. Faço um laço para fazer a operação interna, vou somando um avariavel a ela mesma multimplicando pelo número informando. O looping para quando o i é menor que o expoente. Depois retorno a variavel com o valor para o Main, o qual retorno o valor com uma string.

![image](https://user-images.githubusercontent.com/107625244/195958344-5fac1a3e-1368-413f-97e7-d4959b9800b2.png)



Foi feito no Visual Studio 2017

------------------------------------------------------------------------
### Atividade 6

Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

Olha bem simples, Primeira coisa é receber as entradas. 
Para fazer a operação, criei uma função Fatorial recebendo o valor lido no Main. Faço um laço que soma uma variavel a ela mesma multíplicando a i. Detalhe, este laço começa com o valor lido -1, o qual incrementa a partir de cada repetição. Após isto retorno a variável ao Main, que o exibe com uma string.

![image](https://user-images.githubusercontent.com/107625244/195958548-feef3a01-7c24-40bd-90c1-d47e644bd5fd.png)


Para cada aula de laboratório, salvar print da execução de cada atividade com o resultado da execução do programa.
