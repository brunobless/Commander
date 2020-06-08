﻿using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>()
            {
                new Command() {
                    Id = 0,
                    HowTo = "Boil an egg",
                    Line = "Boil water",
                    Plattform = "Kettle & Pan"
                },
                new Command() {
                    Id = 1,
                    HowTo = "Cut bread",
                    Line = "Get a knife",
                    Plattform = "Knife & choppong board"
                },
                new Command() {
                    Id = 2,
                    HowTo = "Make cup of tea",
                    Line = "Place teabag in cup",
                    Plattform = "Kettle & cup"
                },
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command()
            {
                Id = 0,
                HowTo = "Boil an egg",
                Line = "Boil water",
                Plattform = "Kettle & Pan"
            };
        }
    }
}