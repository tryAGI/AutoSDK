//HintName: G.Models.AssetRenderResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response returned by the Serve API [get asset by render id](#get-asset-by-render-id) request. The response  is an array of asset resources, including video, image, audio, thumbnail and poster image. The response follows  the [json:api](https://jsonapi.org/) specification.
    /// </summary>
    public sealed partial class AssetRenderResponse
    {
        /// <summary>
        /// An array of asset resources grouped by render id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AssetResponseData> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetRenderResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// An array of asset resources grouped by render id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetRenderResponse(
            global::System.Collections.Generic.IList<global::G.AssetResponseData> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetRenderResponse" /> class.
        /// </summary>
        public AssetRenderResponse()
        {
        }
    }
}