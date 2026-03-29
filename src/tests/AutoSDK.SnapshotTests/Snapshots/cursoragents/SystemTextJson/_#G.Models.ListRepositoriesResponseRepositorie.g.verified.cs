//HintName: G.Models.ListRepositoriesResponseRepositorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListRepositoriesResponseRepositorie
    {
        /// <summary>
        /// The owner of the repository (user or organization)<br/>
        /// Example: your-org
        /// </summary>
        /// <example>your-org</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// The name of the repository<br/>
        /// Example: your-repo
        /// </summary>
        /// <example>your-repo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The full URL to the GitHub repository<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </summary>
        /// <example>https://github.com/your-org/your-repo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoriesResponseRepositorie" /> class.
        /// </summary>
        /// <param name="owner">
        /// The owner of the repository (user or organization)<br/>
        /// Example: your-org
        /// </param>
        /// <param name="name">
        /// The name of the repository<br/>
        /// Example: your-repo
        /// </param>
        /// <param name="repository">
        /// The full URL to the GitHub repository<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListRepositoriesResponseRepositorie(
            string owner,
            string name,
            string repository)
        {
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoriesResponseRepositorie" /> class.
        /// </summary>
        public ListRepositoriesResponseRepositorie()
        {
        }
    }
}