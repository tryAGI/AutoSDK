//HintName: G.Models.CustomModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomModelInput
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CustomModelTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomModelType ModelType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_epochs")]
        public int? NumEpochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomModelInput" /> class.
        /// </summary>
        /// <param name="modelType">
        /// An enumeration.
        /// </param>
        /// <param name="learningRate"></param>
        /// <param name="numEpochs"></param>
        /// <param name="datasetId"></param>
        /// <param name="modelName"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CustomModelInput(
            global::G.CustomModelType modelType,
            string datasetId,
            string modelName,
            double? learningRate,
            int? numEpochs)
        {
            this.ModelType = modelType;
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.LearningRate = learningRate;
            this.NumEpochs = numEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomModelInput" /> class.
        /// </summary>
        public CustomModelInput()
        {
        }
    }
}