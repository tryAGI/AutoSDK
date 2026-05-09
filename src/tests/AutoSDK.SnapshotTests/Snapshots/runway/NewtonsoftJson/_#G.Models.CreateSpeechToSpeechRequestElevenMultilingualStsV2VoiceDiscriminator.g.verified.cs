//HintName: G.Models.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeJsonConverter))]
        public global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminator(
            global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminator" /> class.
        /// </summary>
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminator()
        {
        }
    }
}