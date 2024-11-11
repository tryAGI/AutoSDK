//HintName: G.Models.NullableGitUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metaproperties for Git author/committer information.
    /// </summary>
    public sealed partial class NullableGitUser
    {
        /// <summary>
        /// Example: "Chris Wanstrath"
        /// </summary>
        /// <example>"Chris Wanstrath"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: "chris@ozmm.org"
        /// </summary>
        /// <example>"chris@ozmm.org"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: "2007-10-29T02:42:39.000-07:00"
        /// </summary>
        /// <example>"2007-10-29T02:42:39.000-07:00"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableGitUser" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: "Chris Wanstrath"
        /// </param>
        /// <param name="email">
        /// Example: "chris@ozmm.org"
        /// </param>
        /// <param name="date">
        /// Example: "2007-10-29T02:42:39.000-07:00"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public NullableGitUser(
            string? name,
            string? email,
            string? date)
        {
            this.Name = name;
            this.Email = email;
            this.Date = date;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableGitUser" /> class.
        /// </summary>
        public NullableGitUser()
        {
        }
    }
}