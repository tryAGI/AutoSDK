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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The email of the author or committer of the commit. You'll receive a `422` status code if `email` is omitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Example: "2013-01-05T13:13:22+05:00"
        /// </summary>
        /// <example>"2013-01-05T13:13:22+05:00"</example>
        [global::Newtonsoft.Json.JsonProperty("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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