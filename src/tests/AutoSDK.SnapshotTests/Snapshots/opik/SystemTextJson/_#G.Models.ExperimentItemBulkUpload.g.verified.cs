//HintName: G.Models.ExperimentItemBulkUpload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItemBulkUpload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// Optional experiment ID. If provided, items will be added to the existing experiment and experimentName will be ignored. If not provided or experiment with that ID doesn't exist, a new experiment will be created with the given experimentName
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_id")]
        public global::System.Guid? ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExperimentItemBulkRecord> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkUpload" /> class.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="datasetName"></param>
        /// <param name="items"></param>
        /// <param name="experimentId">
        /// Optional experiment ID. If provided, items will be added to the existing experiment and experimentName will be ignored. If not provided or experiment with that ID doesn't exist, a new experiment will be created with the given experimentName
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentItemBulkUpload(
            string experimentName,
            string datasetName,
            global::System.Collections.Generic.IList<global::G.ExperimentItemBulkRecord> items,
            global::System.Guid? experimentId)
        {
            this.ExperimentName = experimentName ?? throw new global::System.ArgumentNullException(nameof(experimentName));
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.ExperimentId = experimentId;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkUpload" /> class.
        /// </summary>
        public ExperimentItemBulkUpload()
        {
        }
    }
}