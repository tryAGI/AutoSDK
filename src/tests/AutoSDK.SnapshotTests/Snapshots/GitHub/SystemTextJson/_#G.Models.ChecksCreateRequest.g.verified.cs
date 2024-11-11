//HintName: G.Models.ChecksCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksCreateRequest
    {
        /// <summary>
        /// The name of the check. For example, "code-coverage".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The SHA of the commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// The URL of the integrator's site that has the full details of the check. If the integrator does not provide this, then the homepage of the GitHub app is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details_url")]
        public string? DetailsUrl { get; set; }

        /// <summary>
        /// A reference for the run on the integrator's system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// The current status of the check run. Only GitHub Actions can set a status of `waiting`, `pending`, or `requested`.<br/>
        /// Default Value: queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChecksCreateRequestStatusJsonConverter))]
        public global::G.ChecksCreateRequestStatus? Status { get; set; }

        /// <summary>
        /// The time that the check run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// **Required if you provide `completed_at` or a `status` of `completed`**. The final conclusion of the check. <br/>
        /// **Note:** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChecksCreateRequestConclusionJsonConverter))]
        public global::G.ChecksCreateRequestConclusion? Conclusion { get; set; }

        /// <summary>
        /// The time the check completed. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Check runs can accept a variety of data in the `output` object, including a `title` and `summary` and can optionally provide descriptive details about the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::G.ChecksCreateRequestOutput? Output { get; set; }

        /// <summary>
        /// Displays a button on GitHub that can be clicked to alert your app to do additional tasks. For example, a code linting app can display a button that automatically fixes detected errors. The button created in this object is displayed after the check run completes. When a user clicks the button, GitHub sends the [`check_run.requested_action` webhook](https://docs.github.com/webhooks/event-payloads/#check_run) to your app. Each action includes a `label`, `identifier` and `description`. A maximum of three actions are accepted. To learn more about check runs and requested actions, see "[Check runs and requested actions](https://docs.github.com/rest/guides/using-the-rest-api-to-interact-with-checks#check-runs-and-requested-actions)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::G.ChecksCreateRequestAction>? Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the check. For example, "code-coverage".
        /// </param>
        /// <param name="headSha">
        /// The SHA of the commit.
        /// </param>
        /// <param name="detailsUrl">
        /// The URL of the integrator's site that has the full details of the check. If the integrator does not provide this, then the homepage of the GitHub app is used.
        /// </param>
        /// <param name="externalId">
        /// A reference for the run on the integrator's system.
        /// </param>
        /// <param name="status">
        /// The current status of the check run. Only GitHub Actions can set a status of `waiting`, `pending`, or `requested`.<br/>
        /// Default Value: queued
        /// </param>
        /// <param name="startedAt">
        /// The time that the check run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="conclusion">
        /// **Required if you provide `completed_at` or a `status` of `completed`**. The final conclusion of the check. <br/>
        /// **Note:** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
        /// </param>
        /// <param name="completedAt">
        /// The time the check completed. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="output">
        /// Check runs can accept a variety of data in the `output` object, including a `title` and `summary` and can optionally provide descriptive details about the run.
        /// </param>
        /// <param name="actions">
        /// Displays a button on GitHub that can be clicked to alert your app to do additional tasks. For example, a code linting app can display a button that automatically fixes detected errors. The button created in this object is displayed after the check run completes. When a user clicks the button, GitHub sends the [`check_run.requested_action` webhook](https://docs.github.com/webhooks/event-payloads/#check_run) to your app. Each action includes a `label`, `identifier` and `description`. A maximum of three actions are accepted. To learn more about check runs and requested actions, see "[Check runs and requested actions](https://docs.github.com/rest/guides/using-the-rest-api-to-interact-with-checks#check-runs-and-requested-actions)."
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChecksCreateRequest(
            string name,
            string headSha,
            string? detailsUrl,
            string? externalId,
            global::G.ChecksCreateRequestStatus? status,
            global::System.DateTime? startedAt,
            global::G.ChecksCreateRequestConclusion? conclusion,
            global::System.DateTime? completedAt,
            global::G.ChecksCreateRequestOutput? output,
            global::System.Collections.Generic.IList<global::G.ChecksCreateRequestAction>? actions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.DetailsUrl = detailsUrl;
            this.ExternalId = externalId;
            this.Status = status;
            this.StartedAt = startedAt;
            this.Conclusion = conclusion;
            this.CompletedAt = completedAt;
            this.Output = output;
            this.Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequest" /> class.
        /// </summary>
        public ChecksCreateRequest()
        {
        }
    }
}