//HintName: G.Models.PydanticPronunciationDictionaryVersionLocator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A locator for other documents to be able to reference a specific dictionary and it's version.<br/>
    /// This is a pydantic version of PronunciationDictionaryVersionLocatorDBModel.<br/>
    /// Required to ensure compat with the rest of the agent data models.
    /// </summary>
    public sealed partial class PydanticPronunciationDictionaryVersionLocator
    {
        /// <summary>
        /// The ID of the pronunciation dictionary
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionary_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PronunciationDictionaryId { get; set; } = default!;

        /// <summary>
        /// The ID of the version of the pronunciation dictionary
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? VersionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PydanticPronunciationDictionaryVersionLocator" /> class.
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The ID of the pronunciation dictionary
        /// </param>
        /// <param name="versionId">
        /// The ID of the version of the pronunciation dictionary
        /// </param>
        public PydanticPronunciationDictionaryVersionLocator(
            string pronunciationDictionaryId,
            string? versionId)
        {
            this.PronunciationDictionaryId = pronunciationDictionaryId ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryId));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PydanticPronunciationDictionaryVersionLocator" /> class.
        /// </summary>
        public PydanticPronunciationDictionaryVersionLocator()
        {
        }
    }
}