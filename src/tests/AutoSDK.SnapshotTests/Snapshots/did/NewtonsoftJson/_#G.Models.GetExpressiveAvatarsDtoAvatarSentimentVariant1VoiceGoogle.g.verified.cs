//HintName: G.Models.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleTypeJsonConverter))]
        public global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Default Value: he-IL-Wavenet-A<br/>
        /// Example: he-IL-Wavenet-A
        /// </summary>
        /// <example>he-IL-Wavenet-A</example>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="voiceId">
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Default Value: he-IL-Wavenet-A<br/>
        /// Example: he-IL-Wavenet-A
        /// </param>
        public GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle(
            global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogleType type,
            string? voiceId)
        {
            this.Type = type;
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle" /> class.
        /// </summary>
        public GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceGoogle()
        {
        }
    }
}