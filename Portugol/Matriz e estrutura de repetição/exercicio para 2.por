programa
{
//2- Desenvolver um sistema que efetue a soma de todos os números ímpares que são 
//múltiplos de três e que se encontram no conjunto dos números de 1 até 500.
    funcao inicio()
    {
        inteiro soma = 0, i

        para (i = 0; i < 30; i++)
        {
            se ((i % 2 != 0) e (i % 3 == 0))
            {
                soma += i
            }
        }
         escreva(soma)
    }
}
