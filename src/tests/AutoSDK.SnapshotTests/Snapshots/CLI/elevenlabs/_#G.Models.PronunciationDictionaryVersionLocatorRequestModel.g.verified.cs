//HintName: G.Models.PronunciationDictionaryVersionLocatorRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PronunciationDictionaryVersionLocatorRequestModel
    {
        /// <summary>
        /// The ID of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PronunciationDictionaryId { get; set; }

        /// <summary>
        /// The ID of the version of the pronunciation dictionary. If not provided, the latest version will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionLocatorRequestModel" /> class.
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The ID of the pronunciation dictionary.
        /// </param>
        /// <param name="versionId">
        /// The ID of the version of the pronunciation dictionary. If not provided, the latest version will be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryVersionLocatorRequestModel(
            string pronunciationDictionaryId,
            string? versionId)
        {
            this.PronunciationDictionaryId = pronunciationDictionaryId ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryId));
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionLocatorRequestModel" /> class.
        /// </summary>
        public PronunciationDictionaryVersionLocatorRequestModel()
        {
        }
    }
}