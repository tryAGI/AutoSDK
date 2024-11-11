//HintName: G.Models.GetRepoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRepoResponse
    {
        /// <summary>
        /// All database fields for repos, plus helpful computed fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepoWithLookups Repo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepoResponse" /> class.
        /// </summary>
        /// <param name="repo">
        /// All database fields for repos, plus helpful computed fields.
        /// </param>
        public GetRepoResponse(
            global::G.RepoWithLookups repo)
        {
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepoResponse" /> class.
        /// </summary>
        public GetRepoResponse()
        {
        }
    }
}