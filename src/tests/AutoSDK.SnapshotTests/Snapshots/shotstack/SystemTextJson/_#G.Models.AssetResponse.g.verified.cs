//HintName: G.Models.AssetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response returned by the Serve API [get asset](#get-asset) request. Includes details of a hosted video, image, audio file, thumbnail or poster image. The response follows the [json:api](https://jsonapi.org/) specification.
    /// </summary>
    public sealed partial class AssetResponse
    {
        /// <summary>
        /// The type of resource (an asset) and attributes of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssetResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The type of resource (an asset) and attributes of the asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetResponse(
            global::G.AssetResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponse" /> class.
        /// </summary>
        public AssetResponse()
        {
        }
    }
}