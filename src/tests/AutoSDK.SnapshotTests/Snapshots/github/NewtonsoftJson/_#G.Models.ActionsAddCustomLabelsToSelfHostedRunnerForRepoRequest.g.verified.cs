﻿//HintName: G.Models.ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest
    {
        /// <summary>
        /// The names of the custom labels to add to the runner.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Labels { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest" /> class.
        /// </summary>
        /// <param name="labels">
        /// The names of the custom labels to add to the runner.
        /// </param>
        public ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest(
            global::System.Collections.Generic.IList<string> labels)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest" /> class.
        /// </summary>
        public ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest()
        {
        }
    }
}