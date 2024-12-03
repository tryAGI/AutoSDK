//HintName: G.Models.RepositoryRuleMergeQueueParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleMergeQueueParameters
    {
        /// <summary>
        /// Maximum time for a required status check to report a conclusion. After this much time has elapsed, checks that have not reported a conclusion will be assumed to have failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_response_timeout_minutes", Required = global::Newtonsoft.Json.Required.Always)]
        public int CheckResponseTimeoutMinutes { get; set; } = default!;

        /// <summary>
        /// When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grouping_strategy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryRuleMergeQueueParametersGroupingStrategy GroupingStrategy { get; set; } = default!;

        /// <summary>
        /// Limit the number of queued pull requests requesting checks and workflow runs at the same time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_entries_to_build", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxEntriesToBuild { get; set; } = default!;

        /// <summary>
        /// The maximum number of PRs that will be merged together in a group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_entries_to_merge", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxEntriesToMerge { get; set; } = default!;

        /// <summary>
        /// Method to use when merging changes from queued pull requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryRuleMergeQueueParametersMergeMethod MergeMethod { get; set; } = default!;

        /// <summary>
        /// The minimum number of PRs that will be merged together in a group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_entries_to_merge", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinEntriesToMerge { get; set; } = default!;

        /// <summary>
        /// The time merge queue should wait after the first PR is added to the queue for the minimum group size to be met. After this time has elapsed, the minimum group size will be ignored and a smaller group will be merged.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_entries_to_merge_wait_minutes", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinEntriesToMergeWaitMinutes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMergeQueueParameters" /> class.
        /// </summary>
        /// <param name="checkResponseTimeoutMinutes">
        /// Maximum time for a required status check to report a conclusion. After this much time has elapsed, checks that have not reported a conclusion will be assumed to have failed
        /// </param>
        /// <param name="groupingStrategy">
        /// When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge.
        /// </param>
        /// <param name="maxEntriesToBuild">
        /// Limit the number of queued pull requests requesting checks and workflow runs at the same time.
        /// </param>
        /// <param name="maxEntriesToMerge">
        /// The maximum number of PRs that will be merged together in a group.
        /// </param>
        /// <param name="mergeMethod">
        /// Method to use when merging changes from queued pull requests.
        /// </param>
        /// <param name="minEntriesToMerge">
        /// The minimum number of PRs that will be merged together in a group.
        /// </param>
        /// <param name="minEntriesToMergeWaitMinutes">
        /// The time merge queue should wait after the first PR is added to the queue for the minimum group size to be met. After this time has elapsed, the minimum group size will be ignored and a smaller group will be merged.
        /// </param>
        public RepositoryRuleMergeQueueParameters(
            int checkResponseTimeoutMinutes,
            global::G.RepositoryRuleMergeQueueParametersGroupingStrategy groupingStrategy,
            int maxEntriesToBuild,
            int maxEntriesToMerge,
            global::G.RepositoryRuleMergeQueueParametersMergeMethod mergeMethod,
            int minEntriesToMerge,
            int minEntriesToMergeWaitMinutes)
        {
            this.CheckResponseTimeoutMinutes = checkResponseTimeoutMinutes;
            this.GroupingStrategy = groupingStrategy;
            this.MaxEntriesToBuild = maxEntriesToBuild;
            this.MaxEntriesToMerge = maxEntriesToMerge;
            this.MergeMethod = mergeMethod;
            this.MinEntriesToMerge = minEntriesToMerge;
            this.MinEntriesToMergeWaitMinutes = minEntriesToMergeWaitMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMergeQueueParameters" /> class.
        /// </summary>
        public RepositoryRuleMergeQueueParameters()
        {
        }
    }
}