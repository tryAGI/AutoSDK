//HintName: G.Models.EvalRunResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalRunResult
    {
        /// <summary>
        /// This is the status of the eval run result.<br/>
        /// The status is only 'pass' or 'fail' for an eval run result.<br/>
        /// Currently, An eval is considered `pass` only if all the Assistant Judge messages are evaluated to pass.<br/>
        /// Example: pass
        /// </summary>
        /// <example>pass</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalRunResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalRunResultStatus Status { get; set; }

        /// <summary>
        /// This is the messages of the eval run result.<br/>
        /// It contains the user/system messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatEvalUserMessageMock, global::G.ChatEvalSystemMessageMock, global::G.ChatEvalToolResponseMessageMock, global::G.ChatEvalAssistantMessageMock>> Messages { get; set; }

        /// <summary>
        /// This is the start time of the eval run result.<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2021-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// This is the end time of the eval run result.<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2021-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunResult" /> class.
        /// </summary>
        /// <param name="status">
        /// This is the status of the eval run result.<br/>
        /// The status is only 'pass' or 'fail' for an eval run result.<br/>
        /// Currently, An eval is considered `pass` only if all the Assistant Judge messages are evaluated to pass.<br/>
        /// Example: pass
        /// </param>
        /// <param name="messages">
        /// This is the messages of the eval run result.<br/>
        /// It contains the user/system messages
        /// </param>
        /// <param name="startedAt">
        /// This is the start time of the eval run result.<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </param>
        /// <param name="endedAt">
        /// This is the end time of the eval run result.<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRunResult(
            global::G.EvalRunResultStatus status,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatEvalUserMessageMock, global::G.ChatEvalSystemMessageMock, global::G.ChatEvalToolResponseMessageMock, global::G.ChatEvalAssistantMessageMock>> messages,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt)
        {
            this.Status = status;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunResult" /> class.
        /// </summary>
        public EvalRunResult()
        {
        }
    }
}