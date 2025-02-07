//HintName: G.Models.DeleteDatasetByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDatasetByIdResponse
    {
        /// <summary>
        /// columns and relationships of "datasets"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_datasets_by_pk")]
        public global::G.DeleteDatasetByIdResponseDeleteDatasetsByPk? DeleteDatasetsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDatasetByIdResponse" /> class.
        /// </summary>
        /// <param name="deleteDatasetsByPk">
        /// columns and relationships of "datasets"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteDatasetByIdResponse(
            global::G.DeleteDatasetByIdResponseDeleteDatasetsByPk? deleteDatasetsByPk)
        {
            this.DeleteDatasetsByPk = deleteDatasetsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDatasetByIdResponse" /> class.
        /// </summary>
        public DeleteDatasetByIdResponse()
        {
        }
    }
}