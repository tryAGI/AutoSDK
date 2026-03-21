//HintName: G.Models.CreateTextToSpeechRequestElevenMultilingualV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestElevenMultilingualV2
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptText", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptText { get; set; } = default!;

        /// <summary>
        /// The voice to use for the generated speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice Voice { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"eleven_multilingual_v2"</default>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string Model { get; set; } = "eleven_multilingual_v2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenMultilingualV2" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="voice">
        /// The voice to use for the generated speech.
        /// </param>
        /// <param name="model"></param>
        public CreateTextToSpeechRequestElevenMultilingualV2(
            string promptText,
            global::G.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice voice,
            string model = "eleven_multilingual_v2")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenMultilingualV2" /> class.
        /// </summary>
        public CreateTextToSpeechRequestElevenMultilingualV2()
        {
        }
    }
}