//HintName: G.Models.ComputerCallOutputItemParam.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::G.AnyOf<string, object>? Id { get; set; }

        /// <summary>
        /// The ID of the computer tool call that produced the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The type of the computer tool call output. Always `computer_call_output`.<br/>
        /// Default Value: computer_call_output
        /// </summary>
        /// <default>global::G.ComputerCallOutputItemParamType.ComputerCallOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComputerCallOutputItemParamTypeJsonConverter))]
        public global::G.ComputerCallOutputItemParamType Type { get; set; } = global::G.ComputerCallOutputItemParamType.ComputerCallOutput;

        /// <summary>
        /// A computer screenshot image used with the computer use tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ComputerScreenshotImage Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledged_safety_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.ComputerCallSafetyCheckParam>, object>))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ComputerCallSafetyCheckParam>, object>? AcknowledgedSafetyChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ComputerCallOutputItemParamStatus?, object>))]
        public global::G.AnyOf<global::G.ComputerCallOutputItemParamStatus?, object>? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerCallOutputItemParam(
            string callId,
            global::G.ComputerScreenshotImage output,
            global::G.AnyOf<string, object>? id,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ComputerCallSafetyCheckParam>, object>? acknowledgedSafetyChecks,
            global::G.AnyOf<global::G.ComputerCallOutputItemParamStatus?, object>? status,
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