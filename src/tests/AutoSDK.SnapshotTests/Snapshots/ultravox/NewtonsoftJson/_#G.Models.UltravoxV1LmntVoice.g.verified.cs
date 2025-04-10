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
        [global::Newtonsoft.Json.JsonProperty("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The LMNT model to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The speaking rate. Must be between 0.25 and 2. Defaults to 1.<br/>
        ///  See https://docs.lmnt.com/api-reference/speech/synthesize-speech-bytes#body-speed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// See https://docs.lmnt.com/api-reference/speech/synthesize-speech-bytes#body-conversational
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversational")]
        public bool? Conversational { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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