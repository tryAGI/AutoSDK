//HintName: G.Models.ToolCustom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A custom tool the model may use.
    /// </summary>
    public sealed partial class ToolCustom
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The name of the tool. Must match the regex `^[a-zA-Z0-9_-]{1,64}$`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of what this tool does.<br/>
        /// Tool descriptions should be as detailed as possible. The more information that<br/>
        /// the model has about what the tool is and how to use it, the better it will<br/>
        /// perform. You can use natural language descriptions to reinforce important<br/>
        /// aspects of the tool input JSON schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// [JSON schema](https://json-schema.org/) for this tool's input.<br/>
        /// This defines the shape of the `input` that your tool accepts and that the model<br/>
        /// will produce.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCustom" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool.
        /// </param>
        /// <param name="name">
        /// The name of the tool. Must match the regex `^[a-zA-Z0-9_-]{1,64}$`.
        /// </param>
        /// <param name="description">
        /// Description of what this tool does.<br/>
        /// Tool descriptions should be as detailed as possible. The more information that<br/>
        /// the model has about what the tool is and how to use it, the better it will<br/>
        /// perform. You can use natural language descriptions to reinforce important<br/>
        /// aspects of the tool input JSON schema.
        /// </param>
        /// <param name="inputSchema">
        /// [JSON schema](https://json-schema.org/) for this tool's input.<br/>
        /// This defines the shape of the `input` that your tool accepts and that the model<br/>
        /// will produce.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolCustom(
            string name,
            object inputSchema,
            string? type,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Type = type;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCustom" /> class.
        /// </summary>
        public ToolCustom()
        {
        }
    }
}