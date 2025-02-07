//HintName: G.Models.ActionsReviewPendingDeploymentsForRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsReviewPendingDeploymentsForRunRequest
    {
        /// <summary>
        /// The list of environment ids to approve or reject<br/>
        /// Example: [161171787, 161171795]
        /// </summary>
        /// <example>[161171787, 161171795]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> EnvironmentIds { get; set; }

        /// <summary>
        /// Whether to approve or reject deployment to the specified environments.<br/>
        /// Example: approved
        /// </summary>
        /// <example>approved</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ActionsReviewPendingDeploymentsForRunRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ActionsReviewPendingDeploymentsForRunRequestState State { get; set; }

        /// <summary>
        /// A comment to accompany the deployment review<br/>
        /// Example: Ship it!
        /// </summary>
        /// <example>Ship it!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsReviewPendingDeploymentsForRunRequest" /> class.
        /// </summary>
        /// <param name="environmentIds">
        /// The list of environment ids to approve or reject<br/>
        /// Example: [161171787, 161171795]
        /// </param>
        /// <param name="state">
        /// Whether to approve or reject deployment to the specified environments.<br/>
        /// Example: approved
        /// </param>
        /// <param name="comment">
        /// A comment to accompany the deployment review<br/>
        /// Example: Ship it!
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsReviewPendingDeploymentsForRunRequest(
            global::System.Collections.Generic.IList<int> environmentIds,
            global::G.ActionsReviewPendingDeploymentsForRunRequestState state,
            string comment)
        {
            this.EnvironmentIds = environmentIds ?? throw new global::System.ArgumentNullException(nameof(environmentIds));
            this.State = state;
            this.Comment = comment ?? throw new global::System.ArgumentNullException(nameof(comment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsReviewPendingDeploymentsForRunRequest" /> class.
        /// </summary>
        public ActionsReviewPendingDeploymentsForRunRequest()
        {
        }
    }
}