//HintName: G.Models.ElevenLabsPronunciationDictionaryLocator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElevenLabsPronunciationDictionaryLocator
    {
        /// <summary>
        /// This is the ID of the pronunciation dictionary to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciationDictionaryId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PronunciationDictionaryId { get; set; } = default!;

        /// <summary>
        /// This is the version ID of the pronunciation dictionary to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsPronunciationDictionaryLocator" /> class.
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// This is the ID of the pronunciation dictionary to use.
        /// </param>
        /// <param name="versionId">
        /// This is the version ID of the pronunciation dictionary to use.
        /// </param>
        public ElevenLabsPronunciationDictionaryLocator(
            string pronunciationDictionaryId,
            string versionId)
        {
            this.PronunciationDictionaryId = pronunciationDictionaryId ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryId));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsPronunciationDictionaryLocator" /> class.
        /// </summary>
        public ElevenLabsPronunciationDictionaryLocator()
        {
        }
    }
}