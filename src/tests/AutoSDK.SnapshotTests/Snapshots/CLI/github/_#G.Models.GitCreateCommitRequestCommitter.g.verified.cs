//HintName: G.Models.GitCreateCommitRequestCommitter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the person who is making the commit. By default, `committer` will use the information set in `author`. See the `author` and `committer` object below for details.
    /// </summary>
    public sealed partial class GitCreateCommitRequestCommitter
    {
        /// <summary>
        /// The name of the author (or committer) of the commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The email of the author (or committer) of the commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Indicates when this commit was authored (or committed). This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateCommitRequestCommitter" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the author (or committer) of the commit
        /// </param>
        /// <param name="email">
        /// The email of the author (or committer) of the commit
        /// </param>
        /// <param name="date">
        /// Indicates when this commit was authored (or committed). This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitCreateCommitRequestCommitter(
            string? name,
            string? email,
            global::System.DateTime? date)
        {
            this.Name = name;
            this.Email = email;
            this.Date = date;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateCommitRequestCommitter" /> class.
        /// </summary>
        public GitCreateCommitRequestCommitter()
        {
        }
    }
}