//HintName: G.Models.ChatFormatTextConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default text response format
    /// </summary>
    public sealed partial class ChatFormatTextConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatFormatTextConfigType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatTextConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ChatFormatTextConfig(
            global::G.ChatFormatTextConfigType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatTextConfig" /> class.
        /// </summary>
        public ChatFormatTextConfig()
        {
        }
    }
}