//HintName: G.Models.ScenarioToolMock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScenarioToolMock
    {
        /// <summary>
        /// This is the tool call function name to mock (must match `toolCall.function.name`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// This is the result content to return for this tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public string? Result { get; set; }

        /// <summary>
        /// This is whether this mock is enabled. Defaults to true when omitted.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioToolMock" /> class.
        /// </summary>
        /// <param name="toolName">
        /// This is the tool call function name to mock (must match `toolCall.function.name`).
        /// </param>
        /// <param name="result">
        /// This is the result content to return for this tool call.
        /// </param>
        /// <param name="enabled">
        /// This is whether this mock is enabled. Defaults to true when omitted.<br/>
        /// Default Value: true
        /// </param>
        public ScenarioToolMock(
            string toolName,
            string? result,
            bool? enabled)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Result = result;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioToolMock" /> class.
        /// </summary>
        public ScenarioToolMock()
        {
        }
    }
}