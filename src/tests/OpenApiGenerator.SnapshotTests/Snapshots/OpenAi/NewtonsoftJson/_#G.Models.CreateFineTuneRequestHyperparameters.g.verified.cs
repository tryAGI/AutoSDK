//HintName: G.Models.CreateFineTuneRequestHyperparameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job.
    /// </summary>
    public sealed partial class CreateFineTuneRequestHyperparameters
    {
        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one
        /// full cycle through the training dataset.
        /// <br/>Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs")]
        public object? NEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}