//HintName: G.Models.VoiceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceResponse
    {
        /// <summary>
        /// Unique id for the voice.<br/>
        /// Example: retell-Cimo
        /// </summary>
        /// <example>retell-Cimo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Name of the voice.<br/>
        /// Example: Adrian
        /// </summary>
        /// <example>Adrian</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceName { get; set; }

        /// <summary>
        /// Indicates the provider of voice.<br/>
        /// Example: elevenlabs
        /// </summary>
        /// <example>elevenlabs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceResponseProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceResponseProvider Provider { get; set; }

        /// <summary>
        /// Accent annotation of the voice.<br/>
        /// Example: American
        /// </summary>
        /// <example>American</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Gender of voice.<br/>
        /// Example: male
        /// </summary>
        /// <example>male</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceResponseGenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoiceResponseGender Gender { get; set; }

        /// <summary>
        /// Age annotation of the voice.<br/>
        /// Example: Young
        /// </summary>
        /// <example>Young</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public string? Age { get; set; }

        /// <summary>
        /// URL to the preview audio of the voice.<br/>
        /// Example: https://retell-utils-public.s3.us-west-2.amazonaws.com/adrian.mp3
        /// </summary>
        /// <example>https://retell-utils-public.s3.us-west-2.amazonaws.com/adrian.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_audio_url")]
        public string? PreviewAudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceResponse" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Unique id for the voice.<br/>
        /// Example: retell-Cimo
        /// </param>
        /// <param name="voiceName">
        /// Name of the voice.<br/>
        /// Example: Adrian
        /// </param>
        /// <param name="provider">
        /// Indicates the provider of voice.<br/>
        /// Example: elevenlabs
        /// </param>
        /// <param name="gender">
        /// Gender of voice.<br/>
        /// Example: male
        /// </param>
        /// <param name="accent">
        /// Accent annotation of the voice.<br/>
        /// Example: American
        /// </param>
        /// <param name="age">
        /// Age annotation of the voice.<br/>
        /// Example: Young
        /// </param>
        /// <param name="previewAudioUrl">
        /// URL to the preview audio of the voice.<br/>
        /// Example: https://retell-utils-public.s3.us-west-2.amazonaws.com/adrian.mp3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceResponse(
            string voiceId,
            string voiceName,
            global::G.VoiceResponseProvider provider,
            global::G.VoiceResponseGender gender,
            string? accent,
            string? age,
            string? previewAudioUrl)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
            this.Provider = provider;
            this.Accent = accent;
            this.Gender = gender;
            this.Age = age;
            this.PreviewAudioUrl = previewAudioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceResponse" /> class.
        /// </summary>
        public VoiceResponse()
        {
        }
    }
}