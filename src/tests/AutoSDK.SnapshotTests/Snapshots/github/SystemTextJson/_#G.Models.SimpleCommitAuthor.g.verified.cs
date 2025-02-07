//HintName: G.Models.SimpleCommitAuthor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the Git author
    /// </summary>
    public sealed partial class SimpleCommitAuthor
    {
        /// <summary>
        /// Name of the commit's author<br/>
        /// Example: Monalisa Octocat
        /// </summary>
        /// <example>Monalisa Octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Git email address of the commit's author<br/>
        /// Example: monalisa.octocat@example.com
        /// </summary>
        /// <example>monalisa.octocat@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCommitAuthor" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the commit's author<br/>
        /// Example: Monalisa Octocat
        /// </param>
        /// <param name="email">
        /// Git email address of the commit's author<br/>
        /// Example: monalisa.octocat@example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimpleCommitAuthor(
            string name,
            string email)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCommitAuthor" /> class.
        /// </summary>
        public SimpleCommitAuthor()
        {
        }
    }
}