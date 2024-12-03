//HintName: G.Models.ReposCreateOrUpdateFileContentsRequestCommitter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The person that committed the file. Default: the authenticated user.
    /// </summary>
    public sealed partial class ReposCreateOrUpdateFileContentsRequestCommitter
    {
        /// <summary>
        /// The name of the author or committer of the commit. You'll receive a `422` status code if `name` is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The email of the author or committer of the commit. You'll receive a `422` status code if `email` is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Example: "2013-01-05T13:13:22+05:00"
        /// </summary>
        /// <example>"2013-01-05T13:13:22+05:00"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateOrUpdateFileContentsRequestCommitter" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the author or committer of the commit. You'll receive a `422` status code if `name` is omitted.
        /// </param>
        /// <param name="email">
        /// The email of the author or committer of the commit. You'll receive a `422` status code if `email` is omitted.
        /// </param>
        /// <param name="date">
        /// Example: "2013-01-05T13:13:22+05:00"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposCreateOrUpdateFileContentsRequestCommitter(
            string name,
            string email,
            string? date)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Date = date;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateOrUpdateFileContentsRequestCommitter" /> class.
        /// </summary>
        public ReposCreateOrUpdateFileContentsRequestCommitter()
        {
        }
    }
}