//HintName: G.Models.VoiceStatisticsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceStatisticsResponseModel
    {
        /// <summary>
        /// The voice ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// The number of unconverted characters for this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_unconverted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharactersUnconverted { get; set; }

        /// <summary>
        /// The number of converted characters for this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_converted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharactersConverted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStatisticsResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The voice ID.
        /// </param>
        /// <param name="charactersUnconverted">
        /// The number of unconverted characters for this voice.
        /// </param>
        /// <param name="charactersConverted">
        /// The number of converted characters for this voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceStatisticsResponseModel(
            string voiceId,
            int charactersUnconverted,
            int charactersConverted)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.CharactersUnconverted = charactersUnconverted;
            this.CharactersConverted = charactersConverted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStatisticsResponseModel" /> class.
        /// </summary>
        public VoiceStatisticsResponseModel()
        {
        }
    }
}