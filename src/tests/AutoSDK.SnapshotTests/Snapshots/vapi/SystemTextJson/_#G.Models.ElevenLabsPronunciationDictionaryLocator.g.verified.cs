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
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciationDictionaryId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PronunciationDictionaryId { get; set; }

        /// <summary>
        /// This is the version ID of the pronunciation dictionary to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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