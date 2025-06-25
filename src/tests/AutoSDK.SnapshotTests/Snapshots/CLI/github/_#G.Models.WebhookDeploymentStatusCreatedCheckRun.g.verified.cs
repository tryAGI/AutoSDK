﻿//HintName: G.Models.WebhookDeploymentStatusCreatedCheckRun.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The result of the completed check run. This value will be `null` until the check run has completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookDeploymentStatusCreatedCheckRunConclusionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookDeploymentStatusCreatedCheckRunConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DetailsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// The SHA of the commit that is being checked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The id of the check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the check run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// The current status of the check run. Can be `queued`, `in_progress`, or `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookDeploymentStatusCreatedCheckRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookDeploymentStatusCreatedCheckRunStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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