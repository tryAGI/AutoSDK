//HintName: G.Models.ChatCompletionContentPartImageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Learn about [image inputs](https://platform.openai.com/docs/guides/vision).
    /// </summary>
    public sealed partial class ChatCompletionContentPartImageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageURL ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"image_url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "image_url";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageParam" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPartImageParam(
            global::G.ImageURL imageUrl,
            string type = "image_url")
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageParam" /> class.
        /// </summary>
        public ChatCompletionContentPartImageParam()
        {
        }
    }
}