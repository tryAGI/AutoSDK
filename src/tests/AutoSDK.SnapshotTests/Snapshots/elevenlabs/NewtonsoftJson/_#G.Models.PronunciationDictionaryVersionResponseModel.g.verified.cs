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
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_time_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreationTimeUnix { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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