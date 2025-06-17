﻿//HintName: G.Models.TTSConversationalConfigOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSConversationalConfigOverride
    {
        /// <summary>
        /// The voice ID to use for TTS
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOverride" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The voice ID to use for TTS
        /// </param>
        public TTSConversationalConfigOverride(
            string? voiceId)
        {
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSConversationalConfigOverride" /> class.
        /// </summary>
        public TTSConversationalConfigOverride()
        {
        }
    }
}