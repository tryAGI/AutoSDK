//HintName: G.Models.GitCommitCommitter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifying information for the git-user
    /// </summary>
    public sealed partial class GitCommitCommitter
    {
        /// <summary>
        /// Timestamp of the commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Date { get; set; } = default!;

        /// <summary>
        /// Git email address of the user<br/>
        /// Example: monalisa.octocat@example.com
        /// </summary>
        /// <example>monalisa.octocat@example.com</example>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Name of the git user<br/>
        /// Example: Monalisa Octocat
        /// </summary>
        /// <example>Monalisa Octocat</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCommitCommitter" /> class.
        /// </summary>
        /// <param name="date">
        /// Timestamp of the commit
        /// </param>
        /// <param name="email">
        /// Git email address of the user<br/>
        /// Example: monalisa.octocat@example.com
        /// </param>
        /// <param name="name">
        /// Name of the git user<br/>
        /// Example: Monalisa Octocat
        /// </param>
        public GitCommitCommitter(
            global::System.DateTime date,
            string email,
            string name)
        {
            this.Date = date;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCommitCommitter" /> class.
        /// </summary>
        public GitCommitCommitter()
        {
        }
    }
}