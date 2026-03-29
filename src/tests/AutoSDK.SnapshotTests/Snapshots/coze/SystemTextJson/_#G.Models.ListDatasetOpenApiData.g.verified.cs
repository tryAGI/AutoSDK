//HintName: G.Models.ListDatasetOpenApiData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListDatasetOpenApiData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_list")]
        public global::System.Collections.Generic.IList<global::G.Dataset>? DatasetList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetOpenApiData" /> class.
        /// </summary>
        /// <param name="datasetList"></param>
        /// <param name="totalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDatasetOpenApiData(
            global::System.Collections.Generic.IList<global::G.Dataset>? datasetList,
            int? totalCount)
        {
            this.DatasetList = datasetList;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetOpenApiData" /> class.
        /// </summary>
        public ListDatasetOpenApiData()
        {
        }
    }
}