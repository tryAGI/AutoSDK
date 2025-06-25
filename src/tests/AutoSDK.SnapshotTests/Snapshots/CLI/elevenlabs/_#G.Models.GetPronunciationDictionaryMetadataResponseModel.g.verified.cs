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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the latest version of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestVersionId { get; set; }

        /// <summary>
        /// The number of rules in the latest version of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_rules_num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatestVersionRulesNum { get; set; }

        /// <summary>
        /// The name of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The permission on the resource of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_on_resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource? PermissionOnResource { get; set; }

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
        /// The archive time of the pronunciation dictionary in Unix timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_time_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? ArchivedTimeUnix { get; set; }

        /// <summary>
        /// The description of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPronunciationDictionaryMetadataResponseModel(
            string id,
            string latestVersionId,
            int latestVersionRulesNum,
            string name,
            global::G.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource? permissionOnResource,
            string createdBy,
            global::System.DateTimeOffset creationTimeUnix,
            global::System.DateTimeOffset? archivedTimeUnix,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LatestVersionId = latestVersionId ?? throw new global::System.ArgumentNullException(nameof(latestVersionId));
            this.LatestVersionRulesNum = latestVersionRulesNum;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PermissionOnResource = permissionOnResource;
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