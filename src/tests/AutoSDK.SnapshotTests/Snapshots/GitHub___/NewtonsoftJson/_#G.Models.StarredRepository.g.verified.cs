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
        [global::Newtonsoft.Json.JsonProperty("starred_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StarredAt { get; set; } = default!;

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Repository Repo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StarredRepository" /> class.
        /// </summary>
        /// <param name="starredAt"></param>
        /// <param name="repo">
        /// A repository on GitHub.
        /// </param>
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