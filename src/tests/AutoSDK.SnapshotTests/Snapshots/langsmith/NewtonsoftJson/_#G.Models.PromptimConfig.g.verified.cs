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
        [global::Newtonsoft.Json.JsonProperty("message_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int MessageIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string TaskDescription { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_split")]
        public string? TrainSplit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dev_split")]
        public string? DevSplit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_split")]
        public string? TestSplit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluators", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> Evaluators { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_epochs", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumEpochs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_commit", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AutoCommit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptimConfig" /> class.
        /// </summary>
        /// <param name="messageIndex"></param>
        /// <param name="taskDescription"></param>
        /// <param name="datasetName"></param>
        /// <param name="evaluators"></param>
        /// <param name="numEpochs"></param>
        /// <param name="autoCommit"></param>
        /// <param name="trainSplit"></param>
        /// <param name="devSplit"></param>
        /// <param name="testSplit"></param>
        public PromptimConfig(
            int messageIndex,
            string taskDescription,
            string datasetName,
            global::System.Collections.Generic.IList<global::System.Guid> evaluators,
            int numEpochs,
            bool autoCommit,
            string? trainSplit,
            string? devSplit,
            string? testSplit)
        {
            this.MessageIndex = messageIndex;
            this.TaskDescription = taskDescription ?? throw new global::System.ArgumentNullException(nameof(taskDescription));
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.TrainSplit = trainSplit;
            this.DevSplit = devSplit;
            this.TestSplit = testSplit;
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