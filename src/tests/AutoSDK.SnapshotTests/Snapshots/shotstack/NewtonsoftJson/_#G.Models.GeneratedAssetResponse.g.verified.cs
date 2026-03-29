//HintName: G.Models.GeneratedAssetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response returned by the Create API [generate asset](#generate-asset) and [get generated asset](#get-generated-asset) requests. Includes status and details of the generated asset. The response follows the [json:api](https://jsonapi.org/) specification.
    /// </summary>
    public sealed partial class GeneratedAssetResponse
    {
        /// <summary>
        /// The type of resource (an asset), it's id and attributes of the generated file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GeneratedAssetResponseData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAssetResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The type of resource (an asset), it's id and attributes of the generated file.
        /// </param>
        public GeneratedAssetResponse(
            global::G.GeneratedAssetResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAssetResponse" /> class.
        /// </summary>
        public GeneratedAssetResponse()
        {
        }
    }
}