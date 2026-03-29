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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Image detail level for vision models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatContentImageImageUrlDetailJsonConverter))]
        public global::G.ChatContentImageImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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