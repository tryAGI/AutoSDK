//HintName: G.Models.WebhookDeploymentStatusCreatedCheckRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentStatusCreatedCheckRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CompletedAt { get; set; } = default!;

        /// <summary>
        /// The result of the completed check run. This value will be `null` until the check run has completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDeploymentStatusCreatedCheckRunConclusion? Conclusion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DetailsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalId { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit that is being checked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadSha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The id of the check.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the check run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// The current status of the check run. Can be `queued`, `in_progress`, or `completed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDeploymentStatusCreatedCheckRunStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentStatusCreatedCheckRun" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="conclusion">
        /// The result of the completed check run. This value will be `null` until the check run has completed.
        /// </param>
        /// <param name="detailsUrl"></param>
        /// <param name="externalId"></param>
        /// <param name="headSha">
        /// The SHA of the commit that is being checked.
        /// </param>
        /// <param name="htmlUrl"></param>
        /// <param name="id">
        /// The id of the check.
        /// </param>
        /// <param name="name">
        /// The name of the check run.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="startedAt"></param>
        /// <param name="status">
        /// The current status of the check run. Can be `queued`, `in_progress`, or `completed`.
        /// </param>
        /// <param name="url"></param>
        public WebhookDeploymentStatusCreatedCheckRun(
            global::System.DateTime? completedAt,
            global::G.WebhookDeploymentStatusCreatedCheckRunConclusion? conclusion,
            string detailsUrl,
            string externalId,
            string headSha,
            string htmlUrl,
            int id,
            string name,
            string nodeId,
            global::System.DateTime startedAt,
            global::G.WebhookDeploymentStatusCreatedCheckRunStatus status,
            string url)
        {
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.DetailsUrl = detailsUrl ?? throw new global::System.ArgumentNullException(nameof(detailsUrl));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.StartedAt = startedAt;
            this.Status = status;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentStatusCreatedCheckRun" /> class.
        /// </summary>
        public WebhookDeploymentStatusCreatedCheckRun()
        {
        }
    }
}