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
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PronunciationDictionaryId { get; set; }

        /// <summary>
        /// The ID of the version of the pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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