//HintName: G.Models.WebhookDeploymentReviewRequestedReviewer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentReviewRequestedReviewer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewer")]
        public global::G.WebhookDeploymentReviewRequestedReviewerReviewer? Reviewer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.WebhookDeploymentReviewRequestedReviewerType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRequestedReviewer" /> class.
        /// </summary>
        /// <param name="reviewer"></param>
        /// <param name="type"></param>
        public WebhookDeploymentReviewRequestedReviewer(
            global::G.WebhookDeploymentReviewRequestedReviewerReviewer? reviewer,
            global::G.WebhookDeploymentReviewRequestedReviewerType? type)
        {
            this.Reviewer = reviewer;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRequestedReviewer" /> class.
        /// </summary>
        public WebhookDeploymentReviewRequestedReviewer()
        {
        }
    }
}