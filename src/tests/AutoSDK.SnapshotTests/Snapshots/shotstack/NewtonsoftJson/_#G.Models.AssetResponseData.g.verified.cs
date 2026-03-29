//HintName: G.Models.AssetResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of resource (an asset) and attributes of the asset.
    /// </summary>
    public sealed partial class AssetResponseData
    {
        /// <summary>
        /// The type of resource, in this case it is an assets.<br/>
        /// Example: asset
        /// </summary>
        /// <example>asset</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The list of asset attributes and their values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssetResponseAttributes Attributes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponseData" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of resource, in this case it is an assets.<br/>
        /// Example: asset
        /// </param>
        /// <param name="attributes">
        /// The list of asset attributes and their values.
        /// </param>
        public AssetResponseData(
            string type,
            global::G.AssetResponseAttributes attributes)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponseData" /> class.
        /// </summary>
        public AssetResponseData()
        {
        }
    }
}