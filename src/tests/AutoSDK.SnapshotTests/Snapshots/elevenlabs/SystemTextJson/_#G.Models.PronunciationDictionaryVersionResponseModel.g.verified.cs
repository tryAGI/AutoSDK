//HintName: G.Models.PronunciationDictionaryVersionResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PronunciationDictionaryVersionResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PronunciationDictionaryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dictionary_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DictionaryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreationTimeUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionResponseModel" /> class.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="pronunciationDictionaryId"></param>
        /// <param name="dictionaryName"></param>
        /// <param name="versionName"></param>
        /// <param name="createdBy"></param>
        /// <param name="creationTimeUnix"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PronunciationDictionaryVersionResponseModel(
            string versionId,
            string pronunciationDictionaryId,
            string dictionaryName,
            string versionName,
            string createdBy,
            int creationTimeUnix)
        {
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.PronunciationDictionaryId = pronunciationDictionaryId ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryId));
            this.DictionaryName = dictionaryName ?? throw new global::System.ArgumentNullException(nameof(dictionaryName));
            this.VersionName = versionName ?? throw new global::System.ArgumentNullException(nameof(versionName));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreationTimeUnix = creationTimeUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionResponseModel" /> class.
        /// </summary>
        public PronunciationDictionaryVersionResponseModel()
        {
        }
    }
}