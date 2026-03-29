//HintName: G.Models.ListOperationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response message for Operations.ListOperations.
    /// </summary>
    public sealed partial class ListOperationsResponse
    {
        /// <summary>
        /// A list of operations that matches the specified filter in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        public global::System.Collections.Generic.IList<global::G.Operation>? Operations { get; set; }

        /// <summary>
        /// The standard List next-page token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Unordered list. Unreachable resources. Populated when the request sets `ListOperationsRequest.return_partial_success` and reads across collections. For example, when attempting to list all resources across all supported locations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unreachable")]
        public global::System.Collections.Generic.IList<string>? Unreachable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOperationsResponse" /> class.
        /// </summary>
        /// <param name="operations">
        /// A list of operations that matches the specified filter in the request.
        /// </param>
        /// <param name="nextPageToken">
        /// The standard List next-page token.
        /// </param>
        /// <param name="unreachable">
        /// Unordered list. Unreachable resources. Populated when the request sets `ListOperationsRequest.return_partial_success` and reads across collections. For example, when attempting to list all resources across all supported locations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOperationsResponse(
            global::System.Collections.Generic.IList<global::G.Operation>? operations,
            string? nextPageToken,
            global::System.Collections.Generic.IList<string>? unreachable)
        {
            this.Operations = operations;
            this.NextPageToken = nextPageToken;
            this.Unreachable = unreachable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOperationsResponse" /> class.
        /// </summary>
        public ListOperationsResponse()
        {
        }
    }
}