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
        [global::Newtonsoft.Json.JsonProperty("base_model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseModel BaseModel { get; set; } = default!;

        /// <summary>
        /// The data used for training and evaluating the fine-tuned model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// The fine-tuning hyperparameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparameters")]
        public global::G.Hyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// read-only. Whether the model is single-label or multi-label (only for classification).<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multi_label")]
        public bool? MultiLabel { get; set; }

        /// <summary>
        /// The Weights &amp; Biases configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wandb")]
        public global::G.WandbConfig? Wandb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}