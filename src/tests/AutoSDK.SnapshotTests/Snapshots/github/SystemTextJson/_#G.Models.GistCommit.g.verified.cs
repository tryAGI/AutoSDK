//HintName: G.Models.GistCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gist Commit
    /// </summary>
    public sealed partial class GistCommit
    {
        /// <summary>
        /// Example: https://api.github.com/gists/aa5a315d61ae9438b18d/57a7f021a713b1c5a6a199b54cc514735d2d462f
        /// </summary>
        /// <example>https://api.github.com/gists/aa5a315d61ae9438b18d/57a7f021a713b1c5a6a199b54cc514735d2d462f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: 57a7f021a713b1c5a6a199b54cc514735d2d462f
        /// </summary>
        /// <example>57a7f021a713b1c5a6a199b54cc514735d2d462f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GistCommitChangeStatus ChangeStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CommittedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistCommit" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/gists/aa5a315d61ae9438b18d/57a7f021a713b1c5a6a199b54cc514735d2d462f
        /// </param>
        /// <param name="version">
        /// Example: 57a7f021a713b1c5a6a199b54cc514735d2d462f
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="changeStatus"></param>
        /// <param name="committedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GistCommit(
            string url,
            string version,
            global::G.NullableSimpleUser? user,
            global::G.GistCommitChangeStatus changeStatus,
            global::System.DateTime committedAt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.ChangeStatus = changeStatus ?? throw new global::System.ArgumentNullException(nameof(changeStatus));
            this.CommittedAt = committedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistCommit" /> class.
        /// </summary>
        public GistCommit()
        {
        }
    }
}