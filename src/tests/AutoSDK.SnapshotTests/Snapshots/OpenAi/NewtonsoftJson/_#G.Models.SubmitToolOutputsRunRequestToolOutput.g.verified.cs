//HintName: G.Models.SubmitToolOutputsRunRequestToolOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitToolOutputsRunRequestToolOutput
    {
        /// <summary>
        /// The ID of the tool call in the `required_action` object within the run object the output is being submitted for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// The output of the tool call to be submitted to continue the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequestToolOutput" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// The ID of the tool call in the `required_action` object within the run object the output is being submitted for.
        /// </param>
        /// <param name="output">
        /// The output of the tool call to be submitted to continue the run.
        /// </param>
        public SubmitToolOutputsRunRequestToolOutput(
            string? toolCallId,
            string? output)
        {
            this.ToolCallId = toolCallId;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequestToolOutput" /> class.
        /// </summary>
        public SubmitToolOutputsRunRequestToolOutput()
        {
        }
    }
}