//HintName: G.Models.ToolReturnCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Submit tool return(s) from client-side tool execution.<br/>
    /// This is the preferred way to send tool results back to the agent after<br/>
    /// client-side tool execution. It is equivalent to sending an ApprovalCreate<br/>
    /// with tool return approvals, but provides a cleaner API for the common case.
    /// </summary>
    public sealed partial class ToolReturnCreate
    {
        /// <summary>
        /// The message type to be created.<br/>
        /// Default Value: tool_return
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of tool returns from client-side execution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_returns", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LettaSchemasLettaMessageToolReturn> ToolReturns { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReturnCreate" /> class.
        /// </summary>
        /// <param name="toolReturns">
        /// List of tool returns from client-side execution
        /// </param>
        /// <param name="type">
        /// The message type to be created.<br/>
        /// Default Value: tool_return
        /// </param>
        public ToolReturnCreate(
            global::System.Collections.Generic.IList<global::G.LettaSchemasLettaMessageToolReturn> toolReturns,
            string? type)
        {
            this.Type = type;
            this.ToolReturns = toolReturns ?? throw new global::System.ArgumentNullException(nameof(toolReturns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReturnCreate" /> class.
        /// </summary>
        public ToolReturnCreate()
        {
        }
    }
}