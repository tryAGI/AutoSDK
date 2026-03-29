//HintName: G.Models.CreateAssetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetRequest
    {
        /// <summary>
        /// The content type of the asset to upload. Must be one of: video/mp4, video/webm, or video/quicktime.<br/>
        /// Example: video/mp4
        /// </summary>
        /// <example>video/mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAssetRequestContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateAssetRequestContentType ContentType { get; set; }

        /// <summary>
        /// The configuration to use for the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbingAssetRequestConfiguration Configuration { get; set; }

        /// <summary>
        /// The length of the file content to upload. This is used to verify the integrity of the asset during upload.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentLength")]
        public int? ContentLength { get; set; }

        /// <summary>
        /// The MD5 hash of the file content to upload. This is used to verify the integrity of the asset during upload.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentMD5")]
        public string? ContentMD5 { get; set; }

        /// <summary>
        /// The title of the asset to upload.<br/>
        /// Default Value: Untitled<br/>
        /// Example: Untitled
        /// </summary>
        /// <example>Untitled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequest" /> class.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the asset to upload. Must be one of: video/mp4, video/webm, or video/quicktime.<br/>
        /// Example: video/mp4
        /// </param>
        /// <param name="configuration">
        /// The configuration to use for the asset.
        /// </param>
        /// <param name="contentLength">
        /// The length of the file content to upload. This is used to verify the integrity of the asset during upload.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="contentMD5">
        /// The MD5 hash of the file content to upload. This is used to verify the integrity of the asset during upload.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="title">
        /// The title of the asset to upload.<br/>
        /// Default Value: Untitled<br/>
        /// Example: Untitled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetRequest(
            global::G.CreateAssetRequestContentType contentType,
            global::G.DubbingAssetRequestConfiguration configuration,
            int? contentLength,
            string? contentMD5,
            string? title)
        {
            this.ContentType = contentType;
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.ContentLength = contentLength;
            this.ContentMD5 = contentMD5;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequest" /> class.
        /// </summary>
        public CreateAssetRequest()
        {
        }
    }
}