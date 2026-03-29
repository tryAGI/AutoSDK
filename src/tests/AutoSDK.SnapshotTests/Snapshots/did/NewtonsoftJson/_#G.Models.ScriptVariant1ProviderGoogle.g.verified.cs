//HintName: G.Models.ScriptVariant1ProviderGoogle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScriptVariant1ProviderGoogle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ScriptVariant1ProviderGoogleType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ScriptVariant1ProviderGoogle" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="voiceId">
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Default Value: he-IL-Wavenet-A<br/>
        /// Example: he-IL-Wavenet-A
        /// </param>
        public ScriptVariant1ProviderGoogle(
            global::G.ScriptVariant1ProviderGoogleType type,
            string? voiceId)
        {
            this.Type = type;
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptVariant1ProviderGoogle" /> class.
        /// </summary>
        public ScriptVariant1ProviderGoogle()
        {
        }
    }
}