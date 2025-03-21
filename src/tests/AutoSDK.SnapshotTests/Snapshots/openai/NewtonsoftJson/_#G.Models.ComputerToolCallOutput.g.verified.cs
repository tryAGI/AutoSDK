//HintName: G.Models.ComputerToolCallOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output of a computer tool call.
    /// </summary>
    public sealed partial class ComputerToolCallOutput
    {
        /// <summary>
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </summary>
        /// <default>global::G.ComputerToolCallOutputType.ComputerCallOutput</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ComputerToolCallOutputType Type { get; set; } = global::G.ComputerToolCallOutputType.ComputerCallOutput;

        /// <summary>
        /// The ID of the computer tool call output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the computer tool call that produced the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// The safety checks reported by the API that have been acknowledged by the <br/>
        /// developer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("acknowledged_safety_checks")]
        public global::System.Collections.Generic.IList<global::G.ComputerToolCallSafetyCheck>? AcknowledgedSafetyChecks { get; set; }

        /// <summary>
        /// A computer screenshot image used with the computer use tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ComputerScreenshotImage Output { get; set; } = default!;

        /// <summary>
        /// The status of the message input. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when input items are returned via API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ComputerToolCallOutputStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCallOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </param>
        /// <param name="id">
        /// The ID of the computer tool call output.
        /// </param>
        /// <param name="callId">
        /// The ID of the computer tool call that produced the output.
        /// </param>
        /// <param name="acknowledgedSafetyChecks">
        /// The safety checks reported by the API that have been acknowledged by the <br/>
        /// developer.
        /// </param>
        /// <param name="output">
        /// A computer screenshot image used with the computer use tool.
        /// </param>
        /// <param name="status">
        /// The status of the message input. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when input items are returned via API.
        /// </param>
        public ComputerToolCallOutput(
            string callId,
            global::G.ComputerScreenshotImage output,
            string? id,
            global::System.Collections.Generic.IList<global::G.ComputerToolCallSafetyCheck>? acknowledgedSafetyChecks,
            global::G.ComputerToolCallOutputStatus? status,
            global::G.ComputerToolCallOutputType type = global::G.ComputerToolCallOutputType.ComputerCallOutput)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Type = type;
            this.Id = id;
            this.AcknowledgedSafetyChecks = acknowledgedSafetyChecks;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCallOutput" /> class.
        /// </summary>
        public ComputerToolCallOutput()
        {
        }
    }
}