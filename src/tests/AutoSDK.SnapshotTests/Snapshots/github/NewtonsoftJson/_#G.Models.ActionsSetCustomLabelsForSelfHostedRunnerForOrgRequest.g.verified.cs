//HintName: G.Models.ActionsSetCustomLabelsForSelfHostedRunnerForOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetCustomLabelsForSelfHostedRunnerForOrgRequest
    {
        /// <summary>
        /// The names of the custom labels to set for the runner. You can pass an empty array to remove all custom labels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Labels { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetCustomLabelsForSelfHostedRunnerForOrgRequest" /> class.
        /// </summary>
        /// <param name="labels">
        /// The names of the custom labels to set for the runner. You can pass an empty array to remove all custom labels.
        /// </param>
        public ActionsSetCustomLabelsForSelfHostedRunnerForOrgRequest(
            global::System.Collections.Generic.IList<string> labels)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetCustomLabelsForSelfHostedRunnerForOrgRequest" /> class.
        /// </summary>
        public ActionsSetCustomLabelsForSelfHostedRunnerForOrgRequest()
        {
        }
    }
}