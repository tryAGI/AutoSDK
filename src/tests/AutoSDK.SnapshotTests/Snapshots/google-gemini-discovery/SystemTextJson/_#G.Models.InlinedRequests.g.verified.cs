//HintName: G.Models.InlinedRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The requests to be processed in the batch if provided as part of the batch creation request.
    /// </summary>
    public sealed partial class InlinedRequests
    {
        /// <summary>
        /// Required. The requests to be processed in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public global::System.Collections.Generic.IList<global::G.InlinedRequest>? Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedRequests" /> class.
        /// </summary>
        /// <param name="requests">
        /// Required. The requests to be processed in the batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlinedRequests(
            global::System.Collections.Generic.IList<global::G.InlinedRequest>? requests)
        {
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedRequests" /> class.
        /// </summary>
        public InlinedRequests()
        {
        }
    }
}