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
        /// All database fields for commits, plus helpful computed fields and user info<br/>
        /// for private prompts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CommitWithLookups Commit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoCommitResponse" /> class.
        /// </summary>
        /// <param name="commit">
        /// All database fields for commits, plus helpful computed fields and user info<br/>
        /// for private prompts.
        /// </param>
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