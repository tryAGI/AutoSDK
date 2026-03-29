//HintName: G.Models.AgreementV2BackfillTriggerRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for POST /api/dimensions/backfill/<br/>
    /// Exactly one of the three mode fields must be provided:<br/>
    /// - project_id:   backfill a single specific project.<br/>
    /// - num_projects: batched org backfill — queue the next N not-yet-started projects<br/>
    ///                 (ascending project ID order), leaving in-flight jobs untouched.<br/>
    ///                 Check `projects_remaining` in the response and repeat until it reaches 0.<br/>
    /// - all_projects: full org backfill — cancel all in-flight jobs and queue every<br/>
    ///                 remaining non-completed project at once.
    /// </summary>
    public sealed partial class AgreementV2BackfillTriggerRequestRequest
    {
        /// <summary>
        /// Set to true to trigger a full org backfill (cancels in-flight jobs and queues all remaining projects).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_projects")]
        public bool? AllProjects { get; set; }

        /// <summary>
        /// Queue at most this many projects per call (batched mode).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_projects")]
        public int? NumProjects { get; set; }

        /// <summary>
        /// Backfill a single specific project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementV2BackfillTriggerRequestRequest" /> class.
        /// </summary>
        /// <param name="allProjects">
        /// Set to true to trigger a full org backfill (cancels in-flight jobs and queues all remaining projects).
        /// </param>
        /// <param name="numProjects">
        /// Queue at most this many projects per call (batched mode).
        /// </param>
        /// <param name="projectId">
        /// Backfill a single specific project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgreementV2BackfillTriggerRequestRequest(
            bool? allProjects,
            int? numProjects,
            int? projectId)
        {
            this.AllProjects = allProjects;
            this.NumProjects = numProjects;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementV2BackfillTriggerRequestRequest" /> class.
        /// </summary>
        public AgreementV2BackfillTriggerRequestRequest()
        {
        }
    }
}