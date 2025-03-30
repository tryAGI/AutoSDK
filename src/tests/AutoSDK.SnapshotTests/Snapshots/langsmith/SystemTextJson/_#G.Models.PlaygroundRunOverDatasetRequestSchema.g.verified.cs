//HintName: G.Models.PlaygroundRunOverDatasetRequestSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundRunOverDatasetRequestSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Manifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_id")]
        public string? RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Configuration for a Runnable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunnableConfig Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_handle")]
        public string? RepoHandle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_rules")]
        public global::System.Collections.Generic.IList<global::System.Guid>? EvaluatorRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_second")]
        public int? RequestsPerSecond { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_workspace_secrets")]
        public bool? UseWorkspaceSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_splits")]
        public global::System.Collections.Generic.IList<string>? DatasetSplits { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetitions")]
        public int? Repetitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundRunOverDatasetRequestSchema" /> class.
        /// </summary>
        /// <param name="manifest"></param>
        /// <param name="secrets"></param>
        /// <param name="runId"></param>
        /// <param name="repoId"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="options">
        /// Configuration for a Runnable.
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="repoHandle"></param>
        /// <param name="owner"></param>
        /// <param name="commit"></param>
        /// <param name="evaluatorRules"></param>
        /// <param name="requestsPerSecond"></param>
        /// <param name="useWorkspaceSecrets">
        /// Default Value: false
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="datasetSplits"></param>
        /// <param name="repetitions">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundRunOverDatasetRequestSchema(
            object manifest,
            global::System.Collections.Generic.Dictionary<string, string> secrets,
            global::G.RunnableConfig options,
            string projectName,
            global::System.Guid datasetId,
            string? runId,
            string? repoId,
            global::System.Collections.Generic.IList<object>? tools,
            string? toolChoice,
            bool? parallelToolCalls,
            string? repoHandle,
            string? owner,
            string? commit,
            global::System.Collections.Generic.IList<global::System.Guid>? evaluatorRules,
            int? requestsPerSecond,
            bool? useWorkspaceSecrets,
            global::System.Collections.Generic.IList<string>? datasetSplits,
            int? repetitions)
        {
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.DatasetId = datasetId;
            this.RunId = runId;
            this.RepoId = repoId;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
            this.RepoHandle = repoHandle;
            this.Owner = owner;
            this.Commit = commit;
            this.EvaluatorRules = evaluatorRules;
            this.RequestsPerSecond = requestsPerSecond;
            this.UseWorkspaceSecrets = useWorkspaceSecrets;
            this.DatasetSplits = datasetSplits;
            this.Repetitions = repetitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundRunOverDatasetRequestSchema" /> class.
        /// </summary>
        public PlaygroundRunOverDatasetRequestSchema()
        {
        }
    }
}