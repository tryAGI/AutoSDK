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
        /// The URL of the image, must be a supported image types: jpeg, jpg, png, gif, webp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`.
        /// <br/>Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; } = MessageDeltaContentImageUrlObjectImageUrlDetail.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}