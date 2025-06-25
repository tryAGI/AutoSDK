//HintName: G.Models.ReposMergeUpstreamRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposMergeUpstreamRequest
    {
        /// <summary>
        /// The name of the branch which should be updated to match upstream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Branch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposMergeUpstreamRequest" /> class.
        /// </summary>
        /// <param name="branch">
        /// The name of the branch which should be updated to match upstream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposMergeUpstreamRequest(
            string branch)
        {
            this.Branch = branch ?? throw new global::System.ArgumentNullException(nameof(branch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposMergeUpstreamRequest" /> class.
        /// </summary>
        public ReposMergeUpstreamRequest()
        {
        }
    }
}