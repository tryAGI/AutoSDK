//HintName: G.Models.AddCommunityVoiceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddCommunityVoiceRequest
    {
        /// <summary>
        /// Voice provider to add the voice from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AddCommunityVoiceRequestVoiceProviderJsonConverter))]
        public global::G.AddCommunityVoiceRequestVoiceProvider? VoiceProvider { get; set; }

        /// <summary>
        /// Voice id assigned by the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderVoiceId { get; set; } = default!;

        /// <summary>
        /// A custom name for the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceName { get; set; } = default!;

        /// <summary>
        /// Required for ElevenLabs only. User id of the voice owner.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_user_id")]
        public string? PublicUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCommunityVoiceRequest" /> class.
        /// </summary>
        /// <param name="providerVoiceId">
        /// Voice id assigned by the provider.
        /// </param>
        /// <param name="voiceName">
        /// A custom name for the voice.
        /// </param>
        /// <param name="voiceProvider">
        /// Voice provider to add the voice from.
        /// </param>
        /// <param name="publicUserId">
        /// Required for ElevenLabs only. User id of the voice owner.
        /// </param>
        public AddCommunityVoiceRequest(
            string providerVoiceId,
            string voiceName,
            global::G.AddCommunityVoiceRequestVoiceProvider? voiceProvider,
            string? publicUserId)
        {
            this.VoiceProvider = voiceProvider;
            this.ProviderVoiceId = providerVoiceId ?? throw new global::System.ArgumentNullException(nameof(providerVoiceId));
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
            this.PublicUserId = publicUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCommunityVoiceRequest" /> class.
        /// </summary>
        public AddCommunityVoiceRequest()
        {
        }
    }
}