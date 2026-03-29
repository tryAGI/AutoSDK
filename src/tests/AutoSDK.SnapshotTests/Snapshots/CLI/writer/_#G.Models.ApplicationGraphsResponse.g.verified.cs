//HintName: G.Models.ApplicationGraphsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApplicationGraphsResponse
    {
        /// <summary>
        /// A list of Knowledge Graphs associated with the application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> GraphIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationGraphsResponse" /> class.
        /// </summary>
        /// <param name="graphIds">
        /// A list of Knowledge Graphs associated with the application.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplicationGraphsResponse(
            global::System.Collections.Generic.IList<global::System.Guid> graphIds)
        {
            this.GraphIds = graphIds ?? throw new global::System.ArgumentNullException(nameof(graphIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationGraphsResponse" /> class.
        /// </summary>
        public ApplicationGraphsResponse()
        {
        }
    }
}