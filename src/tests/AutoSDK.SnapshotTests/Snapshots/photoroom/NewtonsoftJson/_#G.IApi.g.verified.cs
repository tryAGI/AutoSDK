//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Photoroom API takes an image as input, applies edits (background removal, AI backgrounds, shadows, relighting, text removal, flat lay, ghost mannequin, virtual model, and more), and returns the edited image.<br/>
    /// For tested parameter combinations for common use cases, see our tutorials before building your integration:<br/>
    /// - Second-hand marketplace listings: https://docs.photoroom.com/tutorials/how-to-improve-images-for-second-hand-item-marketplaces<br/>
    /// - E-commerce with brand consistency: https://docs.photoroom.com/tutorials/how-to-create-e-commerce-images-with-consistent-brand-guidelines<br/>
    /// - Food delivery apps: https://docs.photoroom.com/tutorials/how-to-create-food-delivery-images-with-consistent-brand-guidelines<br/>
    /// - Google Shopping compliance: https://docs.photoroom.com/tutorials/how-to-create-compliant-product-images-for-google-shopping<br/>
    /// - Sticker images: https://docs.photoroom.com/tutorials/how-to-create-sticker-images<br/>
    /// To use the API, you need an API key. Create one at https://app.photoroom.com/api-dashboard. The key must be passed in the x-api-key header on every request.<br/>
    /// Full documentation: https://docs.photoroom.com<br/>
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
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::G.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}