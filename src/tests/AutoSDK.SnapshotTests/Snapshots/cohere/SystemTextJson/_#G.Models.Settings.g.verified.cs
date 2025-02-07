//HintName: G.Models.Settings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration used for fine-tuning.
    /// </summary>
    public sealed partial class Settings
    {
        /// <summary>
        /// The base model used for fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseModel BaseModel { get; set; }

        /// <summary>
        /// The data used for training and evaluating the fine-tuned model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// The fine-tuning hyperparameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        public global::G.Hyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// read-only. Whether the model is single-label or multi-label (only for classification).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_label")]
        public bool? MultiLabel { get; set; }

        /// <summary>
        /// The Weights &amp; Biases configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb")]
        public global::G.WandbConfig? Wandb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// The base model used for fine-tuning.
        /// </param>
        /// <param name="datasetId">
        /// The data used for training and evaluating the fine-tuned model.
        /// </param>
        /// <param name="hyperparameters">
        /// The fine-tuning hyperparameters.
        /// </param>
        /// <param name="multiLabel">
        /// read-only. Whether the model is single-label or multi-label (only for classification).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="wandb">
        /// The Weights &amp; Biases configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Settings(
            global::G.BaseModel baseModel,
            string datasetId,
            global::G.Hyperparameters? hyperparameters,
            bool? multiLabel,
            global::G.WandbConfig? wandb)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.Hyperparameters = hyperparameters;
            this.MultiLabel = multiLabel;
            this.Wandb = wandb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        public Settings()
        {
        }
    }
}