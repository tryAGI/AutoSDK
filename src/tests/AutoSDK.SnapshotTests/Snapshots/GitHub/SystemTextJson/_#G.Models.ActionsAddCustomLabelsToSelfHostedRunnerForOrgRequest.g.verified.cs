//HintName: G.Models.ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest
    {
        /// <summary>
        /// The names of the custom labels to add to the runner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest" /> class.
        /// </summary>
        /// <param name="labels">
        /// The names of the custom labels to add to the runner.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest(
            global::System.Collections.Generic.IList<string> labels)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest" /> class.
        /// </summary>
        public ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest()
        {
        }
    }
}