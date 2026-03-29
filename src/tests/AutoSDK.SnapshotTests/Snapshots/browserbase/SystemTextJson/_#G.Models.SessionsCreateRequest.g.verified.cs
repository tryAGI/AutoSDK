//HintName: G.Models.SessionsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsCreateRequest
    {
        /// <summary>
        /// The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensionId")]
        public string? ExtensionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browserSettings")]
        public global::G.SessionsCreateRequestBrowserSettings? BrowserSettings { get; set; }

        /// <summary>
        /// Duration in seconds after which the session will automatically end. Defaults to the Project's `defaultTimeout`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Set to true to keep the session alive even after disconnections. Available on the Hobby Plan and above.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepAlive")]
        public bool? KeepAlive { get; set; }

        /// <summary>
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxies")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>>, bool?>))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>>, bool?>? Proxies { get; set; }

        /// <summary>
        /// The region where the Session should run.<br/>
        /// Default Value: us-west-2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionsCreateRequestRegionJsonConverter))]
        public global::G.SessionsCreateRequestRegion? Region { get; set; }

        /// <summary>
        /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userMetadata")]
        public object? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsCreateRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.
        /// </param>
        /// <param name="extensionId">
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </param>
        /// <param name="browserSettings"></param>
        /// <param name="timeout">
        /// Duration in seconds after which the session will automatically end. Defaults to the Project's `defaultTimeout`.
        /// </param>
        /// <param name="keepAlive">
        /// Set to true to keep the session alive even after disconnections. Available on the Hobby Plan and above.
        /// </param>
        /// <param name="proxies">
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.
        /// </param>
        /// <param name="region">
        /// The region where the Session should run.<br/>
        /// Default Value: us-west-2
        /// </param>
        /// <param name="userMetadata">
        /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsCreateRequest(
            string? projectId,
            string? extensionId,
            global::G.SessionsCreateRequestBrowserSettings? browserSettings,
            int? timeout,
            bool? keepAlive,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>>, bool?>? proxies,
            global::G.SessionsCreateRequestRegion? region,
            object? userMetadata)
        {
            this.ProjectId = projectId;
            this.ExtensionId = extensionId;
            this.BrowserSettings = browserSettings;
            this.Timeout = timeout;
            this.KeepAlive = keepAlive;
            this.Proxies = proxies;
            this.Region = region;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsCreateRequest" /> class.
        /// </summary>
        public SessionsCreateRequest()
        {
        }
    }
}