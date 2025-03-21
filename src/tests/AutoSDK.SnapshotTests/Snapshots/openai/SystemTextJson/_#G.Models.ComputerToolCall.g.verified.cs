//HintName: G.Models.ComputerToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool call to a computer use tool. See the <br/>
    /// [computer use guide](/docs/guides/tools-computer-use) for more information.
    /// </summary>
    public sealed partial class ComputerToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComputerActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ComputerAction Action { get; set; }

        /// <summary>
        /// An identifier used when responding to the tool call with output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The unique ID of the computer call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The pending safety checks for the computer call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_safety_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ComputerToolCallSafetyCheck> PendingSafetyChecks { get; set; }

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComputerToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ComputerToolCallStatus Status { get; set; }

        /// <summary>
        /// The type of the computer call. Always `computer_call`.<br/>
        /// Default Value: computer_call
        /// </summary>
        /// <default>global::G.ComputerToolCallType.ComputerCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComputerToolCallTypeJsonConverter))]
        public global::G.ComputerToolCallType Type { get; set; } = global::G.ComputerToolCallType.ComputerCall;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCall" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="callId">
        /// An identifier used when responding to the tool call with output.
        /// </param>
        /// <param name="id">
        /// The unique ID of the computer call.
        /// </param>
        /// <param name="pendingSafetyChecks">
        /// The pending safety checks for the computer call.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
        /// <param name="type">
        /// The type of the computer call. Always `computer_call`.<br/>
        /// Default Value: computer_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerToolCall(
            global::G.ComputerAction action,
            string callId,
            string id,
            global::System.Collections.Generic.IList<global::G.ComputerToolCallSafetyCheck> pendingSafetyChecks,
            global::G.ComputerToolCallStatus status,
            global::G.ComputerToolCallType type = global::G.ComputerToolCallType.ComputerCall)
        {
            this.Action = action;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PendingSafetyChecks = pendingSafetyChecks ?? throw new global::System.ArgumentNullException(nameof(pendingSafetyChecks));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCall" /> class.
        /// </summary>
        public ComputerToolCall()
        {
        }
    }
}