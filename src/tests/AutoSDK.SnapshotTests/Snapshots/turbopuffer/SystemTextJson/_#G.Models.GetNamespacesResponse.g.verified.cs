//HintName: G.Models.GetNamespacesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetNamespacesResponse
    {
        /// <summary>
        /// The list of namespaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaces")]
        public global::System.Collections.Generic.IList<global::G.NamespaceSummary>? Namespaces { get; set; }

        /// <summary>
        /// The cursor to use to retrieve the next page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespacesResponse" /> class.
        /// </summary>
        /// <param name="namespaces">
        /// The list of namespaces.
        /// </param>
        /// <param name="nextCursor">
        /// The cursor to use to retrieve the next page of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetNamespacesResponse(
            global::System.Collections.Generic.IList<global::G.NamespaceSummary>? namespaces,
            string? nextCursor)
        {
            this.Namespaces = namespaces;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespacesResponse" /> class.
        /// </summary>
        public GetNamespacesResponse()
        {
        }
    }
}