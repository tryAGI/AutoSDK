//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Welcome to the Stability.ai REST API!<br/>
    /// Your DreamStudio API key will be required for authentication: [How to find your API key](https://platform.stability.ai/docs/getting-started/authentication)<br/>
    /// API operations use the following versioning scheme:<br/>
    /// - `/v*` interface is stable and ready for production workloads<br/>
    /// - `/v*beta*`: interface is stable, preparing for production release<br/>
    /// - `/v*alpha*`: under development and the interface is subject to change<br/>
    /// NOTE: The v1alpha and v1beta endpoints from the developer preview are still available, but they<br/>
    /// will disabled on May 1st, 2023.  Please migrate to the v1 endpoints as soon as possible.<br/>
    /// If you have feedback or encounter any issues with the API, please reach out:<br/>
    ///   - [https://github.com/Stability-AI/REST-API](https://github.com/Stability-AI/REST-API)<br/>
    ///   - [https://discord.gg/stablediffusion #API channel](https://discord.com/channels/1002292111942635562/1042896447311454361)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// Enumerate available engines.
        /// </summary>
        public V1EnginesClient V1Engines { get; }

        /// <summary>
        /// Generate images from text, existing images, or both.
        /// </summary>
        public V1GenerationClient V1Generation { get; }

        /// <summary>
        /// Manage your Stability.ai account, and view account/organization balances.
        /// </summary>
        public V1UserClient V1User { get; }

    }
}