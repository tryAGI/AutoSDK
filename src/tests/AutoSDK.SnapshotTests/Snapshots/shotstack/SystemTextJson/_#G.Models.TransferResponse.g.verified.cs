//HintName: G.Models.TransferResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response returned by the Serve API [transfer asset](#transfer-asset) request. The response includes the ID and transfer status. The response follows the [json:api](https://jsonapi.org/) specification.
    /// </summary>
    public sealed partial class TransferResponse
    {
        /// <summary>
        /// The type of resource (an asset) and the transfer attributes. Returned with [TransferResponse](#tocs_transferresponse).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransferResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The type of resource (an asset) and the transfer attributes. Returned with [TransferResponse](#tocs_transferresponse).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferResponse(
            global::G.TransferResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResponse" /> class.
        /// </summary>
        public TransferResponse()
        {
        }
    }
}