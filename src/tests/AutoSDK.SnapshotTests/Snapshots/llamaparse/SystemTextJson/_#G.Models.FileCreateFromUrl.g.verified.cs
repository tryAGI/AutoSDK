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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL of the file to download
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// URL of the proxy server to use for downloading the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_url")]
        public string? ProxyUrl { get; set; }

        /// <summary>
        /// Headers to include in the request when downloading the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestHeaders { get; set; }

        /// <summary>
        /// Whether to verify the SSL certificate when downloading the file<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_ssl")]
        public bool? VerifySsl { get; set; }

        /// <summary>
        /// Whether to follow redirects when downloading the file<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follow_redirects")]
        public bool? FollowRedirects { get; set; }

        /// <summary>
        /// Resource information for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_info")]
        public object? ResourceInfo { get; set; }

        /// <summary>
        /// Storage type for the file. Valid values: 'Ephemeral', 'Permanent' (no expiration). If not specified, defaults to permanent storage.<br/>
        /// Default Value: permanent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.FileCreateFromUrlStorageType?, string>))]
        public global::G.AnyOf<global::G.FileCreateFromUrlStorageType?, string>? StorageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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