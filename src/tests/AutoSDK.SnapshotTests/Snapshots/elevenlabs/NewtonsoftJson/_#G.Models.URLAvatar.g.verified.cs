//HintName: G.Models.URLAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class URLAvatar
    {
        /// <summary>
        /// The type of the avatar<br/>
        /// Default Value: url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.URLAvatarType? Type { get; set; }

        /// <summary>
        /// The custom URL of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_url")]
        public string? CustomUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="URLAvatar" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the avatar<br/>
        /// Default Value: url
        /// </param>
        /// <param name="customUrl">
        /// The custom URL of the avatar
        /// </param>
        public URLAvatar(
            global::G.URLAvatarType? type,
            string? customUrl)
        {
            this.Type = type;
            this.CustomUrl = customUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="URLAvatar" /> class.
        /// </summary>
        public URLAvatar()
        {
        }
    }
}