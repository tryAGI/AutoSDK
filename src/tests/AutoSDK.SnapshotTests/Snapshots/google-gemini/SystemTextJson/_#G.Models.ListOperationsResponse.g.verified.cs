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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListOperationsResponse(
            global::System.Collections.Generic.IList<global::G.Operation>? operations,
            string? nextPageToken)
        {
            this.Operations = operations;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOperationsResponse" /> class.
        /// </summary>
        public ListOperationsResponse()
        {
        }
    }
}