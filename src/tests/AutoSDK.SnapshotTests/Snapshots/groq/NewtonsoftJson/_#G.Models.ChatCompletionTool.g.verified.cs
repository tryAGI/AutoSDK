//HintName: G.Models.ChatCompletionTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.ChatCompletionToolType?, string> Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.FunctionObject? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="function"></param>
        public ChatCompletionTool(
            global::G.AnyOf<global::G.ChatCompletionToolType?, string> type,
            global::G.FunctionObject? function)
        {
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTool" /> class.
        /// </summary>
        public ChatCompletionTool()
        {
        }
    }
}