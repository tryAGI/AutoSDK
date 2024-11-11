//HintName: G.Models.ActionsListLabelsForSelfHostedRunnerForOrgResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListLabelsForSelfHostedRunnerForOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RunnerLabel> Labels { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListLabelsForSelfHostedRunnerForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="labels"></param>
        public ActionsListLabelsForSelfHostedRunnerForOrgResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.RunnerLabel> labels)
        {
            this.TotalCount = totalCount;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListLabelsForSelfHostedRunnerForOrgResponse" /> class.
        /// </summary>
        public ActionsListLabelsForSelfHostedRunnerForOrgResponse()
        {
        }
    }
}