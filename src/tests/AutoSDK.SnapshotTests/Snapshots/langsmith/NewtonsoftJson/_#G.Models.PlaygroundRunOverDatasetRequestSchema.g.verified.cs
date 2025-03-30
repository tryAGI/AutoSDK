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
        [global::Newtonsoft.Json.JsonProperty("manifest", Required = global::Newtonsoft.Json.Required.Always)]
        public object Manifest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secrets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Secrets { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_id")]
        public string? RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Configuration for a Runnable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunnableConfig Options { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_handle")]
        public string? RepoHandle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluator_rules")]
        public global::System.Collections.Generic.IList<global::System.Guid>? EvaluatorRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests_per_second")]
        public int? RequestsPerSecond { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_workspace_secrets")]
        public bool? UseWorkspaceSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_splits")]
        public global::System.Collections.Generic.IList<string>? DatasetSplits { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repetitions")]
        public int? Repetitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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