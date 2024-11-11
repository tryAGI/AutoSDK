//HintName: G.Models.EmbedJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedJob
    {
        /// <summary>
        /// ID of the embed job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// The name of the embed job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the embed job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbedJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbedJobStatus Status { get; set; }

        /// <summary>
        /// The creation date of the embed job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// ID of the input dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputDatasetId { get; set; }

        /// <summary>
        /// ID of the resulting output dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dataset_id")]
        public string? OutputDatasetId { get; set; }

        /// <summary>
        /// ID of the model used to embed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The truncation option used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbedJobTruncateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbedJobTruncate Truncate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedJob" /> class.
        /// </summary>
        /// <param name="jobId">
        /// ID of the embed job
        /// </param>
        /// <param name="name">
        /// The name of the embed job
        /// </param>
        /// <param name="status">
        /// The status of the embed job
        /// </param>
        /// <param name="createdAt">
        /// The creation date of the embed job
        /// </param>
        /// <param name="inputDatasetId">
        /// ID of the input dataset
        /// </param>
        /// <param name="outputDatasetId">
        /// ID of the resulting output dataset
        /// </param>
        /// <param name="model">
        /// ID of the model used to embed
        /// </param>
        /// <param name="truncate">
        /// The truncation option used
        /// </param>
        /// <param name="meta"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EmbedJob(
            string jobId,
            global::G.EmbedJobStatus status,
            global::System.DateTime createdAt,
            string inputDatasetId,
            string model,
            global::G.EmbedJobTruncate truncate,
            string? name,
            string? outputDatasetId,
            global::G.ApiMeta? meta)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.InputDatasetId = inputDatasetId ?? throw new global::System.ArgumentNullException(nameof(inputDatasetId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Truncate = truncate;
            this.Name = name;
            this.OutputDatasetId = outputDatasetId;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedJob" /> class.
        /// </summary>
        public EmbedJob()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.EmbedJob? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.EmbedJob),
                jsonSerializerContext) as global::G.EmbedJob;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.EmbedJob? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.EmbedJob>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.EmbedJob?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.EmbedJob),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.EmbedJob;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.EmbedJob?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.EmbedJob?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}