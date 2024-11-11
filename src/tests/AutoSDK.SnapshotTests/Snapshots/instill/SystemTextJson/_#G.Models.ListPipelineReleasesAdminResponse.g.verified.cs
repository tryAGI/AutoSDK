//HintName: G.Models.ListPipelineReleasesAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListPipelineReleasesAdminResponse contains a list of pipeline releases<br/>
    /// requested by an admin user.<br/>
    /// For the moment, the pipeline recipes will be UID-based (permalink) instead<br/>
    /// of name-based. This is a temporary solution.
    /// </summary>
    public sealed partial class ListPipelineReleasesAdminResponse
    {
        /// <summary>
        /// A list of pipeline releases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases")]
        public global::System.Collections.Generic.IList<global::G.PipelineRelease>? Releases { get; set; }

        /// <summary>
        /// Next page token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of pipeline releases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineReleasesAdminResponse" /> class.
        /// </summary>
        /// <param name="releases">
        /// A list of pipeline releases.
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.
        /// </param>
        /// <param name="totalSize">
        /// Total number of pipeline releases.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListPipelineReleasesAdminResponse(
            global::System.Collections.Generic.IList<global::G.PipelineRelease>? releases,
            string? nextPageToken,
            int? totalSize)
        {
            this.Releases = releases;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineReleasesAdminResponse" /> class.
        /// </summary>
        public ListPipelineReleasesAdminResponse()
        {
        }
    }
}