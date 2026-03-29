//HintName: G.Models.RunEval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunEval
    {
        /// <summary>
        /// Unique identifier for the project to run the eval in
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// The dataset to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.RunEvalDataDatasetId, global::G.RunEvalDataProjectDatasetName, global::G.RunEvalDataDatasetRows> Data { get; set; } = default!;

        /// <summary>
        /// The name of the eval to run when multiple evals available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Values for any parameters used in the eval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Parameters { get; set; }

        /// <summary>
        /// The function to evaluate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionId Task { get; set; } = default!;

        /// <summary>
        /// The functions to score the eval on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AllOf<global::G.FunctionId?, object>> Scores { get; set; } = default!;

        /// <summary>
        /// An optional name for the experiment created by this eval. If it conflicts with an existing experiment, it will be suffixed with a unique identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_name")]
        public string? ExperimentName { get; set; }

        /// <summary>
        /// Optional experiment-level metadata to store about the evaluation. You can later use this to slice &amp; dice across experiments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent")]
        public global::G.AllOf<global::G.InvokeParent?, object>? Parent { get; set; }

        /// <summary>
        /// Whether to stream the results of the eval. If true, the request will return two events: one to indicate the experiment has started, and another upon completion. If false, the request will return the evaluation's summary upon completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// The number of times to run the evaluator per input. This is useful for evaluating applications that have non-deterministic behavior and gives you both a stronger aggregate measure and a sense of the variance in the results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trial_count")]
        public double? TrialCount { get; set; }

        /// <summary>
        /// Whether the experiment should be public. Defaults to false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// The maximum duration, in milliseconds, to run the evaluation. Defaults to undefined, in which case there is no timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// The maximum number of tasks/scorers that will be run concurrently. Defaults to 10. If null is provided, no max concurrency will be used.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_concurrency")]
        public double? MaxConcurrency { get; set; }

        /// <summary>
        /// An optional experiment name to use as a base. If specified, the new experiment will be summarized and compared to this experiment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_experiment_name")]
        public string? BaseExperimentName { get; set; }

        /// <summary>
        /// An optional experiment id to use as a base. If specified, the new experiment will be summarized and compared to this experiment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_experiment_id")]
        public string? BaseExperimentId { get; set; }

        /// <summary>
        /// Optional settings for collecting git metadata. By default, will collect all git metadata fields allowed in org-level settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_metadata_settings")]
        public global::G.GitMetadataSettings? GitMetadataSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_info")]
        public global::G.AllOf<global::G.RepoInfo, object>? RepoInfo { get; set; }

        /// <summary>
        /// If true, throw an error if one of the variables in the prompt is not present in the input
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// The token to stop the run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_token")]
        public string? StopToken { get; set; }

        /// <summary>
        /// A template path of extra messages to append to the conversion. These messages will be appended to the end of the conversation, after the last message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_messages")]
        public string? ExtraMessages { get; set; }

        /// <summary>
        /// Optional tags that will be added to the experiment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_auth")]
        public global::System.Collections.Generic.Dictionary<string, global::G.RunEvalMcpAuth2>? McpAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEval" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project to run the eval in
        /// </param>
        /// <param name="data">
        /// The dataset to use
        /// </param>
        /// <param name="task">
        /// The function to evaluate
        /// </param>
        /// <param name="scores">
        /// The functions to score the eval on
        /// </param>
        /// <param name="name">
        /// The name of the eval to run when multiple evals available
        /// </param>
        /// <param name="parameters">
        /// Values for any parameters used in the eval
        /// </param>
        /// <param name="experimentName">
        /// An optional name for the experiment created by this eval. If it conflicts with an existing experiment, it will be suffixed with a unique identifier.
        /// </param>
        /// <param name="metadata">
        /// Optional experiment-level metadata to store about the evaluation. You can later use this to slice &amp; dice across experiments.
        /// </param>
        /// <param name="parent"></param>
        /// <param name="stream">
        /// Whether to stream the results of the eval. If true, the request will return two events: one to indicate the experiment has started, and another upon completion. If false, the request will return the evaluation's summary upon completion.
        /// </param>
        /// <param name="trialCount">
        /// The number of times to run the evaluator per input. This is useful for evaluating applications that have non-deterministic behavior and gives you both a stronger aggregate measure and a sense of the variance in the results.
        /// </param>
        /// <param name="isPublic">
        /// Whether the experiment should be public. Defaults to false.
        /// </param>
        /// <param name="timeout">
        /// The maximum duration, in milliseconds, to run the evaluation. Defaults to undefined, in which case there is no timeout.
        /// </param>
        /// <param name="maxConcurrency">
        /// The maximum number of tasks/scorers that will be run concurrently. Defaults to 10. If null is provided, no max concurrency will be used.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="baseExperimentName">
        /// An optional experiment name to use as a base. If specified, the new experiment will be summarized and compared to this experiment.
        /// </param>
        /// <param name="baseExperimentId">
        /// An optional experiment id to use as a base. If specified, the new experiment will be summarized and compared to this experiment.
        /// </param>
        /// <param name="gitMetadataSettings">
        /// Optional settings for collecting git metadata. By default, will collect all git metadata fields allowed in org-level settings.
        /// </param>
        /// <param name="repoInfo"></param>
        /// <param name="strict">
        /// If true, throw an error if one of the variables in the prompt is not present in the input
        /// </param>
        /// <param name="stopToken">
        /// The token to stop the run
        /// </param>
        /// <param name="extraMessages">
        /// A template path of extra messages to append to the conversion. These messages will be appended to the end of the conversation, after the last message.
        /// </param>
        /// <param name="tags">
        /// Optional tags that will be added to the experiment.
        /// </param>
        /// <param name="mcpAuth"></param>
        public RunEval(
            string projectId,
            global::G.AnyOf<global::G.RunEvalDataDatasetId, global::G.RunEvalDataProjectDatasetName, global::G.RunEvalDataDatasetRows> data,
            global::G.FunctionId task,
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.FunctionId?, object>> scores,
            string? name,
            global::System.Collections.Generic.Dictionary<string, object?>? parameters,
            string? experimentName,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            global::G.AllOf<global::G.InvokeParent?, object>? parent,
            bool? stream,
            double? trialCount,
            bool? isPublic,
            double? timeout,
            double? maxConcurrency,
            string? baseExperimentName,
            string? baseExperimentId,
            global::G.GitMetadataSettings? gitMetadataSettings,
            global::G.AllOf<global::G.RepoInfo, object>? repoInfo,
            bool? strict,
            string? stopToken,
            string? extraMessages,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.Dictionary<string, global::G.RunEvalMcpAuth2>? mcpAuth)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Data = data;
            this.Name = name;
            this.Parameters = parameters;
            this.Task = task;
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
            this.ExperimentName = experimentName;
            this.Metadata = metadata;
            this.Parent = parent;
            this.Stream = stream;
            this.TrialCount = trialCount;
            this.IsPublic = isPublic;
            this.Timeout = timeout;
            this.MaxConcurrency = maxConcurrency;
            this.BaseExperimentName = baseExperimentName;
            this.BaseExperimentId = baseExperimentId;
            this.GitMetadataSettings = gitMetadataSettings;
            this.RepoInfo = repoInfo;
            this.Strict = strict;
            this.StopToken = stopToken;
            this.ExtraMessages = extraMessages;
            this.Tags = tags;
            this.McpAuth = mcpAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEval" /> class.
        /// </summary>
        public RunEval()
        {
        }
    }
}