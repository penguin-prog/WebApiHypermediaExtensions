﻿using Bluehands.Hypermedia.Client.Extensions.SystemTextJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Test.StringParserTests
{
    [TestClass]
    public class SystemTextJsonParserTest : JsonParserTestBase
    {
        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();
            Parser = new SystemTextJsonStringParser();
        }
    }
}