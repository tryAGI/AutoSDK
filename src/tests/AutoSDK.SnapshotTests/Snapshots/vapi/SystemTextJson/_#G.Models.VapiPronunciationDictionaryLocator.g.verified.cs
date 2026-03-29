//HintName: G.Models.VapiPronunciationDictionaryLocator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VapiPronunciationDictionaryLocator
    {
        /// <summary>
        /// The pronunciation dictionary ID<br/>
        /// Example: pdict_abc123
        /// </summary>
        /// <example>pdict_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciationDictId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PronunciationDictId { get; set; }

        /// <summary>
        /// Version ID (only required for ElevenLabs, ignored for Cartesia)<br/>
        /// Example: ver_abc123
        /// </summary>
        /// <example>ver_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiPronunciationDictionaryLocator" /> class.
        /// </summary>
        /// <param name="pronunciationDictId">
        /// The pronunciation dictionary ID<br/>
        /// Example: pdict_abc123
        /// </param>
        /// <param name="versionId">
        /// Version ID (only required for ElevenLabs, ignored for Cartesia)<br/>
        /// Example: ver_abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VapiPronunciationDictionaryLocator(
            string pronunciationDictId,
            string? versionId)
        {
            this.PronunciationDictId = pronunciationDictId ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictId));
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiPronunciationDictionaryLocator" /> class.
        /// </summary>
        public VapiPronunciationDictionaryLocator()
        {
        }
    }
}