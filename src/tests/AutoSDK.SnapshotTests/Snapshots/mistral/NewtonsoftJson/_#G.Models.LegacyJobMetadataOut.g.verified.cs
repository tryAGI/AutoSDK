//HintName: G.Models.LegacyJobMetadataOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyJobMetadataOut
    {
        /// <summary>
        /// The cost of the fine-tuning job.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// The currency used for the fine-tuning job cost.<br/>
        /// Example: EUR
        /// </summary>
        /// <example>EUR</example>
        [global::Newtonsoft.Json.JsonProperty("cost_currency")]
        public string? CostCurrency { get; set; }

        /// <summary>
        /// The total number of tokens in the training dataset.<br/>
        /// Example: 305375
        /// </summary>
        /// <example>305375</example>
        [global::Newtonsoft.Json.JsonProperty("data_tokens")]
        public int? DataTokens { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated")]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public string Details { get; set; } = default!;

        /// <summary>
        /// The number of complete passes through the entire training dataset.<br/>
        /// Example: 4.2922
        /// </summary>
        /// <example>4.2922</example>
        [global::Newtonsoft.Json.JsonProperty("epochs")]
        public double? Epochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("estimated_start_time")]
        public int? EstimatedStartTime { get; set; }

        /// <summary>
        /// The approximated time (in seconds) for the fine-tuning process to complete.<br/>
        /// Example: 220
        /// </summary>
        /// <example>220</example>
        [global::Newtonsoft.Json.JsonProperty("expected_duration_seconds")]
        public int? ExpectedDurationSeconds { get; set; }

        /// <summary>
        /// Default Value: job.metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.LegacyJobMetadataOutObject? Object { get; set; }

        /// <summary>
        /// The total number of tokens used during the fine-tuning process.<br/>
        /// Example: 1310720
        /// </summary>
        /// <example>1310720</example>
        [global::Newtonsoft.Json.JsonProperty("train_tokens")]
        public int? TrainTokens { get; set; }

        /// <summary>
        /// The number of tokens consumed by one training step.<br/>
        /// Example: 131072
        /// </summary>
        /// <example>131072</example>
        [global::Newtonsoft.Json.JsonProperty("train_tokens_per_step")]
        public int? TrainTokensPerStep { get; set; }

        /// <summary>
        /// The number of training steps to perform. A training step refers to a single update of the model weights during the fine-tuning process. This update is typically calculated using a batch of samples from the training dataset.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyJobMetadataOut" /> class.
        /// </summary>
        /// <param name="cost">
        /// The cost of the fine-tuning job.<br/>
        /// Example: 10
        /// </param>
        /// <param name="costCurrency">
        /// The currency used for the fine-tuning job cost.<br/>
        /// Example: EUR
        /// </param>
        /// <param name="dataTokens">
        /// The total number of tokens in the training dataset.<br/>
        /// Example: 305375
        /// </param>
        /// <param name="deprecated">
        /// Default Value: true
        /// </param>
        /// <param name="details"></param>
        /// <param name="epochs">
        /// The number of complete passes through the entire training dataset.<br/>
        /// Example: 4.2922
        /// </param>
        /// <param name="estimatedStartTime"></param>
        /// <param name="expectedDurationSeconds">
        /// The approximated time (in seconds) for the fine-tuning process to complete.<br/>
        /// Example: 220
        /// </param>
        /// <param name="object">
        /// Default Value: job.metadata
        /// </param>
        /// <param name="trainTokens">
        /// The total number of tokens used during the fine-tuning process.<br/>
        /// Example: 1310720
        /// </param>
        /// <param name="trainTokensPerStep">
        /// The number of tokens consumed by one training step.<br/>
        /// Example: 131072
        /// </param>
        /// <param name="trainingSteps">
        /// The number of training steps to perform. A training step refers to a single update of the model weights during the fine-tuning process. This update is typically calculated using a batch of samples from the training dataset.<br/>
        /// Example: 10
        /// </param>
        public LegacyJobMetadataOut(
            string details,
            double? cost,
            string? costCurrency,
            int? dataTokens,
            bool? deprecated,
            double? epochs,
            int? estimatedStartTime,
            int? expectedDurationSeconds,
            global::G.LegacyJobMetadataOutObject? @object,
            int? trainTokens,
            int? trainTokensPerStep,
            int? trainingSteps)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.Cost = cost;
            this.CostCurrency = costCurrency;
            this.DataTokens = dataTokens;
            this.Deprecated = deprecated;
            this.Epochs = epochs;
            this.EstimatedStartTime = estimatedStartTime;
            this.ExpectedDurationSeconds = expectedDurationSeconds;
            this.Object = @object;
            this.TrainTokens = trainTokens;
            this.TrainTokensPerStep = trainTokensPerStep;
            this.TrainingSteps = trainingSteps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyJobMetadataOut" /> class.
        /// </summary>
        public LegacyJobMetadataOut()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.LegacyJobMetadataOut? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.LegacyJobMetadataOut>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.LegacyJobMetadataOut?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.LegacyJobMetadataOut?>(serializer.Deserialize<global::G.LegacyJobMetadataOut>(jsonReader));
        }

    }
}