//HintName: G.Models.ListNamespacePipelinesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListNamespacePipelinesResponse contains a list of pipelines.
    /// </summary>
    public sealed partial class ListNamespacePipelinesResponse
    {
        /// <summary>
        /// A list of pipeline resources.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelines")]
        public global::System.Collections.Generic.IList<global::G.Pipeline>? Pipelines { get; set; }

        /// <summary>
        /// Next page token.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of pipelines.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNamespacePipelinesResponse" /> class.
        /// </summary>
        /// <param name="pipelines">
        /// A list of pipeline resources.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of pipelines.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListNamespacePipelinesResponse(
            global::System.Collections.Generic.IList<global::G.Pipeline>? pipelines,
            string? nextPageToken,
            int? totalSize)
        {
            this.Pipelines = pipelines;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNamespacePipelinesResponse" /> class.
        /// </summary>
        public ListNamespacePipelinesResponse()
        {
        }
    }
}