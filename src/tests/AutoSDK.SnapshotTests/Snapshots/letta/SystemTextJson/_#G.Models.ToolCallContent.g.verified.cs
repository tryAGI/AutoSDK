//HintName: G.Models.ToolCallContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallContent
    {
        /// <summary>
        /// Indicates this content represents a tool call event.<br/>
        /// Default Value: tool_call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A unique identifier for this specific tool call instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the tool being called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The parameters being passed to the tool, structured as a dictionary of parameter names to values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Stores a unique identifier for any reasoning associated with this tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallContent" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for this specific tool call instance.
        /// </param>
        /// <param name="name">
        /// The name of the tool being called.
        /// </param>
        /// <param name="input">
        /// The parameters being passed to the tool, structured as a dictionary of parameter names to values.
        /// </param>
        /// <param name="type">
        /// Indicates this content represents a tool call event.<br/>
        /// Default Value: tool_call
        /// </param>
        /// <param name="signature">
        /// Stores a unique identifier for any reasoning associated with this tool call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallContent(
            string id,
            string name,
            object input,
            string? type,
            string? signature)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallContent" /> class.
        /// </summary>
        public ToolCallContent()
        {
        }
    }
}