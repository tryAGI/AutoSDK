﻿//HintName: G.Models.GitCreateCommitRequestAuthor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the author of the commit. By default, the `author` will be the authenticated user and the current date. See the `author` and `committer` object below for details.
    /// </summary>
    public sealed partial class GitCreateCommitRequestAuthor
    {
        /// <summary>
        /// The name of the author (or committer) of the commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The email of the author (or committer) of the commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Indicates when this commit was authored (or committed). This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateCommitRequestAuthor" /> class.
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
        public GitCreateCommitRequestAuthor(
            string name,
            string email,
            global::System.DateTime? date)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Date = date;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateCommitRequestAuthor" /> class.
        /// </summary>
        public GitCreateCommitRequestAuthor()
        {
        }
    }
}