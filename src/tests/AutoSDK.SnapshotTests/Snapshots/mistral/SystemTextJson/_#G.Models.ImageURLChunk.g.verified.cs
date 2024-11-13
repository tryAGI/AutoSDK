//HintName: G.Models.ImageURLChunk.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// {"type":"image_url","image_url":{"url":"data:image/png;base64,iVBORw0
    /// </summary>
    public sealed partial class ImageURLChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ImageURL, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.ImageURL, string> ImageUrl { get; set; }

        /// <summary>
        /// Default Value: image_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageURLChunkTypeJsonConverter))]
        public global::G.ImageURLChunkType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageURLChunk" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type">
        /// Default Value: image_url
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImageURLChunk(
            global::G.AnyOf<global::G.ImageURL, string> imageUrl,
            global::G.ImageURLChunkType? type)
        {
            this.ImageUrl = imageUrl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageURLChunk" /> class.
        /// </summary>
        public ImageURLChunk()
        {
        }
    }
}