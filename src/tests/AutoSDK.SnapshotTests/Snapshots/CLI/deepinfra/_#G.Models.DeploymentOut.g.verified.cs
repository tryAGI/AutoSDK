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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeployTypeJsonConverter))]
        public global::G.DeployType? Type { get; set; }

        /// <summary>
        /// Deploy Id<br/>
        /// Example: fkj843kjh8
        /// </summary>
        /// <example>fkj843kjh8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeployId { get; set; }

        /// <summary>
        /// Model Id from huggingface<br/>
        /// Example: google/vit-base-patch16-224
        /// </summary>
        /// <example>google/vit-base-patch16-224</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Model version<br/>
        /// Example: d8b79b422843bd59d628bf25b01aded94a9ec1a9b917e69fe460df9ff39ec42b
        /// </summary>
        /// <example>d8b79b422843bd59d628bf25b01aded94a9ec1a9b917e69fe460df9ff39ec42b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Task<br/>
        /// Example: image-classification
        /// </summary>
        /// <example>image-classification</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Task { get; set; }

        /// <summary>
        /// Status<br/>
        /// Example: deployed
        /// </summary>
        /// <example>deployed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Failure reason<br/>
        /// Example: Initialization failed
        /// </summary>
        /// <example>Initialization failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FailReason { get; set; }

        /// <summary>
        /// Created at<br/>
        /// Example: 2021-08-27T17:19:21+00:00
        /// </summary>
        /// <example>2021-08-27T17:19:21+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Updated at<br/>
        /// Example: 2021-08-27T17:19:21+00:00
        /// </summary>
        /// <example>2021-08-27T17:19:21+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instances")]
        public global::G.DeployInstances? Instances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.DeployLLMConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::G.ScaleSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentOut" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="deployId">
        /// Deploy Id<br/>
        /// Example: fkj843kjh8
        /// </param>
        /// <param name="modelName">
        /// Model Id from huggingface<br/>
        /// Example: google/vit-base-patch16-224
        /// </param>
        /// <param name="version">
        /// Model version<br/>
        /// Example: d8b79b422843bd59d628bf25b01aded94a9ec1a9b917e69fe460df9ff39ec42b
        /// </param>
        /// <param name="task">
        /// Task<br/>
        /// Example: image-classification
        /// </param>
        /// <param name="status">
        /// Status<br/>
        /// Example: deployed
        /// </param>
        /// <param name="failReason">
        /// Failure reason<br/>
        /// Example: Initialization failed
        /// </param>
        /// <param name="createdAt">
        /// Created at<br/>
        /// Example: 2021-08-27T17:19:21+00:00
        /// </param>
        /// <param name="updatedAt">
        /// Updated at<br/>
        /// Example: 2021-08-27T17:19:21+00:00
        /// </param>
        /// <param name="instances"></param>
        /// <param name="config"></param>
        /// <param name="settings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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