//HintName: G.Models.ChatWebSearchServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenRouter built-in server tool: searches the web for current information
    /// </summary>
    public sealed partial class ChatWebSearchServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatWebSearchServerToolTypeJsonConverter))]
        public global::G.ChatWebSearchServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.ChatWebSearchServerToolParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWebSearchServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public ChatWebSearchServerTool(
            global::G.ChatWebSearchServerToolType type,
            global::G.ChatWebSearchServerToolParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWebSearchServerTool" /> class.
        /// </summary>
        public ChatWebSearchServerTool()
        {
        }
    }
}