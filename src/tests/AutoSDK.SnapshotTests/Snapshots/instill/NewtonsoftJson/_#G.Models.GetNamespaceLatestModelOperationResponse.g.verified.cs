//HintName: G.Models.GetNamespaceLatestModelOperationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetNamespaceLatestModelOperationResponse represents a response to query a long-running<br/>
    /// operation.
    /// </summary>
    public sealed partial class GetNamespaceLatestModelOperationResponse
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
        /// Initializes a new instance of the <see cref="GetNamespaceLatestModelOperationResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// The long-running operation.<br/>
        /// Included only in responses
        /// </param>
        public GetNamespaceLatestModelOperationResponse(
            global::G.LongrunningOperation? operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceLatestModelOperationResponse" /> class.
        /// </summary>
        public GetNamespaceLatestModelOperationResponse()
        {
        }
    }
}