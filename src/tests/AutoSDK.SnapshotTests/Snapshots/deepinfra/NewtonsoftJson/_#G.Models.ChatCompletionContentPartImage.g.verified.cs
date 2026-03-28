//HintName: G.Models.ChatCompletionContentPartImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartImage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"image_url"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "image_url";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImageURL ImageUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImage" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
        public ChatCompletionContentPartImage(
            global::G.ImageURL imageUrl,
            string type = "image_url")
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImage" /> class.
        /// </summary>
        public ChatCompletionContentPartImage()
        {
        }
    }
}