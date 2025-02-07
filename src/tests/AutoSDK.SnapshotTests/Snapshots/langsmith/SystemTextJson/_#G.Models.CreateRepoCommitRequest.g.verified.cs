//HintName: G.Models.CreateRepoCommitRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRepoCommitRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Manifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_commit")]
        public string? ParentCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExampleRunIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoCommitRequest" /> class.
        /// </summary>
        /// <param name="manifest"></param>
        /// <param name="parentCommit"></param>
        /// <param name="exampleRunIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRepoCommitRequest(
            object manifest,
            string? parentCommit,
            global::System.Collections.Generic.IList<global::System.Guid>? exampleRunIds)
        {
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.ParentCommit = parentCommit;
            this.ExampleRunIds = exampleRunIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoCommitRequest" /> class.
        /// </summary>
        public CreateRepoCommitRequest()
        {
        }
    }
}