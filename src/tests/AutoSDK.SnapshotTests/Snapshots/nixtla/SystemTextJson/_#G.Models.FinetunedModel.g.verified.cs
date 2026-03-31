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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Default Value: user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Depth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FinetunedModelLossJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FinetunedModelLoss Loss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Freq { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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