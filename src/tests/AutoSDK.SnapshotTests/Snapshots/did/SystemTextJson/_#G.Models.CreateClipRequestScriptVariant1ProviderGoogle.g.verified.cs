//HintName: G.Models.CreateClipRequestScriptVariant1ProviderGoogle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipRequestScriptVariant1ProviderGoogle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateClipRequestScriptVariant1ProviderGoogleTypeJsonConverter))]
        public global::G.CreateClipRequestScriptVariant1ProviderGoogleType Type { get; set; }

        /// <summary>
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Default Value: he-IL-Wavenet-A<br/>
        /// Example: he-IL-Wavenet-A
        /// </summary>
        /// <example>he-IL-Wavenet-A</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestScriptVariant1ProviderGoogle" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="voiceId">
        /// Voice ID selected from the list of available voices.&lt;/br&gt;Retrieve available options from the GET /voices endpoint.<br/>
        /// Default Value: he-IL-Wavenet-A<br/>
        /// Example: he-IL-Wavenet-A
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipRequestScriptVariant1ProviderGoogle(
            global::G.CreateClipRequestScriptVariant1ProviderGoogleType type,
            string? voiceId)
        {
            this.Type = type;
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestScriptVariant1ProviderGoogle" /> class.
        /// </summary>
        public CreateClipRequestScriptVariant1ProviderGoogle()
        {
        }
    }
}