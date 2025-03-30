//HintName: G.Models.PromptOptimizationJob.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptimizationJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EPromptOptimizationJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EPromptOptimizationJobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EPromptOptimizationAlgorithmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EPromptOptimizationAlgorithm Algorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.PromptimConfig, global::G.DemoConfig>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.PromptOptimizationResult>? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJob" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptOptimizationJob(
            global::System.Guid id,
            global::System.Guid repoId,
            global::G.EPromptOptimizationJobStatus status,
            global::System.Guid tenantId,
            global::G.EPromptOptimizationAlgorithm algorithm,
            global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> config,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
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
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJob" /> class.
        /// </summary>
        public PromptOptimizationJob()
        {
        }
    }
}