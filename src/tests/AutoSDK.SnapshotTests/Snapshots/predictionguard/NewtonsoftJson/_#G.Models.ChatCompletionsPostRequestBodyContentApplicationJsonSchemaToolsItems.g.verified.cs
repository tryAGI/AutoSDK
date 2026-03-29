//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems
    {
        /// <summary>
        /// The type of tool to call. Only 'function' is currently supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The tool information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool to call. Only 'function' is currently supported.
        /// </param>
        /// <param name="function">
        /// The tool information.
        /// </param>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems(
            string? type,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunction? function)
        {
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems" /> class.
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems()
        {
        }
    }
}