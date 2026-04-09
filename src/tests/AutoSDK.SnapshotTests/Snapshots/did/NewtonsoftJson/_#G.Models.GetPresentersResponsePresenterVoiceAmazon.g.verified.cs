//HintName: G.Models.GetPresentersResponsePresenterVoiceAmazon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPresentersResponsePresenterVoiceAmazon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetPresentersResponsePresenterVoiceAmazonTypeJsonConverter))]
        public global::G.GetPresentersResponsePresenterVoiceAmazonType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: Joanna
        /// </summary>
        /// <example>Joanna</example>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetPresentersResponsePresenterVoiceAmazonVoiceIdJsonConverter))]
        public global::G.GetPresentersResponsePresenterVoiceAmazonVoiceId VoiceId { get; set; } = default!;

        /// <summary>
        /// Voice customization options. To save the language of the selected agent voice<br/>
        /// Example: English (United States)
        /// </summary>
        /// <example>English (United States)</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresentersResponsePresenterVoiceAmazon" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Example: Joanna
        /// </param>
        /// <param name="type"></param>
        /// <param name="language">
        /// Voice customization options. To save the language of the selected agent voice<br/>
        /// Example: English (United States)
        /// </param>
        public GetPresentersResponsePresenterVoiceAmazon(
            global::G.GetPresentersResponsePresenterVoiceAmazonVoiceId voiceId,
            global::G.GetPresentersResponsePresenterVoiceAmazonType type,
            string? language)
        {
            this.Type = type;
            this.VoiceId = voiceId;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresentersResponsePresenterVoiceAmazon" /> class.
        /// </summary>
        public GetPresentersResponsePresenterVoiceAmazon()
        {
        }
    }
}