//HintName: G.Models.MessageDeltaContentImageUrlObjectImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaContentImageUrlObjectImageUrl
    {
        /// <summary>
        /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.MessageDeltaContentImageUrlObjectImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// The URL of the image, must be a supported image types: jpeg, jpg, png, gif, webp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageUrlObjectImageUrl" /> class.
        /// </summary>
        /// <param name="detail">
        /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="url">
        /// The URL of the image, must be a supported image types: jpeg, jpg, png, gif, webp.
        /// </param>
        public MessageDeltaContentImageUrlObjectImageUrl(
            global::G.MessageDeltaContentImageUrlObjectImageUrlDetail? detail,
            string? url)
        {
            this.Detail = detail;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageUrlObjectImageUrl" /> class.
        /// </summary>
        public MessageDeltaContentImageUrlObjectImageUrl()
        {
        }
    }
}