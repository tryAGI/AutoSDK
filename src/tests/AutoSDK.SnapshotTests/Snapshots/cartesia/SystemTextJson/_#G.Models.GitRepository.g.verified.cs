//HintName: G.Models.GitRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitRepository
    {
        /// <summary>
        /// The provider of the Git repository, e.g., GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// The account name associated with the Git repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Account { get; set; }

        /// <summary>
        /// The name of the Git repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitRepository" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider of the Git repository, e.g., GitHub.
        /// </param>
        /// <param name="account">
        /// The account name associated with the Git repository.
        /// </param>
        /// <param name="name">
        /// The name of the Git repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitRepository(
            string provider,
            string account,
            string name)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitRepository" /> class.
        /// </summary>
        public GitRepository()
        {
        }
    }
}