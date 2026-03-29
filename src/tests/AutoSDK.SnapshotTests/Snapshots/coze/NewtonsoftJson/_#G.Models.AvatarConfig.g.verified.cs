//HintName: G.Models.AvatarConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AvatarConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_uri")]
        public string? ImageUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarConfig" /> class.
        /// </summary>
        /// <param name="imageUri"></param>
        /// <param name="imageUrl"></param>
        public AvatarConfig(
            string? imageUri,
            string? imageUrl)
        {
            this.ImageUri = imageUri;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarConfig" /> class.
        /// </summary>
        public AvatarConfig()
        {
        }
    }
}