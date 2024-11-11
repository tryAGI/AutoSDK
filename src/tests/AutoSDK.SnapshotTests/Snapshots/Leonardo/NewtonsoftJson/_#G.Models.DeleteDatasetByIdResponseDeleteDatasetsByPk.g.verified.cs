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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDatasetByIdResponseDeleteDatasetsByPk" /> class.
        /// </summary>
        /// <param name="id"></param>
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