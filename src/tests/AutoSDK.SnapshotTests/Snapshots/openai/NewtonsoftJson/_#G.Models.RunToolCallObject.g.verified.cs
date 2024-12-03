//HintName: G.Models.RunToolCallObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool call objects
    /// </summary>
    public sealed partial class RunToolCallObject
    {
        /// <summary>
        /// The ID of the tool call. This ID must be referenced when you submit the tool outputs in using the [Submit tool outputs to run](/docs/api-reference/runs/submitToolOutputs) endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of tool call the output is required for. For now, this is always `function`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunToolCallObjectType Type { get; set; }

        /// <summary>
        /// The function definition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunToolCallObjectFunction Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunToolCallObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the tool call. This ID must be referenced when you submit the tool outputs in using the [Submit tool outputs to run](/docs/api-reference/runs/submitToolOutputs) endpoint.
        /// </param>
        /// <param name="type">
        /// The type of tool call the output is required for. For now, this is always `function`.
        /// </param>
        /// <param name="function">
        /// The function definition.
        /// </param>
        public RunToolCallObject(
            string id,
            global::G.RunToolCallObjectFunction function,
            global::G.RunToolCallObjectType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunToolCallObject" /> class.
        /// </summary>
        public RunToolCallObject()
        {
        }
    }
}