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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: data_collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataCollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardDataCollectionChartModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: data_collection
        /// </param>
        /// <param name="dataCollectionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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