//HintName: G.Models.ActionsListRepoAccessToSelfHostedRunnerGroupInOrgResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListRepoAccessToSelfHostedRunnerGroupInOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MinimalRepository> Repositories { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListRepoAccessToSelfHostedRunnerGroupInOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="repositories"></param>
        public ActionsListRepoAccessToSelfHostedRunnerGroupInOrgResponse(
            double totalCount,
            global::System.Collections.Generic.IList<global::G.MinimalRepository> repositories)
        {
            this.TotalCount = totalCount;
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListRepoAccessToSelfHostedRunnerGroupInOrgResponse" /> class.
        /// </summary>
        public ActionsListRepoAccessToSelfHostedRunnerGroupInOrgResponse()
        {
        }
    }
}