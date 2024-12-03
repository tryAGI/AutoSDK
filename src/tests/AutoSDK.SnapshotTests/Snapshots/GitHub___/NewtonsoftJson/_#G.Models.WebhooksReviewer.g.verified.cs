//HintName: G.Models.WebhooksReviewer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksReviewer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewer")]
        public global::G.WebhooksReviewerReviewer? Reviewer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.WebhooksReviewerType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksReviewer" /> class.
        /// </summary>
        /// <param name="reviewer"></param>
        /// <param name="type"></param>
        public WebhooksReviewer(
            global::G.WebhooksReviewerReviewer? reviewer,
            global::G.WebhooksReviewerType? type)
        {
            this.Reviewer = reviewer;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksReviewer" /> class.
        /// </summary>
        public WebhooksReviewer()
        {
        }
    }
}