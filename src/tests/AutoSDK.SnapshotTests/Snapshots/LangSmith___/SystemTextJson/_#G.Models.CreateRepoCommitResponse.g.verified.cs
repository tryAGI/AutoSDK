//HintName: G.Models.CreateRepoCommitResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRepoCommitResponse
    {
        /// <summary>
        /// All database fields for commits, plus helpful computed fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CommitWithLookups Commit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoCommitResponse" /> class.
        /// </summary>
        /// <param name="commit">
        /// All database fields for commits, plus helpful computed fields.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateRepoCommitResponse(
            global::G.CommitWithLookups commit)
        {
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoCommitResponse" /> class.
        /// </summary>
        public CreateRepoCommitResponse()
        {
        }
    }
}