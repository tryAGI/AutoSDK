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
        [global::Newtonsoft.Json.JsonProperty("pronunciationDictId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PronunciationDictId { get; set; } = default!;

        /// <summary>
        /// Version ID (only required for ElevenLabs, ignored for Cartesia)<br/>
        /// Example: ver_abc123
        /// </summary>
        /// <example>ver_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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