//HintName: G.Models.CodespaceGitStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about the codespace's git repository.
    /// </summary>
    public sealed partial class CodespaceGitStatus
    {
        /// <summary>
        /// The number of commits the local repository is ahead of the remote.
        /// <br/>Example: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ahead")]
        public int Ahead { get; set; }

        /// <summary>
        /// The number of commits the local repository is behind the remote.
        /// <br/>Example: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behind")]
        public int Behind { get; set; }

        /// <summary>
        /// Whether the local repository has unpushed changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_unpushed_changes")]
        public bool HasUnpushedChanges { get; set; }

        /// <summary>
        /// Whether the local repository has uncommitted changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_uncommitted_changes")]
        public bool HasUncommittedChanges { get; set; }

        /// <summary>
        /// The current branch (or SHA if in detached HEAD state) of the local repository.
        /// <br/>Example: main
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}