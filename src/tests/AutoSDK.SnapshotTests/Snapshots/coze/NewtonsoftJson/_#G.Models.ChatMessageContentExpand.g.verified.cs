//HintName: G.Models.ChatMessageContentExpand.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageContentExpand
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("info")]
        public string? Info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatMessageContentExpandType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageContentExpand" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="info"></param>
        public ChatMessageContentExpand(
            global::G.ChatMessageContentExpandType type,
            string? info)
        {
            this.Info = info;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageContentExpand" /> class.
        /// </summary>
        public ChatMessageContentExpand()
        {
        }
    }
}