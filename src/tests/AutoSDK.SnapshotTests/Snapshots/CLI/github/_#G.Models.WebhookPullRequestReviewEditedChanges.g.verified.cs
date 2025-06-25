﻿//HintName: G.Models.WebhookPullRequestReviewEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::G.WebhookPullRequestReviewEditedChangesBody? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewEditedChanges" /> class.
        /// </summary>
        /// <param name="body"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPullRequestReviewEditedChanges(
            global::G.WebhookPullRequestReviewEditedChangesBody? body)
        {
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewEditedChanges" /> class.
        /// </summary>
        public WebhookPullRequestReviewEditedChanges()
        {
        }
    }
}