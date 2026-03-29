//HintName: G.Models.ModelDescriptionEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelDescriptionEntity
    {
        /// <summary>
        /// Identifier of the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// Type of the task that the model performs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string TaskType { get; set; } = default!;

        /// <summary>
        /// Batch size accepted by the model (if registered).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Image input height accepted by the model (if registered).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_height")]
        public int? InputHeight { get; set; }

        /// <summary>
        /// Image input width accepted by the model (if registered).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_width")]
        public int? InputWidth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDescriptionEntity" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Identifier of the model
        /// </param>
        /// <param name="taskType">
        /// Type of the task that the model performs
        /// </param>
        /// <param name="batchSize">
        /// Batch size accepted by the model (if registered).
        /// </param>
        /// <param name="inputHeight">
        /// Image input height accepted by the model (if registered).
        /// </param>
        /// <param name="inputWidth">
        /// Image input width accepted by the model (if registered).
        /// </param>
        public ModelDescriptionEntity(
            string modelId,
            string taskType,
            int? batchSize,
            int? inputHeight,
            int? inputWidth)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.TaskType = taskType ?? throw new global::System.ArgumentNullException(nameof(taskType));
            this.BatchSize = batchSize;
            this.InputHeight = inputHeight;
            this.InputWidth = inputWidth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDescriptionEntity" /> class.
        /// </summary>
        public ModelDescriptionEntity()
        {
        }
    }
}