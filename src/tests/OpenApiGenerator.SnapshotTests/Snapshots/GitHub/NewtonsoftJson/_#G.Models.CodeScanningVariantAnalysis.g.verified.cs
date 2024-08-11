//HintName: G.Models.CodeScanningVariantAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A run of a CodeQL query against one or more repositories.
    /// </summary>
    public sealed partial class CodeScanningVariantAnalysis
    {
        /// <summary>
        /// The ID of the variant analysis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("controller_repo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleRepository? ControllerRepo { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser? Actor { get; set; } = default!;

        /// <summary>
        /// The language targeted by the CodeQL query
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_language", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningVariantAnalysisLanguage? QueryLanguage { get; set; } = default!;

        /// <summary>
        /// The download url for the query pack.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_pack_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string QueryPackUrl { get; set; } = default!;

        /// <summary>
        /// The date and time at which the variant analysis was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time at which the variant analysis was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The date and time at which the variant analysis was completed, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ. Will be null if the variant analysis has not yet completed or this information is not available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningVariantAnalysisStatus2 Status { get; set; } = default!;

        /// <summary>
        /// The GitHub Actions workflow run used to execute this variant analysis. This is only available if the workflow run has started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actions_workflow_run_id")]
        public int ActionsWorkflowRunId { get; set; }

        /// <summary>
        /// The reason for a failure of the variant analysis. This is only available if the variant analysis has failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_reason")]
        public global::G.CodeScanningVariantAnalysisFailureReason? FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scanned_repositories")]
        public global::System.Collections.Generic.IList<global::G.CodeScanningVariantAnalysisScannedRepositorie>? ScannedRepositories { get; set; }

        /// <summary>
        /// Information about repositories that were skipped from processing. This information is only available to the user that initiated the variant analysis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skipped_repositories")]
        public global::G.CodeScanningVariantAnalysisSkippedRepositories? SkippedRepositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}