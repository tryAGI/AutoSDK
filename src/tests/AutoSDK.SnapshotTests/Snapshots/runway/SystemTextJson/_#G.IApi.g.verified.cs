//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API for generating videos from images and managing tasks. Generated from https://docs.dev.runwayml.com/api/<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}