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
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// The number of unconverted characters for this voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters_unconverted", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharactersUnconverted { get; set; } = default!;

        /// <summary>
        /// The number of converted characters for this voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters_converted", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharactersConverted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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