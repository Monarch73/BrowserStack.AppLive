// Copyright (c) Monarch73, 2022. All rights reserved.
// Licensed under the unlicense license. See the LICENSE file in the project root for full license information.

using System.Net.Http;

namespace Monarch73.BrowserStack.AppLive;

/// <summary>
/// Provides access to the automation of Browserstack App Live api.
/// </summary>
public class BrowserStackAppLiveClient
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BrowserStackAppLiveClient"/> class.
    /// Creates an instance of BrowserStackAppLive Client.
    /// </summary>
    /// <param name="userName">Username.</param>
    /// <param name="password">Password.</param>
    public BrowserStackAppLiveClient(string userName, string password)
        : this(userName, password, new HttpClient())
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BrowserStackAppLiveClient"/> class.
    /// </summary>
    /// <param name="userName">Username for Browserstack API.</param>
    /// <param name="password">Password for Browserstack API.</param>
    /// <param name="http">HttpClient interface.</param>
    public BrowserStackAppLiveClient(string userName, string password, HttpClient http)
    {
        this.Username = userName;
        this.Password = password;
        this.Http = http;
    }

    /// <summary>
    /// Gets the Username for the BrowserStack API.
    /// </summary>
    public string Username { get; }

    /// <summary>
    /// Gets the Password used for the BrowserStack API.
    /// </summary>
    public string Password { get; }

    /// <summary>
    /// Gets access to the HttpClient instance.
    /// </summary>
    public HttpClient Http { get; }
}
