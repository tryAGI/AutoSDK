//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object representing the tool to be chosen
    /// </summary>
    public sealed partial class ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Allows for multiple tools to be set in tool_choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems>? Tools { get; set; }

        /// <summary>
        /// The name of the tool to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The label of the MCP server that the tool is on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="mode"></param>
        /// <param name="tools">
        /// Allows for multiple tools to be set in tool_choice.
        /// </param>
        /// <param name="name">
        /// The name of the tool to use.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server that the tool is on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1(
            string? type,
            string? mode,
            global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems>? tools,
            string? name,
            string? serverLabel)
        {
            this.Type = type;
            this.Mode = mode;
            this.Tools = tools;
            this.Name = name;
            this.ServerLabel = serverLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1" /> class.
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1()
        {
        }
    }
}