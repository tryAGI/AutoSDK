//HintName: G.Models.Base64Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Base64Image
    {
        /// <summary>
        /// The source type for the image.<br/>
        /// Default Value: base64
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The media type for the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// The base64 encoded image data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// What level of detail to use when processing and understanding the image (low, high, or auto to let the model decide)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Base64Image" /> class.
        /// </summary>
        /// <param name="mediaType">
        /// The media type for the image.
        /// </param>
        /// <param name="data">
        /// The base64 encoded image data.
        /// </param>
        /// <param name="type">
        /// The source type for the image.<br/>
        /// Default Value: base64
        /// </param>
        /// <param name="detail">
        /// What level of detail to use when processing and understanding the image (low, high, or auto to let the model decide)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Base64Image(
            string mediaType,
            string data,
            string? type,
            string? detail)
        {
            this.Type = type;
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Base64Image" /> class.
        /// </summary>
        public Base64Image()
        {
        }
    }
}