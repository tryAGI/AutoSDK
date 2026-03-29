//HintName: G.Models.ImageContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageContent
    {
        /// <summary>
        /// Default Value: image_url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ImageContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImageURL ImageUrl { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_variable")]
        public string? ImageVariable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContent" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type">
        /// Default Value: image_url
        /// </param>
        /// <param name="imageVariable">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public ImageContent(
            global::G.ImageURL imageUrl,
            global::G.ImageContentType? type,
            string? imageVariable)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.ImageVariable = imageVariable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContent" /> class.
        /// </summary>
        public ImageContent()
        {
        }
    }
}