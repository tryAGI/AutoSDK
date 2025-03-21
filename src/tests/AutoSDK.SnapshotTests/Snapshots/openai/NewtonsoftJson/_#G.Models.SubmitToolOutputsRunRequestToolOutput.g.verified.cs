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
        /// The output of the tool call to be submitted to continue the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// The ID of the tool call in the `required_action` object within the run object the output is being submitted for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequestToolOutput" /> class.
        /// </summary>
        /// <param name="output">
        /// The output of the tool call to be submitted to continue the run.
        /// </param>
        /// <param name="toolCallId">
        /// The ID of the tool call in the `required_action` object within the run object the output is being submitted for.
        /// </param>
        public SubmitToolOutputsRunRequestToolOutput(
            string? output,
            string? toolCallId)
        {
            this.Output = output;
            this.ToolCallId = toolCallId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequestToolOutput" /> class.
        /// </summary>
        public SubmitToolOutputsRunRequestToolOutput()
        {
        }
    }
}