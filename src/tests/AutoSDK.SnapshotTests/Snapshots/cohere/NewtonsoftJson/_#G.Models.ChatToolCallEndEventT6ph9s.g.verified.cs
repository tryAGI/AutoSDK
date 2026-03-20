//HintName: G.Models.ChatToolCallEndEventT6ph9s.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallEndEventT6ph9s
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallEndEventT6ph9s" /> class.
        /// </summary>
        /// <param name="index"></param>
        public ChatToolCallEndEventT6ph9s(
            int? index)
        {
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallEndEventT6ph9s" /> class.
        /// </summary>
        public ChatToolCallEndEventT6ph9s()
        {
        }
    }
}