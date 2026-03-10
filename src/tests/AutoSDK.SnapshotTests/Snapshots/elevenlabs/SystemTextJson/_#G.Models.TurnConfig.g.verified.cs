//HintName: G.Models.TurnConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"mode":"turn","silence_end_call_timeout":-1.0,"soft_timeout_config":{"message":"Hhmmmm...yeah.","timeout_seconds":-1.0},"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0}
    /// </summary>
    public sealed partial class TurnConfig
    {
        /// <summary>
        /// Maximum wait time for the user's reply before re-engaging the user<br/>
        /// Default Value: 7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_timeout")]
        public double? TurnTimeout { get; set; }

        /// <summary>
        /// How long the agent will wait for the user to start the conversation if the first message is empty. If not set, uses the regular turn_timeout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_wait_time")]
        public double? InitialWaitTime { get; set; }

        /// <summary>
        /// Maximum wait time since the user last spoke before terminating the call<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_end_call_timeout")]
        public double? SilenceEndCallTimeout { get; set; }

        /// <summary>
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.<br/>
        /// Example: {"message":"Hhmmmm...yeah.","timeout_seconds":2.0,"use_llm_generated_message":false}
        /// </summary>
        /// <example>{"message":"Hhmmmm...yeah.","timeout_seconds":2.0,"use_llm_generated_message":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_timeout_config")]
        public global::G.SoftTimeoutConfig? SoftTimeoutConfig { get; set; }

        /// <summary>
        /// The mode of turn detection<br/>
        /// Default Value: turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TurnModeJsonConverter))]
        public global::G.TurnMode? Mode { get; set; }

        /// <summary>
        /// Controls how eager the agent is to respond. Low = less eager (waits longer), Standard = default eagerness, High = more eager (responds sooner)<br/>
        /// Default Value: normal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_eagerness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TurnEagernessJsonConverter))]
        public global::G.TurnEagerness? TurnEagerness { get; set; }

        /// <summary>
        /// Controls if the agent should be more patient when user is spelling numbers and named entities. Auto = model based, Off = never wait extra<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spelling_patience")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpellingPatienceJsonConverter))]
        public global::G.SpellingPatience? SpellingPatience { get; set; }

        /// <summary>
        /// When enabled, starts generating LLM responses during silence before full turn confidence is reached, reducing perceived latency. May increase LLM costs.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculative_turn")]
        public bool? SpeculativeTurn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfig" /> class.
        /// </summary>
        /// <param name="turnTimeout">
        /// Maximum wait time for the user's reply before re-engaging the user<br/>
        /// Default Value: 7F
        /// </param>
        /// <param name="initialWaitTime">
        /// How long the agent will wait for the user to start the conversation if the first message is empty. If not set, uses the regular turn_timeout.
        /// </param>
        /// <param name="silenceEndCallTimeout">
        /// Maximum wait time since the user last spoke before terminating the call<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="softTimeoutConfig">
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.<br/>
        /// Example: {"message":"Hhmmmm...yeah.","timeout_seconds":2.0,"use_llm_generated_message":false}
        /// </param>
        /// <param name="mode">
        /// The mode of turn detection<br/>
        /// Default Value: turn
        /// </param>
        /// <param name="turnEagerness">
        /// Controls how eager the agent is to respond. Low = less eager (waits longer), Standard = default eagerness, High = more eager (responds sooner)<br/>
        /// Default Value: normal
        /// </param>
        /// <param name="spellingPatience">
        /// Controls if the agent should be more patient when user is spelling numbers and named entities. Auto = model based, Off = never wait extra<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="speculativeTurn">
        /// When enabled, starts generating LLM responses during silence before full turn confidence is reached, reducing perceived latency. May increase LLM costs.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnConfig(
            double? turnTimeout,
            double? initialWaitTime,
            double? silenceEndCallTimeout,
            global::G.SoftTimeoutConfig? softTimeoutConfig,
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
        /// Initializes a new instance of the <see cref="TurnConfig" /> class.
        /// </summary>
        public TurnConfig()
        {
        }
    }
}