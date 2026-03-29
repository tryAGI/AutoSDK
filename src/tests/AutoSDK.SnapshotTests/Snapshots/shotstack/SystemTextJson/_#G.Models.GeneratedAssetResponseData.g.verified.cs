//HintName: G.Models.GeneratedAssetResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of resource (an asset), it's id and attributes of the generated file.
    /// </summary>
    public sealed partial class GeneratedAssetResponseData
    {
        /// <summary>
        /// The type of resource, in this case it is an asset.<br/>
        /// Example: asset
        /// </summary>
        /// <example>asset</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The generated asset id.<br/>
        /// Example: 01gz0-tj679-xj30t-hr8zk-3hasvk
        /// </summary>
        /// <example>01gz0-tj679-xj30t-hr8zk-3hasvk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The id and attributes of the generated asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeneratedAssetResponseAttributes Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAssetResponseData" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of resource, in this case it is an asset.<br/>
        /// Example: asset
        /// </param>
        /// <param name="id">
        /// The generated asset id.<br/>
        /// Example: 01gz0-tj679-xj30t-hr8zk-3hasvk
        /// </param>
        /// <param name="attributes">
        /// The id and attributes of the generated asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedAssetResponseData(
            string type,
            string id,
            global::G.GeneratedAssetResponseAttributes attributes)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAssetResponseData" /> class.
        /// </summary>
        public GeneratedAssetResponseData()
        {
        }
    }
}