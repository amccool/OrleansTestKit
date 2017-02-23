﻿using System.Threading.Tasks;
using Orleans;
using OrleansUnitTestSilo.Tests.TestGrainInterfaces;

namespace OrleansUnitTestSilo.Tests.TestGrains
{
    public class HelloGrain : Grain, IHello
    {
        Task<string> IHello.SayHello(string greeting)
        {
            return Task.FromResult("You said: '" + greeting + "', I say: Hello!");
        }
    }
}