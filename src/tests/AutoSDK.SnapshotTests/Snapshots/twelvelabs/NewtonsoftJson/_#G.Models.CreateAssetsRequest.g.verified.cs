//HintName: G.Models.CreateAssetsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetsRequest
    {
        /// <summary>
        /// An array of asset IDs to add to the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AssetIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetsRequest" /> class.
        /// </summary>
        /// <param name="assetIds">
        /// An array of asset IDs to add to the entity.
        /// </param>
        public CreateAssetsRequest(
            global::System.Collections.Generic.IList<string> assetIds)
        {
            this.AssetIds = assetIds ?? throw new global::System.ArgumentNullException(nameof(assetIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetsRequest" /> class.
        /// </summary>
        public CreateAssetsRequest()
        {
        }
    }
}