﻿//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksComments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksComments
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("href", Required = global::Newtonsoft.Json.Required.Always)]
        public string Href { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksComments" /> class.
        /// </summary>
        /// <param name="href"></param>
        public WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksComments(
            string href)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksComments" /> class.
        /// </summary>
        public WebhookPullRequestReviewRequestRemovedVariant1PullRequestLinksComments()
        {
        }
    }
}