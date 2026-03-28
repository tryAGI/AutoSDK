//HintName: G.Models.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A voice preset from the RunwayML API.
    /// </summary>
    public sealed partial class CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"runway-preset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "runway-preset";

        /// <summary>
        /// The preset voice ID to use for the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice" /> class.
        /// </summary>
        /// <param name="presetId">
        /// The preset voice ID to use for the generated speech.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice(
            global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId presetId,
            string type = "runway-preset")
        {
            this.Type = type;
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice" /> class.
        /// </summary>
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice()
        {
        }
    }
}