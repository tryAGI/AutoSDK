﻿//HintName: G.IChatsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create, manage, and interact with chat sessions for conversational AI<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IChatsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}