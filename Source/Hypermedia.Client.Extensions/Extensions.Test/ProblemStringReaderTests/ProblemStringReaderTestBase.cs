﻿using Bluehands.Hypermedia.Client.Reader;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Test.ProblemStringReaderTests
{
    public class ProblemStringReaderTestBase
    {
        protected string ProblemString { get; set; }

        protected IProblemStringReader ProblemReader { get; set; }

        [TestMethod]
        public void ProblemStringReaderTest()
        {
            var canRead = ProblemReader.TryReadProblemString(ProblemString, out var description);
            canRead.Should().BeTrue();
            description.Title.Should().Be("SomeProblem");
            description.ProblemType.Should().Be("UnitTestProblem");
            description.Detail.Should().Be("This Unit Test was unexpectedly green");
            description.StatusCode.Should().Be(42);
        }
    }
}