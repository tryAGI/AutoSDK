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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RepositoryRuleMergeQueueParameters? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoryRuleMergeQueueParameters>(
                json,
                jsonSerializerOptions);
        }

    }
}