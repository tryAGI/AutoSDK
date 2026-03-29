//HintName: G.Models.ListDatasetExamplesData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListDatasetExamplesData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filtered_splits")]
        public global::System.Collections.Generic.IList<string>? FilteredSplits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DatasetExample> Examples { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetExamplesData" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="versionId"></param>
        /// <param name="examples"></param>
        /// <param name="filteredSplits"></param>
        public ListDatasetExamplesData(
            string datasetId,
            string versionId,
            global::System.Collections.Generic.IList<global::G.DatasetExample> examples,
            global::System.Collections.Generic.IList<string>? filteredSplits)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.FilteredSplits = filteredSplits;
            this.Examples = examples ?? throw new global::System.ArgumentNullException(nameof(examples));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetExamplesData" /> class.
        /// </summary>
        public ListDatasetExamplesData()
        {
        }
    }
}