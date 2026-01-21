//HintName: G.Models.GetPronunciationDictionaryMetadataResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"created_by":"ar6633Es2kUjFXBdR1iVc9ztsXl1","creation_time_unix":1714156800,"description":"This is a test dictionary","id":"5xM3yVvZQKV0EfqQpLrJ","latest_version_id":"5xM3yVvZQKV0EfqQpLr2","latest_version_rules_num":2,"name":"My Dictionary"}
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
        /// The permission on the resource of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission_on_resource", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2? PermissionOnResource { get; set; } = default!;

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
        public int? ArchivedTimeUnix { get; set; } = default!;

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
        /// <param name="permissionOnResource">
        /// The permission on the resource of the pronunciation dictionary.
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
            global::G.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2? permissionOnResource,
            string createdBy,
            global::System.DateTimeOffset creationTimeUnix,
            int? archivedTimeUnix,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LatestVersionId = latestVersionId ?? throw new global::System.ArgumentNullException(nameof(latestVersionId));
            this.LatestVersionRulesNum = latestVersionRulesNum;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PermissionOnResource = permissionOnResource ?? throw new global::System.ArgumentNullException(nameof(permissionOnResource));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreationTimeUnix = creationTimeUnix;
            this.ArchivedTimeUnix = archivedTimeUnix ?? throw new global::System.ArgumentNullException(nameof(archivedTimeUnix));
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