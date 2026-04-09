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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The name of the data source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfigurableDataSourceNamesJsonConverter))]
        public global::G.ConfigurableDataSourceNames SourceType { get; set; } = default!;

        /// <summary>
        /// Custom metadata that will be present on all data loaded from the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// Component that implements the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource> Component { get; set; } = default!;

        /// <summary>
        /// Version metadata for the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_metadata")]
        public global::G.DataSourceReaderVersionMetadata? VersionMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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