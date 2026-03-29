//HintName: G.Models.GetToolkitsBySlugResponseAuthConfigDetailProxy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for proxying authentication requests to external services
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseAuthConfigDetailProxy
    {
        /// <summary>
        /// URL to which authentication requests will be proxied<br/>
        /// Example: https://auth.example.com/proxy
        /// </summary>
        /// <example>https://auth.example.com/proxy</example>
        [global::Newtonsoft.Json.JsonProperty("base_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BaseUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailProxy" /> class.
        /// </summary>
        /// <param name="baseUrl">
        /// URL to which authentication requests will be proxied<br/>
        /// Example: https://auth.example.com/proxy
        /// </param>
        public GetToolkitsBySlugResponseAuthConfigDetailProxy(
            string baseUrl)
        {
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailProxy" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseAuthConfigDetailProxy()
        {
        }
    }
}