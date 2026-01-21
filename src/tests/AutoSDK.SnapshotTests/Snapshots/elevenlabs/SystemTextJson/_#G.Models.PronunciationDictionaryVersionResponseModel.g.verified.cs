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
        [global::System.Text.Json.Serialization.JsonPropertyName("version_rules_num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionRulesNum { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_on_resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2? PermissionOnResource { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_time_unix")]
        public int? ArchivedTimeUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionResponseModel" /> class.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="versionRulesNum"></param>
        /// <param name="pronunciationDictionaryId"></param>
        /// <param name="dictionaryName"></param>
        /// <param name="versionName"></param>
        /// <param name="permissionOnResource"></param>
        /// <param name="createdBy"></param>
        /// <param name="creationTimeUnix"></param>
        /// <param name="archivedTimeUnix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryVersionResponseModel(
            string versionId,
            int versionRulesNum,
            string pronunciationDictionaryId,
            string dictionaryName,
            string versionName,
            global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2? permissionOnResource,
            string createdBy,
            int creationTimeUnix,
            int? archivedTimeUnix)
        {
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.VersionRulesNum = versionRulesNum;
            this.PronunciationDictionaryId = pronunciationDictionaryId ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryId));
            this.DictionaryName = dictionaryName ?? throw new global::System.ArgumentNullException(nameof(dictionaryName));
            this.VersionName = versionName ?? throw new global::System.ArgumentNullException(nameof(versionName));
            this.PermissionOnResource = permissionOnResource ?? throw new global::System.ArgumentNullException(nameof(permissionOnResource));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreationTimeUnix = creationTimeUnix;
            this.ArchivedTimeUnix = archivedTimeUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionResponseModel" /> class.
        /// </summary>
        public PronunciationDictionaryVersionResponseModel()
        {
        }
    }
}