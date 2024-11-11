//HintName: G.Models.GetNamespaceModelOperationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetNamespaceModelOperationResponse represents a response to query a long-running<br/>
    /// operation.
    /// </summary>
    public sealed partial class GetNamespaceModelOperationResponse
    {
        /// <summary>
        /// The long-running operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public global::G.LongrunningOperation? Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceModelOperationResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// The long-running operation.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetNamespaceModelOperationResponse(
            global::G.LongrunningOperation? operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceModelOperationResponse" /> class.
        /// </summary>
        public GetNamespaceModelOperationResponse()
        {
        }
    }
}