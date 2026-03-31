//HintName: G.Models.CreateChatCompletionResponseMcpListToolTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionResponseMcpListToolTool
    {
        /// <summary>
        /// Additional metadata for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public object? Annotations { get; set; }

        /// <summary>
        /// Description of what the tool does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON Schema describing the tool's input parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponseMcpListToolTool" /> class.
        /// </summary>
        /// <param name="annotations">
        /// Additional metadata for the tool.
        /// </param>
        /// <param name="description">
        /// Description of what the tool does.
        /// </param>
        /// <param name="inputSchema">
        /// JSON Schema describing the tool's input parameters.
        /// </param>
        /// <param name="name">
        /// The name of the tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionResponseMcpListToolTool(
            object? annotations,
            string? description,
            object? inputSchema,
            string? name)
        {
            this.Annotations = annotations;
            this.Description = description;
            this.InputSchema = inputSchema;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponseMcpListToolTool" /> class.
        /// </summary>
        public CreateChatCompletionResponseMcpListToolTool()
        {
        }
    }
}