//HintName: G.Models.FinetunedModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetunedModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Default Value: user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BaseModelId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("steps", Required = global::Newtonsoft.Json.Required.Always)]
        public int Steps { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("depth", Required = global::Newtonsoft.Json.Required.Always)]
        public int Depth { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loss", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FinetunedModelLoss Loss { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("freq", Required = global::Newtonsoft.Json.Required.Always)]
        public string Freq { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetunedModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="baseModelId"></param>
        /// <param name="steps"></param>
        /// <param name="depth"></param>
        /// <param name="loss"></param>
        /// <param name="model"></param>
        /// <param name="freq"></param>
        /// <param name="createdBy">
        /// Default Value: user
        /// </param>
        public FinetunedModel(
            string id,
            string createdAt,
            string baseModelId,
            int steps,
            int depth,
            global::G.FinetunedModelLoss loss,
            string model,
            string freq,
            string? createdBy)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatedBy = createdBy;
            this.BaseModelId = baseModelId ?? throw new global::System.ArgumentNullException(nameof(baseModelId));
            this.Steps = steps;
            this.Depth = depth;
            this.Loss = loss;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Freq = freq ?? throw new global::System.ArgumentNullException(nameof(freq));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetunedModel" /> class.
        /// </summary>
        public FinetunedModel()
        {
        }
    }
}