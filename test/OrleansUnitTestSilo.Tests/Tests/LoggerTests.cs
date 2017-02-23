﻿using FluentAssertions;
using OrleansNonSiloTesting;
using OrleansUnitTestSilo.Tests.TestGrainInterfaces;
using OrleansUnitTestSilo.Tests.TestGrains;
using Xunit;
using Xunit.Abstractions;

namespace OrleansUnitTestSilo.Tests.Tests
{
    public class LoggerTests : UnitTestSiloBase
    {
        private readonly ITestOutputHelper _output;

        public LoggerTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact(Skip = "This isn't a real test since we can't assert anything")]
        public void ConsoleLog()
        {
            const string greeting = "Bonjour";

            IHello grain = Silo.CreateGrain<HelloGrain>(1);

            grain.Invoking(g => g.SayHello(greeting)).ShouldNotThrow();
        }

        [Fact(Skip = "This isn't a real test since we can't assert anything")]
        public void XUnitLog()
        {
            const string greeting = "Bonjour";

            IHello grain = Silo.CreateGrain<HelloGrain>(2);

            grain.Invoking(g => g.SayHello(greeting)).ShouldNotThrow();
        }
    }
}
