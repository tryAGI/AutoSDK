//HintName: G.Models.FineTuneEvent2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuneEvent2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.FineTuneEventObject2 Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level")]
        public global::G.FineTuneEventLevel? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuneEventType2 Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ParamCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TokenCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_steps", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalSteps { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wandb_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string WandbUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step", Required = global::Newtonsoft.Json.Required.Always)]
        public int Step { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checkpoint_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string CheckpointPath { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelPath { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_offset", Required = global::Newtonsoft.Json.Required.Always)]
        public int TrainingOffset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string Hash { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneEvent2" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="createdAt"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="paramCount"></param>
        /// <param name="tokenCount"></param>
        /// <param name="totalSteps"></param>
        /// <param name="wandbUrl"></param>
        /// <param name="step"></param>
        /// <param name="checkpointPath"></param>
        /// <param name="modelPath"></param>
        /// <param name="trainingOffset"></param>
        /// <param name="hash"></param>
        public FineTuneEvent2(
            string createdAt,
            string message,
            global::G.FineTuneEventType2 type,
            int paramCount,
            int tokenCount,
            int totalSteps,
            string wandbUrl,
            int step,
            string checkpointPath,
            string modelPath,
            int trainingOffset,
            string hash,
            global::G.FineTuneEventObject2 @object,
            global::G.FineTuneEventLevel? level)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
            this.ParamCount = paramCount;
            this.TokenCount = tokenCount;
            this.TotalSteps = totalSteps;
            this.WandbUrl = wandbUrl ?? throw new global::System.ArgumentNullException(nameof(wandbUrl));
            this.Step = step;
            this.CheckpointPath = checkpointPath ?? throw new global::System.ArgumentNullException(nameof(checkpointPath));
            this.ModelPath = modelPath ?? throw new global::System.ArgumentNullException(nameof(modelPath));
            this.TrainingOffset = trainingOffset;
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.Object = @object;
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneEvent2" /> class.
        /// </summary>
        public FineTuneEvent2()
        {
        }
    }
}