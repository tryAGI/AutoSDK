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
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// The name of the embed job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the embed job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbedJobStatus Status { get; set; } = default!;

        /// <summary>
        /// The creation date of the embed job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// ID of the input dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputDatasetId { get; set; } = default!;

        /// <summary>
        /// ID of the resulting output dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_dataset_id")]
        public string? OutputDatasetId { get; set; }

        /// <summary>
        /// ID of the model used to embed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The truncation option used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbedJobTruncate Truncate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}