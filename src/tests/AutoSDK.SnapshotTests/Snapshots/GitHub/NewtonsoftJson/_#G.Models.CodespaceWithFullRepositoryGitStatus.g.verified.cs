//HintName: G.Models.CodespaceWithFullRepositoryGitStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about the codespace's git repository.
    /// </summary>
    public sealed partial class CodespaceWithFullRepositoryGitStatus
    {
        /// <summary>
        /// The number of commits the local repository is ahead of the remote.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("ahead")]
        public int? Ahead { get; set; }

        /// <summary>
        /// The number of commits the local repository is behind the remote.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("behind")]
        public int? Behind { get; set; }

        /// <summary>
        /// Whether the local repository has unpushed changes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_unpushed_changes")]
        public bool? HasUnpushedChanges { get; set; }

        /// <summary>
        /// Whether the local repository has uncommitted changes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_uncommitted_changes")]
        public bool? HasUncommittedChanges { get; set; }

        /// <summary>
        /// The current branch (or SHA if in detached HEAD state) of the local repository.<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespaceWithFullRepositoryGitStatus" /> class.
        /// </summary>
        /// <param name="ahead">
        /// The number of commits the local repository is ahead of the remote.<br/>
        /// Example: 0
        /// </param>
        /// <param name="behind">
        /// The number of commits the local repository is behind the remote.<br/>
        /// Example: 0
        /// </param>
        /// <param name="hasUnpushedChanges">
        /// Whether the local repository has unpushed changes.
        /// </param>
        /// <param name="hasUncommittedChanges">
        /// Whether the local repository has uncommitted changes.
        /// </param>
        /// <param name="ref">
        /// The current branch (or SHA if in detached HEAD state) of the local repository.<br/>
        /// Example: main
        /// </param>
        public CodespaceWithFullRepositoryGitStatus(
            int? ahead,
            int? behind,
            bool? hasUnpushedChanges,
            bool? hasUncommittedChanges,
            string? @ref)
        {
            this.Ahead = ahead;
            this.Behind = behind;
            this.HasUnpushedChanges = hasUnpushedChanges;
            this.HasUncommittedChanges = hasUncommittedChanges;
            this.Ref = @ref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespaceWithFullRepositoryGitStatus" /> class.
        /// </summary>
        public CodespaceWithFullRepositoryGitStatus()
        {
        }
    }
}