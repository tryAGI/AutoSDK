//HintName: G.Models.CreateSesameVoiceDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSesameVoiceDTO
    {
        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceName")]
        public string? VoiceName { get; set; }

        /// <summary>
        /// The transcript of the utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSesameVoiceDTO" /> class.
        /// </summary>
        /// <param name="voiceName">
        /// The name of the voice.
        /// </param>
        /// <param name="transcription">
        /// The transcript of the utterance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSesameVoiceDTO(
            string? voiceName,
            string? transcription)
        {
            this.VoiceName = voiceName;
            this.Transcription = transcription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSesameVoiceDTO" /> class.
        /// </summary>
        public CreateSesameVoiceDTO()
        {
        }
    }
}