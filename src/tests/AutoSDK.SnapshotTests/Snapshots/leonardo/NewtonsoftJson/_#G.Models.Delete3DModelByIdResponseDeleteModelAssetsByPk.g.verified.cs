//HintName: G.Models.Delete3DModelByIdResponseDeleteModelAssetsByPk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "model_assets"
    /// </summary>
    public sealed partial class Delete3DModelByIdResponseDeleteModelAssetsByPk
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
        /// Initializes a new instance of the <see cref="Delete3DModelByIdResponseDeleteModelAssetsByPk" /> class.
        /// </summary>
        /// <param name="id"></param>
        public Delete3DModelByIdResponseDeleteModelAssetsByPk(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Delete3DModelByIdResponseDeleteModelAssetsByPk" /> class.
        /// </summary>
        public Delete3DModelByIdResponseDeleteModelAssetsByPk()
        {
        }
    }
}