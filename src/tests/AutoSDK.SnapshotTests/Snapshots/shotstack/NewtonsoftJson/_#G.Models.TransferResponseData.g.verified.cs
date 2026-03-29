//HintName: G.Models.TransferResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of resource (an asset) and the transfer attributes. Returned with [TransferResponse](#tocs_transferresponse).
    /// </summary>
    public sealed partial class TransferResponseData
    {
        /// <summary>
        /// The type of resource, in this case it is an asset.<br/>
        /// Example: asset
        /// </summary>
        /// <example>asset</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The transfer request attributes inlcudling the user specified ID and status. Returned with [TransferResponseData](#tocs_transferresponsedata).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public global::G.TransferResponseAttributes? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResponseData" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of resource, in this case it is an asset.<br/>
        /// Example: asset
        /// </param>
        /// <param name="attributes">
        /// The transfer request attributes inlcudling the user specified ID and status. Returned with [TransferResponseData](#tocs_transferresponsedata).
        /// </param>
        public TransferResponseData(
            string? type,
            global::G.TransferResponseAttributes? attributes)
        {
            this.Type = type;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResponseData" /> class.
        /// </summary>
        public TransferResponseData()
        {
        }
    }
}