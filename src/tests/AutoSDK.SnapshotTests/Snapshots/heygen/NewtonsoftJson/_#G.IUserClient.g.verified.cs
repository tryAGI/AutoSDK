﻿//HintName: G.IUserClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Obtain information about your account.<br/>
    /// **Reference**: [https://docs.heygen.com/reference/get-remaining-quota-v2](https://docs.heygen.com/reference/get-remaining-quota-v2)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IUserClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}