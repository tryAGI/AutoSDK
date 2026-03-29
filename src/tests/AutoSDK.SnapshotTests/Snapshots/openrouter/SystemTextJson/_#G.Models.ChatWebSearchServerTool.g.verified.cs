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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatWebSearchServerToolTypeJsonConverter))]
        public global::G.ChatWebSearchServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.ChatWebSearchServerToolParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWebSearchServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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