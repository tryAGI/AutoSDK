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
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImageURL ImageUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"image_url"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "image_url";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageParam" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
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