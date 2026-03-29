//HintName: G.Models.ChatContentImageImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentImageImageUrl
    {
        /// <summary>
        /// URL of the image (data: URLs supported)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Image detail level for vision models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.ChatContentImageImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentImageImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the image (data: URLs supported)
        /// </param>
        /// <param name="detail">
        /// Image detail level for vision models
        /// </param>
        public ChatContentImageImageUrl(
            string url,
            global::G.ChatContentImageImageUrlDetail? detail)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentImageImageUrl" /> class.
        /// </summary>
        public ChatContentImageImageUrl()
        {
        }
    }
}