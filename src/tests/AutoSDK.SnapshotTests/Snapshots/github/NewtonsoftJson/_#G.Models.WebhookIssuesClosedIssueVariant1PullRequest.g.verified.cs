﻿//HintName: G.Models.WebhookIssuesClosedIssueVariant1PullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookIssuesClosedIssueVariant1PullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diff_url")]
        public string? DiffUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged_at")]
        public global::System.DateTime? MergedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patch_url")]
        public string? PatchUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesClosedIssueVariant1PullRequest" /> class.
        /// </summary>
        /// <param name="diffUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="mergedAt"></param>
        /// <param name="patchUrl"></param>
        /// <param name="url"></param>
        public WebhookIssuesClosedIssueVariant1PullRequest(
            string? diffUrl,
            string? htmlUrl,
            global::System.DateTime? mergedAt,
            string? patchUrl,
            string? url)
        {
            this.DiffUrl = diffUrl;
            this.HtmlUrl = htmlUrl;
            this.MergedAt = mergedAt;
            this.PatchUrl = patchUrl;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesClosedIssueVariant1PullRequest" /> class.
        /// </summary>
        public WebhookIssuesClosedIssueVariant1PullRequest()
        {
        }
    }
}