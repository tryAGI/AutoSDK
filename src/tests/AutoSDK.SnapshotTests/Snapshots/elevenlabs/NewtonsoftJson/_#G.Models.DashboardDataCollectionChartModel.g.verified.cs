//HintName: G.Models.DashboardDataCollectionChartModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashboardDataCollectionChartModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Default Value: data_collection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_collection_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DataCollectionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardDataCollectionChartModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: data_collection
        /// </param>
        /// <param name="dataCollectionId"></param>
        public DashboardDataCollectionChartModel(
            string name,
            string dataCollectionId,
            string? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DataCollectionId = dataCollectionId ?? throw new global::System.ArgumentNullException(nameof(dataCollectionId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardDataCollectionChartModel" /> class.
        /// </summary>
        public DashboardDataCollectionChartModel()
        {
        }
    }
}