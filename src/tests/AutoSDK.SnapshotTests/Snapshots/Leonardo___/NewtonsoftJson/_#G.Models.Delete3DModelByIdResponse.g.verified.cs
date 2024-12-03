//HintName: G.Models.Delete3DModelByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Delete3DModelByIdResponse
    {
        /// <summary>
        /// columns and relationships of "model_assets"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_model_assets_by_pk")]
        public global::G.Delete3DModelByIdResponseDeleteModelAssetsByPk? DeleteModelAssetsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Delete3DModelByIdResponse" /> class.
        /// </summary>
        /// <param name="deleteModelAssetsByPk">
        /// columns and relationships of "model_assets"
        /// </param>
        public Delete3DModelByIdResponse(
            global::G.Delete3DModelByIdResponseDeleteModelAssetsByPk? deleteModelAssetsByPk)
        {
            this.DeleteModelAssetsByPk = deleteModelAssetsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Delete3DModelByIdResponse" /> class.
        /// </summary>
        public Delete3DModelByIdResponse()
        {
        }
    }
}