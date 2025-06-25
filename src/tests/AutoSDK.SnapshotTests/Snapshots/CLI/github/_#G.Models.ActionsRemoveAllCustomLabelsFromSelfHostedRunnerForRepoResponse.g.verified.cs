//HintName: G.Models.ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepoResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RunnerLabel> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepoResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="labels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepoResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.RunnerLabel> labels)
        {
            this.TotalCount = totalCount;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepoResponse" /> class.
        /// </summary>
        public ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepoResponse()
        {
        }
    }
}