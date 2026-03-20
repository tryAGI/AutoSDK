//HintName: G.Models.SessionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for an xAI Realtime session.
    /// </summary>
    public sealed partial class SessionConfig
    {
        /// <summary>
        /// System-level instructions for the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Voice to use for audio output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.SessionConfigVoice? Voice { get; set; }

        /// <summary>
        /// Server VAD turn detection configuration. Null for manual mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_detection")]
        public global::G.TurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Audio format configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.AudioConfig? Audio { get; set; }

        /// <summary>
        /// Tools available to the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Response modalities (e.g. text, audio).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modalities")]
        public global::System.Collections.Generic.IList<string>? Modalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfig" /> class.
        /// </summary>
        /// <param name="instructions">
        /// System-level instructions for the agent.
        /// </param>
        /// <param name="voice">
        /// Voice to use for audio output.
        /// </param>
        /// <param name="turnDetection">
        /// Server VAD turn detection configuration. Null for manual mode.
        /// </param>
        /// <param name="audio">
        /// Audio format configuration.
        /// </param>
        /// <param name="tools">
        /// Tools available to the agent.
        /// </param>
        /// <param name="modalities">
        /// Response modalities (e.g. text, audio).
        /// </param>
        public SessionConfig(
            string? instructions,
            global::G.SessionConfigVoice? voice,
            global::G.TurnDetection? turnDetection,
            global::G.AudioConfig? audio,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::System.Collections.Generic.IList<string>? modalities)
        {
            this.Instructions = instructions;
            this.Voice = voice;
            this.TurnDetection = turnDetection;
            this.Audio = audio;
            this.Tools = tools;
            this.Modalities = modalities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfig" /> class.
        /// </summary>
        public SessionConfig()
        {
        }
    }
}