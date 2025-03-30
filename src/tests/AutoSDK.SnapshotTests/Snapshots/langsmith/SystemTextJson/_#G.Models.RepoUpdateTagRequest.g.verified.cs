//HintName: G.Models.RepoUpdateTagRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fields to update a prompt tag
    /// </summary>
    public sealed partial class RepoUpdateTagRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CommitId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoUpdateTagRequest" /> class.
        /// </summary>
        /// <param name="commitId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepoUpdateTagRequest(
            global::System.Guid commitId)
        {
            this.CommitId = commitId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoUpdateTagRequest" /> class.
        /// </summary>
        public RepoUpdateTagRequest()
        {
        }
    }
}