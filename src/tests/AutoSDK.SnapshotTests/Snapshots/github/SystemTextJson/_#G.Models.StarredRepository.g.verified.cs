//HintName: G.Models.StarredRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Starred Repository
    /// </summary>
    public sealed partial class StarredRepository
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StarredAt { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Repository Repo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StarredRepository" /> class.
        /// </summary>
        /// <param name="starredAt"></param>
        /// <param name="repo">
        /// A repository on GitHub.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StarredRepository(
            global::System.DateTime starredAt,
            global::G.Repository repo)
        {
            this.StarredAt = starredAt;
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StarredRepository" /> class.
        /// </summary>
        public StarredRepository()
        {
        }
    }
}