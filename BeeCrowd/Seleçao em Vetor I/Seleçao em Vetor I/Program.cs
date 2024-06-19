﻿/*
 Faça um programa que leia um vetor A[100]. No final, mostre todas as posições do vetor que armazenam um valor menor ou igual a 10 e 
o valor armazenado em cada uma das posições.

Entrada
A entrada contém 100 valores, podendo ser inteiros, reais, positivos ou negativos.

Saída
Para cada valor do vetor menor ou igual a 10, escreva "A[i] = x", onde i é a posição do vetor e x é o valor armazenado na posição, 
com uma casa após o ponto decimal.

Exemplo de Entrada	
0
-5
63
-8.5
...

Exemplo de Saída
A[0] = 0.0
A[1] = -5.0
A[3] = -8.5
...
 */
using System;

namespace BeeCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[100];
            for (int i = 0; i < vetor.Length; i++)
            {
                double input = double.Parse(Console.ReadLine());
                vetor[i] = input;
            }
            for (int i = 0; i < vetor.Length; i++) 
            {
                if (vetor[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {vetor[i].ToString("f1")}");
                }
            }
        }
    }
}