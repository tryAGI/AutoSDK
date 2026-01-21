//HintName: G.Models.AddPronunciationDictionaryResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"created_by":"ar6633Es2kUjFXBdR1iVc9ztsXl1","creation_time_unix":1714156800,"description":"This is a test dictionary","id":"5xM3yVvZQKV0EfqQpLrJ","name":"My Dictionary","version_id":"5xM3yVvZQKV0EfqQpLrJ"}
    /// </summary>
    public sealed partial class AddPronunciationDictionaryResponseModel
    {
        /// <summary>
        /// The ID of the created pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the created pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The user ID of the creator of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// The creation time of the pronunciation dictionary in Unix timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreationTimeUnix { get; set; }

        /// <summary>
        /// The ID of the created pronunciation dictionary version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// The number of rules in the version of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_rules_num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionRulesNum { get; set; }

        /// <summary>
        /// The description of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The permission on the resource of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_on_resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AddPronunciationDictionaryResponseModelPermissionOnResource2? PermissionOnResource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddPronunciationDictionaryResponseModel(
            string id,
            string name,
            string createdBy,
            global::System.DateTimeOffset creationTimeUnix,
            string versionId,
            int versionRulesNum,
            global::G.AddPronunciationDictionaryResponseModelPermissionOnResource2? permissionOnResource,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreationTimeUnix = creationTimeUnix;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.VersionRulesNum = versionRulesNum;
            this.PermissionOnResource = permissionOnResource ?? throw new global::System.ArgumentNullException(nameof(permissionOnResource));
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