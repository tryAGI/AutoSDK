//HintName: G.Models.TurnConfigWorkflowOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"mode":"turn","silence_end_call_timeout":-1.0,"soft_timeout_config":{"message":"Hhmmmm...yeah.","timeout_seconds":-1.0,"use_llm_generated_message":false},"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0}
    /// </summary>
    public sealed partial class TurnConfigWorkflowOverride
    {
        /// <summary>
        /// Maximum wait time for the user's reply before re-engaging the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_timeout")]
        public double? TurnTimeout { get; set; }

        /// <summary>
        /// How long the agent will wait for the user to start the conversation if the first message is empty. If not set, uses the regular turn_timeout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_wait_time")]
        public double? InitialWaitTime { get; set; }

        /// <summary>
        /// Maximum wait time since the user last spoke before terminating the call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_end_call_timeout")]
        public double? SilenceEndCallTimeout { get; set; }

        /// <summary>
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_timeout_config")]
        public global::G.SoftTimeoutConfigWorkflowOverride? SoftTimeoutConfig { get; set; }

        /// <summary>
        /// The mode of turn detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public global::G.TurnMode? Mode { get; set; }

        /// <summary>
        /// Controls how eager the agent is to respond. Low = less eager (waits longer), Standard = default eagerness, High = more eager (responds sooner)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_eagerness")]
        public global::G.TurnEagerness? TurnEagerness { get; set; }

        /// <summary>
        /// Controls if the agent should be more patient when user is spelling numbers and named entities. Auto = model based, Off = never wait extra
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spelling_patience")]
        public global::G.SpellingPatience? SpellingPatience { get; set; }

        /// <summary>
        /// When enabled, starts generating LLM responses during silence before full turn confidence is reached, reducing perceived latency. May increase LLM costs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculative_turn")]
        public bool? SpeculativeTurn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigWorkflowOverride" /> class.
        /// </summary>
        /// <param name="turnTimeout">
        /// Maximum wait time for the user's reply before re-engaging the user
        /// </param>
        /// <param name="initialWaitTime">
        /// How long the agent will wait for the user to start the conversation if the first message is empty. If not set, uses the regular turn_timeout.
        /// </param>
        /// <param name="silenceEndCallTimeout">
        /// Maximum wait time since the user last spoke before terminating the call
        /// </param>
        /// <param name="softTimeoutConfig">
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.
        /// </param>
        /// <param name="mode">
        /// The mode of turn detection
        /// </param>
        /// <param name="turnEagerness">
        /// Controls how eager the agent is to respond. Low = less eager (waits longer), Standard = default eagerness, High = more eager (responds sooner)
        /// </param>
        /// <param name="spellingPatience">
        /// Controls if the agent should be more patient when user is spelling numbers and named entities. Auto = model based, Off = never wait extra
        /// </param>
        /// <param name="speculativeTurn">
        /// When enabled, starts generating LLM responses during silence before full turn confidence is reached, reducing perceived latency. May increase LLM costs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnConfigWorkflowOverride(
            double? turnTimeout,
            double? initialWaitTime,
            double? silenceEndCallTimeout,
            global::G.SoftTimeoutConfigWorkflowOverride? softTimeoutConfig,
            global::G.TurnMode? mode,
            global::G.TurnEagerness? turnEagerness,
            global::G.SpellingPatience? spellingPatience,
            bool? speculativeTurn)
        {
            this.TurnTimeout = turnTimeout;
            this.InitialWaitTime = initialWaitTime;
            this.SilenceEndCallTimeout = silenceEndCallTimeout;
            this.SoftTimeoutConfig = softTimeoutConfig;
            this.Mode = mode;
            this.TurnEagerness = turnEagerness;
            this.SpellingPatience = spellingPatience;
            this.SpeculativeTurn = speculativeTurn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigWorkflowOverride" /> class.
        /// </summary>
        public TurnConfigWorkflowOverride()
        {
        }
    }
}