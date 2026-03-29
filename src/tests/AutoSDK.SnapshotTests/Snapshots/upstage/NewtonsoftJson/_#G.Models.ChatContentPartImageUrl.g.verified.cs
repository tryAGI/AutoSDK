//HintName: G.Models.ChatContentPartImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image URL (for image_url type).
    /// </summary>
    public sealed partial class ChatContentPartImageUrl
    {
        /// <summary>
        /// Either a URL of the image or base64-encoded image data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Image detail level.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.ChatContentPartImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentPartImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// Either a URL of the image or base64-encoded image data.
        /// </param>
        /// <param name="detail">
        /// Image detail level.<br/>
        /// Default Value: auto
        /// </param>
        public ChatContentPartImageUrl(
            string? url,
            global::G.ChatContentPartImageUrlDetail? detail)
        {
            this.Url = url;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentPartImageUrl" /> class.
        /// </summary>
        public ChatContentPartImageUrl()
        {
        }
    }
}