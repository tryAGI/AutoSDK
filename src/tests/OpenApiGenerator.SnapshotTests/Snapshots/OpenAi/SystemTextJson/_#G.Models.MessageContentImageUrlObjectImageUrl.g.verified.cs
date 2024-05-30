//HintName: G.Models.MessageContentImageUrlObjectImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentImageUrlObjectImageUrl
    {
        /// <summary>
        /// The external URL of the image, must be a supported image types: jpeg, jpg, png, gif, webp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`. Default value is `auto`
        /// <br/>Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter))]
        public MessageContentImageUrlObjectImageUrlDetail? Detail { get; set; } = MessageContentImageUrlObjectImageUrlDetail.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}