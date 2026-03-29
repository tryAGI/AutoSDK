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
        [global::Newtonsoft.Json.JsonProperty("runs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExperimentHypotheseRun> Runs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parentPromptVersion")]
        public global::G.ExperimentHypotheseParentPromptVersion? ParentPromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptVersion")]
        public global::G.ExperimentHypothesePromptVersion? PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptVersionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptVersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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