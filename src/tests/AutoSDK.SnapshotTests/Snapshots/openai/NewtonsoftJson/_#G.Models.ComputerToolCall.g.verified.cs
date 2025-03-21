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
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ComputerAction Action { get; set; } = default!;

        /// <summary>
        /// An identifier used when responding to the tool call with output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// The unique ID of the computer call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The pending safety checks for the computer call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_safety_checks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ComputerToolCallSafetyCheck> PendingSafetyChecks { get; set; } = default!;

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ComputerToolCallStatus Status { get; set; } = default!;

        /// <summary>
        /// The type of the computer call. Always `computer_call`.<br/>
        /// Default Value: computer_call
        /// </summary>
        /// <default>global::G.ComputerToolCallType.ComputerCall</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ComputerToolCallType Type { get; set; } = global::G.ComputerToolCallType.ComputerCall;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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