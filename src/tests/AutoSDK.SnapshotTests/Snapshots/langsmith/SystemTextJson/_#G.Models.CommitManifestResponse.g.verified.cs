//HintName: G.Models.CommitManifestResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for get_commit_manifest.
    /// </summary>
    public sealed partial class CommitManifestResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Manifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<global::G.RepoExampleResponse>? Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitManifestResponse" /> class.
        /// </summary>
        /// <param name="commitHash"></param>
        /// <param name="manifest"></param>
        /// <param name="examples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitManifestResponse(
            string commitHash,
            object manifest,
            global::System.Collections.Generic.IList<global::G.RepoExampleResponse>? examples)
        {
            this.CommitHash = commitHash ?? throw new global::System.ArgumentNullException(nameof(commitHash));
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.Examples = examples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitManifestResponse" /> class.
        /// </summary>
        public CommitManifestResponse()
        {
        }
    }
}