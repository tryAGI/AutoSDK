//HintName: G.Models.OpenAIVoicemailDetectionPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIVoicemailDetectionPlan
    {
        /// <summary>
        /// This is the maximum duration from the start of the call that we will wait for a voicemail beep, before speaking our message<br/>
        /// - If we detect a voicemail beep before this, we will speak the message at that point.<br/>
        /// - Setting too low a value means that the bot will start speaking its voicemail message too early. If it does so before the actual beep, it will get cut off. You should definitely tune this to your use case.<br/>
        /// @default 30<br/>
        /// @min 0<br/>
        /// @max 60<br/>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beepMaxAwaitSeconds")]
        public double? BeepMaxAwaitSeconds { get; set; }

        /// <summary>
        /// This is the provider to use for voicemail detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAIVoicemailDetectionPlanProviderJsonConverter))]
        public global::G.OpenAIVoicemailDetectionPlanProvider Provider { get; set; }

        /// <summary>
        /// This is the backoff plan for the voicemail detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoffPlan")]
        public global::G.VoicemailDetectionBackoffPlan? BackoffPlan { get; set; }

        /// <summary>
        /// This is the detection type to use for voicemail detection.<br/>
        /// - 'audio': Uses native audio models (default)<br/>
        /// - 'transcript': Uses ASR/transcript-based detection<br/>
        /// @default 'audio' (audio detection)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAIVoicemailDetectionPlanTypeJsonConverter))]
        public global::G.OpenAIVoicemailDetectionPlanType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIVoicemailDetectionPlan" /> class.
        /// </summary>
        /// <param name="beepMaxAwaitSeconds">
        /// This is the maximum duration from the start of the call that we will wait for a voicemail beep, before speaking our message<br/>
        /// - If we detect a voicemail beep before this, we will speak the message at that point.<br/>
        /// - Setting too low a value means that the bot will start speaking its voicemail message too early. If it does so before the actual beep, it will get cut off. You should definitely tune this to your use case.<br/>
        /// @default 30<br/>
        /// @min 0<br/>
        /// @max 60<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="provider">
        /// This is the provider to use for voicemail detection.
        /// </param>
        /// <param name="backoffPlan">
        /// This is the backoff plan for the voicemail detection.
        /// </param>
        /// <param name="type">
        /// This is the detection type to use for voicemail detection.<br/>
        /// - 'audio': Uses native audio models (default)<br/>
        /// - 'transcript': Uses ASR/transcript-based detection<br/>
        /// @default 'audio' (audio detection)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIVoicemailDetectionPlan(
            double? beepMaxAwaitSeconds,
            global::G.OpenAIVoicemailDetectionPlanProvider provider,
            global::G.VoicemailDetectionBackoffPlan? backoffPlan,
            global::G.OpenAIVoicemailDetectionPlanType? type)
        {
            this.BeepMaxAwaitSeconds = beepMaxAwaitSeconds;
            this.Provider = provider;
            this.BackoffPlan = backoffPlan;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIVoicemailDetectionPlan" /> class.
        /// </summary>
        public OpenAIVoicemailDetectionPlan()
        {
        }
    }
}