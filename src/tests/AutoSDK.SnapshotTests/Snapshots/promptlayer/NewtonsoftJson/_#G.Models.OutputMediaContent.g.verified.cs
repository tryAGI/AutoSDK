//HintName: G.Models.OutputMediaContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// LLM-generated media output (e.g. from image generation tools).
    /// </summary>
    public sealed partial class OutputMediaContent
    {
        /// <summary>
        /// Default Value: output_media
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OutputMediaContentType? Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Default Value: image/png
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_type")]
        public global::G.OutputMediaContentMediaType? MediaType { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_metadata")]
        public object? ProviderMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputMediaContent" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="type">
        /// Default Value: output_media
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="mimeType">
        /// Default Value: image/png
        /// </param>
        /// <param name="mediaType">
        /// Default Value: image
        /// </param>
        /// <param name="providerMetadata">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public OutputMediaContent(
            string url,
            global::G.OutputMediaContentType? type,
            string? id,
            string? mimeType,
            global::G.OutputMediaContentMediaType? mediaType,
            object? providerMetadata)
        {
            this.Type = type;
            this.Id = id;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.MimeType = mimeType;
            this.MediaType = mediaType;
            this.ProviderMetadata = providerMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputMediaContent" /> class.
        /// </summary>
        public OutputMediaContent()
        {
        }
    }
}