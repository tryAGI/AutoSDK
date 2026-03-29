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
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public object? Annotations { get; set; }

        /// <summary>
        /// Description of what the tool does.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON Schema describing the tool's input parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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