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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "runway-preset";

        /// <summary>
        /// The preset voice ID to use for the generated speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presetId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId PresetId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice" /> class.
        /// </summary>
        /// <param name="presetId">
        /// The preset voice ID to use for the generated speech.
        /// </param>
        /// <param name="type"></param>
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