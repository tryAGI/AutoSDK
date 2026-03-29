//HintName: G.Models.QueryHeliconeDatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryHeliconeDatasetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetIds")]
        public global::System.Collections.Generic.IList<string>? DatasetIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHeliconeDatasetRequest" /> class.
        /// </summary>
        /// <param name="datasetIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryHeliconeDatasetRequest(
            global::System.Collections.Generic.IList<string>? datasetIds)
        {
            this.DatasetIds = datasetIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHeliconeDatasetRequest" /> class.
        /// </summary>
        public QueryHeliconeDatasetRequest()
        {
        }
    }
}