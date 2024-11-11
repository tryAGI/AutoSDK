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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RunnerGroupsOrg> RunnerGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListSelfHostedRunnerGroupsForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="runnerGroups"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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