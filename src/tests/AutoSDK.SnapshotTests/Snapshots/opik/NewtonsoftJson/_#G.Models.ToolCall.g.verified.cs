//HintName: G.Models.ToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolCallTypeJsonConverter))]
        public global::G.ToolCallType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.FunctionCall? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCall" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="index"></param>
        /// <param name="type"></param>
        /// <param name="function"></param>
        public ToolCall(
            string? id,
            int? index,
            global::G.ToolCallType? type,
            global::G.FunctionCall? function)
        {
            this.Id = id;
            this.Index = index;
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCall" /> class.
        /// </summary>
        public ToolCall()
        {
        }
    }
}