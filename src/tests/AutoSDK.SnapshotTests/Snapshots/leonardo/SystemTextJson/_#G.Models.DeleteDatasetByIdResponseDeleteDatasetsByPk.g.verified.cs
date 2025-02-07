//HintName: G.Models.DeleteDatasetByIdResponseDeleteDatasetsByPk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "datasets"
    /// </summary>
    public sealed partial class DeleteDatasetByIdResponseDeleteDatasetsByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDatasetByIdResponseDeleteDatasetsByPk" /> class.
        /// </summary>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteDatasetByIdResponseDeleteDatasetsByPk(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDatasetByIdResponseDeleteDatasetsByPk" /> class.
        /// </summary>
        public DeleteDatasetByIdResponseDeleteDatasetsByPk()
        {
        }
    }
}