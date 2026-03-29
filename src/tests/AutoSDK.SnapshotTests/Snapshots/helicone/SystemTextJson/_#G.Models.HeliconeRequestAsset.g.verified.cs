//HintName: G.Models.HeliconeRequestAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeliconeRequestAsset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeRequestAsset" /> class.
        /// </summary>
        /// <param name="assetUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeliconeRequestAsset(
            string assetUrl)
        {
            this.AssetUrl = assetUrl ?? throw new global::System.ArgumentNullException(nameof(assetUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeRequestAsset" /> class.
        /// </summary>
        public HeliconeRequestAsset()
        {
        }
    }
}