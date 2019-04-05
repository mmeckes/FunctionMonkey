﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using FunctionMonkey.Tests.Integration.Http.Helpers;
using Xunit;

namespace FunctionMonkey.Tests.Integration.Http
{
    public class HttpFunctionWithNoRouteShould : AbstractHttpFunctionTest
    {
        [Fact]
        public async Task Return200()
        {
            HttpResponseMessage response = await Settings.Host
                .AppendPathSegment("HttpCommandWithNoRoute")
                .GetAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}