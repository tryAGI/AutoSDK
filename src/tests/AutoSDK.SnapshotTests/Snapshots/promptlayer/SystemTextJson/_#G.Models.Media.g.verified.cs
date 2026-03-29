//HintName: G.Models.Media.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Media
    {
        /// <summary>
        /// Title of the media<br/>
        /// Default Value: media
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// MIME type of the media. For example, image/png, image/jpeg<br/>
        /// Default Value: image/jpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Format of the media data.<br/>
        /// Default Value: neither
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MediaFormatJsonConverter))]
        public global::G.MediaFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Media" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the media<br/>
        /// Default Value: media
        /// </param>
        /// <param name="type">
        /// MIME type of the media. For example, image/png, image/jpeg<br/>
        /// Default Value: image/jpeg
        /// </param>
        /// <param name="url">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="format">
        /// Format of the media data.<br/>
        /// Default Value: neither
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Media(
            string? title,
            string? type,
            string? url,
            global::G.MediaFormat? format)
        {
            this.Title = title;
            this.Type = type;
            this.Url = url;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Media" /> class.
        /// </summary>
        public Media()
        {
        }
    }
}