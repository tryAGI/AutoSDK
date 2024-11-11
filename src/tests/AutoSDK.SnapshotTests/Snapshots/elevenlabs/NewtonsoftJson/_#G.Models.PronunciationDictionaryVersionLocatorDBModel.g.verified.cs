//HintName: G.Models.PronunciationDictionaryVersionLocatorDBModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PronunciationDictionaryVersionLocatorDBModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionary_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PronunciationDictionaryId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionLocatorDBModel" /> class.
        /// </summary>
        /// <param name="pronunciationDictionaryId"></param>
        /// <param name="versionId"></param>
        public PronunciationDictionaryVersionLocatorDBModel(
            string pronunciationDictionaryId,
            string versionId)
        {
            this.PronunciationDictionaryId = pronunciationDictionaryId ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryId));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionLocatorDBModel" /> class.
        /// </summary>
        public PronunciationDictionaryVersionLocatorDBModel()
        {
        }
    }
}