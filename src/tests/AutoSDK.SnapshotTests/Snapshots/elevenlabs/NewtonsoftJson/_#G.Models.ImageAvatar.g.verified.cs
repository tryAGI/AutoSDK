//HintName: G.Models.ImageAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageAvatar
    {
        /// <summary>
        /// The type of the avatar<br/>
        /// Default Value: image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The URL of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAvatar" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the avatar<br/>
        /// Default Value: image
        /// </param>
        /// <param name="url">
        /// The URL of the avatar
        /// </param>
        public ImageAvatar(
            string? type,
            string? url)
        {
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAvatar" /> class.
        /// </summary>
        public ImageAvatar()
        {
        }
    }
}