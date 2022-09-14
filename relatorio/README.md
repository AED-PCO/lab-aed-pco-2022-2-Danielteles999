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
Para cada aula de laboratório, salvar print da execução de cada atividade com o resultado da execução do programa.
