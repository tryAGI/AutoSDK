//HintName: G.Models.DataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for a data source.
    /// </summary>
    public sealed partial class DataSource
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The name of the data source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfigurableDataSourceNamesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConfigurableDataSourceNames SourceType { get; set; }

        /// <summary>
        /// Custom metadata that will be present on all data loaded from the data source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// Component that implements the data source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource> Component { get; set; }

        /// <summary>
        /// Version metadata for the data source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_metadata")]
        public global::G.DataSourceReaderVersionMetadata? VersionMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSource" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="name">
        /// The name of the data source.
        /// </param>
        /// <param name="sourceType"></param>
        /// <param name="component">
        /// Component that implements the data source
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata that will be present on all data loaded from the data source
        /// </param>
        /// <param name="versionMetadata">
        /// Version metadata for the data source
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSource(
            global::System.Guid id,
            string name,
            global::G.ConfigurableDataSourceNames sourceType,
            global::G.AnyOf<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource> component,
            global::System.Guid projectId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            object? customMetadata,
            global::G.DataSourceReaderVersionMetadata? versionMetadata)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceType = sourceType;
            this.CustomMetadata = customMetadata;
            this.Component = component;
            this.VersionMetadata = versionMetadata;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSource" /> class.
        /// </summary>
        public DataSource()
        {
        }
    }
}