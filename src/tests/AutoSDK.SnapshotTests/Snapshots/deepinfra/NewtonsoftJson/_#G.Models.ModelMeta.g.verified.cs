//HintName: G.Models.ModelMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task", Required = global::Newtonsoft.Json.Required.Always)]
        public string Task { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan_id")]
        public string? PlanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMeta" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="modelName"></param>
        /// <param name="task"></param>
        /// <param name="planId"></param>
        public ModelMeta(
            string provider,
            string modelName,
            string task,
            string? planId)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Task = task ?? throw new global::System.ArgumentNullException(nameof(task));
            this.PlanId = planId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMeta" /> class.
        /// </summary>
        public ModelMeta()
        {
        }
    }
}