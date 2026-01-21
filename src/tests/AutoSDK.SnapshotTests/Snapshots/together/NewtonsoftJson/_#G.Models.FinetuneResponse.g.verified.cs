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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_file")]
        public string? TrainingFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_file")]
        public string? ValidationFile { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs")]
        public int? NEpochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_checkpoints")]
        public int? NCheckpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_evals")]
        public int? NEvals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_steps")]
        public int? EvalSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_type")]
        public global::G.FinetuneResponseTrainingType? TrainingType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FinetuneJobStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.FinetuneEvent>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_count")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param_count")]
        public int? ParamCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_price")]
        public int? TotalPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("epochs_completed")]
        public int? EpochsCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_depth")]
        public int? QueueDepth { get; set; }

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
        /// <param name="id"></param>
        /// <param name="trainingFile"></param>
        /// <param name="validationFile"></param>
        /// <param name="model"></param>
        /// <param name="modelOutputName"></param>
        /// <param name="modelOutputPath"></param>
        /// <param name="trainingfileNumlines"></param>
        /// <param name="trainingfileSize"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="nEpochs"></param>
        /// <param name="nCheckpoints"></param>
        /// <param name="nEvals"></param>
        /// <param name="batchSize"></param>
        /// <param name="learningRate"></param>
        /// <param name="evalSteps"></param>
        /// <param name="trainingType"></param>
        /// <param name="status"></param>
        /// <param name="jobId"></param>
        /// <param name="events"></param>
        /// <param name="tokenCount"></param>
        /// <param name="paramCount"></param>
        /// <param name="totalPrice"></param>
        /// <param name="epochsCompleted"></param>
        /// <param name="queueDepth"></param>
        /// <param name="wandbProjectName"></param>
        /// <param name="wandbUrl"></param>
        public FinetuneResponse(
            global::System.Guid id,
            global::G.FinetuneJobStatus status,
            string? trainingFile,
            string? validationFile,
            string? model,
            string? modelOutputName,
            string? modelOutputPath,
            int? trainingfileNumlines,
            int? trainingfileSize,
            string? createdAt,
            string? updatedAt,
            int? nEpochs,
            int? nCheckpoints,
            int? nEvals,
            int? batchSize,
            double? learningRate,
            int? evalSteps,
            global::G.FinetuneResponseTrainingType? trainingType,
            string? jobId,
            global::System.Collections.Generic.IList<global::G.FinetuneEvent>? events,
            int? tokenCount,
            int? paramCount,
            int? totalPrice,
            int? epochsCompleted,
            int? queueDepth,
            string? wandbProjectName,
            string? wandbUrl)
        {
            this.Id = id;
            this.Status = status;
            this.TrainingFile = trainingFile;
            this.ValidationFile = validationFile;
            this.Model = model;
            this.ModelOutputName = modelOutputName;
            this.ModelOutputPath = modelOutputPath;
            this.TrainingfileNumlines = trainingfileNumlines;
            this.TrainingfileSize = trainingfileSize;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.NEpochs = nEpochs;
            this.NCheckpoints = nCheckpoints;
            this.NEvals = nEvals;
            this.BatchSize = batchSize;
            this.LearningRate = learningRate;
            this.EvalSteps = evalSteps;
            this.TrainingType = trainingType;
            this.JobId = jobId;
            this.Events = events;
            this.TokenCount = tokenCount;
            this.ParamCount = paramCount;
            this.TotalPrice = totalPrice;
            this.EpochsCompleted = epochsCompleted;
            this.QueueDepth = queueDepth;
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