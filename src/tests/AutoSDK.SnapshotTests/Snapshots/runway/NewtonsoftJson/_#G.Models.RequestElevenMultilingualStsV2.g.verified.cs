//HintName: G.Models.RequestElevenMultilingualStsV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestElevenMultilingualStsV2
    {
        /// <summary>
        /// Whether to remove background noise from the generated speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("removeBackgroundNoise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Media Media { get; set; } = default!;

        /// <summary>
        /// The voice to use for the generated speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RequestElevenMultilingualStsV2VoiceRunwayPresetVoice Voice { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"eleven_multilingual_sts_v2"</default>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string Model { get; set; } = "eleven_multilingual_sts_v2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2" /> class.
        /// </summary>
        /// <param name="removeBackgroundNoise">
        /// Whether to remove background noise from the generated speech.
        /// </param>
        /// <param name="media"></param>
        /// <param name="voice">
        /// The voice to use for the generated speech.
        /// </param>
        /// <param name="model"></param>
        public RequestElevenMultilingualStsV2(
            global::G.Media media,
            global::G.RequestElevenMultilingualStsV2VoiceRunwayPresetVoice voice,
            bool? removeBackgroundNoise,
            string model = "eleven_multilingual_sts_v2")
        {
            this.Media = media;
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.RemoveBackgroundNoise = removeBackgroundNoise;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2" /> class.
        /// </summary>
        public RequestElevenMultilingualStsV2()
        {
        }
    }
}