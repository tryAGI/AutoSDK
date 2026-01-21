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
        [global::Newtonsoft.Json.JsonProperty("version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_rules_num", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionRulesNum { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionary_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PronunciationDictionaryId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dictionary_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DictionaryName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission_on_resource", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PronunciationDictionaryVersionResponseModelPermissionOnResource2? PermissionOnResource { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_time_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreationTimeUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived_time_unix")]
        public int? ArchivedTimeUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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