//HintName: G.Models.ListNamespacePipelineReleasesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListNamespacePipelineReleasesResponse contains a list of pipeline releases.
    /// </summary>
    public sealed partial class ListNamespacePipelineReleasesResponse
    {
        /// <summary>
        /// A list of pipeline release resources.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases")]
        public global::System.Collections.Generic.IList<global::G.PipelineRelease>? Releases { get; set; }

        /// <summary>
        /// Next page token.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of pipeline releases.<br/>
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
        /// Initializes a new instance of the <see cref="ListNamespacePipelineReleasesResponse" /> class.
        /// </summary>
        /// <param name="releases">
        /// A list of pipeline release resources.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of pipeline releases.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListNamespacePipelineReleasesResponse(
            global::System.Collections.Generic.IList<global::G.PipelineRelease>? releases,
            string? nextPageToken,
            int? totalSize)
        {
            this.Releases = releases;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNamespacePipelineReleasesResponse" /> class.
        /// </summary>
        public ListNamespacePipelineReleasesResponse()
        {
        }
    }
}