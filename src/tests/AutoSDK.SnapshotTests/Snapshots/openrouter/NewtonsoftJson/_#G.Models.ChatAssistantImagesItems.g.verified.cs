//HintName: G.Models.ChatAssistantImagesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatAssistantImagesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatAssistantImagesItemsImageUrl ImageUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantImagesItems" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        public ChatAssistantImagesItems(
            global::G.ChatAssistantImagesItemsImageUrl imageUrl)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantImagesItems" /> class.
        /// </summary>
        public ChatAssistantImagesItems()
        {
        }
    }
}