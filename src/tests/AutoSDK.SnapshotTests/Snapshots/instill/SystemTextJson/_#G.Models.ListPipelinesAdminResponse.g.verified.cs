//HintName: G.Models.ListPipelinesAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListPipelinesAdminResponse contains a list of pipelines requested by an<br/>
    /// admin user.<br/>
    /// For the moment, the pipeline recipes will be UID-based (permalink) instead<br/>
    /// of name-based. This is a temporary solution.
    /// </summary>
    public sealed partial class ListPipelinesAdminResponse
    {
        /// <summary>
        /// A list of pipeline resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelines")]
        public global::System.Collections.Generic.IList<global::G.Pipeline>? Pipelines { get; set; }

        /// <summary>
        /// Next page token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of pipelines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelinesAdminResponse" /> class.
        /// </summary>
        /// <param name="pipelines">
        /// A list of pipeline resources.
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.
        /// </param>
        /// <param name="totalSize">
        /// Total number of pipelines.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPipelinesAdminResponse(
            global::System.Collections.Generic.IList<global::G.Pipeline>? pipelines,
            string? nextPageToken,
            int? totalSize)
        {
            this.Pipelines = pipelines;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelinesAdminResponse" /> class.
        /// </summary>
        public ListPipelinesAdminResponse()
        {
        }
    }
}