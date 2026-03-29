//HintName: G.Models.DataSourceCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating a data source.
    /// </summary>
    public sealed partial class DataSourceCreate
    {
        /// <summary>
        /// The name of the data source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("component", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource> Component { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the data source.
        /// </param>
        /// <param name="sourceType"></param>
        /// <param name="component">
        /// Component that implements the data source
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata that will be present on all data loaded from the data source
        /// </param>
        public DataSourceCreate(
            string name,
            global::G.ConfigurableDataSourceNames sourceType,
            global::G.AnyOf<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource> component,
            object? customMetadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceType = sourceType;
            this.CustomMetadata = customMetadata;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceCreate" /> class.
        /// </summary>
        public DataSourceCreate()
        {
        }
    }
}