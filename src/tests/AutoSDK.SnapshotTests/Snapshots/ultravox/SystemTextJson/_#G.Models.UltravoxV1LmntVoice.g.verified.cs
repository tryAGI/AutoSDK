//HintName: G.Models.UltravoxV1LmntVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for a voice served by LMNT.
    /// </summary>
    public sealed partial class UltravoxV1LmntVoice
    {
        /// <summary>
        /// The ID of the voice in LMNT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The LMNT model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The speaking rate. Must be between 0.25 and 2. Defaults to 1.<br/>
        ///  See https://docs.lmnt.com/api-reference/speech/synthesize-speech-bytes#body-speed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// See https://docs.lmnt.com/api-reference/speech/synthesize-speech-bytes#body-conversational
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversational")]
        public bool? Conversational { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1LmntVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the voice in LMNT.
        /// </param>
        /// <param name="model">
        /// The LMNT model to use.
        /// </param>
        /// <param name="speed">
        /// The speaking rate. Must be between 0.25 and 2. Defaults to 1.<br/>
        ///  See https://docs.lmnt.com/api-reference/speech/synthesize-speech-bytes#body-speed
        /// </param>
        /// <param name="conversational">
        /// See https://docs.lmnt.com/api-reference/speech/synthesize-speech-bytes#body-conversational
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1LmntVoice(
            string? voiceId,
            string? model,
            float? speed,
            bool? conversational)
        {
            this.VoiceId = voiceId;
            this.Model = model;
            this.Speed = speed;
            this.Conversational = conversational;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1LmntVoice" /> class.
        /// </summary>
        public UltravoxV1LmntVoice()
        {
        }
    }
}