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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: 57a7f021a713b1c5a6a199b54cc514735d2d462f
        /// </summary>
        /// <example>57a7f021a713b1c5a6a199b54cc514735d2d462f</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("change_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GistCommitChangeStatus ChangeStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CommittedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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