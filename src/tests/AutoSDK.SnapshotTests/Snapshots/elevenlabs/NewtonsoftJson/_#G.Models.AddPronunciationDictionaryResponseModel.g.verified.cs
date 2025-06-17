//HintName: G.Models.AddPronunciationDictionaryResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddPronunciationDictionaryResponseModel
    {
        /// <summary>
        /// The ID of the created pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the created pronunciation dictionary.
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
        /// The ID of the created pronunciation dictionary version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// The number of rules in the version of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_rules_num", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionRulesNum { get; set; } = default!;

        /// <summary>
        /// The description of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The permission on the resource of the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission_on_resource", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AddPronunciationDictionaryResponseModelPermissionOnResource? PermissionOnResource { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPronunciationDictionaryResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the created pronunciation dictionary.
        /// </param>
        /// <param name="name">
        /// The name of the created pronunciation dictionary.
        /// </param>
        /// <param name="createdBy">
        /// The user ID of the creator of the pronunciation dictionary.
        /// </param>
        /// <param name="creationTimeUnix">
        /// The creation time of the pronunciation dictionary in Unix timestamp.
        /// </param>
        /// <param name="versionId">
        /// The ID of the created pronunciation dictionary version.
        /// </param>
        /// <param name="versionRulesNum">
        /// The number of rules in the version of the pronunciation dictionary.
        /// </param>
        /// <param name="description">
        /// The description of the pronunciation dictionary.
        /// </param>
        /// <param name="permissionOnResource">
        /// The permission on the resource of the pronunciation dictionary.
        /// </param>
        public AddPronunciationDictionaryResponseModel(
            string id,
            string name,
            string createdBy,
            global::System.DateTimeOffset creationTimeUnix,
            string versionId,
            int versionRulesNum,
            global::G.AddPronunciationDictionaryResponseModelPermissionOnResource? permissionOnResource,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreationTimeUnix = creationTimeUnix;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.VersionRulesNum = versionRulesNum;
            this.PermissionOnResource = permissionOnResource;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPronunciationDictionaryResponseModel" /> class.
        /// </summary>
        public AddPronunciationDictionaryResponseModel()
        {
        }
    }
}