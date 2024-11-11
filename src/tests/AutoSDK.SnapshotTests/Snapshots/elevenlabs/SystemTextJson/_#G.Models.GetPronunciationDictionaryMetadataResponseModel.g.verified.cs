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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// <param name="id"></param>
        /// <param name="latestVersionId"></param>
        /// <param name="name"></param>
        /// <param name="createdBy"></param>
        /// <param name="creationTimeUnix"></param>
        /// <param name="description"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetPronunciationDictionaryMetadataResponseModel(
            string id,
            string latestVersionId,
            string name,
            string createdBy,
            int creationTimeUnix,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LatestVersionId = latestVersionId ?? throw new global::System.ArgumentNullException(nameof(latestVersionId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreationTimeUnix = creationTimeUnix;
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