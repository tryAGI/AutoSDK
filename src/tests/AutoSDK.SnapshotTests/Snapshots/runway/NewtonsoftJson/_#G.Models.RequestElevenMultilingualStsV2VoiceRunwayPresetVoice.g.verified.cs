//HintName: G.Models.RequestElevenMultilingualStsV2VoiceRunwayPresetVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A voice preset from the RunwayML API.
    /// </summary>
    public sealed partial class RequestElevenMultilingualStsV2VoiceRunwayPresetVoice
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
        public global::G.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId PresetId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2VoiceRunwayPresetVoice" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="presetId">
        /// The preset voice ID to use for the generated speech.
        /// </param>
        public RequestElevenMultilingualStsV2VoiceRunwayPresetVoice(
            global::G.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId presetId,
            string type = "runway-preset")
        {
            this.PresetId = presetId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2VoiceRunwayPresetVoice" /> class.
        /// </summary>
        public RequestElevenMultilingualStsV2VoiceRunwayPresetVoice()
        {
        }
    }
}