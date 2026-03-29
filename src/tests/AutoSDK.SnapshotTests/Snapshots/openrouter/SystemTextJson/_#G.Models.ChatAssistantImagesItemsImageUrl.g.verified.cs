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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantImagesItemsImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// URL or base64-encoded data of the generated image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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