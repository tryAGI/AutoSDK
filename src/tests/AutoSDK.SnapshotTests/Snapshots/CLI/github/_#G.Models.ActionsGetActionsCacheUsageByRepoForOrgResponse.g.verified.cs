//HintName: G.Models.ActionsGetActionsCacheUsageByRepoForOrgResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGetActionsCacheUsageByRepoForOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_cache_usages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ActionsCacheUsageByRepository> RepositoryCacheUsages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetActionsCacheUsageByRepoForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="repositoryCacheUsages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsGetActionsCacheUsageByRepoForOrgResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.ActionsCacheUsageByRepository> repositoryCacheUsages)
        {
            this.TotalCount = totalCount;
            this.RepositoryCacheUsages = repositoryCacheUsages ?? throw new global::System.ArgumentNullException(nameof(repositoryCacheUsages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetActionsCacheUsageByRepoForOrgResponse" /> class.
        /// </summary>
        public ActionsGetActionsCacheUsageByRepoForOrgResponse()
        {
        }
    }
}