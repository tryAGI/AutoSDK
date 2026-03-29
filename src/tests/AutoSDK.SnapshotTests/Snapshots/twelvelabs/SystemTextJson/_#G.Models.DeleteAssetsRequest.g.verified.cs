//HintName: G.Models.DeleteAssetsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAssetsRequest
    {
        /// <summary>
        /// An array of asset IDs to remove from the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AssetIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAssetsRequest" /> class.
        /// </summary>
        /// <param name="assetIds">
        /// An array of asset IDs to remove from the entity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAssetsRequest(
            global::System.Collections.Generic.IList<string> assetIds)
        {
            this.AssetIds = assetIds ?? throw new global::System.ArgumentNullException(nameof(assetIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAssetsRequest" /> class.
        /// </summary>
        public DeleteAssetsRequest()
        {
        }
    }
}