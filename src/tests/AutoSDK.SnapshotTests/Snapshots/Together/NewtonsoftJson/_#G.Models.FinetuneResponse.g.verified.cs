//HintName: G.Models.FinetuneResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("epochs_completed")]
        public int? EpochsCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_steps")]
        public int? EvalSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.FinetuneEvent2>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_output_name")]
        public string? ModelOutputName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_output_path")]
        public string? ModelOutputPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_checkpoints")]
        public int? NCheckpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs")]
        public int? NEpochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_evals")]
        public int? NEvals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param_count")]
        public int? ParamCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_depth")]
        public int? QueueDepth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FinetuneJobStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_count")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_price")]
        public int? TotalPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_file")]
        public string? TrainingFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_type")]
        public global::G.FinetuneResponseTrainingType? TrainingType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trainingfile_numlines")]
        public int? TrainingfileNumlines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trainingfile_size")]
        public int? TrainingfileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wandb_project_name")]
        public string? WandbProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wandb_url")]
        public string? WandbUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponse" /> class.
        /// </summary>
        /// <param name="batchSize"></param>
        /// <param name="createdAt"></param>
        /// <param name="epochsCompleted"></param>
        /// <param name="evalSteps"></param>
        /// <param name="events"></param>
        /// <param name="id"></param>
        /// <param name="jobId"></param>
        /// <param name="learningRate"></param>
        /// <param name="model"></param>
        /// <param name="modelOutputName"></param>
        /// <param name="modelOutputPath"></param>
        /// <param name="nCheckpoints"></param>
        /// <param name="nEpochs"></param>
        /// <param name="nEvals"></param>
        /// <param name="paramCount"></param>
        /// <param name="queueDepth"></param>
        /// <param name="status"></param>
        /// <param name="tokenCount"></param>
        /// <param name="totalPrice"></param>
        /// <param name="trainingFile"></param>
        /// <param name="trainingType"></param>
        /// <param name="trainingfileNumlines"></param>
        /// <param name="trainingfileSize"></param>
        /// <param name="updatedAt"></param>
        /// <param name="validationFile"></param>
        /// <param name="wandbProjectName"></param>
        /// <param name="wandbUrl"></param>
        public FinetuneResponse(
            global::System.Guid id,
            global::G.FinetuneJobStatus status,
            int? batchSize,
            string? createdAt,
            int? epochsCompleted,
            int? evalSteps,
            global::System.Collections.Generic.IList<global::G.FinetuneEvent2>? events,
            string? jobId,
            double? learningRate,
            string? model,
            string? modelOutputName,
            string? modelOutputPath,
            int? nCheckpoints,
            int? nEpochs,
            int? nEvals,
            int? paramCount,
            int? queueDepth,
            int? tokenCount,
            int? totalPrice,
            string? trainingFile,
            global::G.FinetuneResponseTrainingType? trainingType,
            int? trainingfileNumlines,
            int? trainingfileSize,
            string? updatedAt,
            string? validationFile,
            string? wandbProjectName,
            string? wandbUrl)
        {
            this.Id = id;
            this.Status = status;
            this.BatchSize = batchSize;
            this.CreatedAt = createdAt;
            this.EpochsCompleted = epochsCompleted;
            this.EvalSteps = evalSteps;
            this.Events = events;
            this.JobId = jobId;
            this.LearningRate = learningRate;
            this.Model = model;
            this.ModelOutputName = modelOutputName;
            this.ModelOutputPath = modelOutputPath;
            this.NCheckpoints = nCheckpoints;
            this.NEpochs = nEpochs;
            this.NEvals = nEvals;
            this.ParamCount = paramCount;
            this.QueueDepth = queueDepth;
            this.TokenCount = tokenCount;
            this.TotalPrice = totalPrice;
            this.TrainingFile = trainingFile;
            this.TrainingType = trainingType;
            this.TrainingfileNumlines = trainingfileNumlines;
            this.TrainingfileSize = trainingfileSize;
            this.UpdatedAt = updatedAt;
            this.ValidationFile = validationFile;
            this.WandbProjectName = wandbProjectName;
            this.WandbUrl = wandbUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponse" /> class.
        /// </summary>
        public FinetuneResponse()
        {
        }
    }
}