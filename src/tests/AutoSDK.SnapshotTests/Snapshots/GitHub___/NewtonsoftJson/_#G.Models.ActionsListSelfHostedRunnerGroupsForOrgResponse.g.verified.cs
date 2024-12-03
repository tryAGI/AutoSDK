//HintName: G.Models.ActionsListSelfHostedRunnerGroupsForOrgResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListSelfHostedRunnerGroupsForOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_groups", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RunnerGroupsOrg> RunnerGroups { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListSelfHostedRunnerGroupsForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="runnerGroups"></param>
        public ActionsListSelfHostedRunnerGroupsForOrgResponse(
            double totalCount,
            global::System.Collections.Generic.IList<global::G.RunnerGroupsOrg> runnerGroups)
        {
            this.TotalCount = totalCount;
            this.RunnerGroups = runnerGroups ?? throw new global::System.ArgumentNullException(nameof(runnerGroups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListSelfHostedRunnerGroupsForOrgResponse" /> class.
        /// </summary>
        public ActionsListSelfHostedRunnerGroupsForOrgResponse()
        {
        }
    }
}