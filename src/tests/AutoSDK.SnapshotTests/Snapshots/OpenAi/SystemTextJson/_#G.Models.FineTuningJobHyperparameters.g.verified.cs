//HintName: G.Models.FineTuningJobHyperparameters.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job. See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
    /// </summary>
    public sealed partial class FineTuningJobHyperparameters
    {
        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// "auto" decides the optimal number of epochs based on the size of the dataset. If setting the number manually, we support any number between 1 and 50 epochs.<br/>
        /// Default Value: auto
        /// </summary>
        /// <default>global::G.FineTuningJobHyperparametersNEpochs.Auto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FineTuningJobHyperparametersNEpochs?, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.FineTuningJobHyperparametersNEpochs?, int?> NEpochs { get; set; } = global::G.FineTuningJobHyperparametersNEpochs.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobHyperparameters" /> class.
        /// </summary>
        /// <param name="nEpochs">
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// "auto" decides the optimal number of epochs based on the size of the dataset. If setting the number manually, we support any number between 1 and 50 epochs.<br/>
        /// Default Value: auto
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FineTuningJobHyperparameters(
            global::G.OneOf<global::G.FineTuningJobHyperparametersNEpochs?, int?> nEpochs)
        {
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobHyperparameters" /> class.
        /// </summary>
        public FineTuningJobHyperparameters()
        {
        }
    }
}