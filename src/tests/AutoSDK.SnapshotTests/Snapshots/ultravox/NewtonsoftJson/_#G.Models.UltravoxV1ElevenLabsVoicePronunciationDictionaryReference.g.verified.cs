﻿//HintName: G.Models.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reference to a pronunciation dictionary within ElevenLabs.
    /// </summary>
    public sealed partial class UltravoxV1ElevenLabsVoicePronunciationDictionaryReference
    {
        /// <summary>
        /// The dictionary's ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dictionaryId")]
        public string? DictionaryId { get; set; }

        /// <summary>
        /// The dictionary's version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ElevenLabsVoicePronunciationDictionaryReference" /> class.
        /// </summary>
        /// <param name="dictionaryId">
        /// The dictionary's ID.
        /// </param>
        /// <param name="versionId">
        /// The dictionary's version.
        /// </param>
        public UltravoxV1ElevenLabsVoicePronunciationDictionaryReference(
            string? dictionaryId,
            string? versionId)
        {
            this.DictionaryId = dictionaryId;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ElevenLabsVoicePronunciationDictionaryReference" /> class.
        /// </summary>
        public UltravoxV1ElevenLabsVoicePronunciationDictionaryReference()
        {
        }
    }
}