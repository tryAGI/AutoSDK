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
        [global::System.Text.Json.Serialization.JsonPropertyName("check_response_timeout_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CheckResponseTimeoutMinutes { get; set; }

        /// <summary>
        /// When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grouping_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleMergeQueueParametersGroupingStrategyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRuleMergeQueueParametersGroupingStrategy GroupingStrategy { get; set; }

        /// <summary>
        /// Limit the number of queued pull requests requesting checks and workflow runs at the same time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_entries_to_build")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxEntriesToBuild { get; set; }

        /// <summary>
        /// The maximum number of PRs that will be merged together in a group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_entries_to_merge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxEntriesToMerge { get; set; }

        /// <summary>
        /// Method to use when merging changes from queued pull requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleMergeQueueParametersMergeMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRuleMergeQueueParametersMergeMethod MergeMethod { get; set; }

        /// <summary>
        /// The minimum number of PRs that will be merged together in a group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_entries_to_merge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinEntriesToMerge { get; set; }

        /// <summary>
        /// The time merge queue should wait after the first PR is added to the queue for the minimum group size to be met. After this time has elapsed, the minimum group size will be ignored and a smaller group will be merged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_entries_to_merge_wait_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinEntriesToMergeWaitMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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