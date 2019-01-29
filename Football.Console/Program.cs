﻿using Football.Domain.Entity;
using Football.Domain.Repository;
using System;

namespace Football.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerRepository repo = new PlayerRepository();
            foreach (var item in repo.GetByName("ma"))
            {
                System.Console.WriteLine(item.Name);
            }

            //System.Console.WriteLine(repo.Get(9).Name);
        }
        
    }
    
}
