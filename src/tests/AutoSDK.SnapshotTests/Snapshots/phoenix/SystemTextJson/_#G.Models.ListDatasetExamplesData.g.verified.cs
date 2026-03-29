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
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filtered_splits")]
        public global::System.Collections.Generic.IList<string>? FilteredSplits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DatasetExample> Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetExamplesData" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="versionId"></param>
        /// <param name="examples"></param>
        /// <param name="filteredSplits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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