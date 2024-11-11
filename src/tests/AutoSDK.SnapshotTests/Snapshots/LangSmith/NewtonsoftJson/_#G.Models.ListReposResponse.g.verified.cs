//HintName: G.Models.ListReposResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListReposResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepoWithLookups> Repos { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListReposResponse" /> class.
        /// </summary>
        /// <param name="repos"></param>
        /// <param name="total"></param>
        public ListReposResponse(
            global::System.Collections.Generic.IList<global::G.RepoWithLookups> repos,
            int total)
        {
            this.Repos = repos ?? throw new global::System.ArgumentNullException(nameof(repos));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListReposResponse" /> class.
        /// </summary>
        public ListReposResponse()
        {
        }
    }
}