//HintName: G.Models.ComputerCallOutputItemParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output of a computer tool call.
    /// </summary>
    public sealed partial class ComputerCallOutputItemParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the computer tool call that produced the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </summary>
        /// <default>global::G.ComputerCallOutputItemParamType.ComputerCallOutput</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ComputerCallOutputItemParamType Type { get; set; } = global::G.ComputerCallOutputItemParamType.ComputerCallOutput;

        /// <summary>
        /// A computer screenshot image used with the computer use tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ComputerScreenshotImage Output { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("acknowledged_safety_checks")]
        public global::System.Collections.Generic.IList<global::G.ComputerCallSafetyCheckParam>? AcknowledgedSafetyChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ComputerCallOutputItemParamStatus2? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerCallOutputItemParam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callId">
        /// The ID of the computer tool call that produced the output.
        /// </param>
        /// <param name="type">
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </param>
        /// <param name="output">
        /// A computer screenshot image used with the computer use tool.
        /// </param>
        /// <param name="acknowledgedSafetyChecks"></param>
        /// <param name="status"></param>
        public ComputerCallOutputItemParam(
            string callId,
            global::G.ComputerScreenshotImage output,
            string? id,
            global::System.Collections.Generic.IList<global::G.ComputerCallSafetyCheckParam>? acknowledgedSafetyChecks,
            global::G.ComputerCallOutputItemParamStatus2? status,
            global::G.ComputerCallOutputItemParamType type = global::G.ComputerCallOutputItemParamType.ComputerCallOutput)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Id = id;
            this.Type = type;
            this.AcknowledgedSafetyChecks = acknowledgedSafetyChecks;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerCallOutputItemParam" /> class.
        /// </summary>
        public ComputerCallOutputItemParam()
        {
        }
    }
}