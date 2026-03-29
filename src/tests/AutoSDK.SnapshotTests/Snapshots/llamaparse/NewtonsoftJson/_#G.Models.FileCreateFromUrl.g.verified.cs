//HintName: G.Models.FileCreateFromUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating a file from a URL.
    /// </summary>
    public sealed partial class FileCreateFromUrl
    {
        /// <summary>
        /// Name that will be used for created file. If possible, always include the file extension in the name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL of the file to download
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// URL of the proxy server to use for downloading the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxy_url")]
        public string? ProxyUrl { get; set; }

        /// <summary>
        /// Headers to include in the request when downloading the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestHeaders { get; set; }

        /// <summary>
        /// Whether to verify the SSL certificate when downloading the file<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verify_ssl")]
        public bool? VerifySsl { get; set; }

        /// <summary>
        /// Whether to follow redirects when downloading the file<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("follow_redirects")]
        public bool? FollowRedirects { get; set; }

        /// <summary>
        /// Resource information for the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_info")]
        public object? ResourceInfo { get; set; }

        /// <summary>
        /// Storage type for the file. Valid values: 'Ephemeral', 'Permanent' (no expiration). If not specified, defaults to permanent storage.<br/>
        /// Default Value: permanent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_type")]
        public global::G.AnyOf<global::G.FileCreateFromUrlStorageType?, string>? StorageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCreateFromUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the file to download
        /// </param>
        /// <param name="name">
        /// Name that will be used for created file. If possible, always include the file extension in the name.
        /// </param>
        /// <param name="proxyUrl">
        /// URL of the proxy server to use for downloading the file
        /// </param>
        /// <param name="requestHeaders">
        /// Headers to include in the request when downloading the file
        /// </param>
        /// <param name="verifySsl">
        /// Whether to verify the SSL certificate when downloading the file<br/>
        /// Default Value: true
        /// </param>
        /// <param name="followRedirects">
        /// Whether to follow redirects when downloading the file<br/>
        /// Default Value: true
        /// </param>
        /// <param name="resourceInfo">
        /// Resource information for the file
        /// </param>
        /// <param name="storageType">
        /// Storage type for the file. Valid values: 'Ephemeral', 'Permanent' (no expiration). If not specified, defaults to permanent storage.<br/>
        /// Default Value: permanent
        /// </param>
        public FileCreateFromUrl(
            string url,
            string? name,
            string? proxyUrl,
            global::System.Collections.Generic.Dictionary<string, string>? requestHeaders,
            bool? verifySsl,
            bool? followRedirects,
            object? resourceInfo,
            global::G.AnyOf<global::G.FileCreateFromUrlStorageType?, string>? storageType)
        {
            this.Name = name;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ProxyUrl = proxyUrl;
            this.RequestHeaders = requestHeaders;
            this.VerifySsl = verifySsl;
            this.FollowRedirects = followRedirects;
            this.ResourceInfo = resourceInfo;
            this.StorageType = storageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCreateFromUrl" /> class.
        /// </summary>
        public FileCreateFromUrl()
        {
        }
    }
}