//HintName: G.Models.CallTombstone.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallTombstone
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        public global::System.Guid CallId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        public global::System.Guid AccountId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletionTime")]
        public global::System.DateTime DeletionTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joined")]
        public global::System.DateTime? Joined { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended")]
        public global::System.DateTime? Ended { get; set; }

        /// <summary>
        /// Default Value: 3600s
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDuration")]
        public string? MaxDuration { get; set; }

        /// <summary>
        /// The reason the call ended.<br/>
        /// * `unjoined` - Client never joined<br/>
        /// * `hangup` - Client hung up<br/>
        /// * `agent_hangup` - Agent hung up<br/>
        /// * `timeout` - Call timed out<br/>
        /// * `connection_error` - Connection error<br/>
        /// * `system_error` - System error<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.EndReasonEnum?, global::G.NullEnum?>))]
        public global::G.OneOf<global::G.EndReasonEnum?, global::G.NullEnum?>? EndReason { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingEnabled")]
        public bool RecordingEnabled { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("hadSummary")]
        public bool HadSummary { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallTombstone" /> class.
        /// </summary>
        /// <param name="callId">
        /// Included only in responses
        /// </param>
        /// <param name="accountId">
        /// Included only in responses
        /// </param>
        /// <param name="created"></param>
        /// <param name="deletionTime">
        /// Included only in responses
        /// </param>
        /// <param name="joined"></param>
        /// <param name="ended"></param>
        /// <param name="maxDuration">
        /// Default Value: 3600s
        /// </param>
        /// <param name="endReason">
        /// The reason the call ended.<br/>
        /// * `unjoined` - Client never joined<br/>
        /// * `hangup` - Client hung up<br/>
        /// * `agent_hangup` - Agent hung up<br/>
        /// * `timeout` - Call timed out<br/>
        /// * `connection_error` - Connection error<br/>
        /// * `system_error` - System error<br/>
        /// Included only in responses
        /// </param>
        /// <param name="recordingEnabled">
        /// Included only in responses
        /// </param>
        /// <param name="hadSummary">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallTombstone(
            global::System.DateTime created,
            global::System.DateTime? joined,
            global::System.DateTime? ended,
            string? maxDuration,
            global::G.OneOf<global::G.EndReasonEnum?, global::G.NullEnum?>? endReason,
            global::System.Guid callId = default!,
            global::System.Guid accountId = default!,
            global::System.DateTime deletionTime = default!,
            bool recordingEnabled = default!,
            bool hadSummary = default!)
        {
            this.Created = created;
            this.CallId = callId;
            this.AccountId = accountId;
            this.DeletionTime = deletionTime;
            this.Joined = joined;
            this.Ended = ended;
            this.MaxDuration = maxDuration;
            this.EndReason = endReason;
            this.RecordingEnabled = recordingEnabled;
            this.HadSummary = hadSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallTombstone" /> class.
        /// </summary>
        public CallTombstone()
        {
        }
    }
}