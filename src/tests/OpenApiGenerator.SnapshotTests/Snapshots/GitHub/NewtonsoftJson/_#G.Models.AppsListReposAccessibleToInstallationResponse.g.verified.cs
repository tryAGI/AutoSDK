//HintName: G.Models.AppsListReposAccessibleToInstallationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsListReposAccessibleToInstallationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<Repository> Repositories { get; set; } = default!;

        /// <summary>
        /// <br/>Example: selected
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection")]
        public string? RepositorySelection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}