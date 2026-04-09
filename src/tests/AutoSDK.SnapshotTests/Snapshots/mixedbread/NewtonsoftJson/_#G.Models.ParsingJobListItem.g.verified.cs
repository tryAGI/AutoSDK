//HintName: G.Models.ParsingJobListItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A parsing job item for list responses.
    /// </summary>
    public sealed partial class ParsingJobListItem
    {
        /// <summary>
        /// The ID of the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the file to parse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// The name of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The status of the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ParsingJobStatusJsonConverter))]
        public global::G.ParsingJobStatus Status { get; set; } = default!;

        /// <summary>
        /// The error of the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public object? Error { get; set; }

        /// <summary>
        /// The started time of the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The finished time of the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// The creation time of the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The updated time of the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: parsing_job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobListItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the job
        /// </param>
        /// <param name="fileId">
        /// The ID of the file to parse
        /// </param>
        /// <param name="status">
        /// The status of the job
        /// </param>
        /// <param name="filename">
        /// The name of the file
        /// </param>
        /// <param name="error">
        /// The error of the job
        /// </param>
        /// <param name="startedAt">
        /// The started time of the job
        /// </param>
        /// <param name="finishedAt">
        /// The finished time of the job
        /// </param>
        /// <param name="createdAt">
        /// The creation time of the job
        /// </param>
        /// <param name="updatedAt">
        /// The updated time of the job
        /// </param>
        /// <param name="object">
        /// The type of the object<br/>
        /// Default Value: parsing_job
        /// </param>
        public ParsingJobListItem(
            string id,
            string fileId,
            global::G.ParsingJobStatus status,
            string? filename,
            object? error,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Filename = filename;
            this.Status = status;
            this.Error = error;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobListItem" /> class.
        /// </summary>
        public ParsingJobListItem()
        {
        }
    }
}