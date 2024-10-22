//HintName: G.IPersonalizedVideoClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Import contacts into your HeyGen **Personalized Video** campaign. <br/>
    /// **Guide**: [https://docs.heygen.com/docs/import-contacts-via-api](https://docs.heygen.com/docs/import-contacts-via-api)  <br/>
    /// Reference: [https://docs.heygen.com/reference/add-contact](https://docs.heygen.com/reference/add-contact)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IPersonalizedVideoClient : global::System.IDisposable
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
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}