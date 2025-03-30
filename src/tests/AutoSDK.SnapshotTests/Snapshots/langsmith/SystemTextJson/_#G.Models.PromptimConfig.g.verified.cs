//HintName: G.Models.PromptimConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptimConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_split")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TrainSplit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dev_split")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DevSplit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_split")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TestSplit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_epochs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumEpochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoCommit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptimConfig" /> class.
        /// </summary>
        /// <param name="messageIndex"></param>
        /// <param name="taskDescription"></param>
        /// <param name="datasetName"></param>
        /// <param name="trainSplit"></param>
        /// <param name="devSplit"></param>
        /// <param name="testSplit"></param>
        /// <param name="evaluators"></param>
        /// <param name="numEpochs"></param>
        /// <param name="autoCommit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptimConfig(
            int messageIndex,
            string taskDescription,
            string datasetName,
            string? trainSplit,
            string? devSplit,
            string? testSplit,
            global::System.Collections.Generic.IList<global::System.Guid> evaluators,
            int numEpochs,
            bool autoCommit)
        {
            this.MessageIndex = messageIndex;
            this.TaskDescription = taskDescription ?? throw new global::System.ArgumentNullException(nameof(taskDescription));
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.TrainSplit = trainSplit ?? throw new global::System.ArgumentNullException(nameof(trainSplit));
            this.DevSplit = devSplit ?? throw new global::System.ArgumentNullException(nameof(devSplit));
            this.TestSplit = testSplit ?? throw new global::System.ArgumentNullException(nameof(testSplit));
            this.Evaluators = evaluators ?? throw new global::System.ArgumentNullException(nameof(evaluators));
            this.NumEpochs = numEpochs;
            this.AutoCommit = autoCommit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptimConfig" /> class.
        /// </summary>
        public PromptimConfig()
        {
        }
    }
}