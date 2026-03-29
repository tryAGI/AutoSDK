//HintName: G.Models.TranscriptionConfigAudioFilteringConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for limiting the transcription of quiet audio.
    /// </summary>
    public sealed partial class TranscriptionConfigAudioFilteringConfig
    {
        /// <summary>
        /// Controls the lower limit of audio volume at which speech and audio events will be transcribed. If the volume limit is very low, then most sound will be passed to the speech recognition engine. Higher numbers will cut out increasing amounts of sound.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_threshold")]
        public float? VolumeThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigAudioFilteringConfig" /> class.
        /// </summary>
        /// <param name="volumeThreshold">
        /// Controls the lower limit of audio volume at which speech and audio events will be transcribed. If the volume limit is very low, then most sound will be passed to the speech recognition engine. Higher numbers will cut out increasing amounts of sound.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionConfigAudioFilteringConfig(
            float? volumeThreshold)
        {
            this.VolumeThreshold = volumeThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigAudioFilteringConfig" /> class.
        /// </summary>
        public TranscriptionConfigAudioFilteringConfig()
        {
        }
    }
}