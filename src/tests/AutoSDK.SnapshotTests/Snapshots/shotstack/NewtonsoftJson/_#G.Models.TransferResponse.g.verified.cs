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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TransferResponseData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The type of resource (an asset) and the transfer attributes. Returned with [TransferResponse](#tocs_transferresponse).
        /// </param>
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