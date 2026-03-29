//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The name of the tool of choice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The label of the MCP server that the tool is on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool.
        /// </param>
        /// <param name="name">
        /// The name of the tool of choice.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server that the tool is on.
        /// </param>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems(
            string? type,
            string? name,
            string? serverLabel)
        {
            this.Type = type;
            this.Name = name;
            this.ServerLabel = serverLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems" /> class.
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems()
        {
        }
    }
}