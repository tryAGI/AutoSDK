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
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.ImageURL, string> ImageUrl { get; set; } = default!;

        /// <summary>
        /// Default Value: image_url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ImageURLChunkType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageURLChunk" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type">
        /// Default Value: image_url
        /// </param>
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