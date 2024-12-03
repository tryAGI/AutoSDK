//HintName: G.Models.GetDatasetByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetByIdResponse
    {
        /// <summary>
        /// columns and relationships of "datasets"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets_by_pk")]
        public global::G.GetDatasetByIdResponseDatasetsByPk? DatasetsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetByIdResponse" /> class.
        /// </summary>
        /// <param name="datasetsByPk">
        /// columns and relationships of "datasets"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetDatasetByIdResponse(
            global::G.GetDatasetByIdResponseDatasetsByPk? datasetsByPk)
        {
            this.DatasetsByPk = datasetsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetByIdResponse" /> class.
        /// </summary>
        public GetDatasetByIdResponse()
        {
        }
    }
}