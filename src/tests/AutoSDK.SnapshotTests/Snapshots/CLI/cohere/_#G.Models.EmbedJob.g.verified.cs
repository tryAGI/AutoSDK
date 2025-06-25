﻿//HintName: G.Models.EmbedJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedJob
    {
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
        /// ID of the embed job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// ID of the model used to embed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The name of the embed job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ID of the resulting output dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dataset_id")]
        public string? OutputDatasetId { get; set; }

        /// <summary>
        /// The status of the embed job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbedJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbedJobStatus Status { get; set; }

        /// <summary>
        /// The truncation option used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbedJobTruncateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbedJobTruncate Truncate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedJob" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The creation date of the embed job
        /// </param>
        /// <param name="inputDatasetId">
        /// ID of the input dataset
        /// </param>
        /// <param name="jobId">
        /// ID of the embed job
        /// </param>
        /// <param name="meta"></param>
        /// <param name="model">
        /// ID of the model used to embed
        /// </param>
        /// <param name="name">
        /// The name of the embed job
        /// </param>
        /// <param name="outputDatasetId">
        /// ID of the resulting output dataset
        /// </param>
        /// <param name="status">
        /// The status of the embed job
        /// </param>
        /// <param name="truncate">
        /// The truncation option used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedJob(
            global::System.DateTime createdAt,
            string inputDatasetId,
            string jobId,
            string model,
            global::G.EmbedJobStatus status,
            global::G.EmbedJobTruncate truncate,
            global::G.ApiMeta? meta,
            string? name,
            string? outputDatasetId)
        {
            this.CreatedAt = createdAt;
            this.InputDatasetId = inputDatasetId ?? throw new global::System.ArgumentNullException(nameof(inputDatasetId));
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Status = status;
            this.Truncate = truncate;
            this.Meta = meta;
            this.Name = name;
            this.OutputDatasetId = outputDatasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedJob" /> class.
        /// </summary>
        public EmbedJob()
        {
        }
    }
}