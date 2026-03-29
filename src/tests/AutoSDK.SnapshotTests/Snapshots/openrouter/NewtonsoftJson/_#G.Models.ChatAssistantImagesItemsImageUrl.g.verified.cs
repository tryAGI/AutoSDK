//HintName: G.Models.ChatAssistantImagesItemsImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatAssistantImagesItemsImageUrl
    {
        /// <summary>
        /// URL or base64-encoded data of the generated image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantImagesItemsImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// URL or base64-encoded data of the generated image
        /// </param>
        public ChatAssistantImagesItemsImageUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantImagesItemsImageUrl" /> class.
        /// </summary>
        public ChatAssistantImagesItemsImageUrl()
        {
        }
    }
}