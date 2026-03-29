//HintName: G.Models.ExperimentHypothese.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentHypothese
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExperimentHypotheseRun> Runs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentPromptVersion")]
        public global::G.ExperimentHypotheseParentPromptVersion? ParentPromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersion")]
        public global::G.ExperimentHypothesePromptVersion? PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentHypothese" /> class.
        /// </summary>
        /// <param name="runs"></param>
        /// <param name="providerKey"></param>
        /// <param name="createdAt"></param>
        /// <param name="status"></param>
        /// <param name="model"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="id"></param>
        /// <param name="parentPromptVersion"></param>
        /// <param name="promptVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentHypothese(
            global::System.Collections.Generic.IList<global::G.ExperimentHypotheseRun> runs,
            string providerKey,
            string createdAt,
            string status,
            string model,
            string promptVersionId,
            string id,
            global::G.ExperimentHypotheseParentPromptVersion? parentPromptVersion,
            global::G.ExperimentHypothesePromptVersion? promptVersion)
        {
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
            this.ProviderKey = providerKey ?? throw new global::System.ArgumentNullException(nameof(providerKey));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ParentPromptVersion = parentPromptVersion;
            this.PromptVersion = promptVersion;
            this.PromptVersionId = promptVersionId ?? throw new global::System.ArgumentNullException(nameof(promptVersionId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentHypothese" /> class.
        /// </summary>
        public ExperimentHypothese()
        {
        }
    }
}