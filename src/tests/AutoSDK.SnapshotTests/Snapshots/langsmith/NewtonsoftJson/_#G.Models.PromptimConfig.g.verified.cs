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
        [global::Newtonsoft.Json.JsonProperty("train_split", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TrainSplit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dev_split", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DevSplit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_split", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TestSplit { get; set; } = default!;

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
        /// <param name="trainSplit"></param>
        /// <param name="devSplit"></param>
        /// <param name="testSplit"></param>
        /// <param name="evaluators"></param>
        /// <param name="numEpochs"></param>
        /// <param name="autoCommit"></param>
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