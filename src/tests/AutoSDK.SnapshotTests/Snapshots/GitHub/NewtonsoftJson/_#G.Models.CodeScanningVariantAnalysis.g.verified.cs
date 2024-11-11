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
        public global::G.SimpleRepository ControllerRepo { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Actor { get; set; } = default!;

        /// <summary>
        /// The language targeted by the CodeQL query
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_language", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningVariantAnalysisLanguage QueryLanguage { get; set; } = default!;

        /// <summary>
        /// The download url for the query pack.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_pack_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string QueryPackUrl { get; set; } = default!;

        /// <summary>
        /// The date and time at which the variant analysis was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time at which the variant analysis was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

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
        public int? ActionsWorkflowRunId { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysis" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the variant analysis.
        /// </param>
        /// <param name="controllerRepo">
        /// A GitHub repository.
        /// </param>
        /// <param name="actor">
        /// A GitHub user.
        /// </param>
        /// <param name="queryLanguage">
        /// The language targeted by the CodeQL query
        /// </param>
        /// <param name="queryPackUrl">
        /// The download url for the query pack.
        /// </param>
        /// <param name="createdAt">
        /// The date and time at which the variant analysis was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time at which the variant analysis was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="completedAt">
        /// The date and time at which the variant analysis was completed, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ. Will be null if the variant analysis has not yet completed or this information is not available.
        /// </param>
        /// <param name="status"></param>
        /// <param name="actionsWorkflowRunId">
        /// The GitHub Actions workflow run used to execute this variant analysis. This is only available if the workflow run has started.
        /// </param>
        /// <param name="failureReason">
        /// The reason for a failure of the variant analysis. This is only available if the variant analysis has failed.
        /// </param>
        /// <param name="scannedRepositories"></param>
        /// <param name="skippedRepositories">
        /// Information about repositories that were skipped from processing. This information is only available to the user that initiated the variant analysis.
        /// </param>
        public CodeScanningVariantAnalysis(
            int id,
            global::G.SimpleRepository controllerRepo,
            global::G.SimpleUser actor,
            global::G.CodeScanningVariantAnalysisLanguage queryLanguage,
            string queryPackUrl,
            global::G.CodeScanningVariantAnalysisStatus2 status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? completedAt,
            int? actionsWorkflowRunId,
            global::G.CodeScanningVariantAnalysisFailureReason? failureReason,
            global::System.Collections.Generic.IList<global::G.CodeScanningVariantAnalysisScannedRepositorie>? scannedRepositories,
            global::G.CodeScanningVariantAnalysisSkippedRepositories? skippedRepositories)
        {
            this.Id = id;
            this.ControllerRepo = controllerRepo ?? throw new global::System.ArgumentNullException(nameof(controllerRepo));
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.QueryLanguage = queryLanguage;
            this.QueryPackUrl = queryPackUrl ?? throw new global::System.ArgumentNullException(nameof(queryPackUrl));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
            this.ActionsWorkflowRunId = actionsWorkflowRunId;
            this.FailureReason = failureReason;
            this.ScannedRepositories = scannedRepositories;
            this.SkippedRepositories = skippedRepositories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysis" /> class.
        /// </summary>
        public CodeScanningVariantAnalysis()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CodeScanningVariantAnalysis? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeScanningVariantAnalysis>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CodeScanningVariantAnalysis?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodeScanningVariantAnalysis?>(serializer.Deserialize<global::G.CodeScanningVariantAnalysis>(jsonReader));
        }

    }
}