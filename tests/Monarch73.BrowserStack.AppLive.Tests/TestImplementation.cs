// Copyright (c) Monarch73, 2022. All rights reserved.
// Licensed under the unlicense license. See the LICENSE file in the project root for full license information.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monarch73.BrowserStack.AppLive;

namespace Monarch73.BrowserStack.AppLive.Tests;

/// <summary>
/// Implements various tests.
/// </summary>
[TestClass]
public class TestImplementation
{
    /// <summary>
    /// Tests basic connectivity.
    /// </summary>
    [TestMethod]
    public void TestConnectivity()
    {
        var test = new BrowserStackAppLiveClient(string.Empty, string.Empty);
        using (var abc = new HttpClient())
        {
            var test2 = new BrowserStackAppLiveClient(string.Empty, string.Empty, abc);
        }
    }
}
