//HintName: G.Models.CreateSpeechToSpeechRequestElevenMultilingualStsV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechToSpeechRequestElevenMultilingualStsV2
    {
        /// <summary>
        /// Whether to remove background noise from the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeBackgroundNoise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MediaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Media Media { get; set; }

        /// <summary>
        /// The voice to use for the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"eleven_multilingual_sts_v2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "eleven_multilingual_sts_v2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2" /> class.
        /// </summary>
        /// <param name="media"></param>
        /// <param name="voice">
        /// The voice to use for the generated speech.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// Whether to remove background noise from the generated speech.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2(
            global::G.Media media,
            global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice voice,
            bool? removeBackgroundNoise,
            string model = "eleven_multilingual_sts_v2")
        {
            this.RemoveBackgroundNoise = removeBackgroundNoise;
            this.Media = media;
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2" /> class.
        /// </summary>
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2()
        {
        }
    }
}