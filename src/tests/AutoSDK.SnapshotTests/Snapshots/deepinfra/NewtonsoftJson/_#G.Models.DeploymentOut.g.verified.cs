//HintName: G.Models.DeploymentOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentOut
    {
        /// <summary>
        /// Default Value: legacy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DeployType? Type { get; set; }

        /// <summary>
        /// Deploy Id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deploy_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeployId { get; set; } = default!;

        /// <summary>
        /// Model Id from huggingface
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// Model version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task", Required = global::Newtonsoft.Json.Required.Always)]
        public string Task { get; set; } = default!;

        /// <summary>
        /// Status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Failure reason
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fail_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string FailReason { get; set; } = default!;

        /// <summary>
        /// Created at
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Updated at
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Details about number of instances running right now
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instances")]
        public global::G.DeployInstances? Instances { get; set; }

        /// <summary>
        /// Immutable deploy configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.DeployLLMConfig? Config { get; set; }

        /// <summary>
        /// Scale Settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings")]
        public global::G.ScaleSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentOut" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: legacy
        /// </param>
        /// <param name="deployId">
        /// Deploy Id
        /// </param>
        /// <param name="modelName">
        /// Model Id from huggingface
        /// </param>
        /// <param name="version">
        /// Model version
        /// </param>
        /// <param name="task">
        /// Task
        /// </param>
        /// <param name="status">
        /// Status
        /// </param>
        /// <param name="failReason">
        /// Failure reason
        /// </param>
        /// <param name="createdAt">
        /// Created at
        /// </param>
        /// <param name="updatedAt">
        /// Updated at
        /// </param>
        /// <param name="instances">
        /// Details about number of instances running right now
        /// </param>
        /// <param name="config">
        /// Immutable deploy configuration
        /// </param>
        /// <param name="settings">
        /// Scale Settings
        /// </param>
        public DeploymentOut(
            string deployId,
            string modelName,
            string version,
            string task,
            string status,
            string failReason,
            string createdAt,
            string updatedAt,
            global::G.DeployType? type,
            global::G.DeployInstances? instances,
            global::G.DeployLLMConfig? config,
            global::G.ScaleSettings? settings)
        {
            this.DeployId = deployId ?? throw new global::System.ArgumentNullException(nameof(deployId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Task = task ?? throw new global::System.ArgumentNullException(nameof(task));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.FailReason = failReason ?? throw new global::System.ArgumentNullException(nameof(failReason));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Type = type;
            this.Instances = instances;
            this.Config = config;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentOut" /> class.
        /// </summary>
        public DeploymentOut()
        {
        }
    }
}