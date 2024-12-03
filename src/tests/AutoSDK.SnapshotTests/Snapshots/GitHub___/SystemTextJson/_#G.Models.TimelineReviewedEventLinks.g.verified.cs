//HintName: G.Models.TimelineReviewedEventLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimelineReviewedEventLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimelineReviewedEventLinksHtml Html { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimelineReviewedEventLinksPullRequest PullRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineReviewedEventLinks" /> class.
        /// </summary>
        /// <param name="html"></param>
        /// <param name="pullRequest"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TimelineReviewedEventLinks(
            global::G.TimelineReviewedEventLinksHtml html,
            global::G.TimelineReviewedEventLinksPullRequest pullRequest)
        {
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineReviewedEventLinks" /> class.
        /// </summary>
        public TimelineReviewedEventLinks()
        {
        }
    }
}