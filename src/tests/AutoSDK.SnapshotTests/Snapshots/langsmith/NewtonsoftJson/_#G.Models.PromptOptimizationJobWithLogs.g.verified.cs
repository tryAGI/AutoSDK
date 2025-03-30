//HintName: G.Models.PromptOptimizationJobWithLogs.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptimizationJobWithLogs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RepoId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EPromptOptimizationJobStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("algorithm", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EPromptOptimizationAlgorithm Algorithm { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.PromptOptimizationResult>? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PromptOptimizationJobLog> Logs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobWithLogs" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="repoId"></param>
        /// <param name="status"></param>
        /// <param name="tenantId"></param>
        /// <param name="algorithm"></param>
        /// <param name="config"></param>
        /// <param name="results"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="logs"></param>
        public PromptOptimizationJobWithLogs(
            global::System.Guid id,
            global::System.Guid repoId,
            global::G.EPromptOptimizationJobStatus status,
            global::System.Guid tenantId,
            global::G.EPromptOptimizationAlgorithm algorithm,
            global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> config,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::G.PromptOptimizationJobLog> logs,
            global::System.Collections.Generic.IList<global::G.PromptOptimizationResult>? results)
        {
            this.Id = id;
            this.RepoId = repoId;
            this.Status = status;
            this.TenantId = tenantId;
            this.Algorithm = algorithm;
            this.Config = config;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobWithLogs" /> class.
        /// </summary>
        public PromptOptimizationJobWithLogs()
        {
        }
    }
}