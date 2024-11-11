//HintName: G.Models.GetOperationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetOperationResponse contains the long-running operation details.
    /// </summary>
    public sealed partial class GetOperationResponse
    {
        /// <summary>
        /// The long-running operation.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operation")]
        public global::G.LongrunningOperation? Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOperationResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// The long-running operation.<br/>
        /// Included only in responses
        /// </param>
        public GetOperationResponse(
            global::G.LongrunningOperation? operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOperationResponse" /> class.
        /// </summary>
        public GetOperationResponse()
        {
        }
    }
}