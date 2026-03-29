//HintName: G.Models.ToolCallNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Typed child override for prefilled arguments.<br/>
    /// When used in a ChildToolRule, if this child is selected next, its `args` will be<br/>
    /// applied as prefilled arguments (overriding overlapping LLM-provided values).
    /// </summary>
    public sealed partial class ToolCallNode
    {
        /// <summary>
        /// The name of the child tool to invoke next.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional prefilled arguments for this child tool. Keys must match the tool's parameter names and values must satisfy the tool's JSON schema. Supports partial prefill; non-overlapping parameters are left to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args")]
        public object? Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallNode" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the child tool to invoke next.
        /// </param>
        /// <param name="args">
        /// Optional prefilled arguments for this child tool. Keys must match the tool's parameter names and values must satisfy the tool's JSON schema. Supports partial prefill; non-overlapping parameters are left to the model.
        /// </param>
        public ToolCallNode(
            string name,
            object? args)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Args = args;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallNode" /> class.
        /// </summary>
        public ToolCallNode()
        {
        }
    }
}