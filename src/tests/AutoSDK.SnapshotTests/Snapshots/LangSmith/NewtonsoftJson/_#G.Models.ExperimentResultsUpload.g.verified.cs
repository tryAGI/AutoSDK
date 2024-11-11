//HintName: G.Models.ExperimentResultsUpload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Class for uploading the results of an already-run experiment.
    /// </summary>
    public sealed partial class ExperimentResultsUpload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_description")]
        public string? ExperimentDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_description")]
        public string? DatasetDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_experiment_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackCreateCoreSchema>? SummaryExperimentScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExperimentResultRow> Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExperimentStartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExperimentEndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_metadata")]
        public object? ExperimentMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResultsUpload" /> class.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="experimentDescription"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="datasetDescription"></param>
        /// <param name="summaryExperimentScores"></param>
        /// <param name="results"></param>
        /// <param name="experimentStartTime"></param>
        /// <param name="experimentEndTime"></param>
        /// <param name="experimentMetadata"></param>
        public ExperimentResultsUpload(
            string experimentName,
            global::System.Collections.Generic.IList<global::G.ExperimentResultRow> results,
            global::System.DateTime experimentStartTime,
            global::System.DateTime experimentEndTime,
            string? experimentDescription,
            global::System.Guid? datasetId,
            string? datasetName,
            string? datasetDescription,
            global::System.Collections.Generic.IList<global::G.FeedbackCreateCoreSchema>? summaryExperimentScores,
            object? experimentMetadata)
        {
            this.ExperimentName = experimentName ?? throw new global::System.ArgumentNullException(nameof(experimentName));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.ExperimentStartTime = experimentStartTime;
            this.ExperimentEndTime = experimentEndTime;
            this.ExperimentDescription = experimentDescription;
            this.DatasetId = datasetId;
            this.DatasetName = datasetName;
            this.DatasetDescription = datasetDescription;
            this.SummaryExperimentScores = summaryExperimentScores;
            this.ExperimentMetadata = experimentMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResultsUpload" /> class.
        /// </summary>
        public ExperimentResultsUpload()
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
        public static global::G.ExperimentResultsUpload? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ExperimentResultsUpload>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ExperimentResultsUpload?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ExperimentResultsUpload?>(serializer.Deserialize<global::G.ExperimentResultsUpload>(jsonReader));
        }

    }
}