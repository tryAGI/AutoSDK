//HintName: G.Models.TimelineCommittedEventAuthor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifying information for the git-user
    /// </summary>
    public sealed partial class TimelineCommittedEventAuthor
    {
        /// <summary>
        /// Timestamp of the commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// Git email address of the user<br/>
        /// Example: monalisa.octocat@example.com
        /// </summary>
        /// <example>monalisa.octocat@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Name of the git user<br/>
        /// Example: Monalisa Octocat
        /// </summary>
        /// <example>Monalisa Octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommittedEventAuthor" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimelineCommittedEventAuthor(
            global::System.DateTime date,
            string email,
            string name)
        {
            this.Date = date;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommittedEventAuthor" /> class.
        /// </summary>
        public TimelineCommittedEventAuthor()
        {
        }
    }
}