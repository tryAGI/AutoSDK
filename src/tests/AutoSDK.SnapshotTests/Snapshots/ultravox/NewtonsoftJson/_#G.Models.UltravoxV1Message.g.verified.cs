//HintName: G.Models.UltravoxV1Message.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A message exchanged during a call.
    /// </summary>
    public sealed partial class UltravoxV1Message
    {
        /// <summary>
        /// The message's role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.UltravoxV1MessageRole? Role { get; set; }

        /// <summary>
        /// The message text for user and agent messages, tool arguments for tool_call messages, tool results for tool_result messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The invocation ID for tool messages. Used to pair tool calls with their results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invocationId")]
        public string? InvocationId { get; set; }

        /// <summary>
        /// The tool name for tool messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolName")]
        public string? ToolName { get; set; }

        /// <summary>
        /// For failed tool calls, additional debugging information. While the text field is<br/>
        ///  presented to the model so it can respond to failures gracefully, the full details<br/>
        ///  are only exposed via the Ultravox REST API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorDetails")]
        public string? ErrorDetails { get; set; }

        /// <summary>
        /// The medium of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("medium")]
        public global::G.UltravoxV1MessageMedium? Medium { get; set; }

        /// <summary>
        /// The index of the message within the call stage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callStageMessageIndex")]
        public int? CallStageMessageIndex { get; set; }

        /// <summary>
        /// The call stage this message appeared in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callStageId")]
        public string? CallStageId { get; set; }

        /// <summary>
        /// If the message updated the call state, the new call state.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callState")]
        public object? CallState { get; set; }

        /// <summary>
        /// The timespan during the call when this message occurred.<br/>
        ///  This is only set for messages that occurred during the call (stage)<br/>
        ///  and not for messages in the call's (call stage's) initial messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timespan")]
        public global::G.UltravoxV1InCallTimespan? Timespan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Message" /> class.
        /// </summary>
        /// <param name="role">
        /// The message's role.
        /// </param>
        /// <param name="text">
        /// The message text for user and agent messages, tool arguments for tool_call messages, tool results for tool_result messages.
        /// </param>
        /// <param name="invocationId">
        /// The invocation ID for tool messages. Used to pair tool calls with their results.
        /// </param>
        /// <param name="toolName">
        /// The tool name for tool messages.
        /// </param>
        /// <param name="errorDetails">
        /// For failed tool calls, additional debugging information. While the text field is<br/>
        ///  presented to the model so it can respond to failures gracefully, the full details<br/>
        ///  are only exposed via the Ultravox REST API.
        /// </param>
        /// <param name="medium">
        /// The medium of the message.
        /// </param>
        /// <param name="callStageMessageIndex">
        /// The index of the message within the call stage.
        /// </param>
        /// <param name="callStageId">
        /// The call stage this message appeared in.
        /// </param>
        /// <param name="callState">
        /// If the message updated the call state, the new call state.
        /// </param>
        /// <param name="timespan">
        /// The timespan during the call when this message occurred.<br/>
        ///  This is only set for messages that occurred during the call (stage)<br/>
        ///  and not for messages in the call's (call stage's) initial messages.
        /// </param>
        public UltravoxV1Message(
            global::G.UltravoxV1MessageRole? role,
            string? text,
            string? invocationId,
            string? toolName,
            string? errorDetails,
            global::G.UltravoxV1MessageMedium? medium,
            int? callStageMessageIndex,
            string? callStageId,
            object? callState,
            global::G.UltravoxV1InCallTimespan? timespan)
        {
            this.Role = role;
            this.Text = text;
            this.InvocationId = invocationId;
            this.ToolName = toolName;
            this.ErrorDetails = errorDetails;
            this.Medium = medium;
            this.CallStageMessageIndex = callStageMessageIndex;
            this.CallStageId = callStageId;
            this.CallState = callState;
            this.Timespan = timespan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Message" /> class.
        /// </summary>
        public UltravoxV1Message()
        {
        }
    }
}