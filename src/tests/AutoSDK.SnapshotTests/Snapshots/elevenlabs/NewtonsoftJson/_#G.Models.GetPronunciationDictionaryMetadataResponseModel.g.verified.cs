//HintName: G.Models.GetPronunciationDictionaryMetadataResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPronunciationDictionaryMetadataResponseModel
    {
        /// <summary>
        /// The ID of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the latest version of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LatestVersionId { get; set; } = default!;

        /// <summary>
        /// The number of rules in the latest version of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_version_rules_num", Required = global::Newtonsoft.Json.Required.Always)]
        public int LatestVersionRulesNum { get; set; } = default!;

        /// <summary>
        /// The name of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The user ID of the creator of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// The creation time of the pronunciation dictionary in Unix timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_time_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreationTimeUnix { get; set; } = default!;

        /// <summary>
        /// The archive time of the pronunciation dictionary in Unix timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived_time_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? ArchivedTimeUnix { get; set; } = default!;

        /// <summary>
        /// The description of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionaryMetadataResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the pronunciation dictionary.
        /// </param>
        /// <param name="latestVersionId">
        /// The ID of the latest version of the pronunciation dictionary.
        /// </param>
        /// <param name="latestVersionRulesNum">
        /// The number of rules in the latest version of the pronunciation dictionary.
        /// </param>
        /// <param name="name">
        /// The name of the pronunciation dictionary.
        /// </param>
        /// <param name="createdBy">
        /// The user ID of the creator of the pronunciation dictionary.
        /// </param>
        /// <param name="creationTimeUnix">
        /// The creation time of the pronunciation dictionary in Unix timestamp.
        /// </param>
        /// <param name="archivedTimeUnix">
        /// The archive time of the pronunciation dictionary in Unix timestamp.
        /// </param>
        /// <param name="description">
        /// The description of the pronunciation dictionary.
        /// </param>
        public GetPronunciationDictionaryMetadataResponseModel(
            string id,
            string latestVersionId,
            int latestVersionRulesNum,
            string name,
            string createdBy,
            global::System.DateTimeOffset creationTimeUnix,
            global::System.DateTimeOffset? archivedTimeUnix,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LatestVersionId = latestVersionId ?? throw new global::System.ArgumentNullException(nameof(latestVersionId));
            this.LatestVersionRulesNum = latestVersionRulesNum;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreationTimeUnix = creationTimeUnix;
            this.ArchivedTimeUnix = archivedTimeUnix;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionaryMetadataResponseModel" /> class.
        /// </summary>
        public GetPronunciationDictionaryMetadataResponseModel()
        {
        }
    }
}