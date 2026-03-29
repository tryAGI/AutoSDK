//HintName: G.Models.DataSourceUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for updating a data source.
    /// </summary>
    public sealed partial class DataSourceUpdate
    {
        /// <summary>
        /// The name of the data source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConfigurableDataSourceNames SourceType { get; set; } = default!;

        /// <summary>
        /// Custom metadata that will be present on all data loaded from the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// Component that implements the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component")]
        public global::G.AnyOf<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource, object>? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceUpdate" /> class.
        /// </summary>
        /// <param name="sourceType"></param>
        /// <param name="name">
        /// The name of the data source.
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata that will be present on all data loaded from the data source
        /// </param>
        /// <param name="component">
        /// Component that implements the data source
        /// </param>
        public DataSourceUpdate(
            global::G.ConfigurableDataSourceNames sourceType,
            string? name,
            object? customMetadata,
            global::G.AnyOf<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource, object>? component)
        {
            this.Name = name;
            this.SourceType = sourceType;
            this.CustomMetadata = customMetadata;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceUpdate" /> class.
        /// </summary>
        public DataSourceUpdate()
        {
        }
    }
}