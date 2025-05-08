//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
    /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
    /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction
    {
        /// <summary>
        /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionTypeJsonConverter))]
        public global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction(
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReductionType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction()
        {
        }
    }
}