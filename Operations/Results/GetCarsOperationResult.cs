﻿using System;
using System.Collections.Generic;
using Db4o_Sprawozdanie.Models;

namespace Db4o_Sprawozdanie.Operations.Results
{
    public class GetCarsOperationResult : IOperationResult
    {
        public IEnumerable<Car> Results { get; set; }

        public void LogResult()
        {
            int iterator = 1;
            foreach (var car in Results)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine($"{iterator}. {car}");
                Console.WriteLine("---------------------------");
                iterator++;
            }
        }
    }
}
