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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A unique identifier for this specific tool call instance.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the tool being called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The parameters being passed to the tool, structured as a dictionary of parameter names to values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public object Input { get; set; } = default!;

        /// <summary>
        /// Stores a unique identifier for any reasoning associated with this tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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