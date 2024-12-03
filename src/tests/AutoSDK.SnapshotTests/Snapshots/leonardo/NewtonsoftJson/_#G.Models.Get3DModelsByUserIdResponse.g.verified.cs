//HintName: G.Models.Get3DModelsByUserIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Get3DModelsByUserIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_assets")]
        public global::System.Collections.Generic.IList<global::G.Get3DModelsByUserIdResponseModelAsset>? ModelAssets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Get3DModelsByUserIdResponse" /> class.
        /// </summary>
        /// <param name="modelAssets"></param>
        public Get3DModelsByUserIdResponse(
            global::System.Collections.Generic.IList<global::G.Get3DModelsByUserIdResponseModelAsset>? modelAssets)
        {
            this.ModelAssets = modelAssets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get3DModelsByUserIdResponse" /> class.
        /// </summary>
        public Get3DModelsByUserIdResponse()
        {
        }
    }
}