﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                ConversorDeMoeda conversorDeMoeda = new ConversorDeMoeda();
                conversorDeMoeda.Apresentacao();
                conversorDeMoeda.Cadastrar();
                conversorDeMoeda.ConverterMoeda();
            }
            catch (Exception)
            {
                Console.WriteLine("Programa encerrado, agradecemos a sua participação! ;D");
            }
        } 

    }
}