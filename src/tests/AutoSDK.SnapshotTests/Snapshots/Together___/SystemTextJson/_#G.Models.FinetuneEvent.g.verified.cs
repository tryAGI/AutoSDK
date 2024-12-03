//HintName: G.Models.FineTuneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuneEventLevelJsonConverter))]
        public global::G.FineTuneEventLevel? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuneEventObjectJsonConverter))]
        public global::G.FineTuneEventObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParamCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Step { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TokenCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrainingOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuneEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuneEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WandbUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneEvent" /> class.
        /// </summary>
        /// <param name="checkpointPath"></param>
        /// <param name="createdAt"></param>
        /// <param name="hash"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="modelPath"></param>
        /// <param name="object"></param>
        /// <param name="paramCount"></param>
        /// <param name="step"></param>
        /// <param name="tokenCount"></param>
        /// <param name="totalSteps"></param>
        /// <param name="trainingOffset"></param>
        /// <param name="type"></param>
        /// <param name="wandbUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FineTuneEvent(
            string checkpointPath,
            string createdAt,
            string hash,
            string message,
            string modelPath,
            int paramCount,
            int step,
            int tokenCount,
            int totalSteps,
            int trainingOffset,
            global::G.FineTuneEventType type,
            string wandbUrl,
            global::G.FineTuneEventLevel? level,
            global::G.FineTuneEventObject @object)
        {
            this.CheckpointPath = checkpointPath ?? throw new global::System.ArgumentNullException(nameof(checkpointPath));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ModelPath = modelPath ?? throw new global::System.ArgumentNullException(nameof(modelPath));
            this.ParamCount = paramCount;
            this.Step = step;
            this.TokenCount = tokenCount;
            this.TotalSteps = totalSteps;
            this.TrainingOffset = trainingOffset;
            this.Type = type;
            this.WandbUrl = wandbUrl ?? throw new global::System.ArgumentNullException(nameof(wandbUrl));
            this.Level = level;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneEvent" /> class.
        /// </summary>
        public FineTuneEvent()
        {
        }
    }
}