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
        [global::Newtonsoft.Json.JsonProperty("assetUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssetUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeRequestAsset" /> class.
        /// </summary>
        /// <param name="assetUrl"></param>
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