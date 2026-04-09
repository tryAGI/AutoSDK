//HintName: G.Models.ChatCompletionContentPartImageWithTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartImageWithTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionContentPartImageWithTitleImageUrl ImageUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionContentPartImageWithTitleTypeJsonConverter))]
        public global::G.ChatCompletionContentPartImageWithTitleType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageWithTitle" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
        public ChatCompletionContentPartImageWithTitle(
            global::G.ChatCompletionContentPartImageWithTitleImageUrl imageUrl,
            global::G.ChatCompletionContentPartImageWithTitleType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageWithTitle" /> class.
        /// </summary>
        public ChatCompletionContentPartImageWithTitle()
        {
        }
    }
}